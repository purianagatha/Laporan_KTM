using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using GUI_FindMyKTM.Entities;

namespace GUI_FindMyKTM.Reuseable
{
    public static class ReportController
    {
        public class DefaultResponse<T>
        {
            public int StatusCode { get; set; }
            public string Message { get; set; }
            public T Data { get; set; }
        }
        public static async Task<List<Report>> GetAllReportAsync()
        {
            HttpResponseMessage response = await Connection.client.GetAsync("api/Report");
            if (response.IsSuccessStatusCode)
            {
                // Read and deserialize the response content
                var reportsResponse = await response.Content.ReadFromJsonAsync<DefaultResponse<IEnumerable<Report>>>();

                if (reportsResponse != null && reportsResponse.Data != null)
                {
                    // Process the collection of reports
                    List<Report> reports = (List<Report>)reportsResponse.Data;
                    foreach (var report in reports)
                    {
                        Console.WriteLine($"Report ID: {report.Id}, Report Name: {report.Title}");
                        // Process each report as needed
                    }
                    return reports;
                }

            }
            return null;
        }
    }
}
