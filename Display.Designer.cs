namespace College_Management_System
{
    partial class Display
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
            btnIssueBooks = new Button();
            btnDashboard = new Button();
            panel3 = new Panel();
            btnReturn = new Button();
            DGVIssuedBooks = new DataGridView();
            btnSearch = new Button();
            cmbStatus = new ComboBox();
            lblStatus = new Label();
            txtEnrollment = new TextBox();
            lblEnrollment = new Label();
            panel4 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVIssuedBooks).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(82, 121, 111);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1468, 48);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.closeIcon;
            pictureBox1.Location = new Point(1417, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(132, 169, 140);
            panel2.Controls.Add(btnLogout);
            panel2.Controls.Add(btnBooks);
            panel2.Controls.Add(btnStudents);
            panel2.Controls.Add(btnIssueBooks);
            panel2.Controls.Add(btnDashboard);
            panel2.Location = new Point(3, 45);
            panel2.Name = "panel2";
            panel2.Size = new Size(237, 649);
            panel2.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Silver;
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(35, 466);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(158, 62);
            btnLogout.TabIndex = 10;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnBooks
            // 
            btnBooks.BackColor = Color.Silver;
            btnBooks.Cursor = Cursors.Hand;
            btnBooks.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBooks.Location = new Point(35, 357);
            btnBooks.Name = "btnBooks";
            btnBooks.Size = new Size(158, 62);
            btnBooks.TabIndex = 9;
            btnBooks.Text = "Books";
            btnBooks.UseVisualStyleBackColor = false;
            btnBooks.Click += btnBooks_Click;
            // 
            // btnStudents
            // 
            btnStudents.BackColor = Color.Silver;
            btnStudents.Cursor = Cursors.Hand;
            btnStudents.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStudents.Location = new Point(35, 253);
            btnStudents.Name = "btnStudents";
            btnStudents.Size = new Size(158, 62);
            btnStudents.TabIndex = 8;
            btnStudents.Text = "Students";
            btnStudents.UseVisualStyleBackColor = false;
            btnStudents.Click += btnStudents_Click;
            // 
            // btnIssueBooks
            // 
            btnIssueBooks.BackColor = Color.Silver;
            btnIssueBooks.Cursor = Cursors.Hand;
            btnIssueBooks.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIssueBooks.Location = new Point(35, 144);
            btnIssueBooks.Name = "btnIssueBooks";
            btnIssueBooks.Size = new Size(158, 62);
            btnIssueBooks.TabIndex = 7;
            btnIssueBooks.Text = "Issue Books";
            btnIssueBooks.UseVisualStyleBackColor = false;
            btnIssueBooks.Click += btnIssueBooks_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.Silver;
            btnDashboard.Cursor = Cursors.Hand;
            btnDashboard.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.Location = new Point(35, 42);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(158, 57);
            btnDashboard.TabIndex = 6;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(202, 210, 197);
            panel3.Controls.Add(btnReturn);
            panel3.Controls.Add(DGVIssuedBooks);
            panel3.Controls.Add(btnSearch);
            panel3.Controls.Add(cmbStatus);
            panel3.Controls.Add(lblStatus);
            panel3.Controls.Add(txtEnrollment);
            panel3.Controls.Add(lblEnrollment);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(238, 45);
            panel3.Name = "panel3";
            panel3.Size = new Size(1230, 649);
            panel3.TabIndex = 1;
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.Silver;
            btnReturn.Cursor = Cursors.Hand;
            btnReturn.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReturn.Location = new Point(1068, 187);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(149, 66);
            btnReturn.TabIndex = 7;
            btnReturn.Text = "Return Books";
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturn_Click;
            // 
            // DGVIssuedBooks
            // 
            DGVIssuedBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVIssuedBooks.Location = new Point(0, 253);
            DGVIssuedBooks.Name = "DGVIssuedBooks";
            DGVIssuedBooks.RowHeadersWidth = 51;
            DGVIssuedBooks.Size = new Size(1230, 396);
            DGVIssuedBooks.TabIndex = 6;
            DGVIssuedBooks.CellClick += DGVIssuedBooks_CellClick;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Silver;
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(445, 135);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(133, 55);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // cmbStatus
            // 
            cmbStatus.BackColor = Color.FromArgb(224, 224, 224);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(167, 178);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(246, 28);
            cmbStatus.TabIndex = 4;
            cmbStatus.SelectedIndexChanged += cmbStatus_SelectedIndexChanged;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(85, 178);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(76, 23);
            lblStatus.TabIndex = 3;
            lblStatus.Text = "Status :";
            // 
            // txtEnrollment
            // 
            txtEnrollment.BackColor = Color.FromArgb(224, 224, 224);
            txtEnrollment.Location = new Point(167, 118);
            txtEnrollment.Name = "txtEnrollment";
            txtEnrollment.Size = new Size(246, 27);
            txtEnrollment.TabIndex = 2;
            // 
            // lblEnrollment
            // 
            lblEnrollment.AutoSize = true;
            lblEnrollment.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEnrollment.Location = new Point(37, 122);
            lblEnrollment.Name = "lblEnrollment";
            lblEnrollment.Size = new Size(124, 23);
            lblEnrollment.TabIndex = 1;
            lblEnrollment.Text = "Enrollment :";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(53, 79, 82);
            panel4.Controls.Add(label1);
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1230, 82);
            panel4.TabIndex = 0;
            panel4.Paint += panel4_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(488, 19);
            label1.Name = "label1";
            label1.Size = new Size(351, 40);
            label1.TabIndex = 2;
            label1.Text = "📋 View Issued Books";
            // 
            // Display
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1467, 694);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Display";
            Text = "Display";
            Load += Display_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVIssuedBooks).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label lblStatus;
        private TextBox txtEnrollment;
        private Label lblEnrollment;
        private ComboBox cmbStatus;
        private Button btnReturn;
        private DataGridView DGVIssuedBooks;
        private Button btnSearch;
        private Button btnStudents;
        private Button btnIssueBooks;
        private Button btnDashboard;
        private Button btnLogout;
        private Button btnBooks;
        private Label label1;
    }
}