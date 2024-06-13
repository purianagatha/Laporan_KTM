using GUI_FindMyKTM.Entities;
using GUI_FindMyKTM.Reuseable;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
                listlaporan.DataSource = dvReport.ToTable();
                listlaporan.Columns["ID"].Width = 50;
                listlaporan.Columns["Title"].Width = 200;
                listlaporan.Columns["NIM"].Width = 300;
                listlaporan.Columns["Tanggal Pembuatan"].Width = 150;
            }
            else
            {
                Console.WriteLine("No reports found or an error occurred.");
            }
        }
    }
}
