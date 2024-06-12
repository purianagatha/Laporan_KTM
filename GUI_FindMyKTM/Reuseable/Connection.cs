using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Json;
using System.Net.Http.Headers;

namespace GUI_FindMyKTM.Reuseable
{
    public static class Connection
    {
        static public HttpClient client = new HttpClient();
        public static void Connect(string baseUrl)
        {
            client.BaseAddress = new Uri(baseUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }
        
    }
}