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
    public partial class ViewStudents : Form
    {
        public ViewStudents()
        {
            InitializeComponent();
            DesignGridView();
            LoadStudents();
            DGVStudent.ClearSelection();
            LoadDepartments();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private void LoadStudents()
        {
            try
            {
                string qry = @"
                SELECT
                S.StudentID,
                S.FullName AS [Student Name],
                S.EnrollmentNo AS [Enrollment No],
                S.Email,
                S.ContactNo AS [Contact No],
                D.DepartmentName AS Department,
                SM.SemesterName AS Semester,
                S.StudentStatus AS Status
                FROM TblStudents S
                INNER JOIN TblDepartments D
                ON S.DepartmentID = D.DepartmentID
                INNER JOIN TblSemester SM
                ON S.SemesterID = SM.SemesterID
                WHERE S.IsAct = 1";

                SqlDataAdapter da =
                    new SqlDataAdapter(qry, DBConnection.con);

                DataTable dt = new DataTable();

                da.Fill(dt);

                DGVStudent.DataSource = dt;

                DGVStudent.Columns["StudentID"].Visible = false;
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(ex.Message, "Error", DialogType.Error);
            }
        }

        private void LoadDepartments()
        {
            try
            {
                string qry =
                    "SELECT DepartmentID, DepartmentName FROM TblDepartments WHERE IsAct = 1";

                SqlDataAdapter da =
                    new SqlDataAdapter(qry, DBConnection.con);

                DataTable dt = new DataTable();

                da.Fill(dt);

                DataRow row = dt.NewRow();

                row["DepartmentID"] = 0;
                row["DepartmentName"] = "All Departments";

                dt.Rows.InsertAt(row, 0);

                cmbDept.DataSource = dt;

                cmbDept.DisplayMember =
                    "DepartmentName";

                cmbDept.ValueMember =
                    "DepartmentID";
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(ex.Message, "Error", DialogType.Error);
            }
        }

        private void cmbDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbDept.SelectedValue == null)
                    return;

                int departmentID;

                if (!int.TryParse(
                    cmbDept.SelectedValue.ToString(),
                    out departmentID))
                {
                    return;
                }

                if (departmentID == 0)
                {
                    LoadStudents();
                    return;
                }

                string qry = @"
                SELECT
                S.StudentID,
                S.FullName,
                S.EnrollmentNo,
                S.Email,
                S.ContactNo,
                D.DepartmentName,
                SM.SemesterName,
                S.StudentStatus
                FROM TblStudents S
                INNER JOIN TblDepartments D
                ON S.DepartmentID = D.DepartmentID
                INNER JOIN TblSemester SM
                ON S.SemesterID = SM.SemesterID
                WHERE S.IsAct = 1
                AND S.DepartmentID = @DepartmentID";

                SqlDataAdapter da =
                    new SqlDataAdapter(qry, DBConnection.con);

                da.SelectCommand.Parameters.AddWithValue(
                    "@DepartmentID",
                    departmentID);

                DataTable dt = new DataTable();

                da.Fill(dt);

                DGVStudent.DataSource = dt;
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(ex.Message, "Error", DialogType.Error);
            }
        }

        private void DesignGridView()
        {
            DGVStudent.BorderStyle = BorderStyle.None;

            DGVStudent.BackgroundColor =
                Color.FromArgb(240, 240, 240);

            DGVStudent.EnableHeadersVisualStyles = false;

            DGVStudent.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.None;

            DGVStudent.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(44, 62, 80);

            DGVStudent.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            DGVStudent.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);

            DGVStudent.ColumnHeadersHeight = 40;

            DGVStudent.DefaultCellStyle.Font =
                new Font("Segoe UI", 10);

            DGVStudent.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(52, 152, 219);

            DGVStudent.DefaultCellStyle.SelectionForeColor =
                Color.White;

            DGVStudent.DefaultCellStyle.BackColor =
                Color.White;

            DGVStudent.DefaultCellStyle.ForeColor =
                Color.Black;

            DGVStudent.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(245, 245, 245);

            DGVStudent.RowTemplate.Height = 35;

            DGVStudent.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            DGVStudent.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            DGVStudent.MultiSelect = false;

            DGVStudent.ReadOnly = true;

            DGVStudent.RowHeadersVisible = false;

            DGVStudent.AllowUserToAddRows = false;

            DGVStudent.AllowUserToResizeRows = false;

            DGVStudent.GridColor =
                Color.LightGray;
        }

        private void btnUppdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGVStudent.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a student.");
                    return;
                }

                Students.studentID =
                    Convert.ToInt32(
                        DGVStudent.SelectedRows[0]
                        .Cells["StudentID"].Value
                    );

                Students st = new Students();

                st.Show();

                this.Close();
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(ex.Message, "Error", DialogType.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGVStudent.SelectedRows.Count == 0)
                {
                    MessageBox.Show(
                        "Please select a student.");
                    return;
                }

                DialogResult result =
                    MessageBox.Show(
                        "Are you sure?",
                        "Delete Student",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                if (result == DialogResult.No)
                    return;

                int studentID =
                    Convert.ToInt32(
                        DGVStudent.SelectedRows[0]
                        .Cells["StudentID"].Value);

                string qry =
                    @"UPDATE TblStudents
              SET IsAct = 0,
                  UpdatedDate = GETDATE()
              WHERE StudentID = @StudentID";

                SqlCommand cmd =
                    new SqlCommand(
                        qry,
                        DBConnection.con);

                cmd.Parameters.AddWithValue(
                    "@StudentID",
                    studentID);

                DBConnection.con.Open();

                cmd.ExecuteNonQuery();

                DBConnection.con.Close();

                CustomMessageBox.Show(
                    "Student Deleted Successfully", "Error", DialogType.Error);

                LoadStudents();
            }
            catch (Exception ex)
            {
                DBConnection.con.Close();

                CustomMessageBox.Show(ex.Message, "Error", DialogType.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
            this.Close();
        }

        private void ViewStudents_Load(object sender, EventArgs e)
        {
            
        }
    }
}
