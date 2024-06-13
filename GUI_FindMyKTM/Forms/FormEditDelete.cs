using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI_Laporan_KTM;

namespace GUI_FindMyKTM.Forms
{
    public partial class FormEditDelete : Form
    {
        StateKTM state = new StateKTM();
        private HttpClient httpClient;
        private const string apiUrl = "http://192.168.18.13:9000/api/report";
        public FormEditDelete()
        {
            InitializeComponent();
            UpdateLabel();
            LabelSelamat.Visible = false;
            PlaceHolderNama.Text = "Loading..."; // ketika awal
            httpClient = new HttpClient();
            LoadReportDetailsFromApi();

        }
        private async void LoadReportDetailsFromApi()
        {
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    var responseData = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(responseBody);

                    int dataLength = responseData.data.Count;

                    if (dataLength > 0)
                    {
                        
                        var lastReport = responseData.data[dataLength - 1]; 

                        string title = lastReport.student.name;

                        string nim = lastReport.student.nim;
                        string alasan=lastReport.student.alasan;

                        PlaceHolderNama.Text = title;
                        LabelNim.Text = nim;
                        LabelAlasan.Text = alasan;
                        
                    }
                }
                else
                {
                    PlaceHolderNama.Text = "gagal meload data"; // jika gagal meload data
                }
            }
            catch (HttpRequestException ex)
            {
                PlaceHolderNama.Text = $"Error: {ex.Message}"; // menampilkan http error
            }
            catch (Exception ex)
            {
                PlaceHolderNama.Text = $"Error: {ex.Message}"; // menampilkan expection lain
            }
        }
        private void UpdateLabel()
        {
            switch (state.currentState)
            {
                case StateKTM.PengerjaanState.BelumDiProses:
                    LabelProses.Text = "Belum di proses";
                    ButtonCari.Visible = true;
                    ButtonProses.Visible = false;
                    ButtonBermasalh.Visible = false;
                    break;
                case StateKTM.PengerjaanState.SudahDiProses:
                    LabelProses.Text = "Sudah di proses";
                    ButtonCari.Visible = false;
                    ButtonProses.Visible = true;
                    ButtonBermasalh.Visible = true;
                    break;
                case StateKTM.PengerjaanState.Bermasalah:
                    LabelProses.Text = "Bermasalah";
                    ButtonCari.Visible = false;
                   ButtonProses.Visible = true;
                    ButtonBermasalh.Visible = true;
                    break;


                case StateKTM.PengerjaanState.Selesai:
                    LabelProses.Text = "Selesai ";
                    ButtonCari.Visible = false;
                    ButtonProses.Visible = false;
                    ButtonBermasalh.Visible = false;

                    LabelSelamat.Visible = true;

                    break;
                default:
                    LabelProses.Text = "State tidak diketahui";
                    break;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {
         
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            state.ActivateTrigger(StateKTM.Trigger.Cari);
            UpdateLabel();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void LabelSelamat_Click(object sender, EventArgs e)
        {

        }

        private void ButtonCari_Click(object sender, EventArgs e)
        {
            state.ActivateTrigger(StateKTM.Trigger.Cari);
            UpdateLabel();
        }

      

        private void ButtonProsess(object sender, EventArgs e)
        {
            state.ActivateTrigger(StateKTM.Trigger.Proses);
            UpdateLabel();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void ButtonBermasalh_Click(object sender, EventArgs e)
        {
            state.ActivateTrigger(StateKTM.Trigger.Bermasalah);
            UpdateLabel();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void FormEditDelete_Load(object sender, EventArgs e)
        {

        }
    }
}