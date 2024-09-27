using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class adbook : Form
    {
        public adbook()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("This will delete your unsaved data", "Are you Sure?", MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK)
            { 
                this.Close();
            }
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            if (txtname.Text != "" && txtauth.Text != "" && txtpub.Text != "" && txtprice.Text != "" && txtquan.Text != "")
            {
                String bname = txtname.Text;
                String bauth = txtauth.Text;
                String bpub = txtpub.Text;
                String bdate = txtdate.Text;
                Int64 price = Int64.Parse(txtprice.Text);
                Int64 quan = Int64.Parse(txtquan.Text);


                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = HARI\\SQLEXPRESS ; database = library1; integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "insert into NewBook (bName , bAuthor, bPub, bPDate, bPrice, bQuan) values ('" + bname + "','" + bauth + "','" + bpub + "','" + bdate + "'," + price + "," + quan + ")";
                cmd.ExecuteNonQuery();
                con.Close();


                MessageBox.Show("Data Saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtname.Clear();
                txtauth.Clear();
                txtpub.Clear();
                txtprice.Clear();
                txtquan.Clear();
            }
            else
            {
                MessageBox.Show("Empty Field NOT Allowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }        
        
    }
}

