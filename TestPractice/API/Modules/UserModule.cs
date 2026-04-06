using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Modules
{
   public class UserModule
    {
        public long Id { get; set; }

        public string Username { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Phone { get; set; }

        public int UserStatus { get; set; }

        public DateTime CreatedAt { get; set; }

        public Dictionary<string, string> Metadata { get; set; }
    }
}
