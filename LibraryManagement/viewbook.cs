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
    public partial class viewbook : Form
    {
        public viewbook()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(txtbkn.Text !="")
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = HARI\\SQLEXPRESS; database=library1; integrated security =True ";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from NewBook where bName LIKE'"+txtbkn.Text+"%'";
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                ad.Fill(ds);


                dataGridView1.DataSource = ds.Tables[0];
            }

            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = HARI\\SQLEXPRESS; database=library1; integrated security =True ";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from NewBook ";
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                ad.Fill(ds);


                dataGridView1.DataSource = ds.Tables[0];

            }
        }

        private void viewbook_Load(object sender, EventArgs e)
        {

            panel2.Visible = false;


            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = HARI\\SQLEXPRESS; database=library1; integrated security =True ";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from NewBook ";
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            ad.Fill(ds);


            dataGridView1.DataSource = ds.Tables[0];
        }
        int bid;
        Int64 rowid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value!=null)
            {
                bid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            panel2.Visible=true;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = HARI\\SQLEXPRESS; database=library1; integrated security =True ";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from NewBook where bid = "+bid+"";
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            ad.Fill(ds);

            rowid = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());

            txtbook.Text = ds.Tables[0].Rows[0][1].ToString();
            txtauthn.Text = ds.Tables[0].Rows[0][2].ToString();
            txtpu.Text = ds.Tables[0].Rows[0][3].ToString();
            dateTimePicker1.Text = ds.Tables[0].Rows[0][4].ToString();
            txtp.Text = ds.Tables[0].Rows[0][5].ToString();
            txtq.Text = ds.Tables[0].Rows[0][6].ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void btnref_Click(object sender, EventArgs e)
        {
            txtbkn.Clear();
            panel2.Visible = false;

        }

        private void btnup_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be updated.Comfirm?", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            { 
            string bname = txtbook.Text;
            string bauth = txtauthn.Text;
            string bpu = txtpu.Text;
            string bdate = dateTimePicker1.Text;
            Int64 price = Int64.Parse(txtp.Text);
            Int64 quan = Int64.Parse(txtq.Text);

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = HARI\\SQLEXPRESS; database=library1; integrated security =True ";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "update NewBook set bName = '" + bname + "' , bAuthor ='" + bauth + "' ,bPub ='" + bpu + "' , bPDate = '" + bdate + "' , bPrice=" + price + " , bQuan = " + quan + " where bid=" + rowid + "";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

             da.Fill(ds);

                viewbook_Load(this, null);
        }
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be Deleted.Comfirm?", "Confrim", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
              
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = HARI\\SQLEXPRESS; database=library1; integrated security =True ";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText ="delete from NewBook where bid ="+rowid+"";
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                ad.Fill(ds);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
