namespace WindowsFormsApplication6
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttontopThree = new System.Windows.Forms.Button();
            this.buttonProfile = new System.Windows.Forms.Button();
            this.buttonMarkAttendance = new System.Windows.Forms.Button();
            this.buttonViewAttendance = new System.Windows.Forms.Button();
            this.panelSearching = new System.Windows.Forms.Panel();
            this.labelInfo = new System.Windows.Forms.Label();
            this.labelInput = new System.Windows.Forms.Label();
            this.labelSearchType = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.comboBoxSearchType = new System.Windows.Forms.ComboBox();
            this.buttonsearchStudent = new System.Windows.Forms.Button();
            this.buttonListAll = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panelProfile = new System.Windows.Forms.Panel();
            this.textBoxEnrollment = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBoxtopThree = new System.Windows.Forms.RichTextBox();
            this.textBoxUniversity = new System.Windows.Forms.TextBox();
            this.textBoxDepartment = new System.Windows.Forms.TextBox();
            this.textBoxCgPA = new System.Windows.Forms.TextBox();
            this.textBoxSemester = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelAttendance = new System.Windows.Forms.Panel();
            this.radioButtonPresent = new System.Windows.Forms.RadioButton();
            this.radioButtonAbsent = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBoxEnrollmentAtt = new System.Windows.Forms.TextBox();
            this.richTextBoxMarkedAttendance = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panelSearching.SuspendLayout();
            this.panelProfile.SuspendLayout();
            this.panelAttendance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F);
            this.label1.Location = new System.Drawing.Point(397, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(540, 91);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Portal";
            // 
            // buttontopThree
            // 
            this.buttontopThree.Location = new System.Drawing.Point(30, 368);
            this.buttontopThree.Name = "buttontopThree";
            this.buttontopThree.Size = new System.Drawing.Size(97, 57);
            this.buttontopThree.TabIndex = 1;
            this.buttontopThree.Text = "Top Three Students";
            this.buttontopThree.UseVisualStyleBackColor = true;
            this.buttontopThree.Click += new System.EventHandler(this.buttontopThree_Click);
            // 
            // buttonProfile
            // 
            this.buttonProfile.Location = new System.Drawing.Point(236, 64);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Size = new System.Drawing.Size(126, 82);
            this.buttonProfile.TabIndex = 2;
            this.buttonProfile.Text = "Create Profile";
            this.buttonProfile.UseVisualStyleBackColor = true;
            this.buttonProfile.Click += new System.EventHandler(this.buttonProfile_Click);
            // 
            // buttonMarkAttendance
            // 
            this.buttonMarkAttendance.Location = new System.Drawing.Point(209, 146);
            this.buttonMarkAttendance.Name = "buttonMarkAttendance";
            this.buttonMarkAttendance.Size = new System.Drawing.Size(117, 43);
            this.buttonMarkAttendance.TabIndex = 3;
            this.buttonMarkAttendance.Text = "Mark Attendance ";
            this.buttonMarkAttendance.UseVisualStyleBackColor = true;
            this.buttonMarkAttendance.Click += new System.EventHandler(this.buttonMarkAttendance_Click);
            // 
            // buttonViewAttendance
            // 
            this.buttonViewAttendance.Location = new System.Drawing.Point(23, 146);
            this.buttonViewAttendance.Name = "buttonViewAttendance";
            this.buttonViewAttendance.Size = new System.Drawing.Size(144, 43);
            this.buttonViewAttendance.TabIndex = 4;
            this.buttonViewAttendance.Text = "View Attendance";
            this.buttonViewAttendance.UseVisualStyleBackColor = true;
            this.buttonViewAttendance.Click += new System.EventHandler(this.buttonViewAttendance_Click);
            // 
            // panelSearching
            // 
            this.panelSearching.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelSearching.Controls.Add(this.labelInfo);
            this.panelSearching.Controls.Add(this.labelInput);
            this.panelSearching.Controls.Add(this.labelSearchType);
            this.panelSearching.Controls.Add(this.textBoxInput);
            this.panelSearching.Controls.Add(this.comboBoxSearchType);
            this.panelSearching.Controls.Add(this.buttonsearchStudent);
            this.panelSearching.Controls.Add(this.buttonListAll);
            this.panelSearching.Controls.Add(this.label2);
            this.panelSearching.Location = new System.Drawing.Point(12, 120);
            this.panelSearching.Name = "panelSearching";
            this.panelSearching.Size = new System.Drawing.Size(532, 680);
            this.panelSearching.TabIndex = 7;
            this.panelSearching.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSearching_Paint);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelInfo.Location = new System.Drawing.Point(97, 153);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(320, 20);
            this.labelInfo.TabIndex = 18;
            this.labelInfo.Text = " STUDENT INFORMATION IS AS FOLLOW";
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelInput.Location = new System.Drawing.Point(19, 107);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(82, 20);
            this.labelInput.TabIndex = 16;
            this.labelInput.Text = "Enter Text";
            // 
            // labelSearchType
            // 
            this.labelSearchType.AutoSize = true;
            this.labelSearchType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelSearchType.Location = new System.Drawing.Point(3, 64);
            this.labelSearchType.Name = "labelSearchType";
            this.labelSearchType.Size = new System.Drawing.Size(98, 20);
            this.labelSearchType.TabIndex = 15;
            this.labelSearchType.Text = "Search Type";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(110, 109);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(217, 20);
            this.textBoxInput.TabIndex = 14;
            // 
            // comboBoxSearchType
            // 
            this.comboBoxSearchType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBoxSearchType.FormattingEnabled = true;
            this.comboBoxSearchType.Items.AddRange(new object[] {
            "By ID",
            "By Name",
            "List All"});
            this.comboBoxSearchType.Location = new System.Drawing.Point(110, 61);
            this.comboBoxSearchType.Name = "comboBoxSearchType";
            this.comboBoxSearchType.Size = new System.Drawing.Size(217, 28);
            this.comboBoxSearchType.TabIndex = 13;
            this.comboBoxSearchType.SelectedIndexChanged += new System.EventHandler(this.comboBoxSearchType_SelectedIndexChanged);
            // 
            // buttonsearchStudent
            // 
            this.buttonsearchStudent.Location = new System.Drawing.Point(371, 51);
            this.buttonsearchStudent.Name = "buttonsearchStudent";
            this.buttonsearchStudent.Size = new System.Drawing.Size(150, 38);
            this.buttonsearchStudent.TabIndex = 12;
            this.buttonsearchStudent.Text = "SearchStudent";
            this.buttonsearchStudent.UseVisualStyleBackColor = true;
            this.buttonsearchStudent.Click += new System.EventHandler(this.buttonsearchStudent_Click);
            // 
            // buttonListAll
            // 
            this.buttonListAll.Location = new System.Drawing.Point(371, 100);
            this.buttonListAll.Name = "buttonListAll";
            this.buttonListAll.Size = new System.Drawing.Size(150, 36);
            this.buttonListAll.TabIndex = 11;
            this.buttonListAll.Text = "ListAllStudents";
            this.buttonListAll.UseVisualStyleBackColor = true;
            this.buttonListAll.Click += new System.EventHandler(this.buttonListAll_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(69, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Searching";
            // 
            // panelProfile
            // 
            this.panelProfile.BackColor = System.Drawing.Color.Bisque;
            this.panelProfile.Controls.Add(this.textBoxEnrollment);
            this.panelProfile.Controls.Add(this.buttonDelete);
            this.panelProfile.Controls.Add(this.label5);
            this.panelProfile.Controls.Add(this.richTextBoxtopThree);
            this.panelProfile.Controls.Add(this.textBoxUniversity);
            this.panelProfile.Controls.Add(this.textBoxDepartment);
            this.panelProfile.Controls.Add(this.textBoxCgPA);
            this.panelProfile.Controls.Add(this.textBoxSemester);
            this.panelProfile.Controls.Add(this.textBoxName);
            this.panelProfile.Controls.Add(this.textBoxID);
            this.panelProfile.Controls.Add(this.label3);
            this.panelProfile.Controls.Add(this.buttonProfile);
            this.panelProfile.Controls.Add(this.buttontopThree);
            this.panelProfile.Location = new System.Drawing.Point(560, 120);
            this.panelProfile.Name = "panelProfile";
            this.panelProfile.Size = new System.Drawing.Size(406, 702);
            this.panelProfile.TabIndex = 8;
            // 
            // textBoxEnrollment
            // 
            this.textBoxEnrollment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxEnrollment.Location = new System.Drawing.Point(161, 510);
            this.textBoxEnrollment.Name = "textBoxEnrollment";
            this.textBoxEnrollment.Size = new System.Drawing.Size(201, 26);
            this.textBoxEnrollment.TabIndex = 21;
            this.textBoxEnrollment.Text = "Enrollment No";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonDelete.Location = new System.Drawing.Point(13, 487);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(142, 72);
            this.buttonDelete.TabIndex = 20;
            this.buttonDelete.Text = "Delete Student Record";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(188, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Top 3 CGPA";
            // 
            // richTextBoxtopThree
            // 
            this.richTextBoxtopThree.Location = new System.Drawing.Point(160, 368);
            this.richTextBoxtopThree.Name = "richTextBoxtopThree";
            this.richTextBoxtopThree.Size = new System.Drawing.Size(183, 78);
            this.richTextBoxtopThree.TabIndex = 18;
            this.richTextBoxtopThree.Text = "";
            this.richTextBoxtopThree.TextChanged += new System.EventHandler(this.richTextBoxtopThree_TextChanged);
            // 
            // textBoxUniversity
            // 
            this.textBoxUniversity.Location = new System.Drawing.Point(30, 316);
            this.textBoxUniversity.Name = "textBoxUniversity";
            this.textBoxUniversity.Size = new System.Drawing.Size(183, 20);
            this.textBoxUniversity.TabIndex = 17;
            this.textBoxUniversity.Text = "University";
            // 
            // textBoxDepartment
            // 
            this.textBoxDepartment.Location = new System.Drawing.Point(30, 276);
            this.textBoxDepartment.Name = "textBoxDepartment";
            this.textBoxDepartment.Size = new System.Drawing.Size(183, 20);
            this.textBoxDepartment.TabIndex = 16;
            this.textBoxDepartment.Text = "Department";
            // 
            // textBoxCgPA
            // 
            this.textBoxCgPA.Location = new System.Drawing.Point(30, 220);
            this.textBoxCgPA.Name = "textBoxCgPA";
            this.textBoxCgPA.Size = new System.Drawing.Size(183, 20);
            this.textBoxCgPA.TabIndex = 15;
            this.textBoxCgPA.Text = "CGPA";
            // 
            // textBoxSemester
            // 
            this.textBoxSemester.Location = new System.Drawing.Point(30, 169);
            this.textBoxSemester.Name = "textBoxSemester";
            this.textBoxSemester.Size = new System.Drawing.Size(183, 20);
            this.textBoxSemester.TabIndex = 14;
            this.textBoxSemester.Text = "Semester";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(30, 126);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(183, 20);
            this.textBoxName.TabIndex = 13;
            this.textBoxName.Text = "Name";
            // 
            // textBoxID
            // 
            this.textBoxID.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textBoxID.Location = new System.Drawing.Point(30, 69);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(183, 20);
            this.textBoxID.TabIndex = 12;
            this.textBoxID.Text = "ID";
            this.textBoxID.TextChanged += new System.EventHandler(this.textBoxID_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Chocolate;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(122, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 26);
            this.label3.TabIndex = 11;
            this.label3.Text = "Profile";
            // 
            // panelAttendance
            // 
            this.panelAttendance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelAttendance.Controls.Add(this.label6);
            this.panelAttendance.Controls.Add(this.richTextBoxMarkedAttendance);
            this.panelAttendance.Controls.Add(this.textBoxEnrollmentAtt);
            this.panelAttendance.Controls.Add(this.radioButtonPresent);
            this.panelAttendance.Controls.Add(this.radioButtonAbsent);
            this.panelAttendance.Controls.Add(this.label4);
            this.panelAttendance.Controls.Add(this.buttonMarkAttendance);
            this.panelAttendance.Controls.Add(this.buttonViewAttendance);
            this.panelAttendance.Location = new System.Drawing.Point(958, 120);
            this.panelAttendance.Name = "panelAttendance";
            this.panelAttendance.Size = new System.Drawing.Size(384, 662);
            this.panelAttendance.TabIndex = 9;
            this.panelAttendance.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAttendance_Paint);
            // 
            // radioButtonPresent
            // 
            this.radioButtonPresent.AutoSize = true;
            this.radioButtonPresent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioButtonPresent.Location = new System.Drawing.Point(244, 100);
            this.radioButtonPresent.Name = "radioButtonPresent";
            this.radioButtonPresent.Size = new System.Drawing.Size(82, 24);
            this.radioButtonPresent.TabIndex = 15;
            this.radioButtonPresent.TabStop = true;
            this.radioButtonPresent.Text = "Present";
            this.radioButtonPresent.UseVisualStyleBackColor = true;
            // 
            // radioButtonAbsent
            // 
            this.radioButtonAbsent.AutoSize = true;
            this.radioButtonAbsent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioButtonAbsent.Location = new System.Drawing.Point(155, 100);
            this.radioButtonAbsent.Name = "radioButtonAbsent";
            this.radioButtonAbsent.Size = new System.Drawing.Size(78, 24);
            this.radioButtonAbsent.TabIndex = 14;
            this.radioButtonAbsent.TabStop = true;
            this.radioButtonAbsent.Text = "Absent";
            this.radioButtonAbsent.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlText;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(86, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Attendance ";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 311);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(529, 471);
            this.richTextBox1.TabIndex = 17;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // textBoxEnrollmentAtt
            // 
            this.textBoxEnrollmentAtt.Location = new System.Drawing.Point(23, 102);
            this.textBoxEnrollmentAtt.Name = "textBoxEnrollmentAtt";
            this.textBoxEnrollmentAtt.Size = new System.Drawing.Size(100, 20);
            this.textBoxEnrollmentAtt.TabIndex = 17;
            this.textBoxEnrollmentAtt.Text = "xx-xyzzzz-xxx";
            this.textBoxEnrollmentAtt.TextChanged += new System.EventHandler(this.textBoxEnrollmentAtt_TextChanged);
            // 
            // richTextBoxMarkedAttendance
            // 
            this.richTextBoxMarkedAttendance.Location = new System.Drawing.Point(22, 257);
            this.richTextBoxMarkedAttendance.Name = "richTextBoxMarkedAttendance";
            this.richTextBoxMarkedAttendance.Size = new System.Drawing.Size(285, 360);
            this.richTextBoxMarkedAttendance.TabIndex = 18;
            this.richTextBoxMarkedAttendance.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Azure;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label6.Location = new System.Drawing.Point(56, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 26);
            this.label6.TabIndex = 19;
            this.label6.Text = "Marked Attendance";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1296, 749);
            this.Controls.Add(this.panelAttendance);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.panelProfile);
            this.Controls.Add(this.panelSearching);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSearching.ResumeLayout(false);
            this.panelSearching.PerformLayout();
            this.panelProfile.ResumeLayout(false);
            this.panelProfile.PerformLayout();
            this.panelAttendance.ResumeLayout(false);
            this.panelAttendance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttontopThree;
        private System.Windows.Forms.Button buttonProfile;
        private System.Windows.Forms.Button buttonMarkAttendance;
        private System.Windows.Forms.Button buttonViewAttendance;
        private System.Windows.Forms.Panel panelSearching;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelProfile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelAttendance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxUniversity;
        private System.Windows.Forms.TextBox textBoxDepartment;
        private System.Windows.Forms.TextBox textBoxCgPA;
        private System.Windows.Forms.TextBox textBoxSemester;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Button buttonListAll;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button buttonsearchStudent;
        private System.Windows.Forms.ComboBox comboBoxSearchType;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.Label labelSearchType;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBoxtopThree;
        private System.Windows.Forms.TextBox textBoxEnrollment;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.RadioButton radioButtonPresent;
        private System.Windows.Forms.RadioButton radioButtonAbsent;
        private System.Windows.Forms.TextBox textBoxEnrollmentAtt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextBoxMarkedAttendance;
    }
}

