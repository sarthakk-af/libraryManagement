using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class ViewBook : Form
    {
        private readonly string connectionString = "data source=HARI\\SQLEXPRESS; database=library1; integrated security=True";
        private readonly System.Windows.Forms.Timer searchTimer; // Explicitly use Windows Forms Timer
        private int bid;
        private int rowid; // Changed to int to match SQL Server INT type

        public ViewBook()
        {
            InitializeComponent();
            searchTimer = new System.Windows.Forms.Timer { Interval = 300 };
            searchTimer.Tick += SearchTimer_Tick;
        }

        private void ViewBook_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            RefreshGridView();
        }

        private void txtbkn_TextChanged(object sender, EventArgs e)
        {
            // Debounce search: wait 300ms after last keystroke
            searchTimer.Stop();
            searchTimer.Start();
        }

        private void SearchTimer_Tick(object sender, EventArgs e)
        {
            searchTimer.Stop(); // Stop the timer to prevent multiple triggers
            PerformSearch();
        }

        private void PerformSearch()
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtbkn.Text))
                {
                    using (var con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        string query = "SELECT * FROM NewBook WHERE bName LIKE @bname";
                        using (var cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@bname", txtbkn.Text.Trim() + "%");
                            using (var ad = new SqlDataAdapter(cmd))
                            {
                                var ds = new DataSet();
                                ad.Fill(ds);
                                dataGridView1.DataSource = ds.Tables[0];
                            }
                        }
                    }
                }
                else
                {
                    RefreshGridView();
                }
            }
            catch (Exception ex)
            {
                LogMessage($"Error searching books: {ex.Message}\nStackTrace: {ex.StackTrace}");
                MessageBox.Show($"Error searching books: {ex.Message}\nCheck log for details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dataGridView1.Rows[e.RowIndex].Cells[0].Value == null)
                return;

            try
            {
                bid = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                panel2.Visible = true;

                using (var con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (var cmd = new SqlCommand("SELECT * FROM NewBook WHERE bid = @bid", con))
                    {
                        cmd.Parameters.AddWithValue("@bid", bid);
                        using (var ad = new SqlDataAdapter(cmd))
                        {
                            var ds = new DataSet();
                            ad.Fill(ds);

                            if (ds.Tables[0].Rows.Count > 0)
                            {
                                var row = ds.Tables[0].Rows[0];
                                rowid = Convert.ToInt32(row["bid"]);
                                txtbook.Text = row["bName"].ToString();
                                txtauthn.Text = row["bAuthor"].ToString();
                                txtpu.Text = row["bPub"].ToString();
                                dateTimePicker1.Value = row["bPDate"] == DBNull.Value ? DateTime.Today : Convert.ToDateTime(row["bPDate"]);
                                txtp.Text = row["bPrice"].ToString();
                                txtq.Text = row["bQuan"].ToString();
                                txtco.Text = row["bCode"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LogMessage($"Error loading book details: {ex.Message}\nStackTrace: {ex.StackTrace}");
                MessageBox.Show($"Error loading book details: {ex.Message}\nCheck log for details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                panel2.Visible = false;
            }
        }

        private void btnup_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to update this book?", "Confirm Update", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                return;

            try
            {
                if (string.IsNullOrWhiteSpace(txtbook.Text) || string.IsNullOrWhiteSpace(txtauthn.Text) ||
                    string.IsNullOrWhiteSpace(txtpu.Text) || string.IsNullOrWhiteSpace(txtco.Text))
                {
                    MessageBox.Show("All fields are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!decimal.TryParse(txtp.Text, out decimal price) || price < 0)
                {
                    MessageBox.Show("Price must be a valid non-negative number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(txtq.Text, out int quantity) || quantity < 0)
                {
                    MessageBox.Show("Quantity must be a valid non-negative integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (var con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (var transaction = con.BeginTransaction())
                    {
                        try
                        {
                            // Update the book
                            string query = "UPDATE NewBook SET bName = @bname, bAuthor = @bauth, bPub = @bpub, bPDate = @bdate, bPrice = @price, bQuan = @quan, bCode = @bco WHERE bid = @bid";
                            using (var cmd = new SqlCommand(query, con, transaction))
                            {
                                cmd.Parameters.AddWithValue("@bname", txtbook.Text.Trim());
                                cmd.Parameters.AddWithValue("@bauth", txtauthn.Text.Trim());
                                cmd.Parameters.AddWithValue("@bpub", txtpu.Text.Trim());
                                cmd.Parameters.AddWithValue("@bdate", dateTimePicker1.Value);
                                cmd.Parameters.AddWithValue("@price", price);
                                cmd.Parameters.AddWithValue("@quan", quantity);
                                cmd.Parameters.AddWithValue("@bco", txtco.Text.Trim());
                                cmd.Parameters.AddWithValue("@bid", rowid);
                                cmd.ExecuteNonQuery();
                            }

                            // Renumber IDs
                            RenumberBookIds(con, transaction);
                            transaction.Commit();
                            MessageBox.Show("Book updated and IDs renumbered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            LogMessage($"Error during update or renumbering: {ex.Message}\nStackTrace: {ex.StackTrace}");
                            MessageBox.Show($"Error updating book or renumbering IDs: {ex.Message}\nCheck log for details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }

                RefreshGridView();
                panel2.Visible = false;
                dataGridView1.ClearSelection();
            }
            catch (Exception ex)
            {
                LogMessage($"Error: {ex.Message}\nStackTrace: {ex.StackTrace}");
                MessageBox.Show($"Error: {ex.Message}\nCheck log for details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this book? This action cannot be undone.", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK)
                return;

            try
            {
                using (var con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (var transaction = con.BeginTransaction())
                    {
                        try
                        {
                            // Delete the book
                            using (var cmd = new SqlCommand("DELETE FROM NewBook WHERE bid = @bid", con, transaction))
                            {
                                cmd.Parameters.AddWithValue("@bid", rowid);
                                cmd.ExecuteNonQuery();
                            }

                            // Renumber IDs
                            RenumberBookIds(con, transaction);
                            transaction.Commit();
                            MessageBox.Show("Book deleted and IDs renumbered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            LogMessage($"Error during deletion or renumbering: {ex.Message}\nStackTrace: {ex.StackTrace}");
                            MessageBox.Show($"Error deleting book or renumbering IDs: {ex.Message}\nCheck log for details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }

                RefreshGridView();
                panel2.Visible = false;
                dataGridView1.ClearSelection();
            }
            catch (Exception ex)
            {
                LogMessage($"Error: {ex.Message}\nStackTrace: {ex.StackTrace}");
                MessageBox.Show($"Error deleting book: {ex.Message}\nCheck log for details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnref_Click(object sender, EventArgs e)
        {
            txtbkn.Clear();
            panel2.Visible = false;
            RefreshGridView();
            dataGridView1.ClearSelection();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            dataGridView1.ClearSelection();
        }

        private void RefreshGridView()
        {
            try
            {
                using (var con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT * FROM NewBook ORDER BY bid";
                    using (var ad = new SqlDataAdapter(query, con))
                    {
                        var ds = new DataSet();
                        ad.Fill(ds);
                        dataGridView1.DataSource = ds.Tables[0];
                    }
                }
            }
            catch (Exception ex)
            {
                LogMessage($"Error refreshing grid: {ex.Message}\nStackTrace: {ex.StackTrace}");
                MessageBox.Show($"Error refreshing grid: {ex.Message}\nCheck log for details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RenumberBookIds(SqlConnection con, SqlTransaction transaction)
        {
            try
            {
                // Create temporary table to store existing data
                using (var cmd = new SqlCommand(
                    @"SELECT bName, bAuthor, bPub, bPDate, bPrice, bQuan, bCode 
                    INTO #TempNewBook FROM NewBook ORDER BY bName;",
                    con, transaction))
                {
                    cmd.ExecuteNonQuery();
                }

                // Truncate the original table to reset IDENTITY
                using (var cmd = new SqlCommand("TRUNCATE TABLE NewBook;", con, transaction))
                {
                    cmd.ExecuteNonQuery();
                }

                // Re-insert data into NewBook
                using (var cmd = new SqlCommand(
                    @"INSERT INTO NewBook (bName, bAuthor, bPub, bPDate, bPrice, bQuan, bCode)
                    SELECT CAST(bName AS NVARCHAR(100)), CAST(bAuthor AS NVARCHAR(100)), 
                           CAST(bPub AS NVARCHAR(100)), bPDate, bPrice, bQuan, CAST(bCode AS VARCHAR(20))
                    FROM #TempNewBook ORDER BY bName;",
                    con, transaction))
                {
                    cmd.ExecuteNonQuery();
                }

                // Drop the temporary table
                using (var cmd = new SqlCommand("DROP TABLE #TempNewBook;", con, transaction))
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
            catch (Exception ex)
            {
                try
                {
                    System.Diagnostics.EventLog.WriteEntry("LibraryManagement", $"Failed to write to log file: {ex.Message}\nOriginal message: {message}", System.Diagnostics.EventLogEntryType.Error);
                }
                catch
                {
                    // Silent fail
                }
            }
        }
    }
}