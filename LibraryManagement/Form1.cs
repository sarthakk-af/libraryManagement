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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = HARI\\SQLEXPRESS;database = library1;integrated security=True";
            SqlCommand cmd=new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText="select * from logint where username= '"+txtUser.Text+"' and pass='"+txtPass.Text+"'";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count != 0)
            {
                this.Hide();
                Form2 dsa = new Form2();
                dsa.Show();
            }
            else
            {
                MessageBox.Show("Wrong Username Or Password","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }   

        private void txtUser_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtUser.Text == "Username")
            {
                txtUser.Clear();
            }
        }

        private void txtPass_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtPass.Text == "Password")
            {
                txtPass.Clear();
                txtPass.PasswordChar = '*';
            }
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
