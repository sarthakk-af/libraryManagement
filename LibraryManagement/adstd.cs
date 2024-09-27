using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LibraryManagement
{
    public partial class adstd : Form
    {
        public adstd()
        {
            InitializeComponent();
            stdeml.TextChanged += stdeml_TextChanged;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void sev_Click(object sender, EventArgs e)
        {


            if (stdcon.ForeColor == Color.Red)
            {
                MessageBox.Show("Please enter a valid 10-digit number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (stdeml.ForeColor == Color.Red)
            {
                MessageBox.Show("Please enter a valid Email Address!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }









                if (stdn.Text != "" && stden.Text != "" && stddep.Text != "" && stdsem.Text != "" && stdcon.Text != "" && stdeml.Text != "")
            {
                String name = stdn.Text;
                String enrol = stden.Text;
                String sdep = stddep.Text;
                String sem = stdsem.Text;
                Int64 mob = Int64.Parse(stdcon.Text);
                String eml = stdeml.Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = HARI\\SQLEXPRESS; database=library1;integrated security=True";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "insert into NewStudent (sname,enroll,dep,sem,con ,email) values ('" + name + "','" + enrol + "','" + sdep + "','" + sem + "','" + mob + "','" + eml + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                stdn.Clear();
                stden.Clear();
                stddep.Clear();
                stdcon.Clear();
                stdsem.SelectedIndex=-1;
                stdeml.Clear();
            }
            else
            {
                MessageBox.Show("Please Fill Empty Fields", "Suggest", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void eksit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Confirm?","Alert",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)== DialogResult.OK)
            this.Close();
        }
        private void btnrefresh_Click(object sender, EventArgs e)
        {
            stdn.Clear();
            stden.Clear();
            stddep.Clear();
            stdcon.Clear();
            stdsem.SelectedIndex=-1;
            stdeml.Clear();
        }
        private void stdeml_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string email = textBox.Text;
            string pattern = @"@gmail\.com$";
            if (Regex.IsMatch(email, pattern))
            {
                textBox.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                textBox.ForeColor = System.Drawing.Color.Red;
            }

        }
        private void stdcon_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string text = textBox.Text;

            if (text.Length == 10 && IsNumer(text))
            {
                textBox.ForeColor = Color.Black;
            }
            else
            {
                textBox.ForeColor = Color.Red;
            }
        }

        private bool IsNumer(string text)
        {
            foreach (char c in text)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        private void stdsem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

