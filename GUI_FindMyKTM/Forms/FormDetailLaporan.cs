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
    public partial class FormDetailLaporan : Form
    {
        public FormDetailLaporan()
        {
            InitializeComponent();
        }

        private void linktonama_Click(object sender, EventArgs e)
        {

        }

        public void LoadReportDetails(int id, string title, string nim, DateTime createdAt, string status)
        {
            //labelstudentid.Text = id.ToString();
            labeltitle.Text = title;
            labelstudentid.Text = nim;
            //txtCreatedAt.Text = createdAt.ToString("g"); // General date/time pattern
            labelstatus.Text = status;
        }

    }
}
