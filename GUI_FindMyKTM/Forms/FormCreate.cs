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

namespace GUI_FindMyKTM.Forms
{
    public partial class FormCreate : Form
    {
        public FormCreate()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            // SUBMIT BUTTON
            var report = new Report
            {
                CreatedAt = DateTime.Now,
                Description = textBoxAlasan.Text,
                Status = "Pending"
            };

            var apiUrl = "http://192.168.18.13:9000/";

            var reportData = new
            {
                statusCode = 0,
                message = "",
                data = new
                {
                    id = Guid.NewGuid().ToString(), // bingung
                    title = $"Laporan KTM {textBoxNIM.Text} - {DateTime.Now}",
                    description = report.Description,
                    status = report.Status,
                    createdAt = report.CreatedAt,
                    studentId = report.StudentId 
                }
            };

            try
            {
                
                var response = await Connection.client.PostAsJsonAsync(apiUrl, reportData); // bingung

                Console.WriteLine("Test",report.StudentId, "Texy", report.CreatedAt);
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

            // Save the report to the list
            //reports.Add(report);

            // Optionally, display a message to the user
            //MessageBox.Show("Report has been saved successfully!");

            // Clear the text fields after saving
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
