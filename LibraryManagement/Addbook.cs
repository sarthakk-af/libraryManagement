using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;

namespace LibraryManagement
{
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will delete your unsaved data", "Are you Sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtname.Text) || string.IsNullOrWhiteSpace(txtauth.Text) ||
                string.IsNullOrWhiteSpace(txtpub.Text) || string.IsNullOrWhiteSpace(txtprice.Text) ||
                string.IsNullOrWhiteSpace(txtquan.Text) || string.IsNullOrWhiteSpace(txtc.Text))
            {
                MessageBox.Show("Empty Field NOT Allowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string bname = txtname.Text;
                string bauth = txtauth.Text;
                string bpub = txtpub.Text;
                DateTime bdate = txtdate.Value;
                if (!Int64.TryParse(txtprice.Text, out long price) || !Int64.TryParse(txtquan.Text, out long quan))
                {
                    MessageBox.Show("Price and Quantity must be valid numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string bc = txtc.Text;

                LogMessage("Starting database operation...");

                using (SqlConnection con = new SqlConnection("data source=HARI\\SQLEXPRESS; database=library1; integrated security=True"))
                {
                    LogMessage("Opening database connection...");
                    con.Open();
                    LogMessage("Connection opened successfully.");

                    using (SqlTransaction transaction = con.BeginTransaction())
                    {
                        try
                        {
                            LogMessage("Inserting new book...");
                            // Insert the new book (exclude bid since it's auto-incremented)
                            using (SqlCommand cmd = new SqlCommand(
                                "INSERT INTO NewBook (bName, bAuthor, bPub, bPDate, bPrice, bQuan, bCode) " +
                                "VALUES (@bName, @bAuthor, @bPub, @bPDate, @bPrice, @bQuan, @bCode)", con, transaction))
                            {
                                cmd.Parameters.AddWithValue("@bName", bname).SqlDbType = SqlDbType.NVarChar;
                                cmd.Parameters.AddWithValue("@bAuthor", bauth).SqlDbType = SqlDbType.NVarChar;
                                cmd.Parameters.AddWithValue("@bPub", bpub).SqlDbType = SqlDbType.NVarChar;
                                cmd.Parameters.AddWithValue("@bPDate", bdate).SqlDbType = SqlDbType.Date;
                                cmd.Parameters.AddWithValue("@bPrice", price).SqlDbType = SqlDbType.BigInt;
                                cmd.Parameters.AddWithValue("@bQuan", quan).SqlDbType = SqlDbType.BigInt;
                                cmd.Parameters.AddWithValue("@bCode", bc).SqlDbType = SqlDbType.VarChar;
                                cmd.ExecuteNonQuery();
                            }
                            LogMessage("Book inserted successfully.");

                            LogMessage("Renumbering book IDs...");
                            RenumberBookIds(con, transaction);
                            LogMessage("Book IDs renumbered successfully.");

                            transaction.Commit();
                            LogMessage("Transaction committed successfully.");
                            MessageBox.Show("Data Saved and IDs successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            LogMessage($"Error during save and renumbering: {ex.Message}\nStack Trace: {ex.StackTrace}");
                            MessageBox.Show($"Error during save and renumbering: {ex.Message}\nCheck log for details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }

                // Clear the form
                txtname.Clear();
                txtauth.Clear();
                txtpub.Clear();
                txtprice.Clear();
                txtquan.Clear();
                txtc.Clear();
            }
            catch (Exception ex)
            {
                LogMessage($"Error: {ex.Message}\nStack Trace: {ex.StackTrace}");
                MessageBox.Show($"Error: {ex.Message}\nCheck log for details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RenumberBookIds(SqlConnection con, SqlTransaction transaction)
        {
            try
            {
                // Step 1: Ensure IDENTITY_INSERT is OFF
                LogMessage("Ensuring IDENTITY_INSERT is OFF...");
                using (SqlCommand cmd = new SqlCommand("SET IDENTITY_INSERT NewBook OFF;", con, transaction))
                {
                    cmd.ExecuteNonQuery();
                }

                // Step 2: Create a temporary table to hold the current data (excluding bid)
                LogMessage("Creating temporary table...");
                using (SqlCommand cmd = new SqlCommand(
                    "SELECT bName, bAuthor, bPub, bPDate, bPrice, bQuan, bCode INTO #TempNewBook FROM NewBook;",
                    con, transaction))
                {
                    cmd.ExecuteNonQuery();
                }

                // Step 3: Truncate the NewBook table to reset the IDENTITY seed
                LogMessage("Truncating NewBook table...");
                using (SqlCommand cmd = new SqlCommand("TRUNCATE TABLE NewBook;", con, transaction))
                {
                    cmd.ExecuteNonQuery();
                }

                // Step 4: Reinsert the data, letting the IDENTITY column generate new bid values
                LogMessage("Reinserting data into NewBook...");
                using (SqlCommand cmd = new SqlCommand(
                    "INSERT INTO NewBook (bName, bAuthor, bPub, bPDate, bPrice, bQuan, bCode) " +
                    "SELECT CAST(bName AS NVARCHAR(100)), CAST(bAuthor AS NVARCHAR(100)), CAST(bPub AS NVARCHAR(100)), " +
                    "bPDate, bPrice, bQuan, CAST(bCode AS VARCHAR(20)) FROM #TempNewBook ORDER BY bName;",
                    con, transaction))
                {
                    cmd.ExecuteNonQuery();
                }

                // Step 5: Drop the temporary table
                LogMessage("Dropping temporary table...");
                using (SqlCommand cmd = new SqlCommand("DROP TABLE #TempNewBook;", con, transaction))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to renumber book IDs: {ex.Message}", ex);
            }
        }

        private void LogMessage(string message)
        {
            try
            {
                string logPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "LibraryManagementLog.txt");
                File.AppendAllText(logPath, $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {message}\n");
            }
            catch
            {
                // Ignore logging errors
            }
        }
    }
}