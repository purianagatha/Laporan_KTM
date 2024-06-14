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
    public partial class FormProfile : Form
    {
        private HttpClient httpClient;
        private const string apiUrl = "http://192.168.18.13:9000/api/report";
        public FormProfile()
        {
            InitializeComponent();
            LoadReportDetailsFromApi();
            httpClient = new HttpClient();
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
                        string alasan = lastReport.student.alasan;

                        // tempatFakultas = lastReport.student.faculty;
                        tempatNama.Text = lastReport.student.name;
                        tempatNim.Text = lastReport.student.nim;

                    }
                }
                else
                {
                    tempatNim.Text = "gagal meload data"; // jika gagal meload data
                }
            }
            catch (HttpRequestException ex)
            {
                tempatNim.Text = $"Error: {ex.Message}";
            }
            catch (Exception ex)
            {
                tempatNim.Text = $"Error: {ex.Message}";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FormProfile_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }
    }
}
