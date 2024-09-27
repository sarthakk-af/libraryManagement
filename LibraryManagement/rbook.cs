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
    public partial class rbook : Form
    {
        public rbook()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtsarchol.Text == "")
            {
                dataGridView1.DataSource = null;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnsarch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString= "data source = HARI\\SQLEXPRESS;database = library1;integrated security=True";          
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from IRBook where std_enroll = '"+txtsarchol.Text+"' and book_return_date is NULL";
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            ad.Fill(ds);

            if (ds.Tables[0].Rows.Count != 0 )
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Invalid Enrollment No. OR No Book Issued","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void rbook_Load(object sender, EventArgs e)
        {
            panel3.Visible = false;
            txtsarchol.Clear();
        }
        String bname;
        String bdate;
        Int64 rowid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel3.Visible=true;
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                rowid = Int64.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                bname = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                bdate = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            }
            bknaam.Text = bname;
            bkdin.Text = bdate;
        }
        private void retun_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = HARI\\SQLEXPRESS;database = library1;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "update IRBook set book_return_date = '" + dateTimePicker1.Text + "' where std_enroll='"+txtsarchol.Text+"' and id='"+rowid+"'";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Return Successful","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
            rbook_Load(this, null);
        }
        private void refesh_Click(object sender, EventArgs e)
        {
            txtsarchol.Clear();
        }
        private void cancel_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }
    }
}
