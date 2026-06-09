using College_Management_System.Database;
using College_Management_System.Helper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace College_Management_System
{
    public partial class Students : Form
    {
        string Imagepath = "";
        public static int studentID = 0;
        public Students()
        {
            InitializeComponent();
            LoadStatus();
            LoadDepartment();
            LoadSemester();
            if (studentID != 0)
            {
                LoadStudentData();

                button3.Text = "Save Changes";
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (studentID == 0)
            {
                addStudent();
            }
            else
            {
                UpdateStudent();
            }

        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Imagepath = openFileDialog1.FileName;

                picImg.Image = Image.FromFile(Imagepath);
            }
        }

        private void LoadDepartment()
        {
            try
            {
                string qry = @"
                SELECT DepartmentID, DepartmentName FROM TblDepartments WHERE IsAct = 1";

                SqlDataAdapter da =
                    new SqlDataAdapter(
                        qry,
                        DBConnection.con
                    );

                DataTable dt = new DataTable();

                da.Fill(dt);

                DataRow row = dt.NewRow();

                row["DepartmentID"] = 0;
                row["DepartmentName"] =
                    "Select Department";

                dt.Rows.InsertAt(row, 0);

                cbDepartment.DataSource = dt;

                cbDepartment.DisplayMember =
                    "DepartmentName";

                cbDepartment.ValueMember =
                    "DepartmentID";
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(ex.Message, "Error", DialogType.Error);
            }
        }

        private void LoadSemester()
        {
            try
            {
                string qry = @"
                SELECT
                SemesterID,
                SemesterName
                FROM TblSemester
                WHERE IsAct = 1";

                SqlDataAdapter da =
                    new SqlDataAdapter(
                        qry,
                        DBConnection.con
                    );

                DataTable dt = new DataTable();

                da.Fill(dt);

                DataRow row = dt.NewRow();

                row["SemesterID"] = 0;
                row["SemesterName"] =
                    "Select Semester";

                dt.Rows.InsertAt(row, 0);

                cbSemester.DataSource = dt;

                cbSemester.DisplayMember =
                    "SemesterName";

                cbSemester.ValueMember =
                    "SemesterID";
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(ex.Message, "Error", DialogType.Error);
            }
        }

        private void LoadStatus()
        {
            cbStatus.Items.Clear();

            cbStatus.Items.Add("Select Status");

            cbStatus.Items.Add("Active");

            cbStatus.Items.Add("Inactive");

            cbStatus.SelectedIndex = 0;
        }

        private void LoadStudentData()
        {
            try
            {
                string qry = @"SELECT * FROM TblStudents WHERE StudentID = @StudentID";

                SqlCommand cmd = new SqlCommand(qry, DBConnection.con);

                cmd.Parameters.AddWithValue("@StudentID", studentID);

                DBConnection.con.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    txtSName.Text = dr["FullName"].ToString();

                    txtErollment.Text = dr["EnrollmentNo"].ToString();

                    txtEmail.Text = dr["Email"].ToString();

                    txtContact.Text = dr["ContactNo"].ToString();

                    cbDepartment.SelectedValue = dr["DepartmentID"];

                    cbSemester.SelectedValue = dr["SemesterID"];

                    cbStatus.Text = dr["StudentStatus"].ToString();

                    Imagepath = dr["StudentImage"].ToString();

                    if (File.Exists(Imagepath))
                    {
                        picImg.Image =
                            Image.FromFile(Imagepath);
                    }
                }

                dr.Close();

                DBConnection.con.Close();
            }
            catch (Exception ex)
            {
                DBConnection.con.Close();

                CustomMessageBox.Show(ex.Message, "Error", DialogType.Error);
            }
        }

        private void btnViewStudent_Click(object sender, EventArgs e)
        {
            ViewStudents vs = new ViewStudents();
            vs.Show();
            this.Close();

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Close();
        }

        private void btnViewStudent_Click_1(object sender, EventArgs e)
        {
            ViewStudents vs = new ViewStudents();
            vs.Show();
            this.Close();
        }

        private void addStudent()
        {
            try
            {
                string folderPath = Application.StartupPath + @"\StudentImages\";

                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                string filename = Guid.NewGuid().ToString() + Path.GetExtension(Imagepath);
                string savepath = folderPath + filename;
                File.Copy(Imagepath, savepath);

                string qry = "INSERT INTO TblStudents(FullName, EnrollmentNo, Email, ContactNo, DepartmentID, SemesterID, StudentImage, StudentStatus) VALUES(@FullName, @EnrollmentNo, @Email, @ContactNo, @DepartmentID, @SemesterID, @StudentImage, @StudentStatus)";

                SqlCommand cmd = new SqlCommand(qry, Database.DBConnection.con);

                cmd.Parameters.AddWithValue("@FullName", txtSName.Text);
                cmd.Parameters.AddWithValue("@EnrollmentNo", txtErollment.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@ContactNo", txtContact.Text);
                cmd.Parameters.AddWithValue("@DepartmentID", cbDepartment.SelectedValue);
                cmd.Parameters.AddWithValue("@SemesterID", cbSemester.SelectedValue);
                cmd.Parameters.AddWithValue("@StudentImage", savepath);
                cmd.Parameters.AddWithValue("@StudentStatus", cbStatus.Text);

                Database.DBConnection.con.Open();

                cmd.ExecuteNonQuery();

                Database.DBConnection.con.Close();

                CustomMessageBox.Show("Student Added Successfully", "Success", DialogType.Success);

            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(ex.Message, "Error", DialogType.Error);
            }
        }

        private void UpdateStudent()
        {
            try
            {
                string qry = @"
                UPDATE TblStudents
                SET
                FullName = @FullName,
                EnrollmentNo = @EnrollmentNo,
                Email = @Email,
                ContactNo = @ContactNo,
                DepartmentID = @DepartmentID,
                SemesterID = @SemesterID,
                StudentStatus = @StudentStatus,
                UpdatedDate = GETDATE()
                WHERE StudentID = @StudentID";

                SqlCommand cmd =
                    new SqlCommand(
                        qry,
                        DBConnection.con
                    );

                cmd.Parameters.AddWithValue(
                    "@StudentID",
                    studentID);

                cmd.Parameters.AddWithValue(
                    "@FullName",
                    txtSName.Text);

                cmd.Parameters.AddWithValue(
                    "@EnrollmentNo",
                    txtErollment.Text);

                cmd.Parameters.AddWithValue(
                    "@Email",
                    txtEmail.Text);

                cmd.Parameters.AddWithValue(
                    "@ContactNo",
                    txtContact.Text);

                cmd.Parameters.AddWithValue(
                    "@DepartmentID",
                    cbDepartment.SelectedValue);

                cmd.Parameters.AddWithValue(
                    "@SemesterID",
                    cbSemester.SelectedValue);

                cmd.Parameters.AddWithValue(
                    "@StudentStatus",
                    cbStatus.Text);

                DBConnection.con.Open();

                cmd.ExecuteNonQuery();

                DBConnection.con.Close();

                CustomMessageBox.Show(
                    "Student Updated Successfully", "Success", DialogType.Success);

                studentID = 0;

                this.Close();
            }
            catch (Exception ex)
            {
                DBConnection.con.Close();

                CustomMessageBox.Show(ex.Message, "Error", DialogType.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtSName.Clear();

            txtErollment.Clear();

            txtEmail.Clear();

            txtContact.Clear();

            cbDepartment.SelectedIndex = 0;

            cbSemester.SelectedIndex = 0;

            cbStatus.SelectedIndex = 0;

            picImg.Image = null;

            Imagepath = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            IssueBooks issueBooks = new IssueBooks();
            issueBooks.Show();

            this.Close();
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            Display display = new Display();
            display.Show();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
            this.Close();
        }

        private void Students_Load(object sender, EventArgs e)
        {
            
        }
    }
}
