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
            // Clean Code: Initialize DataTable columns

            reportDataTable.Columns.Add("ID", typeof(int));
            reportDataTable.Columns.Add("Title", typeof(string));
            reportDataTable.Columns.Add("Status", typeof(string));
            reportDataTable.Columns.Add("studentID", typeof(string));
            reportDataTable.Columns.Add("Description", typeof(string)); 
            reportDataTable.Columns.Add("Tanggal Pembuatan", typeof(DateTime));
        }

        private async void LoadListLaporan()
        {
            try
            {
                var reports = await ReportController.GetAllReportAsync();
                if (reports != null && reports.Any())
                {
                    PopulateDataTable(reports);
                }
                else
                {
                    MessageBox.Show("No reports found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (HttpRequestException ex)
            {
                // Secure Code: Handle network-related exceptions

                MessageBox.Show($"Network error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Secure Code: Handle general exceptions

                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateDataTable(IEnumerable<Report> reports)
        {
            // Clean Code: Separate method to populate DataTable

            int i = 1;
            foreach (var report in reports)
            {
                DataRow row = reportDataTable.NewRow();
                row["ID"] = i;
                row["Title"] = report.Title ?? string.Empty; // Secure Code: Null check
                row["Status"] = report.Status ?? string.Empty; // Secure Code: Null check
                row["StudentID"] = report.StudentId ?? string.Empty; // Secure Code: Null check
                row["Description"] = report.Description ?? string.Empty; // Secure Code: Null check
                row["Tanggal Pembuatan"] = report.CreatedAt != DateTime.MinValue ? report.CreatedAt : DateTime.Now; // Secure Code: Validate date
                reportDataTable.Rows.Add(row);
                i++;
            }

            DataView dvReport = reportDataTable.DefaultView;
            listlaporan.DataSource = dvReport.ToTable();
            ConfigureDataGridView();
        }

        private void ConfigureDataGridView()
        {
            // Clean Code: Configure DataGridView columns

            listlaporan.Columns["ID"].Width = 50;
            listlaporan.Columns["Title"].Width = 175;
            listlaporan.Columns["Status"].Width = 150;
            listlaporan.Columns["StudentID"].Width = 250;
            listlaporan.Columns["Description"].Width = 150;
            listlaporan.Columns["Tanggal Pembuatan"].Width = 150;
        }

        private void listlaporan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Clean Code: Check if the click is not on the header row

            if (e.RowIndex >= 0)
            {
                var selectedRow = listlaporan.Rows[e.RowIndex];
                int reportId = Convert.ToInt32(selectedRow.Cells["ID"].Value);
                string title = selectedRow.Cells["Title"].Value.ToString();
                string status = selectedRow.Cells["Status"].Value.ToString();
                string studentId = selectedRow.Cells["StudentID"].Value.ToString();
                DateTime createdAt = Convert.ToDateTime(selectedRow.Cells["Tanggal Pembuatan"].Value);
                string description = selectedRow.Cells["Description"].Value.ToString();

                ShowReportDetails(reportId, title, studentId, createdAt, status, description);
            }
        }

        private void ShowReportDetails(int reportId, string title, string studentId, DateTime createdAt, string status, string description)
        {
            // Clean Code: Separate method to show report details

            var reportDetailsForm = new FormDetailLaporan();
            reportDetailsForm.LoadReportDetailsAsync(reportId, title, studentId, createdAt, status, description);
            reportDetailsForm.ShowDialog();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            ShowForm(new FormCreate());
        }

        private void editdeletebtn_Click(object sender, EventArgs e)
        {
            ShowForm(new FormEditDelete());
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            ShowForm(new FormEditDelete());
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            ShowForm(new FormSearch());
        }

        private void ShowForm(Form form)
        {
            // Clean Code: Reusable method to show forms

            form.Show();
        }

    }
}
