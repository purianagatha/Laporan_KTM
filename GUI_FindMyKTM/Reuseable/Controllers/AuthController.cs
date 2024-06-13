using GUI_FindMyKTM.Entities;
using System;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI_FindMyKTM.Reuseable.Response;

namespace GUI_FindMyKTM.Reuseable.Controllers
{
    public class AuthController
    {
        public async Task LoginAsync(string emailSSO, string password)
        {
            var loginStudent = new { EmailSSO = emailSSO, Password = password };

            try
            {

                HttpResponseMessage response = await Connection.client.PostAsJsonAsync("api/auth/login", loginStudent);

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadFromJsonAsync<ResponseStudent>();
                    MessageBox.Show($"Berhasil Login!, Hallo {result.Data.Data.Name}");
                }
                else
                {
                    switch (response.StatusCode)
                    {
                        case HttpStatusCode.Unauthorized:
                            MessageBox.Show("Email dan password salah. Ulang lagi");
                            break;
                        case HttpStatusCode.BadRequest:
                            MessageBox.Show("Bad Request. Check ulang deh inputnya");
                            break;
                        case HttpStatusCode.InternalServerError:
                            MessageBox.Show("Server Error. Ulang lagi");
                            break;
                        default:
                            MessageBox.Show($"Error : {response.ReasonPhrase}");
                            break;
                    }
                }
            }
            catch (HttpRequestException httpException)
            {
                MessageBox.Show($"Request Error : {httpException.Message}");
            }
            catch (Exception e)
            {
                MessageBox.Show($"Unexpected Error : {e.Message}");
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
