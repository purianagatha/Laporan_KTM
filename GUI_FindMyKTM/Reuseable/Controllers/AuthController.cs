using GUI_FindMyKTM.Entities;
using System;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace GUI_FindMyKTM.Reuseable.Controllers
{
    public class AuthController
    {
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

            HttpResponseMessage response = await Connection.client.PostAsJsonAsync("api/auth/register", student);

            try
            {
                
                var responseBody = await response.Content.ReadFromJsonAsync<Student>();
                Console.WriteLine(responseBody);
                response.EnsureSuccessStatusCode();

            } catch (HttpRequestException e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
}
