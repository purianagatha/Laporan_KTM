using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Json;
using System.Net.Http.Headers;
using GUI_FindMyKTM.Entities;
using GUI_FindMyKTM.Reuseable;
using GUI_FindMyKTM.Forms;

namespace GUI_FindMyKTM
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string baseUrl = "http://localhost:9000/"; //sesuain ip api kalian
            Connection.Connect(baseUrl);
            Console.WriteLine(Connection.client.BaseAddress);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormAuthentication());
        }
    }
}
