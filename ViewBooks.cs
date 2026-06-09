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
    public partial class ViewBooks : Form
    {
        public ViewBooks()
        {
            InitializeComponent();
            DesignDataGridView();
            LoadFilterCategories();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();

            this.Close();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Close();
        }

        private void btnAddBooks_Click(object sender, EventArgs e)
        {
            Books books = new Books();
            books.Show();
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue == null || comboBox1.SelectedValue is DataRowView)
            {
                return;
            }

            int categoryId = Convert.ToInt32(comboBox1.SelectedValue);

            string qry = "";
            if (categoryId == 0)
            {
                qry = @"
                    SELECT
                    B.BookID,
                    B.BookName,
                    B.ISBN,
                    B.AuthorName,
                    C.CategoryName,
                    B.Quantity,
                    B.RackNumber
                    FROM TblBooks B
                    INNER JOIN TblCategories C
                    ON B.CategoryID = C.CategoryID
                    WHERE B.IsAct = 1";
            }
            else
            {
                qry = @"
                    SELECT
                    B.BookID,
                    B.BookName,
                    B.ISBN,
                    B.AuthorName,
                    C.CategoryName,
                    B.Quantity,
                    B.RackNumber
                    FROM TblBooks B
                    INNER JOIN TblCategories C
                    ON B.CategoryID = C.CategoryID
                    WHERE B.IsAct = 1
                    AND B.CategoryID = @CategoryID";
            }

            SqlDataAdapter da = new SqlDataAdapter(qry, DBConnection.con);

            if (categoryId != 0)
            {
                da.SelectCommand.Parameters.AddWithValue("@CategoryID", comboBox1.SelectedValue);
            }

            DataTable dt = new DataTable();
            da.Fill(dt);
            DGVBooks.DataSource = dt;
        }
        private void LoadFilterCategories()
        {
            string query =
                "SELECT CategoryID, CategoryName " +
                "FROM TblCategories " +
                "WHERE IsAct = 1";

            SqlDataAdapter da =
                new SqlDataAdapter(query, DBConnection.con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            DataRow row = dt.NewRow();
            row["CategoryID"] = 0;
            row["CategoryName"] = "All Categories";

            dt.Rows.InsertAt(row, 0);

            comboBox1.DisplayMember = "CategoryName";
            comboBox1.ValueMember = "CategoryID";
            comboBox1.DataSource = dt;

            comboBox1.SelectedIndex = 0;
        }

        private void DesignDataGridView()
        {
            Color headerColor = Color.FromArgb(30, 41, 59);
            Color rowColor = Color.White;
            Color alternateRowColor = Color.FromArgb(248, 250, 252);
            Color selectionColor = Color.FromArgb(59, 130, 246);

            DGVBooks.BorderStyle = BorderStyle.None;
            DGVBooks.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DGVBooks.BackgroundColor = Color.White;
            DGVBooks.RowHeadersVisible = false;

            DGVBooks.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            DGVBooks.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.AllCells;

            DGVBooks.EnableHeadersVisualStyles = false;

            DGVBooks.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.None;

            DGVBooks.ColumnHeadersDefaultCellStyle.BackColor =
                headerColor;

            DGVBooks.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            DGVBooks.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 11, FontStyle.Bold);

            DGVBooks.ColumnHeadersHeight = 45;

            DGVBooks.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;


            DGVBooks.DefaultCellStyle.BackColor = rowColor;

            DGVBooks.AlternatingRowsDefaultCellStyle.BackColor =
                alternateRowColor;

            DGVBooks.DefaultCellStyle.ForeColor = Color.Black;

            DGVBooks.DefaultCellStyle.Font =
                new Font("Segoe UI", 10);

            DGVBooks.DefaultCellStyle.SelectionBackColor =
                selectionColor;

            DGVBooks.DefaultCellStyle.SelectionForeColor =
                Color.White;

            DGVBooks.DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;


            DGVBooks.RowTemplate.Height = 40;


            DGVBooks.GridColor = Color.LightGray;


            DGVBooks.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            DGVBooks.MultiSelect = false;


            DGVBooks.ReadOnly = true;


            DGVBooks.Cursor = Cursors.Hand;


            DGVBooks.AllowUserToAddRows = false;


            DGVBooks.AllowUserToResizeRows = false;


            DGVBooks.DefaultCellStyle.Padding =
                new Padding(5);
        }

        private void ViewBooks_Load(object sender, EventArgs e)
        {
            
        }
    }
}

