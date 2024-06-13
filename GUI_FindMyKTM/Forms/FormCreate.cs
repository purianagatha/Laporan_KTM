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
            // Ketika tombol submit diklik, fungsi ini akan dieksekusi

            // Membuat objek report baru dengan data dari input pengguna
            Report report = new Report
            {
                Id = Guid.NewGuid().ToString(),  // Menghasilkan ID unik baru untuk laporan
                Title = "Hilang KTM",  // Judul tetap untuk laporan
                Description = textBoxAlasan.Text,  // Mengambil alasan dari teks box alasan
                Status = "Waiting",  // Status awal laporan
                StudentId = AuthController.studentId,  // Menggunakan ID mahasiswa dari AuthController
            };

            try
            {
                Console.WriteLine(textBoxAlasan.Text);  // Menampilkan alasan ke dalam console

                // Mengirimkan objek report ke endpoint "api/Report" sebagai JSON secara asynchronous
                var response = await Connection.client.PostAsJsonAsync("api/Report", report);
                response.EnsureSuccessStatusCode();  // Memastikan request berhasil

                if (response.IsSuccessStatusCode)
                {
                    // Menampilkan pesan sukses jika laporan berhasil disimpan
                    MessageBox.Show("Report has been saved successfully!");
                }
                else
                {
                    // Menampilkan pesan error jika gagal menyimpan laporan bersama dengan alasan error
                    MessageBox.Show($"Error: {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                // Menampilkan pesan error jika terjadi exception saat mengirimkan laporan
                MessageBox.Show($"An error occurred: {ex.Message}");
            }

            // Mengosongkan kolom input setelah laporan berhasil atau gagal disimpan
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
