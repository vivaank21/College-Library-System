using College_Management_System.Database;
using College_Management_System.Helper;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace College_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string qry =
            @"SELECT COUNT(*)
            FROM TblUsers
            WHERE Username=@Username
            AND UserPassword=@Password
            AND IsAct=1";

            SqlCommand cmd =
                new SqlCommand(
                    qry,
                    DBConnection.con);

            cmd.Parameters.AddWithValue(
                "@Username",
                txtUsername.Text.Trim());

            cmd.Parameters.AddWithValue(
                "@Password",
                txtPassword.Text.Trim());

            DBConnection.con.Open();

            int count =
                Convert.ToInt32(
                    cmd.ExecuteScalar());

            DBConnection.con.Close();

            if (count > 0)
            {
                Dashboard ds =
                    new Dashboard();

                ds.Show();

                this.Hide();
            }
            else
            {
                CustomMessageBox.Show(
                    "Invalid Username Or Password", "Error", DialogType.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
