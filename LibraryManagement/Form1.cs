using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Center the form
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtUser.Text = "somaiya";
            txtPass.Text = "somaiya";
            txtPass.PasswordChar = '\0'; // No mask initially
        }
        // DllImport to enable custom region shapes (Windows API)
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        // Helper method to apply rounded corners to any control
   
        private void button1_Click(object sender, EventArgs e)
        {
            // Validate Inputs
            if (string.IsNullOrWhiteSpace(txtUser.Text) || txtUser.Text == "Username" ||
                string.IsNullOrWhiteSpace(txtPass.Text) || txtPass.Text == "Password")
            {
                MessageBox.Show("Please enter both Username and Password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection("data source=HARI\\SQLEXPRESS;database=library1;integrated security=True"))
                {
                    con.Open();
                    string query = "SELECT * FROM logint WHERE username = @username AND pass = @password";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@username", txtUser.Text.Trim());
                        cmd.Parameters.AddWithValue("@password", txtPass.Text.Trim());

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        da.Fill(ds);

                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            this.Hide();
                            Form2 dsa = new Form2();
                            dsa.Show();
                        }
                        else
                        {
                            MessageBox.Show("Wrong Username Or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtPass.Clear();
                            txtUser.Focus();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database connection failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick(); // Pressing Enter key will trigger Login
            }
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
