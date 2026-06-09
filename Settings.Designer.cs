namespace College_Management_System
{
    partial class Settings
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnDashboard = new Button();
            panel2 = new Panel();
            groupBox2 = new GroupBox();
            btnR = new Button();
            btnBackup = new Button();
            groupBox1 = new GroupBox();
            btnCP = new Button();
            txtConfirmPassword = new TextBox();
            txtNewPassword = new TextBox();
            txtOldPassword = new TextBox();
            lblCPass = new Label();
            lblNewPass = new Label();
            lblOldPass = new Label();
            panel3 = new Panel();
            lblHeaderTlt = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(82, 121, 111);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1393, 54);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.closeIcon;
            pictureBox1.Location = new Point(1338, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(132, 169, 140);
            flowLayoutPanel1.Controls.Add(btnDashboard);
            flowLayoutPanel1.Location = new Point(0, 53);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(185, 551);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(224, 224, 224);
            btnDashboard.Cursor = Cursors.Hand;
            btnDashboard.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.Location = new Point(3, 3);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(175, 55);
            btnDashboard.TabIndex = 12;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(202, 210, 197);
            panel2.Controls.Add(groupBox2);
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(184, 54);
            panel2.Name = "panel2";
            panel2.Size = new Size(1206, 550);
            panel2.TabIndex = 3;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnR);
            groupBox2.Controls.Add(btnBackup);
            groupBox2.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(455, 83);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(739, 230);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "💾 DATABASE MANAGEMENT";
            // 
            // btnR
            // 
            btnR.BackColor = Color.Silver;
            btnR.Cursor = Cursors.Hand;
            btnR.Location = new Point(448, 70);
            btnR.Name = "btnR";
            btnR.Size = new Size(165, 72);
            btnR.TabIndex = 12;
            btnR.Text = "Restore Database";
            btnR.UseVisualStyleBackColor = false;
            btnR.Click += btnR_Click;
            // 
            // btnBackup
            // 
            btnBackup.BackColor = Color.Silver;
            btnBackup.Cursor = Cursors.Hand;
            btnBackup.Location = new Point(108, 70);
            btnBackup.Name = "btnBackup";
            btnBackup.Size = new Size(165, 72);
            btnBackup.TabIndex = 11;
            btnBackup.Text = "Back up Database";
            btnBackup.UseVisualStyleBackColor = false;
            btnBackup.Click += btnBackup_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCP);
            groupBox1.Controls.Add(txtConfirmPassword);
            groupBox1.Controls.Add(txtNewPassword);
            groupBox1.Controls.Add(txtOldPassword);
            groupBox1.Controls.Add(lblCPass);
            groupBox1.Controls.Add(lblNewPass);
            groupBox1.Controls.Add(lblOldPass);
            groupBox1.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(7, 83);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(413, 435);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "🔐 SECURITY";
            // 
            // btnCP
            // 
            btnCP.BackColor = Color.Silver;
            btnCP.Cursor = Cursors.Hand;
            btnCP.Location = new Point(139, 269);
            btnCP.Name = "btnCP";
            btnCP.Size = new Size(165, 72);
            btnCP.TabIndex = 10;
            btnCP.Text = "Change Password";
            btnCP.UseVisualStyleBackColor = false;
            btnCP.Click += btnCP_Click;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BackColor = Color.Silver;
            txtConfirmPassword.Location = new Point(193, 204);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(205, 31);
            txtConfirmPassword.TabIndex = 9;
            // 
            // txtNewPassword
            // 
            txtNewPassword.BackColor = Color.Silver;
            txtNewPassword.Location = new Point(177, 128);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(221, 31);
            txtNewPassword.TabIndex = 8;
            // 
            // txtOldPassword
            // 
            txtOldPassword.BackColor = Color.Silver;
            txtOldPassword.Location = new Point(177, 46);
            txtOldPassword.Name = "txtOldPassword";
            txtOldPassword.Size = new Size(221, 31);
            txtOldPassword.TabIndex = 7;
            // 
            // lblCPass
            // 
            lblCPass.AutoSize = true;
            lblCPass.Location = new Point(0, 207);
            lblCPass.Name = "lblCPass";
            lblCPass.Size = new Size(187, 23);
            lblCPass.TabIndex = 6;
            lblCPass.Text = "Confirm Password :";
            // 
            // lblNewPass
            // 
            lblNewPass.AutoSize = true;
            lblNewPass.Location = new Point(6, 131);
            lblNewPass.Name = "lblNewPass";
            lblNewPass.Size = new Size(154, 23);
            lblNewPass.TabIndex = 5;
            lblNewPass.Text = "New Password :";
            // 
            // lblOldPass
            // 
            lblOldPass.AutoSize = true;
            lblOldPass.Location = new Point(6, 46);
            lblOldPass.Name = "lblOldPass";
            lblOldPass.Size = new Size(145, 23);
            lblOldPass.TabIndex = 4;
            lblOldPass.Text = "Old Password :";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(53, 79, 82);
            panel3.Controls.Add(lblHeaderTlt);
            panel3.Location = new Point(0, -1);
            panel3.Name = "panel3";
            panel3.Size = new Size(1209, 78);
            panel3.TabIndex = 0;
            // 
            // lblHeaderTlt
            // 
            lblHeaderTlt.AutoSize = true;
            lblHeaderTlt.Font = new Font("Cambria", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeaderTlt.ForeColor = Color.White;
            lblHeaderTlt.Location = new Point(534, 18);
            lblHeaderTlt.Name = "lblHeaderTlt";
            lblHeaderTlt.Size = new Size(223, 40);
            lblHeaderTlt.TabIndex = 0;
            lblHeaderTlt.Text = "⚙ SETTINGS ";
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1390, 600);
            Controls.Add(panel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Settings";
            Text = "Settings";
            Load += Settings_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnDashboard;
        private Panel panel2;
        private Panel panel3;
        private Label lblHeaderTlt;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Button btnCP;
        private TextBox txtConfirmPassword;
        private TextBox txtNewPassword;
        private TextBox txtOldPassword;
        private Label lblCPass;
        private Label lblNewPass;
        private Label lblOldPass;
        private Button btnR;
        private Button btnBackup;
    }
}