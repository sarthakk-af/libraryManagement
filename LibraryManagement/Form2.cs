using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class Form2 : Form
    {
        //string Connection = "Data Source=HARI\\SQLEXPRESS;Initial Catalog=library1;Integrated Security=True;Trust Server Certificate=True";
        public Form2()

        {
            InitializeComponent();
        }

        private void issueBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bissue ib = new bissue();
            ib.Show();
        }

        private void addNewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(Connection);
            //con.Open();
            //string query = "Insert into newb values";

            adbook abs = new adbook();
            abs.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("You are about to exit??","Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void newBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewbook vb = new viewbook();   
            vb.Show();
        }

        private void addAStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adstd std = new adstd();
            std.Show();

        }

        private void returnBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rbook rb = new rbook();
            rb.Show();
        }

        private void completeBookDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comb cb = new comb();
            cb.Show();
        }

        private void viewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewstudent vs = new viewstudent();
            vs.Show();
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
