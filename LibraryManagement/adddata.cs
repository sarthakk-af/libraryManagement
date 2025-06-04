using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;
using System.IO;
using System.Data.SqlClient;
using ClosedXML.Excel;

namespace LibraryManagement
{
    public partial class adddata : Form
    {
        public adddata()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Excel Files|*.xlsx;*.xls|CSV files|*.csv";
                dialog.Title = "Select a File";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = dialog.FileName;

                    // Set file path in the textbox
                    txtFile.Text = Path.GetFileName(filePath);

                    DataTable dt;

                    if (filePath.EndsWith(".csv"))
                    {
                        dt = GetDataTableFromCSV(filePath);
                    }
                    else
                    {
                        dt = GetDataTableFromExcel(filePath);
                    }

                    if (dt.Columns.Contains("bid") && dt.Columns.Contains("bName") && dt.Columns.Contains("bAuthor") &&
                        dt.Columns.Contains("bPub") && dt.Columns.Contains("bPDate") && dt.Columns.Contains("bPrice") && dt.Columns.Contains("bQuan"))
                    {
                        dataGridView1.DataSource = dt;
                        MessageBox.Show("File data loaded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("File does not contain required columns: bid, bName, bAuthor, bPub, bPDate, bPrice, bQuan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private DataTable GetDataTableFromCSV(string csvFilePath)
        {
            DataTable csvData = new DataTable();
            try
            {
                using (TextFieldParser csvReader = new TextFieldParser(csvFilePath))
                {
                    csvReader.SetDelimiters(new string[] { "," });
                    csvReader.HasFieldsEnclosedInQuotes = true;

                    string[] colFields = csvReader.ReadFields();
                    foreach (string column in colFields)
                    {
                        DataColumn datecolumn = new DataColumn(column);
                        datecolumn.AllowDBNull = true;
                        csvData.Columns.Add(datecolumn);
                    }

                    while (!csvReader.EndOfData)
                    {
                        string[] fieldData = csvReader.ReadFields();
                        for (int i = 0; i < fieldData.Length; i++)
                        {
                            if (fieldData[i] == "")
                            {
                                fieldData[i] = null;
                            }
                        }
                        csvData.Rows.Add(fieldData);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while reading CSV: " + ex.Message);
            }
            return csvData;
        }

        private DataTable GetDataTableFromExcel(string path)
        {
            DataTable dt = new DataTable();

            try
            {
                using (var workbook = new XLWorkbook(path))
                {
                    var worksheet = workbook.Worksheets.First();
                    bool firstRow = true;
                    foreach (var row in worksheet.RowsUsed())
                    {
                        if (firstRow)
                        {
                            foreach (var cell in row.CellsUsed())
                            {
                                string colName = cell.GetString().Trim();
                                if (string.IsNullOrEmpty(colName))
                                    colName = "Column" + (dt.Columns.Count + 1);
                                dt.Columns.Add(colName);
                            }
                            firstRow = false;
                        }
                        else
                        {
                            var newRow = dt.NewRow();
                            int colIndex = 0;

                            foreach (var cell in row.Cells(1, dt.Columns.Count))
                            {
                                // Use IsEmpty() or check for null safely
                                if (cell.IsEmpty())
                                    newRow[colIndex] = DBNull.Value; // Assign DBNull if the cell is empty
                                else
                                    newRow[colIndex] = cell.Value.ToString(); // Convert to string if the cell is not empty

                                colIndex++;
                            }

                            dt.Rows.Add(newRow);
                        }
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading Excel: " + ex.Message);
            }

            return dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to close the form?",
                                                  "Confirmation",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close(); // Close the form if user clicks Yes
            }
            // No need to do anything if user clicks No (the form stays open)
        }


        private bool ValidateRow(DataGridViewRow row, out string errorMessage)
        {
            errorMessage = "";
            row.DefaultCellStyle.BackColor = Color.White; // Reset any previous highlights

            // Check required string fields
            string[] stringFields = { "bName", "bAuthor", "bPub" };
            foreach (var field in stringFields)
            {
                var value = row.Cells[field].Value?.ToString();
                if (string.IsNullOrWhiteSpace(value))
                {
                    errorMessage = $"Field '{field}' cannot be empty.";
                    row.DefaultCellStyle.BackColor = Color.LightCoral;
                    return false;
                }
            }

            // Check valid date
            if (!DateTime.TryParse(row.Cells["bPDate"].Value?.ToString(), out _))
            {
                errorMessage = "Invalid date format in 'bPDate'.";
                row.DefaultCellStyle.BackColor = Color.LightCoral;
                return false;
            }

            // Check valid bigint fields
            string[] numericFields = { "bPrice", "bQuan" };
            foreach (var field in numericFields)
            {
                if (!long.TryParse(row.Cells[field].Value?.ToString(), out _))
                {
                    errorMessage = $"Field '{field}' must be a valid number.";
                    row.DefaultCellStyle.BackColor = Color.LightCoral;
                    return false;
                }
            }

            return true; // All checks passed
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No data available to save. Please load a file first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source=HARI\\SQLEXPRESS; database=library1; integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.IsNewRow) continue;

                    if (!ValidateRow(row, out string error))
                    {
                        MessageBox.Show($"Row {row.Index + 1} Error: {error}", "Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        continue;
                    }

                    long price = 0;
                    long quan = 0;
                   
                    string bname = row.Cells["bName"].Value?.ToString();
                    string bauth = row.Cells["bAuthor"].Value?.ToString();
                    string bpub = row.Cells["bPub"].Value?.ToString();
                    string bdate = Convert.ToDateTime(row.Cells["bPDate"].Value).ToString("yyyy-MM-dd");
                    long.TryParse(row.Cells["bPrice"].Value?.ToString(), out price);
                    long.TryParse(row.Cells["bQuan"].Value?.ToString(), out quan);

                    cmd.CommandText = $"INSERT INTO NewBook (bName, bAuthor, bPub, bPDate, bPrice, bQuan) " +
                                      $"VALUES (@bname, @bauth, @bpub, @bdate, @price, @quan)";

                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@bname", bname);
                    cmd.Parameters.AddWithValue("@bauth", bauth);
                    cmd.Parameters.AddWithValue("@bpub", bpub);
                    cmd.Parameters.AddWithValue("@bdate", bdate);
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.Parameters.AddWithValue("@quan", quan);

                    cmd.ExecuteNonQuery();
                }

                con.Close();
                MessageBox.Show("All data saved to the database successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while saving: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtFile_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
