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
    public partial class bissue : Form
    {
        public bissue()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void bissue_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = HARI\\SQLEXPRESS ; database = library1;integrated security = true";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();

            cmd = new SqlCommand("select bName from NewBook",con);
            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {
                for(int i =0; i<sdr.FieldCount; i++)
                {
                    txtbn.Items.Add(sdr.GetString(i));
                }
            }
            sdr.Close();
            con.Close();
        }


        int count;
        private void sarchstd_Click(object sender, EventArgs e)
        {
            if(sarchno.Text!="")
            {
                String edi = sarchno.Text;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = HARI\\SQLEXPRESS ; database = library1;integrated security = true";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from NewStudent where enroll = '" + edi + "'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet dc = new DataSet(); 
                da.Fill(dc);


                //----------------------------------------------------------------------


                cmd.CommandText = "select count(std_enroll) from IRBook where std_enroll = '" + edi + "' and book_return_date is null";
                SqlDataAdapter da1 = new SqlDataAdapter(cmd);
                DataSet dc1 = new DataSet();
                da1.Fill(dc1);

                count = int.Parse(dc1.Tables[0].Rows[0][0].ToString());




                //---------------------------------------------------------


                if (dc.Tables[0].Rows.Count!=0)
                {
                    txtname.Text = dc.Tables[0].Rows[0][1].ToString();
                    txtdep.Text = dc.Tables[0].Rows[0][4].ToString();
                    txtsem.Text = dc.Tables[0].Rows[0][3].ToString();
                    txtcon.Text = dc.Tables[0].Rows[0][5].ToString();
                    txtem.Text = dc.Tables[0].Rows[0][6].ToString();
                }
                else
                {
                    txtname.Clear();
                    txtdep.Clear();
                    txtsem.Clear();
                    txtcon.Clear();
                    txtem.Clear();
                    MessageBox.Show("Invalid Enrollment No","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void btni_Click(object sender, EventArgs e)
        {
            if(txtname.Text!="")
            {
                if(txtbn.SelectedIndex != -1 && count <= 2)
                {
                    String enroll = sarchno.Text;
                    String sname = txtname.Text;
                    String sdep = txtdep.Text;
                    String ssem = txtem.Text;
                    Int64 scon = Int64.Parse(txtcon.Text);
                    String email = txtem.Text;
                    String bkn = txtbn.Text;
                    String sdate = txtd.Text;



                    String edi = sarchno.Text;
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "data source = HARI\\SQLEXPRESS ; database = library1;integrated security = true";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    con.Open();
                    cmd.CommandText = "insert into IRBook (std_enroll,std_name,std_dep,std_sem,std_contact,std_email,book_name,book_issue_date) values ('"+enroll+"','"+sname+ "','"+sdep+ "','"+ssem+ "',"+scon+ ",'"+email+ "','"+bkn+ "','"+sdate+"')";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    txtname.Clear();
                    txtdep.Clear();
                    txtsem.Clear();
                    txtcon.Clear();
                    txtem.Clear();

                    MessageBox.Show("Book Issued.","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Select Book OR Maximum number of book has been ISSUED.", "No Book Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Enter valid enrollment number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void sarchno_TextChanged(object sender, EventArgs e)
        {
            if (sarchno.Text == "")
            {
                txtname.Clear();
                txtcon.Clear();
                txtsem.Clear();
                txtdep.Clear();
                txtem.Clear();
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            sarchno.Clear();
        }

        private void eksit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are You Sure?","Confirmation",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.OK)
            this.Close();
        }

        private void txtcon_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
