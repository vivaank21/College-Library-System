namespace College_Management_System
{
    partial class ViewBooks
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
            panel3 = new Panel();
            btnAddBooks = new Button();
            btnDashboard = new Button();
            btnLogout = new Button();
            btnSettings = new Button();
            panel4 = new Panel();
            label1 = new Label();
            comboBox1 = new ComboBox();
            DGVBooks = new DataGridView();
            panel5 = new Panel();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVBooks).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(82, 121, 111);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1442, 57);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.closeIcon;
            pictureBox1.Location = new Point(1391, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(132, 169, 140);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(btnAddBooks);
            panel2.Controls.Add(btnDashboard);
            panel2.Controls.Add(btnLogout);
            panel2.Controls.Add(btnSettings);
            panel2.Location = new Point(0, 54);
            panel2.Name = "panel2";
            panel2.Size = new Size(231, 608);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(202, 210, 197);
            panel3.Location = new Point(237, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1202, 608);
            panel3.TabIndex = 10;
            // 
            // btnAddBooks
            // 
            btnAddBooks.BackColor = Color.FromArgb(224, 224, 224);
            btnAddBooks.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddBooks.Location = new Point(12, 42);
            btnAddBooks.Name = "btnAddBooks";
            btnAddBooks.Size = new Size(202, 65);
            btnAddBooks.TabIndex = 9;
            btnAddBooks.Text = "Add Books";
            btnAddBooks.UseVisualStyleBackColor = false;
            btnAddBooks.Click += btnAddBooks_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(224, 224, 224);
            btnDashboard.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.Location = new Point(12, 136);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(202, 65);
            btnDashboard.TabIndex = 8;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(224, 224, 224);
            btnLogout.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(12, 322);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(202, 65);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnSettings
            // 
            btnSettings.BackColor = Color.FromArgb(224, 224, 224);
            btnSettings.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSettings.Location = new Point(12, 229);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(202, 65);
            btnSettings.TabIndex = 6;
            btnSettings.Text = "Settings";
            btnSettings.UseVisualStyleBackColor = false;
            btnSettings.Click += btnSettings_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(202, 210, 197);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(comboBox1);
            panel4.Controls.Add(DGVBooks);
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(220, 54);
            panel4.Name = "panel4";
            panel4.Size = new Size(1222, 608);
            panel4.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(47, 106);
            label1.Name = "label1";
            label1.Size = new Size(229, 27);
            label1.TabIndex = 0;
            label1.Text = " Search by Category :";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(291, 103);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(418, 35);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // DGVBooks
            // 
            DGVBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVBooks.Location = new Point(0, 209);
            DGVBooks.Name = "DGVBooks";
            DGVBooks.RowHeadersWidth = 51;
            DGVBooks.Size = new Size(1222, 399);
            DGVBooks.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(53, 79, 82);
            panel5.Controls.Add(label2);
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(1222, 81);
            panel5.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(473, 11);
            label2.Name = "label2";
            label2.Size = new Size(316, 52);
            label2.TabIndex = 3;
            label2.Text = "📖 View Books";
            // 
            // ViewBooks
            // 
            AutoScaleDimensions = new SizeF(13F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1441, 661);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 4, 5, 4);
            Name = "ViewBooks";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewBooks";
            Load += ViewBooks_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVBooks).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button btnLogout;
        private Button btnSettings;
        private Button btnDashboard;
        private Button btnAddBooks;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Label label1;
        private ComboBox comboBox1;
        private DataGridView DGVBooks;
        private Label label2;
    }
}