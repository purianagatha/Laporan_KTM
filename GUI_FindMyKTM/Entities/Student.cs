using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_FindMyKTM.Entities
{
    internal class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string userName { get; set; }
        public string EmailSSO { get; set; }
        public string Nim { get; set; }
        public string Password { get; set; }
        public string Faculty { get; set; }
        public string Phone { get; set; }
        public Report Report { get; set; }
    }
}
