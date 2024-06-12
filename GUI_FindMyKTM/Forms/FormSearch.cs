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

namespace GUI_FindMyKTM.Forms
{
    public partial class FormSearch : Form
    {
        private DataTable reportDataTable= new DataTable();

        public FormSearch()
        {
            InitializeComponent();
            InitializeReportDataTable();
            loadListLaporan();
        }

        private void InitializeReportDataTable()
        {
            reportDataTable.Columns.Add("ID", typeof(int));
            reportDataTable.Columns.Add("Title", typeof(string));
            reportDataTable.Columns.Add("NIM", typeof(string));
            reportDataTable.Columns.Add("Tanggal Pembuatan", typeof(DateTime));
        }

        private async void loadListLaporan()
        {
            List<Report> list = await ReportController.GetAllReportAsync();
            if (list != null)
            {
                int i = 1;
                foreach (var report in list)
                {

                    // Add data to DataTable
                    DataRow row = reportDataTable.NewRow();
                    row["ID"] = i;
                    row["Title"] = report.Title;
                    row["NIM"] = report.StudentId;
                    row["Tanggal Pembuatan"] = report.CreatedAt;
                    reportDataTable.Rows.Add(row);
                    i++;
                }
                DataView dvReport = reportDataTable.DefaultView;
                ListReportGrid.DataSource = dvReport.ToTable();
                ListReportGrid.Columns["ID"].Width = 50;
                ListReportGrid.Columns["Title"].Width = 200;
                ListReportGrid.Columns["NIM"].Width = 300;
                ListReportGrid.Columns["Tanggal Pembuatan"].Width = 150;
            }
            else
            {
                Console.WriteLine("No reports found or an error occurred.");
            }
        }

        private void panelTitleBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void searchField_TextChanged(object sender, EventArgs e)
        {
            string filterText = searchField.Text;
            DataView dvReport = reportDataTable.DefaultView;
            dvReport.RowFilter = string.Format("Convert(ID, 'System.String') LIKE '%{0}%' OR " +
                                               "Title LIKE '%{0}%' OR " +
                                               "NIM LIKE '%{0}%' OR " +
                                               "Convert([Tanggal Pembuatan], 'System.String') LIKE '%{0}%'", filterText);
            ListReportGrid.DataSource = dvReport.ToTable();
        }
    }
}
