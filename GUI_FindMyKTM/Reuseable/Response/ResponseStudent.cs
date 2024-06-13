using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_FindMyKTM.Reuseable.Response
{
    public class ResponseStudent
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public DataWrapper Data { get; set; }
    }

    public class DataWrapper
    {
        public UserData Data { get; set; }
    }

    public class UserData
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string EmailSSO { get; set; }
        public string Nim { get; set; }
        public string Password { get; set; }
        public string Faculty { get; set; }
        public string Phone { get; set; }
        public string Report { get; set; }
        public string UserName { get; set; }
        public string NormalizedUserName { get; set; }
        public string Email { get; set; }
        public string NormalizedEmail { get; set; }
        public bool EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string ConcurrencyStamp { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public DateTime? LockoutEnd { get; set; }
        public bool LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }
    }
}
