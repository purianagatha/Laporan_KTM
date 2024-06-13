using GUI_FindMyKTM.Entities;
using GUI_FindMyKTM.Reuseable;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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

        public async Task LoadReportDetailsAsync(int id, string title, string nim, DateTime createdAt, string status, string description)
        {
            try
            {
                // Secure Code: Validate input parameters
                if (string.IsNullOrEmpty(title))
                    throw new ArgumentException("Title cannot be null or empty.");
                if (string.IsNullOrEmpty(nim))
                    throw new ArgumentException("NIM cannot be null or empty.");
                if (string.IsNullOrEmpty(status))
                    throw new ArgumentException("Status cannot be null or empty.");
                if (string.IsNullOrEmpty(description))
                    throw new ArgumentException("Description cannot be null or empty.");

                // Secure Code: Update UI on the main thread
                if (InvokeRequired)
                {
                    Invoke(new Action(() => UpdateLabels(title, nim, createdAt, status, description)));
                }
                else
                {
                    UpdateLabels(title, nim, createdAt, status, description);
                }
            }
            catch (Exception ex)
            {
                // Secure Code: Handle exceptions and provide user feedback
                MessageBox.Show($"Error loading report details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateLabels(string title, string nim, DateTime createdAt, string status, string description)
        {
            // Clean Code: Separate method to update labels
            labeltitle.Text = title;
            labelstudentid.Text = nim;
            labelcreatedat.Text = createdAt.ToString("g"); // General date/time pattern
            labelstatus.Text = status;
            labeldescription.Text = description;
        }

        private void linktonama_Click(object sender, EventArgs e)
        {
             
        }


        private void labeltitle_Click(object sender, EventArgs e)
        {

        }

        private void labelcreatedat_Click(object sender, EventArgs e)
        {

        }

        private void labelnama_Click(object sender, EventArgs e)
        {

        }

        private void labeldescription_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
