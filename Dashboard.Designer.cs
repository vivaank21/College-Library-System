namespace College_Management_System
{
    partial class Dashboard
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            panel5 = new Panel();
            label4 = new Label();
            label5 = new Label();
            pictureBox4 = new PictureBox();
            pictureBox1 = new PictureBox();
            lblTimer = new Label();
            lblDate = new Label();
            panel2 = new Panel();
            panel4 = new Panel();
            label2 = new Label();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            btnLogout = new Button();
            btnSettings = new Button();
            btnReports = new Button();
            btnReturnBook = new Button();
            button1 = new Button();
            btnStudent = new Button();
            btnBooks = new Button();
            panel3 = new Panel();
            panel6 = new Panel();
            label9 = new Label();
            label6 = new Label();
            label1 = new Label();
            label7 = new Label();
            label8 = new Label();
            pictureBox6 = new PictureBox();
            pictureBox2 = new PictureBox();
            lblQoute = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(82, 121, 111);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1302, 54);
            panel1.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Teal;
            panel5.Controls.Add(label4);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(pictureBox4);
            panel5.Location = new Point(247, 54);
            panel5.Name = "panel5";
            panel5.Size = new Size(1046, 66);
            panel5.TabIndex = 8;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label4.Cursor = Cursors.IBeam;
            label4.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(1790, -25);
            label4.Name = "label4";
            label4.Size = new Size(269, 31);
            label4.TabIndex = 6;
            label4.Text = "00 : 00 : 00";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label5.Cursor = Cursors.IBeam;
            label5.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(1471, -23);
            label5.Name = "label5";
            label5.Size = new Size(290, 29);
            label5.TabIndex = 7;
            label5.Text = "00 : 00 : 00";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox4
            // 
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox4.Image = Properties.Resources.closeIcon;
            pictureBox4.Location = new Point(1242, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(48, 48);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.closeIcon;
            pictureBox1.Location = new Point(1242, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lblTimer
            // 
            lblTimer.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblTimer.Cursor = Cursors.IBeam;
            lblTimer.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTimer.ForeColor = Color.White;
            lblTimer.Location = new Point(786, 31);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(269, 31);
            lblTimer.TabIndex = 6;
            lblTimer.Text = "00 : 00 : 00";
            lblTimer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDate
            // 
            lblDate.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblDate.Cursor = Cursors.IBeam;
            lblDate.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDate.ForeColor = Color.White;
            lblDate.Location = new Point(449, 29);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(312, 33);
            lblDate.TabIndex = 7;
            lblDate.Text = "00 : 00 : 00";
            lblDate.TextAlign = ContentAlignment.MiddleCenter;
            lblDate.Click += lblDate_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(132, 169, 140);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(btnLogout);
            panel2.Controls.Add(btnSettings);
            panel2.Controls.Add(btnReports);
            panel2.Controls.Add(btnReturnBook);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(btnStudent);
            panel2.Controls.Add(btnBooks);
            panel2.Location = new Point(0, 54);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 686);
            panel2.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(82, 121, 111);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(pictureBox3);
            panel4.Location = new Point(244, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1058, 85);
            panel4.TabIndex = 8;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.Cursor = Cursors.IBeam;
            label2.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(1802, -6);
            label2.Name = "label2";
            label2.Size = new Size(269, 31);
            label2.TabIndex = 6;
            label2.Text = "00 : 00 : 00";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label3.Cursor = Cursors.IBeam;
            label3.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(1483, -4);
            label3.Name = "label3";
            label3.Size = new Size(290, 29);
            label3.TabIndex = 7;
            label3.Text = "00 : 00 : 00";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = Properties.Resources.closeIcon;
            pictureBox3.Location = new Point(1242, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(48, 48);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(224, 224, 224);
            btnLogout.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(12, 609);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(202, 65);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnSettings
            // 
            btnSettings.BackColor = Color.FromArgb(224, 224, 224);
            btnSettings.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSettings.Location = new Point(12, 513);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(202, 65);
            btnSettings.TabIndex = 4;
            btnSettings.Text = "Settings";
            btnSettings.UseVisualStyleBackColor = false;
            btnSettings.Click += btnSettings_Click;
            // 
            // btnReports
            // 
            btnReports.BackColor = Color.FromArgb(224, 224, 224);
            btnReports.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReports.Location = new Point(12, 423);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(202, 62);
            btnReports.TabIndex = 3;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = false;
            btnReports.Click += btnReports_Click;
            // 
            // btnReturnBook
            // 
            btnReturnBook.BackColor = Color.FromArgb(224, 224, 224);
            btnReturnBook.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReturnBook.Location = new Point(12, 331);
            btnReturnBook.Name = "btnReturnBook";
            btnReturnBook.Size = new Size(202, 65);
            btnReturnBook.TabIndex = 2;
            btnReturnBook.Text = "Return Books";
            btnReturnBook.UseVisualStyleBackColor = false;
            btnReturnBook.Click += btnReturnBook_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(224, 224, 224);
            button1.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 239);
            button1.Name = "button1";
            button1.Size = new Size(202, 64);
            button1.TabIndex = 1;
            button1.Text = "Issue Books";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnStudent
            // 
            btnStudent.BackColor = Color.FromArgb(224, 224, 224);
            btnStudent.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStudent.Location = new Point(12, 143);
            btnStudent.Name = "btnStudent";
            btnStudent.Size = new Size(202, 67);
            btnStudent.TabIndex = 1;
            btnStudent.Text = "Students";
            btnStudent.UseVisualStyleBackColor = false;
            btnStudent.Click += btnStudent_Click;
            // 
            // btnBooks
            // 
            btnBooks.BackColor = Color.FromArgb(224, 224, 224);
            btnBooks.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBooks.Location = new Point(12, 50);
            btnBooks.Name = "btnBooks";
            btnBooks.Size = new Size(202, 66);
            btnBooks.TabIndex = 0;
            btnBooks.Text = "Books";
            btnBooks.UseVisualStyleBackColor = false;
            btnBooks.Click += btnBooks_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(202, 210, 197);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(lblQoute);
            panel3.Location = new Point(244, 54);
            panel3.Name = "panel3";
            panel3.Size = new Size(1058, 686);
            panel3.TabIndex = 2;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(53, 79, 82);
            panel6.Controls.Add(label9);
            panel6.Controls.Add(label6);
            panel6.Controls.Add(label1);
            panel6.Controls.Add(label7);
            panel6.Controls.Add(lblTimer);
            panel6.Controls.Add(label8);
            panel6.Controls.Add(lblDate);
            panel6.Controls.Add(pictureBox6);
            panel6.Location = new Point(0, -11);
            panel6.Name = "panel6";
            panel6.Size = new Size(1061, 86);
            panel6.TabIndex = 5;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label9.Cursor = Cursors.IBeam;
            label9.Font = new Font("Cambria", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(12, 11);
            label9.Name = "label9";
            label9.Size = new Size(66, 62);
            label9.TabIndex = 10;
            label9.Text = "🕮";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label6.Cursor = Cursors.IBeam;
            label6.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(72, 54);
            label6.Name = "label6";
            label6.Size = new Size(407, 23);
            label6.TabIndex = 9;
            label6.Text = "Knowledge Today, Leadership Tomorrow";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            label6.Click += label6_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.Cursor = Cursors.IBeam;
            label1.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(72, 15);
            label1.Name = "label1";
            label1.Size = new Size(407, 33);
            label1.TabIndex = 8;
            label1.Text = "Library Management System";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label7.Cursor = Cursors.IBeam;
            label7.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(1805, -5);
            label7.Name = "label7";
            label7.Size = new Size(269, 31);
            label7.TabIndex = 6;
            label7.Text = "00 : 00 : 00";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label8.Cursor = Cursors.IBeam;
            label8.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(1486, -3);
            label8.Name = "label8";
            label8.Size = new Size(290, 29);
            label8.TabIndex = 7;
            label8.Text = "00 : 00 : 00";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox6
            // 
            pictureBox6.Cursor = Cursors.Hand;
            pictureBox6.Image = Properties.Resources.closeIcon;
            pictureBox6.Location = new Point(1242, 3);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(48, 48);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 3;
            pictureBox6.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.LB_MGNT;
            pictureBox2.Location = new Point(210, 170);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(848, 516);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // lblQoute
            // 
            lblQoute.Font = new Font("Cambria", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQoute.Location = new Point(187, 78);
            lblQoute.Name = "lblQoute";
            lblQoute.Size = new Size(871, 116);
            lblQoute.TabIndex = 0;
            lblQoute.Text = "📚 We don't just harvest stories here; we grow the minds that will write the next ones. 🌱";
            lblQoute.TextAlign = ContentAlignment.TopRight;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Tick += timer2_Tick;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1301, 740);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Button btnBooks;
        private Button button1;
        private Button btnStudent;
        private Button btnSettings;
        private Button btnReports;
        private Button btnReturnBook;
        private Button btnLogout;
        private Label lblQoute;
        private PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private Label lblTimer;
        private Label lblDate;
        private System.Windows.Forms.Timer timer2;
        private Panel panel5;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox4;
        private Panel panel4;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox3;
        private Panel panel6;
        private Label label7;
        private Label label8;
        private PictureBox pictureBox6;
        private Label label9;
        private Label label6;
        private Label label1;
    }
}