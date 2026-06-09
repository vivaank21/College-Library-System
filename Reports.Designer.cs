namespace College_Management_System
{
    partial class Reports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reports));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnDashboard = new Button();
            panel2 = new Panel();
            DVGReports = new DataGridView();
            lblTo = new Label();
            dtTo = new DateTimePicker();
            lblFrom = new Label();
            dtFrom = new DateTimePicker();
            btnPrint = new Button();
            btnExcel = new Button();
            btnPDF = new Button();
            btnGenerate = new Button();
            cmbReportType = new ComboBox();
            lblCategory = new Label();
            panel3 = new Panel();
            lblHeaderTlt = new Label();
            printDialog1 = new PrintDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DVGReports).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(82, 121, 111);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1213, 51);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.closeIcon;
            pictureBox1.Location = new Point(1162, 3);
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
            flowLayoutPanel1.Location = new Point(0, 48);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(189, 617);
            flowLayoutPanel1.TabIndex = 1;
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
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(202, 210, 197);
            panel2.Controls.Add(DVGReports);
            panel2.Controls.Add(lblTo);
            panel2.Controls.Add(dtTo);
            panel2.Controls.Add(lblFrom);
            panel2.Controls.Add(dtFrom);
            panel2.Controls.Add(btnPrint);
            panel2.Controls.Add(btnExcel);
            panel2.Controls.Add(btnPDF);
            panel2.Controls.Add(btnGenerate);
            panel2.Controls.Add(cmbReportType);
            panel2.Controls.Add(lblCategory);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(184, 48);
            panel2.Name = "panel2";
            panel2.Size = new Size(1029, 620);
            panel2.TabIndex = 2;
            // 
            // DVGReports
            // 
            DVGReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DVGReports.Location = new Point(0, 322);
            DVGReports.Name = "DVGReports";
            DVGReports.RowHeadersWidth = 51;
            DVGReports.Size = new Size(1029, 295);
            DVGReports.TabIndex = 11;
            // 
            // lblTo
            // 
            lblTo.AutoSize = true;
            lblTo.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTo.Location = new Point(589, 176);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(49, 27);
            lblTo.TabIndex = 10;
            lblTo.Text = "To :";
            lblTo.Click += lblTo_Click;
            // 
            // dtTo
            // 
            dtTo.Location = new Point(646, 176);
            dtTo.Name = "dtTo";
            dtTo.Size = new Size(250, 27);
            dtTo.TabIndex = 9;
            // 
            // lblFrom
            // 
            lblFrom.AutoSize = true;
            lblFrom.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFrom.Location = new Point(165, 175);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(80, 27);
            lblFrom.TabIndex = 8;
            lblFrom.Text = "From :";
            // 
            // dtFrom
            // 
            dtFrom.Location = new Point(251, 176);
            dtFrom.Name = "dtFrom";
            dtFrom.Size = new Size(250, 27);
            dtFrom.TabIndex = 7;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.FromArgb(224, 224, 224);
            btnPrint.Cursor = Cursors.Hand;
            btnPrint.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrint.Location = new Point(839, 264);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(149, 52);
            btnPrint.TabIndex = 6;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // btnExcel
            // 
            btnExcel.BackColor = Color.FromArgb(224, 224, 224);
            btnExcel.Cursor = Cursors.Hand;
            btnExcel.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcel.Location = new Point(589, 264);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(164, 52);
            btnExcel.TabIndex = 5;
            btnExcel.Text = "Export Excel";
            btnExcel.UseVisualStyleBackColor = false;
            btnExcel.Click += btnExcel_Click;
            // 
            // btnPDF
            // 
            btnPDF.BackColor = Color.FromArgb(224, 224, 224);
            btnPDF.Cursor = Cursors.Hand;
            btnPDF.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPDF.Location = new Point(352, 264);
            btnPDF.Name = "btnPDF";
            btnPDF.Size = new Size(149, 52);
            btnPDF.TabIndex = 4;
            btnPDF.Text = "Export PDF";
            btnPDF.UseVisualStyleBackColor = false;
            btnPDF.Click += btnPDF_Click;
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = Color.FromArgb(224, 224, 224);
            btnGenerate.Cursor = Cursors.Hand;
            btnGenerate.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerate.Location = new Point(83, 264);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(149, 52);
            btnGenerate.TabIndex = 3;
            btnGenerate.Text = "Generate ";
            btnGenerate.UseVisualStyleBackColor = false;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // cmbReportType
            // 
            cmbReportType.BackColor = Color.Silver;
            cmbReportType.FormattingEnabled = true;
            cmbReportType.Location = new Point(251, 118);
            cmbReportType.Name = "cmbReportType";
            cmbReportType.Size = new Size(345, 28);
            cmbReportType.TabIndex = 2;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategory.Location = new Point(92, 119);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(153, 27);
            lblCategory.TabIndex = 1;
            lblCategory.Text = "Report Type :";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(53, 79, 82);
            panel3.Controls.Add(lblHeaderTlt);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1029, 77);
            panel3.TabIndex = 0;
            // 
            // lblHeaderTlt
            // 
            lblHeaderTlt.AutoSize = true;
            lblHeaderTlt.Font = new Font("Cambria", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeaderTlt.ForeColor = Color.White;
            lblHeaderTlt.Location = new Point(372, 18);
            lblHeaderTlt.Name = "lblHeaderTlt";
            lblHeaderTlt.Size = new Size(287, 40);
            lblHeaderTlt.TabIndex = 0;
            lblHeaderTlt.Text = " REPORT CENTER";
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // Reports
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1211, 664);
            Controls.Add(panel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Reports";
            Text = "Reports";
            Load += Reports_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DVGReports).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel2;
        private Panel panel3;
        private Label lblHeaderTlt;
        private ComboBox cmbReportType;
        private Label lblCategory;
        private DateTimePicker dtFrom;
        private Button btnPrint;
        private Button btnExcel;
        private Button btnPDF;
        private Button btnGenerate;
        private Label lblFrom;
        private Label lblTo;
        private DateTimePicker dtTo;
        private DataGridView DVGReports;
        private Button btnDashboard;
        private PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
    }
}