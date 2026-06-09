namespace College_Management_System
{
    partial class Books
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
            button2 = new Button();
            btnLogout = new Button();
            btnSettings = new Button();
            btnReports = new Button();
            btnReturnBook = new Button();
            button1 = new Button();
            btnStudent = new Button();
            panel4 = new Panel();
            button4 = new Button();
            button3 = new Button();
            panel3 = new Panel();
            label1 = new Label();
            cbCategory = new ComboBox();
            btnUploadImage = new Button();
            picImg = new PictureBox();
            txtRack = new TextBox();
            txtQty = new TextBox();
            txtAuthor = new TextBox();
            txtISBN = new TextBox();
            txtBName = new TextBox();
            lblRack = new Label();
            lblQty = new Label();
            lblCategory = new Label();
            lblAuthor = new Label();
            lblISBN = new Label();
            lblBookname = new Label();
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
            panel1.Name = "panel1";
            panel1.Size = new Size(1245, 49);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.closeIcon;
            pictureBox1.Location = new Point(1194, 0);
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
            panel2.Controls.Add(button2);
            panel2.Controls.Add(btnLogout);
            panel2.Controls.Add(btnSettings);
            panel2.Controls.Add(btnReports);
            panel2.Controls.Add(btnReturnBook);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(btnStudent);
            panel2.Location = new Point(0, 47);
            panel2.Name = "panel2";
            panel2.Size = new Size(217, 635);
            panel2.TabIndex = 1;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(224, 224, 224);
            button2.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(7, 139);
            button2.Name = "button2";
            button2.Size = new Size(202, 65);
            button2.TabIndex = 8;
            button2.Text = "View Books";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
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
            // 
            // btnStudent
            // 
            btnStudent.BackColor = Color.FromArgb(224, 224, 224);
            btnStudent.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStudent.Location = new Point(7, 54);
            btnStudent.Name = "btnStudent";
            btnStudent.Size = new Size(202, 67);
            btnStudent.TabIndex = 2;
            btnStudent.Text = "Students";
            btnStudent.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(202, 210, 197);
            panel4.Controls.Add(button4);
            panel4.Controls.Add(button3);
            panel4.Controls.Add(panel3);
            panel4.Controls.Add(cbCategory);
            panel4.Controls.Add(btnUploadImage);
            panel4.Controls.Add(picImg);
            panel4.Controls.Add(txtRack);
            panel4.Controls.Add(txtQty);
            panel4.Controls.Add(txtAuthor);
            panel4.Controls.Add(txtISBN);
            panel4.Controls.Add(txtBName);
            panel4.Controls.Add(lblRack);
            panel4.Controls.Add(lblQty);
            panel4.Controls.Add(lblCategory);
            panel4.Controls.Add(lblAuthor);
            panel4.Controls.Add(lblISBN);
            panel4.Controls.Add(lblBookname);
            panel4.Location = new Point(215, 47);
            panel4.Name = "panel4";
            panel4.Size = new Size(1030, 638);
            panel4.TabIndex = 3;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(224, 224, 224);
            button4.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(318, 525);
            button4.Name = "button4";
            button4.Size = new Size(177, 86);
            button4.TabIndex = 24;
            button4.Text = "Update Book";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(224, 224, 224);
            button3.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(28, 528);
            button3.Name = "button3";
            button3.Size = new Size(159, 83);
            button3.TabIndex = 23;
            button3.Text = "Add Books";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(53, 79, 82);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1030, 74);
            panel3.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(294, 11);
            label1.Name = "label1";
            label1.Size = new Size(479, 52);
            label1.TabIndex = 23;
            label1.Text = "📖 Books Management";
            // 
            // cbCategory
            // 
            cbCategory.BackColor = Color.Silver;
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(184, 286);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(311, 35);
            cbCategory.TabIndex = 21;
            cbCategory.Text = "Select Category";
            // 
            // btnUploadImage
            // 
            btnUploadImage.BackColor = Color.FromArgb(224, 224, 224);
            btnUploadImage.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUploadImage.Location = new Point(747, 307);
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
            picImg.Size = new Size(228, 186);
            picImg.SizeMode = PictureBoxSizeMode.StretchImage;
            picImg.TabIndex = 20;
            picImg.TabStop = false;
            // 
            // txtRack
            // 
            txtRack.BackColor = Color.Silver;
            txtRack.Location = new Point(184, 407);
            txtRack.Name = "txtRack";
            txtRack.Size = new Size(311, 34);
            txtRack.TabIndex = 19;
            // 
            // txtQty
            // 
            txtQty.BackColor = Color.Silver;
            txtQty.Location = new Point(184, 351);
            txtQty.Name = "txtQty";
            txtQty.Size = new Size(311, 34);
            txtQty.TabIndex = 18;
            // 
            // txtAuthor
            // 
            txtAuthor.BackColor = Color.Silver;
            txtAuthor.Location = new Point(184, 229);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(311, 34);
            txtAuthor.TabIndex = 17;
            // 
            // txtISBN
            // 
            txtISBN.BackColor = Color.Silver;
            txtISBN.Location = new Point(184, 171);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(311, 34);
            txtISBN.TabIndex = 16;
            // 
            // txtBName
            // 
            txtBName.BackColor = Color.Silver;
            txtBName.Location = new Point(184, 115);
            txtBName.Name = "txtBName";
            txtBName.Size = new Size(311, 34);
            txtBName.TabIndex = 15;
            // 
            // lblRack
            // 
            lblRack.AutoSize = true;
            lblRack.Location = new Point(57, 407);
            lblRack.Name = "lblRack";
            lblRack.Size = new Size(109, 27);
            lblRack.TabIndex = 14;
            lblRack.Text = "Rack No :";
            lblRack.Click += lblRack_Click;
            // 
            // lblQty
            // 
            lblQty.AutoSize = true;
            lblQty.Location = new Point(52, 354);
            lblQty.Name = "lblQty";
            lblQty.Size = new Size(114, 27);
            lblQty.TabIndex = 13;
            lblQty.Text = "Quantity :";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(50, 294);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(116, 27);
            lblCategory.TabIndex = 12;
            lblCategory.Text = "Category :";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Location = new Point(68, 236);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(98, 27);
            lblAuthor.TabIndex = 11;
            lblAuthor.Text = "Author :";
            lblAuthor.Click += lblAuthor_Click;
            // 
            // lblISBN
            // 
            lblISBN.AutoSize = true;
            lblISBN.Location = new Point(92, 174);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(74, 27);
            lblISBN.TabIndex = 10;
            lblISBN.Text = "ISBN :";
            // 
            // lblBookname
            // 
            lblBookname.AutoSize = true;
            lblBookname.Location = new Point(28, 118);
            lblBookname.Name = "lblBookname";
            lblBookname.Size = new Size(138, 27);
            lblBookname.TabIndex = 9;
            lblBookname.Text = "Book Name:";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Books
            // 
            AutoScaleDimensions = new SizeF(13F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1266, 690);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 4, 5, 4);
            Name = "Books";
            Text = "Books";
            Load += Books_Load;
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
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panel4;
        private Button btnStudent;
        private Button button1;
        private Button btnReturnBook;
        private Button btnReports;
        private Button btnSettings;
        private Button btnLogout;
        private Button button2;
        private Label lblAuthor;
        private Label lblISBN;
        private Label lblBookname;
        private Label lblCategory;
        private Label lblRack;
        private Label lblQty;
        private TextBox txtISBN;
        private TextBox txtBName;
        private Button btnUploadImage;
        private PictureBox picImg;
        private TextBox txtRack;
        private TextBox txtQty;
        private TextBox txtAuthor;
        private OpenFileDialog openFileDialog1;
        private Panel panel3;
        private ComboBox cbCategory;
        private Button button4;
        private Button button3;
        private Label label1;
    }
}