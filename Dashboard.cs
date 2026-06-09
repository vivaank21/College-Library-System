using College_Management_System.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace College_Management_System
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            timer1.Start();
            timer2.Start();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            Students students = new Students();
            students.Show();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = "⏰ " + DateTime.Now.ToString("hh:mm:ss tt");

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lblDate.Text = "📅 " + DateTime.Now.ToString("dddd, dd MMM yyyy");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            Books books = new Books();
            books.Show();
            this.Close();
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

            this.Close();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            Reports report = new Reports();
            report.Show();

            this.Close();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
            this.Close();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
           
        }


    }
}
