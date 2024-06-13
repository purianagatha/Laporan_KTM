using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI_FindMyKTM.Reuseable;
using GUI_FindMyKTM.Entities;
using System.Net.Http;

namespace GUI_FindMyKTM.Forms
{
    public partial class FormSearch : Form
    {
        private DataTable reportDataTable= new DataTable();

        public FormSearch()
        {
            // Table Initilisation and load list reports from api
            InitializeComponent();
            InitializeReportDataTable();
            loadListLaporan();
        }

        private void InitializeReportDataTable()
        {
            // Add collumns to table
            reportDataTable.Columns.Add("ID", typeof(int));
            reportDataTable.Columns.Add("Title", typeof(string));
            reportDataTable.Columns.Add("Status", typeof(string));
            reportDataTable.Columns.Add("NIM", typeof(string));
            reportDataTable.Columns.Add("Tanggal Pembuatan", typeof(DateTime));
        }

        private async void loadListLaporan()
        {
            try
            {
                // Get reports from api
                List<Report> list = await ReportController.GetAllReportAsync();
                if (list != null && list.Any())
                {
                    int i = 1;
                    foreach (var report in list)
                    {
                        // Add data to DataTable with validation
                        DataRow row = reportDataTable.NewRow();
                        row["ID"] = i;
                        row["Title"] = report.Title ?? string.Empty;  // Null check
                        row["Status"] = report.Status ?? string.Empty; // Null check for Status
                        row["NIM"] = report.Student.Nim ?? string.Empty; // Null check
                        row["Tanggal Pembuatan"] = report.CreatedAt != DateTime.MinValue ? report.CreatedAt : DateTime.Now; // Validate date
                        reportDataTable.Rows.Add(row);
                        i++;
                    }
                    // Convert table to grid view
                    DataView dvReport = reportDataTable.DefaultView;
                    ListReportGrid.DataSource = dvReport.ToTable();
                    ListReportGrid.Columns["ID"].Width = 50;
                    ListReportGrid.Columns["Title"].Width = 175;
                    ListReportGrid.Columns["Status"].Width = 150;
                    ListReportGrid.Columns["NIM"].Width = 200;
                    ListReportGrid.Columns["Tanggal Pembuatan"].Width = 150;
                }
                else
                {
                    MessageBox.Show("No reports found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Network error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panelTitleBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void searchField_TextChanged(object sender, EventArgs e)
        {
            string filterText = searchField.Text;
            // Convert table to DataView
            DataView dvReport = reportDataTable.DefaultView;
            // Filter based on all collumns
            dvReport.RowFilter = string.Format("Convert(ID, 'System.String') LIKE '%{0}%' OR " +
                                               "Title LIKE '%{0}%' OR " +
                                               "NIM LIKE '%{0}%' OR " +
                                               "Convert([Tanggal Pembuatan], 'System.String') LIKE '%{0}%'", filterText);
            // Convert from Dataview to GridView
            ListReportGrid.DataSource = dvReport.ToTable();
        }
    }
}
