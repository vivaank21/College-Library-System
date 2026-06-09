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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Close();
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd =
                    new SaveFileDialog();

                sfd.Filter =
                    "Backup File (*.bak)|*.bak";

                sfd.FileName =
                    "LibraryDB_" +
                    DateTime.Now.ToString("yyyyMMdd") +
                    ".bak";

                if (sfd.ShowDialog()
                    == DialogResult.OK)
                {
                    string qry =
                        @"BACKUP DATABASE LibraryDB
                        TO DISK = @Path
                        WITH INIT";

                    SqlCommand cmd = new SqlCommand(qry, DBConnection.con);

                    cmd.Parameters.AddWithValue("@Path", sfd.FileName);

                    DBConnection.con.Open();

                    cmd.ExecuteNonQuery();

                    DBConnection.con.Close();

                    CustomMessageBox.Show(
                        "Database Backup Created Successfully.", "Success", DialogType.Success);
                }
            }
            catch (Exception ex)
            {
                DBConnection.con.Close();

                CustomMessageBox.Show(ex.Message, "Error", DialogType.Error);
            }
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd =
                    new OpenFileDialog();

                ofd.Filter =
                    "Backup File (*.bak)|*.bak";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    DBConnection.con.Close();

                    string qry = $@"
                    USE master;

                    ALTER DATABASE LibraryDB
                    SET SINGLE_USER
                    WITH ROLLBACK IMMEDIATE;
        
                    RESTORE DATABASE LibraryDB
                    FROM DISK = '{ofd.FileName}'
                    WITH REPLACE;

                    ALTER DATABASE LibraryDB
                    SET MULTI_USER;";

                    SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=master;Integrated Security=True;TrustServerCertificate=True");

                    con.Open();

                    SqlCommand cmd = new SqlCommand(qry, con);

                    cmd.ExecuteNonQuery();

                    con.Close();

                    CustomMessageBox.Show(
                        "Database Restored Successfully.\nPlease Restart Application.", "Success", DialogType.Success);
                }
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(
                    ex.Message, "Error", DialogType.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCP_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.Text !=
      txtConfirmPassword.Text)
            {
                MessageBox.Show(
                    "Passwords Do Not Match");

                return;
            }

            string qry =
            @"SELECT COUNT(*)
      FROM TblUsers
      WHERE Username='Admin'
      AND UserPassword=@OldPassword";

            SqlCommand cmd =
                new SqlCommand(
                    qry,
                    DBConnection.con);

            cmd.Parameters.AddWithValue(
                "@OldPassword",
                txtOldPassword.Text);

            DBConnection.con.Open();

            int count =
                Convert.ToInt32(
                    cmd.ExecuteScalar());

            if (count == 0)
            {
                DBConnection.con.Close();

                MessageBox.Show(
                    "Old Password Is Incorrect");

                return;
            }

            string updateQry =
            @"UPDATE TblUsers
      SET UserPassword=@NewPassword
      WHERE Username='Admin'";

            SqlCommand updateCmd =
                new SqlCommand(
                    updateQry,
                    DBConnection.con);

            updateCmd.Parameters.AddWithValue(
                "@NewPassword",
                txtNewPassword.Text);

            updateCmd.ExecuteNonQuery();

            DBConnection.con.Close();

            MessageBox.Show(
                "Password Changed Successfully");

            txtOldPassword.Clear();
            txtNewPassword.Clear();
            txtConfirmPassword.Clear();
        }
    }
}
