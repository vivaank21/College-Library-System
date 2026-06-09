namespace College_Management_System
{
    partial class Students
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btnViewStudent = new Button();
            btnLogout = new Button();
            btnSettings = new Button();
            btnReports = new Button();
            btnReturnBook = new Button();
            button1 = new Button();
            btnBooks = new Button();
            panel4 = new Panel();
            button2 = new Button();
            cbSemester = new ComboBox();
            cbStatus = new ComboBox();
            lblStatus = new Label();
            button3 = new Button();
            panel3 = new Panel();
            label1 = new Label();
            cbDepartment = new ComboBox();
            btnUploadImage = new Button();
            picImg = new PictureBox();
            txtContact = new TextBox();
            txtEmail = new TextBox();
            txtErollment = new TextBox();
            txtSName = new TextBox();
            lblSemester = new Label();
            lblQty = new Label();
            lblDepartment = new Label();
            lblAuthor = new Label();
            lblEnrollment = new Label();
            lblStudentname = new Label();
            openFileDialog1 = new OpenFileDialog();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picImg).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(82, 121, 111);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(5, 4, 5, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(2395, 65);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.closeIcon;
            pictureBox1.Location = new Point(1188, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(132, 169, 140);
            panel2.Controls.Add(btnViewStudent);
            panel2.Controls.Add(btnLogout);
            panel2.Controls.Add(btnSettings);
            panel2.Controls.Add(btnReports);
            panel2.Controls.Add(btnReturnBook);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(btnBooks);
            panel2.Location = new Point(0, 65);
            panel2.Name = "panel2";
            panel2.Size = new Size(217, 643);
            panel2.TabIndex = 2;
            // 
            // btnViewStudent
            // 
            btnViewStudent.BackColor = Color.FromArgb(224, 224, 224);
            btnViewStudent.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewStudent.Location = new Point(7, 141);
            btnViewStudent.Name = "btnViewStudent";
            btnViewStudent.Size = new Size(202, 80);
            btnViewStudent.TabIndex = 8;
            btnViewStudent.Text = "View Students";
            btnViewStudent.UseVisualStyleBackColor = false;
            btnViewStudent.Click += btnViewStudent_Click_1;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(224, 224, 224);
            btnLogout.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(7, 546);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(202, 65);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "Dashboard";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnSettings
            // 
            btnSettings.BackColor = Color.FromArgb(224, 224, 224);
            btnSettings.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSettings.Location = new Point(7, 466);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(202, 65);
            btnSettings.TabIndex = 6;
            btnSettings.Text = "Settings";
            btnSettings.UseVisualStyleBackColor = false;
            btnSettings.Click += btnSettings_Click;
            // 
            // btnReports
            // 
            btnReports.BackColor = Color.FromArgb(224, 224, 224);
            btnReports.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReports.Location = new Point(7, 388);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(202, 62);
            btnReports.TabIndex = 5;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = false;
            // 
            // btnReturnBook
            // 
            btnReturnBook.BackColor = Color.FromArgb(224, 224, 224);
            btnReturnBook.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReturnBook.Location = new Point(7, 307);
            btnReturnBook.Name = "btnReturnBook";
            btnReturnBook.Size = new Size(202, 65);
            btnReturnBook.TabIndex = 4;
            btnReturnBook.Text = "Return Books";
            btnReturnBook.UseVisualStyleBackColor = false;
            btnReturnBook.Click += btnReturnBook_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(224, 224, 224);
            button1.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(7, 227);
            button1.Name = "button1";
            button1.Size = new Size(202, 64);
            button1.TabIndex = 3;
            button1.Text = "Issue Books";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnBooks
            // 
            btnBooks.BackColor = Color.FromArgb(224, 224, 224);
            btnBooks.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBooks.Location = new Point(7, 54);
            btnBooks.Name = "btnBooks";
            btnBooks.Size = new Size(202, 67);
            btnBooks.TabIndex = 2;
            btnBooks.Text = "Books";
            btnBooks.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(202, 210, 197);
            panel4.Controls.Add(button2);
            panel4.Controls.Add(cbSemester);
            panel4.Controls.Add(cbStatus);
            panel4.Controls.Add(lblStatus);
            panel4.Controls.Add(button3);
            panel4.Controls.Add(panel3);
            panel4.Controls.Add(cbDepartment);
            panel4.Controls.Add(btnUploadImage);
            panel4.Controls.Add(picImg);
            panel4.Controls.Add(txtContact);
            panel4.Controls.Add(txtEmail);
            panel4.Controls.Add(txtErollment);
            panel4.Controls.Add(txtSName);
            panel4.Controls.Add(lblSemester);
            panel4.Controls.Add(lblQty);
            panel4.Controls.Add(lblDepartment);
            panel4.Controls.Add(lblAuthor);
            panel4.Controls.Add(lblEnrollment);
            panel4.Controls.Add(lblStudentname);
            panel4.Location = new Point(215, 65);
            panel4.Name = "panel4";
            panel4.Size = new Size(1037, 640);
            panel4.TabIndex = 4;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(224, 224, 224);
            button2.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(340, 541);
            button2.Name = "button2";
            button2.Size = new Size(209, 83);
            button2.TabIndex = 28;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // cbSemester
            // 
            cbSemester.BackColor = Color.Silver;
            cbSemester.FormattingEnabled = true;
            cbSemester.Location = new Point(184, 407);
            cbSemester.Name = "cbSemester";
            cbSemester.Size = new Size(311, 35);
            cbSemester.TabIndex = 27;
            cbSemester.Text = "Select Category";
            // 
            // cbStatus
            // 
            cbStatus.BackColor = Color.Silver;
            cbStatus.FormattingEnabled = true;
            cbStatus.Location = new Point(184, 466);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(311, 35);
            cbStatus.TabIndex = 26;
            cbStatus.Text = "Select Category";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(76, 469);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(88, 27);
            lblStatus.TabIndex = 25;
            lblStatus.Text = "Status :";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(224, 224, 224);
            button3.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(76, 541);
            button3.Name = "button3";
            button3.Size = new Size(209, 83);
            button3.TabIndex = 23;
            button3.Text = "Add Student";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(53, 79, 82);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1034, 74);
            panel3.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(271, -30);
            label1.Name = "label1";
            label1.Size = new Size(482, 94);
            label1.TabIndex = 23;
            label1.Text = "\n\U0001f9d1‍🎓 Students Management";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbDepartment
            // 
            cbDepartment.BackColor = Color.Silver;
            cbDepartment.FormattingEnabled = true;
            cbDepartment.Location = new Point(184, 347);
            cbDepartment.Name = "cbDepartment";
            cbDepartment.Size = new Size(311, 35);
            cbDepartment.TabIndex = 21;
            cbDepartment.Text = "Select Category";
            // 
            // btnUploadImage
            // 
            btnUploadImage.BackColor = Color.FromArgb(224, 224, 224);
            btnUploadImage.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUploadImage.Location = new Point(746, 369);
            btnUploadImage.Name = "btnUploadImage";
            btnUploadImage.Size = new Size(202, 65);
            btnUploadImage.TabIndex = 9;
            btnUploadImage.Text = "Upload Image";
            btnUploadImage.UseVisualStyleBackColor = false;
            btnUploadImage.Click += btnUploadImage_Click;
            // 
            // picImg
            // 
            picImg.Image = Properties.Resources.book_img;
            picImg.Location = new Point(736, 105);
            picImg.Name = "picImg";
            picImg.Size = new Size(222, 246);
            picImg.SizeMode = PictureBoxSizeMode.StretchImage;
            picImg.TabIndex = 20;
            picImg.TabStop = false;
            // 
            // txtContact
            // 
            txtContact.BackColor = Color.Silver;
            txtContact.Location = new Point(184, 291);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(311, 34);
            txtContact.TabIndex = 19;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.Silver;
            txtEmail.Location = new Point(184, 229);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(311, 34);
            txtEmail.TabIndex = 17;
            // 
            // txtErollment
            // 
            txtErollment.BackColor = Color.Silver;
            txtErollment.Location = new Point(184, 171);
            txtErollment.Name = "txtErollment";
            txtErollment.Size = new Size(311, 34);
            txtErollment.TabIndex = 16;
            // 
            // txtSName
            // 
            txtSName.BackColor = Color.Silver;
            txtSName.Location = new Point(184, 115);
            txtSName.Name = "txtSName";
            txtSName.Size = new Size(311, 34);
            txtSName.TabIndex = 15;
            // 
            // lblSemester
            // 
            lblSemester.AutoSize = true;
            lblSemester.Location = new Point(44, 410);
            lblSemester.Name = "lblSemester";
            lblSemester.Size = new Size(121, 27);
            lblSemester.TabIndex = 14;
            lblSemester.Text = "Semester :";
            // 
            // lblQty
            // 
            lblQty.AutoSize = true;
            lblQty.Location = new Point(23, 294);
            lblQty.Name = "lblQty";
            lblQty.Size = new Size(141, 27);
            lblQty.TabIndex = 13;
            lblQty.Text = "Contact No. :";
            // 
            // lblDepartment
            // 
            lblDepartment.AutoSize = true;
            lblDepartment.Location = new Point(15, 355);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(150, 27);
            lblDepartment.TabIndex = 12;
            lblDepartment.Text = "Department :";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Location = new Point(83, 232);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(82, 27);
            lblAuthor.TabIndex = 11;
            lblAuthor.Text = "Email :";
            // 
            // lblEnrollment
            // 
            lblEnrollment.AutoSize = true;
            lblEnrollment.Location = new Point(23, 174);
            lblEnrollment.Name = "lblEnrollment";
            lblEnrollment.Size = new Size(142, 27);
            lblEnrollment.TabIndex = 10;
            lblEnrollment.Text = "Enrollment :";
            // 
            // lblStudentname
            // 
            lblStudentname.AutoSize = true;
            lblStudentname.Location = new Point(0, 122);
            lblStudentname.Name = "lblStudentname";
            lblStudentname.Size = new Size(165, 27);
            lblStudentname.TabIndex = 9;
            lblStudentname.Text = "Student Name:";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Students
            // 
            AutoScaleDimensions = new SizeF(13F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1248, 701);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 4, 5, 4);
            Name = "Students";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Students";
            Load += Students_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picImg).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnLogout;
        private Button btnSettings;
        private Button btnReports;
        private Button btnReturnBook;
        private Button button1;
        private Button btnBooks;
        private Panel panel4;
        private Button button3;
        private Panel panel3;
        private Label label1;
        private ComboBox cbDepartment;
        private Button btnUploadImage;
        private PictureBox picImg;
        private TextBox txtContact;
        private TextBox txtEmail;
        private TextBox txtErollment;
        private TextBox txtSName;
        private Label lblSemester;
        private Label lblQty;
        private Label lblDepartment;
        private Label lblAuthor;
        private Label lblEnrollment;
        private Label lblStudentname;
        private ComboBox cbStatus;
        private Label lblStatus;
        private ComboBox cbSemester;
        private PictureBox pictureBox1;
        private Button button2;
        private OpenFileDialog openFileDialog1;
        private Button btnViewStudent;
    }
}