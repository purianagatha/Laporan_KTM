using GUI_FindMyKTM.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUI_FindMyKTM.Reuseable;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net.Http;
using GUI_FindMyKTM.Reuseable.Controllers;

namespace GUI_FindMyKTM.Forms
{
    public partial class FormCreate : Form
    {
        private const string ReportApiUrl = "api/Report"; // Use a constant for the API URL

        public FormCreate()
        {
            InitializeComponent();
            InitializeFormFields();
        }

        // Separate method to initialize form fields
        private void InitializeFormFields()
        {
            textBoxNama.Text = AuthController.nama;
            textBoxFakultas.Text = AuthController.fakultas;
            textBoxNoHp.Text = AuthController.noHp;
            textBoxNIM.Text = AuthController.nim;
        }

        private async void ButtonSubmit_Click(object sender, EventArgs e)
        {
            var report = CreateReport();
            await SubmitReportAsync(report);
            ClearFormFields();
        }

        // Create report object from form fields
        private Report CreateReport()
        {
            return new Report
            {
                Id = Guid.NewGuid().ToString(),
                Title = "Hilang KTM",
                Description = textBoxAlasan.Text,
                Status = "Waiting",
                StudentId = AuthController.studentId,
            };
        }

        // Submit report to API
        private async Task SubmitReportAsync(Report report)
        {
            // Secure Code
            try
            {
                var response = await Connection.client.PostAsJsonAsync(ReportApiUrl, report);
                response.EnsureSuccessStatusCode();

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Report has been saved successfully!");
                }
                else
                {
                    MessageBox.Show($"Error: {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        // Clear form fields after submission
        private void ClearFormFields()
        {
            textBoxNama.Clear();
            textBoxNIM.Clear();
            textBoxFakultas.Clear();
            textBoxNoHp.Clear();
            textBoxAlasan.Clear();
        }

        private void textBoxNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNIM_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxFakultas_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNoHp_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAlasan_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
