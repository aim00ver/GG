namespace GAI
{
    partial class fmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonGrab = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabBrowser = new System.Windows.Forms.TabControl();
            this.tabPageBrowser = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBoxExam = new System.Windows.Forms.ComboBox();
            this.numericUpDownQuestion = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabBrowser.SuspendLayout();
            this.tabPageBrowser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuestion)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numericUpDownQuestion);
            this.panel1.Controls.Add(this.comboBoxExam);
            this.panel1.Controls.Add(this.buttonGrab);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 622);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(911, 36);
            this.panel1.TabIndex = 0;
            // 
            // buttonGrab
            // 
            this.buttonGrab.Location = new System.Drawing.Point(7, 6);
            this.buttonGrab.Name = "buttonGrab";
            this.buttonGrab.Size = new System.Drawing.Size(75, 23);
            this.buttonGrab.TabIndex = 0;
            this.buttonGrab.Text = "Grab";
            this.buttonGrab.UseVisualStyleBackColor = true;
            this.buttonGrab.Click += new System.EventHandler(this.buttonGrab_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabBrowser);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(911, 622);
            this.panel2.TabIndex = 1;
            // 
            // tabBrowser
            // 
            this.tabBrowser.Controls.Add(this.tabPageBrowser);
            this.tabBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabBrowser.Location = new System.Drawing.Point(0, 0);
            this.tabBrowser.Name = "tabBrowser";
            this.tabBrowser.SelectedIndex = 0;
            this.tabBrowser.Size = new System.Drawing.Size(911, 622);
            this.tabBrowser.TabIndex = 0;
            // 
            // tabPageBrowser
            // 
            this.tabPageBrowser.Controls.Add(this.splitContainer1);
            this.tabPageBrowser.Location = new System.Drawing.Point(4, 22);
            this.tabPageBrowser.Name = "tabPageBrowser";
            this.tabPageBrowser.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBrowser.Size = new System.Drawing.Size(903, 596);
            this.tabPageBrowser.TabIndex = 1;
            this.tabPageBrowser.Text = "Browser";
            this.tabPageBrowser.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.webBrowser);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(897, 590);
            this.splitContainer1.SplitterDistance = 638;
            this.splitContainer1.TabIndex = 0;
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(0, 0);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(638, 590);
            this.webBrowser.TabIndex = 2;
            this.webBrowser.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.listView2);
            this.splitContainer2.Panel1.Controls.Add(this.panel3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.listView1);
            this.splitContainer2.Size = new System.Drawing.Size(255, 590);
            this.splitContainer2.SplitterDistance = 396;
            this.splitContainer2.TabIndex = 0;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView2.GridLines = true;
            this.listView2.Location = new System.Drawing.Point(0, 71);
            this.listView2.MultiSelect = false;
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(255, 325);
            this.listView2.TabIndex = 2;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Exam";
            this.columnHeader2.Width = 67;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ticket #";
            this.columnHeader3.Width = 83;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Questions";
            this.columnHeader4.Width = 114;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(255, 71);
            this.panel3.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(255, 190);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Question #";
            this.columnHeader1.Width = 254;
            // 
            // comboBoxExam
            // 
            this.comboBoxExam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxExam.FormattingEnabled = true;
            this.comboBoxExam.Items.AddRange(new object[] {
            "Kiev",
            "Kharkov"});
            this.comboBoxExam.Location = new System.Drawing.Point(89, 8);
            this.comboBoxExam.Name = "comboBoxExam";
            this.comboBoxExam.Size = new System.Drawing.Size(88, 21);
            this.comboBoxExam.TabIndex = 1;
            // 
            // numericUpDownQuestion
            // 
            this.numericUpDownQuestion.Location = new System.Drawing.Point(183, 8);
            this.numericUpDownQuestion.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownQuestion.Name = "numericUpDownQuestion";
            this.numericUpDownQuestion.Size = new System.Drawing.Size(79, 20);
            this.numericUpDownQuestion.TabIndex = 2;
            this.numericUpDownQuestion.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 658);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "fmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GAI Grabber";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabBrowser.ResumeLayout(false);
            this.tabPageBrowser.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuestion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabBrowser;
        private System.Windows.Forms.TabPage tabPageBrowser;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Button buttonGrab;
        private System.Windows.Forms.ComboBox comboBoxExam;
        private System.Windows.Forms.NumericUpDown numericUpDownQuestion;
    }
}

