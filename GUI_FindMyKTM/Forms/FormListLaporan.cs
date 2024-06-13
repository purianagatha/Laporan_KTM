using GUI_FindMyKTM.Entities;
using GUI_FindMyKTM.Reuseable;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_FindMyKTM.Forms
{
    public partial class FormListLaporan : Form
    {
        private DataTable reportDataTable = new DataTable();
        public FormListLaporan()
        {
            InitializeComponent();
            InitializeReportDataTable();
            LoadListLaporan();
        }

        private void InitializeReportDataTable()
        {
            reportDataTable.Columns.Add("ID", typeof(int));
            reportDataTable.Columns.Add("Title", typeof(string));
            reportDataTable.Columns.Add("Status", typeof(string));
            reportDataTable.Columns.Add("NIM", typeof(string));
            reportDataTable.Columns.Add("Tanggal Pembuatan", typeof(DateTime));
        }

        private async void LoadListLaporan()
        {
            try
            {
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
                        row["NIM"] = report.StudentId ?? string.Empty; // Null check
                        row["Tanggal Pembuatan"] = report.CreatedAt != DateTime.MinValue ? report.CreatedAt : DateTime.Now; // Validate date
                        reportDataTable.Rows.Add(row);
                        i++;
                    }

                    DataView dvReport = reportDataTable.DefaultView;
                    listlaporan.DataSource = dvReport.ToTable();
                    listlaporan.Columns["ID"].Width = 50;
                    listlaporan.Columns["Title"].Width = 175;
                    listlaporan.Columns["Status"].Width = 150;
                    listlaporan.Columns["NIM"].Width = 250;
                    listlaporan.Columns["Tanggal Pembuatan"].Width = 150;
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

        private void listlaporan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            // Pop up page for Create Report
            FormCreate buatlaporan = new FormCreate();
            buatlaporan.Show();
        }

        private void editdeletebtn_Click(object sender, EventArgs e)
        {
            // Pop up page for Edit Report
            FormEditDelete editlaporan = new FormEditDelete();
            editlaporan.Show();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            // Pop up page for Delete Report
            FormEditDelete deletelaporan = new FormEditDelete();
            deletelaporan.Show();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            // Pop up page for Delete Report
            FormSearch searchlaporan = new FormSearch();
            searchlaporan.Show();
        }

    }
}
