using College_Management_System.Database;
using College_Management_System.Helper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace College_Management_System
{
    public partial class IssueBooks : Form
    {
        private int studentID = 0;
        private int availableQty = 0;
        public IssueBooks()
        {
            InitializeComponent();
            LoadBooks();
            LoadCategories();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void SetDefaultDates()
        {
            dtIssueDate.Value = DateTime.Now;

            dtDueDate.Value =
                DateTime.Now.AddDays(15);
        }

        private void LoadCategories()
        {
            string qry =
                @"SELECT CategoryID,
                 CategoryName
                 FROM TblCategories
                 WHERE IsAct = 1";

            SqlDataAdapter da =
                new SqlDataAdapter(qry, DBConnection.con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            DataRow row = dt.NewRow();

            row["CategoryID"] = 0;
            row["CategoryName"] = "Select Category";

            dt.Rows.InsertAt(row, 0);

            cmbCategory.DataSource = dt;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryID";
        }

        private void LoadBooks()
        {
            string qry =
                @"SELECT BookID,
                 BookName
                 FROM TblBooks
                 WHERE IsAct = 1";

            SqlDataAdapter da =
                new SqlDataAdapter(
                    qry,
                    DBConnection.con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            DataRow row = dt.NewRow();

            row["BookID"] = 0;
            row["BookName"] = "Select Book";

            dt.Rows.InsertAt(row, 0);

            cmbBooks.DataSource = dt;
            cmbBooks.DisplayMember = "BookName";
            cmbBooks.ValueMember = "BookID";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string qry =
                @"SELECT
            S.StudentID,
            S.FullName,
            D.DepartmentName,
            SM.SemesterName
          FROM TblStudents S
          INNER JOIN TblDepartments D
          ON S.DepartmentID = D.DepartmentID
          INNER JOIN TblSemester SM
          ON S.SemesterID = SM.SemesterID
          WHERE S.EnrollmentNo=@EnrollmentNo";

                SqlCommand cmd =
                    new SqlCommand(
                        qry,
                        DBConnection.con);

                cmd.Parameters.AddWithValue(
                    "@EnrollmentNo",
                    txtEnrollment.Text);

                DBConnection.con.Open();

                SqlDataReader dr =
                    cmd.ExecuteReader();

                if (dr.Read())
                {
                    studentID =
                        Convert.ToInt32(
                            dr["StudentID"]);

                    txtStudentName.Text =
                        dr["FullName"].ToString();

                    txtDepartment.Text =
                        dr["DepartmentName"].ToString();

                    txtSemester.Text =
                        dr["SemesterName"].ToString();
                }
                else
                {
                    MessageBox.Show(
                        "Student Not Found");
                }

                dr.Close();

                DBConnection.con.Close();
            }
            catch (Exception ex)
            {
                DBConnection.con.Close();

                MessageBox.Show(ex.Message);
            }
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbBooks.SelectedValue == null)
                    return;

                if (cmbBooks.SelectedValue is DataRowView)
                    return;

                string qry = @"
        SELECT
            AuthorName,
            RackNumber,
            Quantity
        FROM TblBooks
        WHERE BookID = @BookID";

                SqlCommand cmd =
                    new SqlCommand(
                        qry,
                        DBConnection.con);

                cmd.Parameters.AddWithValue(
                    "@BookID",
                    Convert.ToInt32(
                        cmbBooks.SelectedValue));

                DBConnection.con.Open();

                SqlDataReader dr =
                    cmd.ExecuteReader();

                if (dr.Read())
                {
                    txtAuthor.Text =
                        dr["AuthorName"].ToString();

                    txtRack.Text =
                        dr["RackNumber"].ToString();

                    availableQty =
                        Convert.ToInt32(
                            dr["Quantity"]);

                    lblAvailableCopies.Text =
                        "Available : " +
                        availableQty;
                }

                dr.Close();

                DBConnection.con.Close();
            }
            catch (Exception ex)
            {
                if (DBConnection.con.State ==
                    ConnectionState.Open)
                {
                    DBConnection.con.Close();
                }

                MessageBox.Show(ex.Message);
            }
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            try
            {
                if (studentID == 0)
                {
                    MessageBox.Show(
                        "Search Student First");

                    return;
                }

                if (availableQty <= 0)
                {
                    MessageBox.Show(
                        "Book Out Of Stock");

                    return;
                }

                DBConnection.con.Open();

                string checkQry = @"
                SELECT COUNT(*)
                FROM TblIssueBooks
                WHERE StudentID = @StudentID
                AND BookID = @BookID
                AND Status = 'Issued'";

                SqlCommand checkCmd = new SqlCommand(checkQry, DBConnection.con);

                checkCmd.Parameters.AddWithValue("@StudentID", studentID);

                checkCmd.Parameters.AddWithValue("@BookID", cmbBooks.SelectedValue);

                int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                if (count > 0)
                {
                    MessageBox.Show(
                        "This book is already issued to this student.");

                    return;
                }

                string issueQry = @"
                INSERT INTO TblIssueBooks
                (
                    StudentID,
                    BookID,
                    IssueDate,
                    DueDate,
                    Status
                )
                VALUES
                (
                    @StudentID,
                    @BookID,
                    @IssueDate,
                    @DueDate,
                    'Issued'
                )";

                SqlCommand issueCmd = new SqlCommand(issueQry, DBConnection.con);

                issueCmd.Parameters.AddWithValue("@StudentID", studentID);

                issueCmd.Parameters.AddWithValue("@BookID", cmbBooks.SelectedValue);

                issueCmd.Parameters.AddWithValue("@IssueDate", dtIssueDate.Value.Date);

                issueCmd.Parameters.AddWithValue("@DueDate", dtDueDate.Value.Date);

                issueCmd.ExecuteNonQuery();

                string updateQry = @"
                    UPDATE TblBooks
                    SET Quantity = Quantity - 1
                    WHERE BookID = @BookID";

                SqlCommand updateCmd = new SqlCommand(updateQry, DBConnection.con);

                updateCmd.Parameters.AddWithValue("@BookID", cmbBooks.SelectedValue);

                updateCmd.ExecuteNonQuery();

                DBConnection.con.Close();

                CustomMessageBox.Show("Book Issued Successfully", "Success", DialogType.Success);
                ClearForm();
            }
            catch (Exception ex)
            {
                DBConnection.con.Close();
                CustomMessageBox.Show(ex.Message, "Error", DialogType.Error);
            }
        }

        private void ClearForm()
        {
            txtEnrollment.Clear();
            txtStudentName.Clear();
            txtDepartment.Clear();
            txtSemester.Clear();

            txtAuthor.Clear();
            txtRack.Clear();

            lblAvailableCopies.Text = "Available Books";

            cmbCategory.SelectedIndex = 0;
            cmbBooks.SelectedIndex = 0;

            studentID = 0;
            availableQty = 0;
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            Display display = new Display();
            display.Show();

            this.Close();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();

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

        private void cmbCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbCategory.SelectedValue == null)
                return;

            string qry =
            @"SELECT
            BookID,
            BookName
            FROM TblBooks
            WHERE CategoryID=@CategoryID
            AND IsAct=1";

            SqlDataAdapter da =
                new SqlDataAdapter(qry, DBConnection.con);

            da.SelectCommand.Parameters.AddWithValue("@CategoryID", cmbCategory.SelectedValue);

            DataTable dt =
                new DataTable();

            da.Fill(dt);

            cmbBooks.DataSource = dt;
            cmbBooks.DisplayMember = "BookName";
            cmbBooks.ValueMember = "BookID";
        }

        private void IssueBooks_Load(object sender, EventArgs e)
        {
            
        }
    }
}
