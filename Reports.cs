using ClosedXML.Excel;
using College_Management_System.Database;
using College_Management_System.Helper;
using Microsoft.Data.SqlClient;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;

namespace College_Management_System
{
    public partial class Reports : Form
    {
        private int currentRow = 0;
        public Reports()
        {
            InitializeComponent();
            QuestPDF.Settings.License =
            LicenseType.Community;
            LoadReportTypes();
            DesignGridView();
        }

        private void lblTo_Click(object sender, EventArgs e)
        {

        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            ExportExcel();
        }
        private void LoadReportTypes()
        {
            cmbReportType.Items.Clear();

            cmbReportType.Items.Add("Books");
            cmbReportType.Items.Add("Students");
            cmbReportType.Items.Add("Issued Books");
            cmbReportType.Items.Add("Returned Books");
            cmbReportType.Items.Add("Overdue Books");
            cmbReportType.Items.Add("Fine Collection");

            cmbReportType.SelectedIndex = 0;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            switch (cmbReportType.Text)
            {
                case "Books":
                    LoadBooksReport();
                    break;

                case "Students":
                    LoadStudentsReport();
                    break;

                case "Issued Books":
                    LoadIssuedBooksReport();
                    break;

                case "Returned Books":
                    LoadReturnedBooksReport();
                    break;

                case "Overdue Books":
                    LoadOverdueBooksReport();
                    break;

                case "Fine Collection":
                    LoadFineReport();
                    break;
            }
        }

        private void LoadBooksReport()
        {
            try
            {
                string qry = @"
                    SELECT
                        BookName,
                        ISBN,
                        AuthorName,
                        Quantity,
                        RackNumber,
                        AvailabilityStatus
                    FROM TblBooks
                    WHERE IsAct = 1";

                SqlDataAdapter da = new SqlDataAdapter(qry, DBConnection.con);

                DataTable dt = new DataTable();

                da.Fill(dt);

                DVGReports.DataSource = dt;
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(
                    ex.Message,
                    "Error",
                    DialogType.Error);
            }
        }

        private void LoadStudentsReport()
        {
            try
            {
                string qry = @"
                SELECT
                    EnrollmentNo,
                    FullName,
                    Email,
                    ContactNo,
                    StudentStatus
                FROM TblStudents
                WHERE IsAct = 1";

                SqlDataAdapter da = new SqlDataAdapter(qry, DBConnection.con);

                DataTable dt = new DataTable();

                da.Fill(dt);

                DVGReports.DataSource = dt;
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(
                    ex.Message,
                    "Error",
                    DialogType.Error);
            }
        }

        private void LoadReturnedBooksReport()
        {
            try
            {
                string qry = @"
                SELECT
                    S.FullName,
                    S.EnrollmentNo,
                    B.BookName,
                    IB.IssueDate,
                    IB.ReturnDate
                FROM TblIssueBooks IB
                INNER JOIN TblStudents S
                ON IB.StudentID = S.StudentID
                INNER JOIN TblBooks B
                ON IB.BookID = B.BookID
                WHERE IB.Status = 'Returned'";

                SqlDataAdapter da = new SqlDataAdapter(qry, DBConnection.con);

                DataTable dt = new DataTable();

                da.Fill(dt);

                DVGReports.DataSource = dt;
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(
                    ex.Message,
                    "Error",
                    DialogType.Error);
            }
        }

        private void LoadOverdueBooksReport()
        {
            try
            {
                string qry = @"
                SELECT
                    S.FullName,
                    S.EnrollmentNo,
                    B.BookName,
                    IB.DueDate
                FROM TblIssueBooks IB
                INNER JOIN TblStudents S
                ON IB.StudentID = S.StudentID
                INNER JOIN TblBooks B
                ON IB.BookID = B.BookID
                WHERE
                IB.Status = 'Issued'
                AND IB.DueDate < GETDATE()";

                SqlDataAdapter da = new SqlDataAdapter(qry, DBConnection.con);

                DataTable dt = new DataTable();

                da.Fill(dt);

                DVGReports.DataSource = dt;
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(
                    ex.Message,
                    "Error",
                    DialogType.Error);
            }
        }

        private void LoadFineReport()
        {
            try
            {
                string qry = @"
                SELECT
                    S.FullName,
                    B.BookName,
                    IB.FineAmount,
                    IB.ReturnDate
                FROM TblIssueBooks IB
                INNER JOIN TblStudents S
                ON IB.StudentID = S.StudentID
                INNER JOIN TblBooks B
                ON IB.BookID = B.BookID
                WHERE IB.FineAmount > 0";

                SqlDataAdapter da = new SqlDataAdapter(qry, DBConnection.con);

                DataTable dt = new DataTable();

                da.Fill(dt);

                DVGReports.DataSource = dt;
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(
                    ex.Message,
                    "Error",
                    DialogType.Error);
            }
        }

        private void LoadIssuedBooksReport()
        {
            try
            {
                string qry = @"
                SELECT
                    S.FullName,
                    S.EnrollmentNo,
                    B.BookName,
                    IB.IssueDate,
                    IB.DueDate
                FROM TblIssueBooks IB
                INNER JOIN TblStudents S
                ON IB.StudentID = S.StudentID
                INNER JOIN TblBooks B
                ON IB.BookID = B.BookID
                WHERE IB.Status = 'Issued'";

                SqlDataAdapter da = new SqlDataAdapter(qry, DBConnection.con);

                DataTable dt = new DataTable();

                da.Fill(dt);

                DVGReports.DataSource = dt;
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(
                    ex.Message,
                    "Error",
                    DialogType.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DesignGridView()
        {
            DVGReports.BorderStyle = BorderStyle.None;

            DVGReports.BackgroundColor =
                System.Drawing.Color.White;

            DVGReports.RowHeadersVisible = false;

            DVGReports.AllowUserToAddRows = false;

            DVGReports.AllowUserToResizeRows = false;

            DVGReports.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            DVGReports.MultiSelect = false;

            DVGReports.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            DVGReports.EnableHeadersVisualStyles = false;

            DVGReports.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.None;

            DVGReports.ColumnHeadersHeight = 45;

            DVGReports.ColumnHeadersDefaultCellStyle.BackColor =
               System.Drawing.Color.FromArgb(47, 79, 79);

            DVGReports.ColumnHeadersDefaultCellStyle.ForeColor =
                System.Drawing.Color.White;

            DVGReports.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 11, FontStyle.Bold);

            DVGReports.DefaultCellStyle.Font =
                new Font("Segoe UI", 10);

            DVGReports.DefaultCellStyle.BackColor =
                System.Drawing.Color.White;

            DVGReports.DefaultCellStyle.ForeColor =
                System.Drawing.Color.Black;

            DVGReports.DefaultCellStyle.SelectionBackColor =
                System.Drawing.Color.FromArgb(52, 152, 219);

            DVGReports.DefaultCellStyle.SelectionForeColor =
                System.Drawing.Color.White;

            DVGReports.AlternatingRowsDefaultCellStyle.BackColor =
                System.Drawing.Color.FromArgb(240, 240, 240);

            DVGReports.CellBorderStyle =
                DataGridViewCellBorderStyle.SingleHorizontal;

            DVGReports.GridColor =
                System.Drawing.Color.Gainsboro;

            DVGReports.RowTemplate.Height = 35;
        }

        private void ExportPDF()
        {
            if (DVGReports.Rows.Count == 0)
            {
                MessageBox.Show(
                    "No data available.");

                return;
            }

            SaveFileDialog sfd =
                new SaveFileDialog();

            sfd.Filter =
                "PDF Files (*.pdf)|*.pdf";

            sfd.FileName =
                cmbReportType.Text +
                "_Report.pdf";

            if (sfd.ShowDialog()
                != DialogResult.OK)
                return;

            string reportTitle =
                cmbReportType.Text +
                " Report";

            string filePath =
                sfd.FileName;

            string generatedOn =
                DateTime.Now.ToString(
                    "dd-MMM-yyyy hh:mm tt");

            string fromDate =
                dtFrom.Value.ToString(
                    "dd-MMM-yyyy");

            string toDate =
                dtTo.Value.ToString(
                    "dd-MMM-yyyy");

            int totalRecords =
                DVGReports.Rows.Count;

            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4.Landscape());

                    page.Margin(20);

                    page.Header()
                        .Column(column =>
                        {
                            column.Item()
                                .AlignCenter()
                                .Text(
                                "ABC COLLEGE LIBRARY")
                                .FontSize(22)
                                .Bold();

                            column.Item()
                                .AlignCenter()
                                .Text(
                                "Library Management System")
                                .FontSize(12);

                            column.Item()
                                .PaddingTop(10)
                                .AlignCenter()
                                .Text(reportTitle)
                                .FontSize(18)
                                .Bold();
                        });

                    page.Content()
                        .Column(column =>
                        {
                            column.Item()
                                .PaddingBottom(10)
                                .Text(
                                $"Date Range : {fromDate} To {toDate}");

                            column.Item()
                                .Text(
                                $"Generated On : {generatedOn}");

                            column.Item()
                                .PaddingTop(15);

                            column.Item()
                                .Table(table =>
                                {
                                    int columnCount =
                                        DVGReports.Columns.Count;

                                    table.ColumnsDefinition(columns =>
                                    {
                                        for (int i = 0;
                                             i < columnCount;
                                             i++)
                                        {
                                            columns.RelativeColumn();
                                        }
                                    });

                                    table.Header(header =>
                                    {
                                        foreach (DataGridViewColumn col
                                                 in DVGReports.Columns)
                                        {
                                            header.Cell()
                                                .Background(
                                                Colors.BlueGrey.Darken2)
                                                .Padding(5)
                                                .Text(
                                                col.HeaderText)
                                                .FontColor(
                                                Colors.White)
                                                .Bold();
                                        }
                                    });

                                    foreach (DataGridViewRow row
                                             in DVGReports.Rows)
                                    {
                                        if (row.IsNewRow)
                                            continue;

                                        foreach (DataGridViewCell cell
                                                 in row.Cells)
                                        {
                                            table.Cell()
                                                .Border(1)
                                                .BorderColor(
                                                Colors.Grey.Lighten2)
                                                .Padding(5)
                                                .Text(
                                                cell.Value?
                                                .ToString()
                                                ?? "");
                                        }
                                    }
                                });
                        });

                    page.Footer()
                        .Row(row =>
                        {
                            row.RelativeItem()
                                .Text(
                                $"Total Records : {totalRecords}");

                            row.RelativeItem()
                                .AlignRight()
                                .Text(text =>
                                {
                                    text.Span("Page ");

                                    text.CurrentPageNumber();

                                    text.Span(" of ");

                                    text.TotalPages();
                                });
                        });
                });
            })
            .GeneratePdf(filePath);

            MessageBox.Show(
                "PDF Exported Successfully.");
        }

        private void ExportExcel()
        {
            if (DVGReports.Rows.Count == 0)
            {
                MessageBox.Show(
                    "No data available.");

                return;
            }

            SaveFileDialog sfd =
                new SaveFileDialog();

            sfd.Filter =
                "Excel Workbook (*.xlsx)|*.xlsx";

            sfd.FileName =
                cmbReportType.Text +
                "_Report.xlsx";

            if (sfd.ShowDialog()
                != DialogResult.OK)
                return;

            using (XLWorkbook wb =
                   new XLWorkbook())
            {
                var ws =
                    wb.Worksheets.Add(
                    "Report");

                // Title
                ws.Cell(1, 1).Value =
                    "ABC COLLEGE LIBRARY";

                ws.Range(1, 1, 1, 8)
                    .Merge();

                ws.Cell(1, 1)
                    .Style.Font.Bold = true;

                ws.Cell(1, 1)
                    .Style.Font.FontSize = 18;

                ws.Cell(2, 1).Value =
                    cmbReportType.Text +
                    " Report";

                ws.Range(2, 1, 2, 8)
                    .Merge();

                ws.Cell(2, 1)
                    .Style.Font.Bold = true;

                // Date Range
                ws.Cell(4, 1).Value =
                    "From";

                ws.Cell(4, 2).Value =
                    dtFrom.Value
                    .ToString("dd-MMM-yyyy");

                ws.Cell(4, 3).Value =
                    "To";

                ws.Cell(4, 4).Value =
                    dtTo.Value
                    .ToString("dd-MMM-yyyy");

                int startRow = 6;

                // Headers
                for (int i = 0;
                     i < DVGReports.Columns.Count;
                     i++)
                {
                    ws.Cell(
                        startRow,
                        i + 1)
                        .Value =
                        DVGReports
                        .Columns[i]
                        .HeaderText;

                    ws.Cell(
                        startRow,
                        i + 1)
                        .Style.Font.Bold =
                        true;
                }

                // Data
                for (int i = 0;
                     i < DVGReports.Rows.Count;
                     i++)
                {
                    for (int j = 0;
                         j < DVGReports.Columns.Count;
                         j++)
                    {
                        ws.Cell(
                            i + startRow + 1,
                            j + 1)
                            .Value =
                            DVGReports
                            .Rows[i]
                            .Cells[j]
                            .Value?
                            .ToString();
                    }
                }

                ws.Columns()
                    .AdjustToContents();

                wb.SaveAs(
                    sfd.FileName);
            }

            MessageBox.Show(
                "Excel Exported Successfully.");
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            currentRow = 0;

            printPreviewDialog1.Document =
                printDocument1;

            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font headerFont =
        new Font("Segoe UI", 14,
        FontStyle.Bold);

            Font bodyFont =
                new Font("Segoe UI", 10);

            int y = 50;

            e.Graphics.DrawString(
                "ABC COLLEGE LIBRARY",
                headerFont,
                Brushes.Black,
                300,
                y);

            y += 40;

            e.Graphics.DrawString(
                cmbReportType.Text +
                " Report",
                bodyFont,
                Brushes.Black,
                330,
                y);

            y += 40;

            // Headers
            int x = 50;

            foreach (DataGridViewColumn col
                    in DVGReports.Columns)
            {
                e.Graphics.DrawString(
                    col.HeaderText,
                    bodyFont,
                    Brushes.Black,
                    x,
                    y);

                x += 120;
            }

            y += 30;

            while (currentRow <
                  DVGReports.Rows.Count)
            {
                x = 50;

                DataGridViewRow row =
                    DVGReports.Rows[
                    currentRow];

                if (row.IsNewRow)
                {
                    currentRow++;
                    continue;
                }

                foreach (DataGridViewCell cell
                        in row.Cells)
                {
                    e.Graphics.DrawString(
                        cell.Value?
                        .ToString() ?? "",
                        bodyFont,
                        Brushes.Black,
                        x,
                        y);

                    x += 120;
                }

                y += 25;

                currentRow++;

                if (y > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }
            }

            e.HasMorePages = false;
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            ExportPDF();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
           
        }
    }
}
