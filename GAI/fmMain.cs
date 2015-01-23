using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAI
{
    #region serializer
    public static class ObjectCopier
    {
        /// <summary>
        /// Perform a deep Copy of the object.
        /// </summary>
        /// <typeparam name="T">The type of object being copied.</typeparam>
        /// <param name="source">The object instance to copy.</param>
        /// <returns>The copied object.</returns>
        public static T Clone<T>(T source)
        {
            if (!typeof(T).IsSerializable)
            {
                throw new ArgumentException("The type must be serializable.", "source");
            }

            // Don't serialize a null object, simply return the default for that object
            if (Object.ReferenceEquals(source, null))
            {
                return default(T);
            }

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new MemoryStream();
            using (stream)
            {
                formatter.Serialize(stream, source);
                stream.Seek(0, SeekOrigin.Begin);
                return (T)formatter.Deserialize(stream);
            }
        }

        public static byte[] PackToBinaryBox<T>(T source)
        {
            if (!typeof(T).IsSerializable)
            {
                throw new ArgumentException("The type must be serializable.", "source");
            }

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new MemoryStream();
            using (stream)
            {
                formatter.Serialize(stream, source);
                stream.Seek(0, SeekOrigin.Begin);
                byte[] array = new byte[stream.Length];
                stream.Read(array, 0, (int)stream.Length);
                return array;
            }
        }

        public static object UnpackFromBinaryBox(byte[] box)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new MemoryStream();
            using (stream)
            {
                stream.Write(box, 0, box.Length);
                stream.Seek(0, SeekOrigin.Begin);
                return formatter.Deserialize(stream);
            }
        }
    }
    #endregion
    public partial class fmMain : Form
    {
        private static Exams _exams = null;
        public static Exams ExamsList
        {
            get
            {
                if(_exams == null)
                {
                    _exams = Exams.Load();
                }
                return _exams;
            }
        }
        public fmMain()
        {
            InitializeComponent();
            //var t = ExamsList;
        }

        private void buttonGrab_Click(object sender, EventArgs e)
        {
            if (comboBoxExam.SelectedIndex == -1)
                comboBoxExam.SelectedIndex = 0;
            var exam = (int)Enum.Parse(typeof(Exams.Exam.ExamType), comboBoxExam.SelectedText);
            var maxTicket = (int)Enum.Parse(typeof(Exams.Exam.ExamTicketsNumber), comboBoxExam.SelectedText);
            numericUpDownQuestion.Maximum = maxTicket;
            var url = String.Format("http://online.vodiy.kiev.ua/pdr/test/?complect={0}&bilet={1}&training=on&adv=on&stat=off",
                                    exam, numericUpDownQuestion.Value);
            try
            {
                webBrowser.DocumentCompleted -= webBrowser_DocumentCompleted;
                webBrowser.Navigate(url);
                webBrowser.DocumentCompleted += webBrowser_DocumentCompleted;
            }
            catch
            {
            }
        }

        void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            throw new NotImplementedException();
        }

        [Serializable]
        public class Exams
        {
            [Serializable]
            public class Exam
            {
                #region enums
                public enum ExamType
                {
                    Kharkov = 0,
                    Kiev = 3
                }
                public enum ExamTicketsNumber
                {
                    Kharkov = 82,
                    Kiev = 126
                }
                #endregion
                [Serializable]
                public class Ticket
                {
                    [Serializable]
                    public class Question
                    {
                        public int Number { get; set; }
                        public string QuestionText { get; set; }
                        public List<string> Options { get; set; }
                        public int CorrectOption { get; set; }
                        public string Answer { get; set; }
                        public string FullHtml { get; set; }
                        public bool IsDuplicate { get; set; }
                        public int Hash
                        {
                            get
                            {
                                throw new NotImplementedException();
                            }
                        }
                        public Question()
                        {
                            Options = new List<string>();
                        }
                    }
                    public Ticket()
                    {
                        Questions = new List<Question>();
                    }
                    public Exam Exam { get; set; }
                    public List<Question> Questions { get; set; }
                }
                public Exam()
                {
                    Tickets = new List<Ticket>();
                }
                public bool IsComplete { get; set; }
                public List<Ticket> Tickets { get; set; }
            }
            public Exams()
            {
                ExamsList = new List<Exam>();
            }
            public List<Exam> ExamsList { get; set; }

            #region serialization
            public static string WorkingDir
            {
                get
                {
                    return System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath);
                }
            }
            public void Save()
            {
                Save(WorkingDir + "\\exams.bin");
            }
            public void Save(string fileName)
            {
                Stream stream = null;
                try
                {
                    IFormatter formatter = new BinaryFormatter();
                    stream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None);
                    formatter.Serialize(stream, this);
                }
                catch
                {
                    throw;
                }
                finally
                {
                    if (null != stream)
                        stream.Close();
                }
            }
            public static Exams Load()
            {
                return Load(WorkingDir + "\\exams.bin");
            }
            public static Exams Load(string fileName)
            {
                Exams s = null;
                Stream stream = null;
                try
                {
                    if (File.Exists(fileName))
                    {
                        IFormatter formatter = new BinaryFormatter();
                        stream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.None);
                        s = (Exams)formatter.Deserialize(stream);
                    }
                    else
                    {
                        s = new Exams();
                        IFormatter formatter = new BinaryFormatter();
                        stream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None);
                        formatter.Serialize(stream, s);
                    }
                }
                catch
                {
                    throw;
                }
                finally
                {
                    if (null != stream)
                        stream.Close();
                }
                return s;
            }
            #endregion
        }
    }
}
