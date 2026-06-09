using College_Management_System.Database;
using College_Management_System.Helper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace College_Management_System
{
    public partial class Display : Form
    {
        private int issueID = 0;
        private int bookID = 0;
        public Display()
        {
            InitializeComponent();
            DesignGrid();
            LoadIssuedBooks();
            LoadStatus();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DesignGrid()
        {
            DGVIssuedBooks.BorderStyle = BorderStyle.None;

            DGVIssuedBooks.RowTemplate.Height = 35;

            DGVIssuedBooks.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            DGVIssuedBooks.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            DGVIssuedBooks.MultiSelect = false;

            DGVIssuedBooks.AllowUserToAddRows = false;

            DGVIssuedBooks.AllowUserToDeleteRows = false;

            DGVIssuedBooks.ReadOnly = true;

            DGVIssuedBooks.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);

            DGVIssuedBooks.DefaultCellStyle.Font =
                new Font("Segoe UI", 9);
        }

        private void LoadIssuedBooks()
        {
            try
            {
                string qry = @"
                    SELECT
                        IB.IssueID,
                        IB.BookID,
                        S.EnrollmentNo,
                        S.FullName,
                        B.BookName,
                        IB.IssueDate,
                        IB.DueDate,
                        IB.ReturnDate,
                        IB.FineAmount,
                        IB.Status
                    FROM TblIssueBooks IB
                    INNER JOIN TblStudents S
                    ON IB.StudentID = S.StudentID
                    INNER JOIN TblBooks B
                    ON IB.BookID = B.BookID
                    WHERE IB.IsAct = 1";

                SqlDataAdapter da = new SqlDataAdapter(qry, DBConnection.con);

                DataTable dt = new DataTable();

                da.Fill(dt);

                DGVIssuedBooks.DataSource = dt;
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(ex.Message, "Error", DialogType.Error);
            }
        }

        private void LoadStatus()
        {
            cmbStatus.Items.Clear();

            cmbStatus.Items.Add("All");
            cmbStatus.Items.Add("Issued");
            cmbStatus.Items.Add("Returned");
            cmbStatus.Items.Add("Overdue");

            cmbStatus.SelectedIndex = 0;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = @"
                    SELECT
                    IB.IssueID,
                    S.EnrollmentNo,
                    S.FullName,
                    B.BookName,
                    IB.IssueDate,
                    IB.DueDate,
                    IB.ReturnDate,
                    IB.FineAmount,
                    IB.Status
                    FROM TblIssueBooks IB
                    INNER JOIN TblStudents S
                    ON IB.StudentID = S.StudentID
                    INNER JOIN TblBooks B
                    ON IB.BookID = B.BookID
                    WHERE IB.IsAct = 1
                    AND S.EnrollmentNo LIKE @EnrollmentNo";

                SqlDataAdapter da = new SqlDataAdapter(qry, DBConnection.con);

                da.SelectCommand.Parameters.AddWithValue("@EnrollmentNo", "%" + txtEnrollment.Text.Trim() + "%");

                DataTable dt = new DataTable();

                da.Fill(dt);

                DGVIssuedBooks.DataSource = dt;
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(ex.Message, "Error", DialogType.Error);
            }
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbStatus.Text == "All")
                {
                    LoadIssuedBooks();
                    return;
                }

                string qry = @"
                    SELECT
                    IB.IssueID,
                    S.EnrollmentNo,
                    S.FullName,
                    B.BookName,
                    IB.IssueDate,
                    IB.DueDate,
                    IB.ReturnDate,
                    IB.FineAmount,
                    IB.Status
                    FROM TblIssueBooks IB
                    INNER JOIN TblStudents S
                    ON IB.StudentID = S.StudentID
                    INNER JOIN TblBooks B
                    ON IB.BookID = B.BookID
                    WHERE IB.IsAct = 1
                    AND IB.Status = @Status";

                SqlDataAdapter da = new SqlDataAdapter(qry, DBConnection.con);

                da.SelectCommand.Parameters.AddWithValue("@Status", cmbStatus.Text);

                DataTable dt = new DataTable();

                da.Fill(dt);

                DGVIssuedBooks.DataSource = dt;
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(ex.Message, "Error", DialogType.Error);
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            try
            {
                if (issueID == 0)
                {
                    MessageBox.Show(
                        "Select a book first.");

                    return;
                }

                DataGridViewRow row =
                    DGVIssuedBooks.SelectedRows[0];

                DateTime dueDate =
                    Convert.ToDateTime(
                        row.Cells["DueDate"].Value);

                int lateDays =
                    (DateTime.Now.Date -
                     dueDate.Date).Days;

                decimal fineAmount = 0;

                if (lateDays > 0)
                {
                    fineAmount =
                        lateDays * 5;
                }

                DBConnection.con.Open();



                string qry = @"
                    UPDATE TblIssueBooks
                    SET
                    Status='Returned',
                    ReturnDate=@ReturnDate,
                    FineAmount=@FineAmount
                    WHERE IssueID=@IssueID";

                SqlCommand cmd = new SqlCommand(qry, DBConnection.con);

                cmd.Parameters.AddWithValue("@ReturnDate", DateTime.Now.Date);

                cmd.Parameters.AddWithValue("@FineAmount", fineAmount);

                cmd.Parameters.AddWithValue("@IssueID", issueID);

                cmd.ExecuteNonQuery();

                // Increase Book Quantity

                string updateBookQry = @"
                    UPDATE TblBooks
                    SET Quantity = Quantity + 1
                    WHERE BookID = @BookID";

                SqlCommand bookCmd = new SqlCommand(updateBookQry, DBConnection.con);

                bookCmd.Parameters.AddWithValue("@BookID", bookID);

                bookCmd.ExecuteNonQuery();

                DBConnection.con.Close();

                if (fineAmount > 0)
                {
                    MessageBox.Show(
                        "Book Returned.\nFine: ₹" +
                        fineAmount);
                }
                else
                {
                    MessageBox.Show(
                        "Book Returned Successfully.");
                }

                LoadIssuedBooks();

                issueID = 0;
                bookID = 0;
            }
            catch (Exception ex)
            {
                DBConnection.con.Close();

                MessageBox.Show(ex.Message);
            }
        }

        private void DGVIssuedBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                issueID =
                    Convert.ToInt32(
                        DGVIssuedBooks.Rows[e.RowIndex]
                        .Cells["IssueID"].Value);

                bookID =
                    Convert.ToInt32(
                        DGVIssuedBooks.Rows[e.RowIndex]
                        .Cells["BookID"].Value);
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();

            this.Close();
        }

        private void btnIssueBooks_Click(object sender, EventArgs e)
        {
            IssueBooks issues = new IssueBooks();
            issues.Show();

            this.Close();
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            Students students = new Students();
            students.Show();
            this.Close();
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            Books books = new Books();
            books.Show();

            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();

            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Display_Load(object sender, EventArgs e)
        {
           
        }
    }
}
