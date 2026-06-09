namespace College_Management_System
{
    partial class IssueBooks
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
            btnLogout = new Button();
            btnBooks = new Button();
            btnStudents = new Button();
            btnDisplay = new Button();
            btnDashboard = new Button();
            panel3 = new Panel();
            gbIssuebooks = new GroupBox();
            btnReturn = new Button();
            btnIssue = new Button();
            dtDueDate = new DateTimePicker();
            lblDueDate = new Label();
            dtIssueDate = new DateTimePicker();
            lblIssuedate = new Label();
            groupBox1 = new GroupBox();
            lblAvailableCopies = new Label();
            txtRack = new TextBox();
            lblRack = new Label();
            txtAuthor = new TextBox();
            lblAuthor = new Label();
            cmbBooks = new ComboBox();
            lblBooks = new Label();
            cmbCategory = new ComboBox();
            label1 = new Label();
            gbStudInfo = new GroupBox();
            btnSearch = new Button();
            txtDepartment = new TextBox();
            txtSemester = new TextBox();
            txtStudentName = new TextBox();
            lblSnane = new Label();
            lblSem = new Label();
            lblDept = new Label();
            lblEnroll = new Label();
            txtEnrollment = new TextBox();
            panel4 = new Panel();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            gbIssuebooks.SuspendLayout();
            groupBox1.SuspendLayout();
            gbStudInfo.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(82, 121, 111);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1472, 40);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.closeIcon;
            pictureBox1.Location = new Point(1433, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(132, 169, 140);
            panel2.Controls.Add(btnLogout);
            panel2.Controls.Add(btnBooks);
            panel2.Controls.Add(btnStudents);
            panel2.Controls.Add(btnDisplay);
            panel2.Controls.Add(btnDashboard);
            panel2.Location = new Point(0, 51);
            panel2.Name = "panel2";
            panel2.Size = new Size(219, 656);
            panel2.TabIndex = 1;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Silver;
            btnLogout.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(30, 525);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(157, 61);
            btnLogout.TabIndex = 12;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnBooks
            // 
            btnBooks.BackColor = Color.Silver;
            btnBooks.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBooks.Location = new Point(30, 403);
            btnBooks.Name = "btnBooks";
            btnBooks.Size = new Size(157, 61);
            btnBooks.TabIndex = 11;
            btnBooks.Text = "Books";
            btnBooks.UseVisualStyleBackColor = false;
            btnBooks.Click += btnBooks_Click;
            // 
            // btnStudents
            // 
            btnStudents.BackColor = Color.Silver;
            btnStudents.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStudents.Location = new Point(30, 278);
            btnStudents.Name = "btnStudents";
            btnStudents.Size = new Size(157, 61);
            btnStudents.TabIndex = 10;
            btnStudents.Text = "Students";
            btnStudents.UseVisualStyleBackColor = false;
            btnStudents.Click += btnStudents_Click;
            // 
            // btnDisplay
            // 
            btnDisplay.BackColor = Color.Silver;
            btnDisplay.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDisplay.Location = new Point(30, 157);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(157, 61);
            btnDisplay.TabIndex = 9;
            btnDisplay.Text = "Display";
            btnDisplay.UseVisualStyleBackColor = false;
            btnDisplay.Click += btnDisplay_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.Silver;
            btnDashboard.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.Location = new Point(30, 38);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(157, 61);
            btnDashboard.TabIndex = 8;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(202, 210, 197);
            panel3.Controls.Add(gbIssuebooks);
            panel3.Controls.Add(groupBox1);
            panel3.Controls.Add(gbStudInfo);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(217, 51);
            panel3.Name = "panel3";
            panel3.Size = new Size(1267, 656);
            panel3.TabIndex = 2;
            // 
            // gbIssuebooks
            // 
            gbIssuebooks.Controls.Add(btnReturn);
            gbIssuebooks.Controls.Add(btnIssue);
            gbIssuebooks.Controls.Add(dtDueDate);
            gbIssuebooks.Controls.Add(lblDueDate);
            gbIssuebooks.Controls.Add(dtIssueDate);
            gbIssuebooks.Controls.Add(lblIssuedate);
            gbIssuebooks.Location = new Point(463, 403);
            gbIssuebooks.Name = "gbIssuebooks";
            gbIssuebooks.Size = new Size(791, 224);
            gbIssuebooks.TabIndex = 2;
            gbIssuebooks.TabStop = false;
            gbIssuebooks.Text = "📅 Issue Details";
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.Silver;
            btnReturn.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReturn.Location = new Point(488, 122);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(157, 61);
            btnReturn.TabIndex = 8;
            btnReturn.Text = "Return Book";
            btnReturn.UseVisualStyleBackColor = false;
            // 
            // btnIssue
            // 
            btnIssue.BackColor = Color.Silver;
            btnIssue.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIssue.Location = new Point(94, 122);
            btnIssue.Name = "btnIssue";
            btnIssue.Size = new Size(157, 61);
            btnIssue.TabIndex = 7;
            btnIssue.Text = "Issue Book";
            btnIssue.UseVisualStyleBackColor = false;
            btnIssue.Click += btnIssue_Click;
            // 
            // dtDueDate
            // 
            dtDueDate.Location = new Point(519, 52);
            dtDueDate.Name = "dtDueDate";
            dtDueDate.Size = new Size(250, 27);
            dtDueDate.TabIndex = 6;
            // 
            // lblDueDate
            // 
            lblDueDate.AutoSize = true;
            lblDueDate.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDueDate.Location = new Point(409, 54);
            lblDueDate.Name = "lblDueDate";
            lblDueDate.Size = new Size(104, 23);
            lblDueDate.TabIndex = 5;
            lblDueDate.Text = "Due Date :";
            // 
            // dtIssueDate
            // 
            dtIssueDate.Location = new Point(142, 50);
            dtIssueDate.Name = "dtIssueDate";
            dtIssueDate.Size = new Size(250, 27);
            dtIssueDate.TabIndex = 4;
            // 
            // lblIssuedate
            // 
            lblIssuedate.AutoSize = true;
            lblIssuedate.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIssuedate.Location = new Point(21, 52);
            lblIssuedate.Name = "lblIssuedate";
            lblIssuedate.Size = new Size(115, 23);
            lblIssuedate.TabIndex = 3;
            lblIssuedate.Text = "Issue Date :";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblAvailableCopies);
            groupBox1.Controls.Add(txtRack);
            groupBox1.Controls.Add(lblRack);
            groupBox1.Controls.Add(txtAuthor);
            groupBox1.Controls.Add(lblAuthor);
            groupBox1.Controls.Add(cmbBooks);
            groupBox1.Controls.Add(lblBooks);
            groupBox1.Controls.Add(cmbCategory);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(463, 115);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(791, 273);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "📚 Book Information";
            // 
            // lblAvailableCopies
            // 
            lblAvailableCopies.AutoSize = true;
            lblAvailableCopies.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAvailableCopies.Location = new Point(287, 201);
            lblAvailableCopies.Name = "lblAvailableCopies";
            lblAvailableCopies.Size = new Size(155, 23);
            lblAvailableCopies.TabIndex = 11;
            lblAvailableCopies.Text = "Available books";
            // 
            // txtRack
            // 
            txtRack.BackColor = Color.FromArgb(224, 224, 224);
            txtRack.Location = new Point(488, 127);
            txtRack.Name = "txtRack";
            txtRack.ReadOnly = true;
            txtRack.Size = new Size(264, 27);
            txtRack.TabIndex = 10;
            // 
            // lblRack
            // 
            lblRack.AutoSize = true;
            lblRack.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRack.Location = new Point(383, 127);
            lblRack.Name = "lblRack";
            lblRack.Size = new Size(94, 23);
            lblRack.TabIndex = 9;
            lblRack.Text = "Rack No :";
            // 
            // txtAuthor
            // 
            txtAuthor.BackColor = Color.FromArgb(224, 224, 224);
            txtAuthor.Location = new Point(488, 42);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.ReadOnly = true;
            txtAuthor.Size = new Size(264, 27);
            txtAuthor.TabIndex = 8;
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAuthor.Location = new Point(383, 42);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(84, 23);
            lblAuthor.TabIndex = 6;
            lblAuthor.Text = "Author :";
            // 
            // cmbBooks
            // 
            cmbBooks.BackColor = Color.FromArgb(224, 224, 224);
            cmbBooks.FormattingEnabled = true;
            cmbBooks.Location = new Point(113, 127);
            cmbBooks.Name = "cmbBooks";
            cmbBooks.Size = new Size(214, 28);
            cmbBooks.TabIndex = 5;
            cmbBooks.SelectedIndexChanged += cmbBooks_SelectedIndexChanged;
            // 
            // lblBooks
            // 
            lblBooks.AutoSize = true;
            lblBooks.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBooks.Location = new Point(31, 132);
            lblBooks.Name = "lblBooks";
            lblBooks.Size = new Size(76, 23);
            lblBooks.TabIndex = 4;
            lblBooks.Text = "Books :";
            // 
            // cmbCategory
            // 
            cmbCategory.BackColor = Color.FromArgb(224, 224, 224);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(113, 42);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(214, 28);
            cmbCategory.TabIndex = 3;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            cmbCategory.SelectionChangeCommitted += cmbCategory_SelectionChangeCommitted;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 42);
            label1.Name = "label1";
            label1.Size = new Size(101, 23);
            label1.TabIndex = 2;
            label1.Text = "Category :";
            // 
            // gbStudInfo
            // 
            gbStudInfo.Controls.Add(btnSearch);
            gbStudInfo.Controls.Add(txtDepartment);
            gbStudInfo.Controls.Add(txtSemester);
            gbStudInfo.Controls.Add(txtStudentName);
            gbStudInfo.Controls.Add(lblSnane);
            gbStudInfo.Controls.Add(lblSem);
            gbStudInfo.Controls.Add(lblDept);
            gbStudInfo.Controls.Add(lblEnroll);
            gbStudInfo.Controls.Add(txtEnrollment);
            gbStudInfo.Location = new Point(8, 99);
            gbStudInfo.Name = "gbStudInfo";
            gbStudInfo.Size = new Size(438, 499);
            gbStudInfo.TabIndex = 0;
            gbStudInfo.TabStop = false;
            gbStudInfo.Text = "👨‍🎓 Student Information";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Silver;
            btnSearch.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(126, 426);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(157, 61);
            btnSearch.TabIndex = 8;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtDepartment
            // 
            txtDepartment.BackColor = Color.FromArgb(224, 224, 224);
            txtDepartment.Location = new Point(168, 383);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.ReadOnly = true;
            txtDepartment.Size = new Size(264, 27);
            txtDepartment.TabIndex = 7;
            // 
            // txtSemester
            // 
            txtSemester.BackColor = Color.FromArgb(224, 224, 224);
            txtSemester.Location = new Point(168, 262);
            txtSemester.Name = "txtSemester";
            txtSemester.ReadOnly = true;
            txtSemester.Size = new Size(264, 27);
            txtSemester.TabIndex = 6;
            // 
            // txtStudentName
            // 
            txtStudentName.BackColor = Color.FromArgb(224, 224, 224);
            txtStudentName.Location = new Point(168, 148);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.ReadOnly = true;
            txtStudentName.Size = new Size(264, 27);
            txtStudentName.TabIndex = 5;
            // 
            // lblSnane
            // 
            lblSnane.AutoSize = true;
            lblSnane.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSnane.Location = new Point(6, 148);
            lblSnane.Name = "lblSnane";
            lblSnane.Size = new Size(149, 23);
            lblSnane.TabIndex = 4;
            lblSnane.Text = "Student Name :";
            // 
            // lblSem
            // 
            lblSem.AutoSize = true;
            lblSem.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSem.Location = new Point(21, 266);
            lblSem.Name = "lblSem";
            lblSem.Size = new Size(106, 23);
            lblSem.TabIndex = 3;
            lblSem.Text = "Semester :";
            // 
            // lblDept
            // 
            lblDept.AutoSize = true;
            lblDept.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDept.Location = new Point(23, 387);
            lblDept.Name = "lblDept";
            lblDept.Size = new Size(132, 23);
            lblDept.TabIndex = 2;
            lblDept.Text = "Department :";
            // 
            // lblEnroll
            // 
            lblEnroll.AutoSize = true;
            lblEnroll.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEnroll.Location = new Point(21, 40);
            lblEnroll.Name = "lblEnroll";
            lblEnroll.Size = new Size(124, 23);
            lblEnroll.TabIndex = 1;
            lblEnroll.Text = "Enrollment :";
            lblEnroll.Click += label1_Click;
            // 
            // txtEnrollment
            // 
            txtEnrollment.BackColor = Color.FromArgb(224, 224, 224);
            txtEnrollment.Location = new Point(168, 37);
            txtEnrollment.Name = "txtEnrollment";
            txtEnrollment.Size = new Size(264, 27);
            txtEnrollment.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(53, 79, 82);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1267, 99);
            panel4.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(433, 32);
            label2.Name = "label2";
            label2.Size = new Size(390, 40);
            label2.TabIndex = 3;
            label2.Text = "📚 ISSUE BOOK CENTER ";
            // 
            // IssueBooks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1483, 701);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "IssueBooks";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IssueBooks";
            Load += IssueBooks_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            gbIssuebooks.ResumeLayout(false);
            gbIssuebooks.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            gbStudInfo.ResumeLayout(false);
            gbStudInfo.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private GroupBox gbStudInfo;
        private Label lblEnroll;
        private TextBox txtEnrollment;
        private Label lblSnane;
        private Label lblSem;
        private Label lblDept;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox txtDepartment;
        private TextBox txtSemester;
        private TextBox txtStudentName;
        private TextBox txtRack;
        private Label lblRack;
        private TextBox txtAuthor;
        private Label lblAuthor;
        private ComboBox cmbBooks;
        private Label lblBooks;
        private ComboBox cmbCategory;
        private GroupBox gbIssuebooks;
        private Label lblDueDate;
        private DateTimePicker dtIssueDate;
        private Label lblIssuedate;
        private Label lblAvailableCopies;
        private Button btnReturn;
        private Button btnIssue;
        private DateTimePicker dtDueDate;
        private Label label2;
        private PictureBox pictureBox1;
        private Button btnDashboard;
        private Button btnLogout;
        private Button btnBooks;
        private Button btnStudents;
        private Button btnDisplay;
        private Button btnSearch;
    }
}