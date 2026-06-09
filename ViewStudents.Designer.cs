namespace College_Management_System
{
    partial class ViewStudents
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
            btnSetting = new Button();
            btnStudent = new Button();
            btnDashboard = new Button();
            panel3 = new Panel();
            btnDelete = new Button();
            btnUppdate = new Button();
            DGVStudent = new DataGridView();
            cmbDept = new ComboBox();
            lblDept = new Label();
            panel5 = new Panel();
            lblTitle = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVStudent).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(82, 121, 111);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1520, 54);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.closeIcon;
            pictureBox1.Location = new Point(1469, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(132, 169, 140);
            panel2.Controls.Add(btnLogout);
            panel2.Controls.Add(btnSetting);
            panel2.Controls.Add(btnStudent);
            panel2.Controls.Add(btnDashboard);
            panel2.Location = new Point(0, 52);
            panel2.Name = "panel2";
            panel2.Size = new Size(240, 624);
            panel2.TabIndex = 1;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(224, 224, 224);
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(25, 479);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(189, 75);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnSetting
            // 
            btnSetting.BackColor = Color.FromArgb(224, 224, 224);
            btnSetting.Cursor = Cursors.Hand;
            btnSetting.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSetting.Location = new Point(25, 343);
            btnSetting.Name = "btnSetting";
            btnSetting.Size = new Size(189, 83);
            btnSetting.TabIndex = 2;
            btnSetting.Text = "Settings";
            btnSetting.UseVisualStyleBackColor = false;
            btnSetting.Click += btnSetting_Click;
            // 
            // btnStudent
            // 
            btnStudent.BackColor = Color.FromArgb(224, 224, 224);
            btnStudent.Cursor = Cursors.Hand;
            btnStudent.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStudent.Location = new Point(25, 210);
            btnStudent.Name = "btnStudent";
            btnStudent.Size = new Size(189, 75);
            btnStudent.TabIndex = 1;
            btnStudent.Text = "Student";
            btnStudent.UseVisualStyleBackColor = false;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(224, 224, 224);
            btnDashboard.Cursor = Cursors.Hand;
            btnDashboard.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.Location = new Point(25, 69);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(189, 79);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(202, 210, 197);
            panel3.Controls.Add(btnDelete);
            panel3.Controls.Add(btnUppdate);
            panel3.Controls.Add(DGVStudent);
            panel3.Controls.Add(cmbDept);
            panel3.Controls.Add(lblDept);
            panel3.Controls.Add(panel5);
            panel3.Location = new Point(237, 52);
            panel3.Name = "panel3";
            panel3.Size = new Size(1283, 627);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(224, 224, 224);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(1108, 88);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(136, 51);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUppdate
            // 
            btnUppdate.BackColor = Color.FromArgb(224, 224, 224);
            btnUppdate.Cursor = Cursors.Hand;
            btnUppdate.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUppdate.Location = new Point(956, 87);
            btnUppdate.Name = "btnUppdate";
            btnUppdate.Size = new Size(136, 51);
            btnUppdate.TabIndex = 7;
            btnUppdate.Text = "Update";
            btnUppdate.UseVisualStyleBackColor = false;
            btnUppdate.Click += btnUppdate_Click;
            // 
            // DGVStudent
            // 
            DGVStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVStudent.Cursor = Cursors.Hand;
            DGVStudent.Location = new Point(-3, 188);
            DGVStudent.MultiSelect = false;
            DGVStudent.Name = "DGVStudent";
            DGVStudent.ReadOnly = true;
            DGVStudent.RowHeadersWidth = 51;
            DGVStudent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGVStudent.Size = new Size(1286, 433);
            DGVStudent.TabIndex = 6;
            // 
            // cmbDept
            // 
            cmbDept.Cursor = Cursors.Hand;
            cmbDept.FormattingEnabled = true;
            cmbDept.Location = new Point(286, 111);
            cmbDept.Name = "cmbDept";
            cmbDept.Size = new Size(346, 28);
            cmbDept.TabIndex = 5;
            cmbDept.SelectedIndexChanged += cmbDept_SelectedIndexChanged;
            // 
            // lblDept
            // 
            lblDept.AutoSize = true;
            lblDept.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDept.ForeColor = Color.Black;
            lblDept.Location = new Point(58, 112);
            lblDept.Name = "lblDept";
            lblDept.Size = new Size(222, 27);
            lblDept.TabIndex = 4;
            lblDept.Text = "Select Department : ";
            lblDept.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(53, 79, 82);
            panel5.Controls.Add(lblTitle);
            panel5.Location = new Point(-3, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(1286, 81);
            panel5.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Cambria", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(415, -23);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(368, 104);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "\r\n\U0001f9d1‍🎓 Students View";
            lblTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // ViewStudents
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1519, 669);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewStudents";
            Text = "ViewStudents";
            Load += ViewStudents_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVStudent).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel5;
        private Label lblTitle;
        private Label lblDept;
        private Button btnDashboard;
        private DataGridView DGVStudent;
        private ComboBox cmbDept;
        private Button btnLogout;
        private Button btnSetting;
        private Button btnStudent;
        private Button btnDelete;
        private Button btnUppdate;
    }
}