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
        public FormCreate()
        {
            InitializeComponent();
            textBoxNama.Text = AuthController.nama;
            textBoxFakultas.Text = AuthController.fakultas;
            textBoxNoHp.Text = AuthController.noHp;
            textBoxNIM.Text = AuthController.nim;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            // SUBMIT BUTTON
            Report report = new Report
            {
                Id = Guid.NewGuid().ToString(),
                Title = "Hilang KTM",
                Description = textBoxAlasan.Text,
                Status = "Waiting",
                StudentId = AuthController.studentId,
            };

            try
            {
                Console.WriteLine(textBoxAlasan.Text);
                var response = await Connection.client.PostAsJsonAsync("api/Report", report); // bingung
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
