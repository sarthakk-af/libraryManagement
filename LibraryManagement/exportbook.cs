using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class exportbook : Form
    {
        public exportbook()
        {
            InitializeComponent();
        }

        private void load_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection("data source=HARI\\SQLEXPRESS; database=library1; integrated security=True"))
                {
                    con.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM NewBook", con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to cancel and close this window?",
                "Confirm Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void export_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No data available to export.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Export Data";
            saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx|CSV Files (*.csv)|*.csv|All Files (*.*)|*.*";
            saveFileDialog.FileName = "BooksExport";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (saveFileDialog.FilterIndex == 1)
                    {
                        // Export to Excel
                        using (var workbook = new ClosedXML.Excel.XLWorkbook())
                        {
                            var worksheet = workbook.Worksheets.Add("Books");

                            // Add column headers
                            for (int i = 0; i < dataGridView1.Columns.Count; i++)
                            {
                                worksheet.Cell(1, i + 1).Value = dataGridView1.Columns[i].HeaderText;
                            }

                            // Add rows
                            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                            {
                                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                                {
                                    worksheet.Cell(i + 2, j + 1).Value = Convert.ToString(dataGridView1.Rows[i].Cells[j].Value);
                                }
                            }


                            workbook.SaveAs(saveFileDialog.FileName);
                        }
                    }
                    else
                    {
                        // Export to CSV
                        using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                        {
                            // Column headers
                            var headers = dataGridView1.Columns.Cast<DataGridViewColumn>();
                            sw.WriteLine(string.Join(",", headers.Select(column => "\"" + column.HeaderText + "\"")));

                            // Data rows
                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                if (!row.IsNewRow)
                                {
                                    var cells = row.Cells.Cast<DataGridViewCell>();
                                    sw.WriteLine(string.Join(",", cells.Select(cell => "\"" + cell.Value?.ToString() + "\"")));
                                }
                            }
                        }
                    }

                    MessageBox.Show("Data exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error exporting data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
