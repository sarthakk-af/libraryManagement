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
using static System.Net.Mime.MediaTypeNames;

namespace LibraryManagement
{
    public partial class viewstudent : Form
    {
        public viewstudent()
        {
            InitializeComponent();
        }

        private void viewstudent_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=HARI\\SQLEXPRESS;database = library1;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;


            cmd.CommandText = "select * from NewStudent";
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            ad.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void txtsarch_TextChanged(object sender, EventArgs e)
        {
            if (txtsarch.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source=HARI\\SQLEXPRESS;database = library1;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;


                cmd.CommandText = "select * from NewStudent where enroll LIKE '" + txtsarch.Text + "%'";
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                ad.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source=HARI\\SQLEXPRESS;database = library1;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;


                cmd.CommandText = "select * from NewStudent";
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                ad.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

            }

        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        int bid;
        Int64 rowid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

            }
            panel2.Visible = true;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=HARI\\SQLEXPRESS;database = library1;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;


            cmd.CommandText = "select * from NewStudent where stduid=" + bid + "";
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            ad.Fill(ds);

            rowid = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());

            sname.Text = ds.Tables[0].Rows[0][1].ToString();
            senrol.Text = ds.Tables[0].Rows[0][2].ToString();
            ssem.Text = ds.Tables[0].Rows[0][3].ToString();
            sdep.Text = ds.Tables[0].Rows[0][4].ToString();
            scon.Text = ds.Tables[0].Rows[0][5].ToString();
            smail.Text = ds.Tables[0].Rows[0][6].ToString();
        }

        private void updt_Click(object sender, EventArgs e)
        {
            
            String name = sname.Text;
            String roll = senrol.Text;
            String deep = sdep.Text;
            String sems = ssem.Text;
            Int64 cont = Int64.Parse(scon.Text);
            String em = smail.Text;
            if (MessageBox.Show("Data will be Updated.Confirm?", "Sucess", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source=HARI\\SQLEXPRESS;database = library1;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;


                cmd.CommandText = "update NewStudent set sname='" + name + "',enroll='" + roll + "',dep='" + deep + "',sem='" + sems + "',con='" + cont + "',email='" + em + "' where stduid='" + rowid + "'";
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                ad.Fill(ds);

                viewstudent_Load(this, null);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            viewstudent_Load(this, null);
        }

        private void del_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be deleted.Confirm?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source=HARI\\SQLEXPRESS;database = library1;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;


                cmd.CommandText = "delete from NewStudent where stduid='"+rowid+"'";
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                ad.Fill(ds);

                viewstudent_Load(this, null);
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("unsaved data will be lost.", "Are you Sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
