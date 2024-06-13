using GUI_FindMyKTM.Entities;
using System;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_FindMyKTM.Reuseable.Controllers
{
    public class AuthController
    {
        public async Task LoginAsync(string emailSSO, string password)
        {
            var loginStudent = new { EmailSSO = emailSSO, Password = password };

            HttpResponseMessage response = await Connection.client.PostAsJsonAsync("api/auth/login", loginStudent);

            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                MessageBox.Show($"Berhasil Login!, Hallo {emailSSO}");
            }
        }
        public async Task RegisterAsync(Student objStudent)
        {
            Student student = new Student()
            {
                EmailSSO = objStudent.EmailSSO,
                Name = objStudent.Name,
                userName = objStudent.userName,
                Nim = objStudent.Nim,
                Phone = objStudent.Phone,
                Password = objStudent.Password,
                Faculty = objStudent.Faculty,
                Report = objStudent.Report,
                Id = objStudent.Id,
            };

            try
            {

                HttpResponseMessage response = await Connection.client.PostAsJsonAsync("api/auth/register", student);
                var responseBody = await response.Content.ReadFromJsonAsync<Student>();
                Console.WriteLine(responseBody);
                response.EnsureSuccessStatusCode();

            } catch (HttpRequestException e)
            {
                Console.WriteLine("Controller Error : ", e.Message);
                throw;
            }
        }
    }
}
