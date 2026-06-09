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
    public partial class Books : Form
    {
        string Imagepath = "";
        public Books()
        {
            InitializeComponent();
            loadcategory();
        }

        private void lblAuthor_Click(object sender, EventArgs e)
        {

        }

        private void lblRack_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string folderPath = Application.StartupPath + @"\BookImages\";

                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                string filename = Guid.NewGuid().ToString() + Path.GetExtension(folderPath);
                string savepath = folderPath + filename;
                File.Copy(Imagepath, savepath);



                string qry = @"INSERT INTO TblBooks (BookName, ISBN, AuthorName, CategoryID, Quantity, RackNumber) 
                VALUES(@BookName, @ISBN, @AuthorName, @CategoryID, @Quantity, @RackNumber)";

                SqlCommand cmd = new SqlCommand(qry, DBConnection.con);

                cmd.Parameters.AddWithValue("@BookName", txtBName.Text);
                cmd.Parameters.AddWithValue("@ISBN", txtISBN.Text);
                cmd.Parameters.AddWithValue("@AuthorName", txtAuthor.Text);
                cmd.Parameters.AddWithValue("@CategoryID", cbCategory.SelectedIndex);
                cmd.Parameters.AddWithValue("@Quantity", txtQty.Text);
                cmd.Parameters.AddWithValue("@RackNumber", txtRack.Text);
                cmd.Parameters.AddWithValue("@BookImage", savepath);

                DBConnection.con.Open();
                cmd.ExecuteNonQuery();
                DBConnection.con.Close();

                Helper.CustomMessageBox.Show("Books Added Successfully", "Success", Helper.DialogType.Success);

                ClearData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                Helper.CustomMessageBox.Show(ex.Message.ToString(), "Error", Helper.DialogType.Error);
            }
        }
        private void loadcategory()
        {
            string qry = "SELECT CategoryID, CategoryName FROM TblCategories";

            SqlDataAdapter adapter = new SqlDataAdapter(qry, DBConnection.con);

            DataTable dt = new DataTable();

            adapter.Fill(dt);
            cbCategory.DataSource = dt;
            cbCategory.DisplayMember = "CategoryName";
            cbCategory.ValueMember = "CategoryID";
            cbCategory.SelectedIndex = -1;
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files | *.jpg; *png; *webp; *jpeg";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Imagepath = openFileDialog1.FileName;
                picImg.Image = Image.FromFile(Imagepath);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ClearData()
        {
            txtAuthor.Clear();
            txtBName.Clear();
            txtISBN.Clear();
            txtQty.Clear();
            txtRack.Clear();
            cbCategory.SelectedIndex = -1;
            picImg.Image = null;
            Imagepath = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewBooks viewBooks = new ViewBooks();
            viewBooks.Show();
            this.Close();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
            this.Close();
        }

        private void Books_Load(object sender, EventArgs e)
        {
            
        }
    }
}
