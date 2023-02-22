using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordStore.Core.Entities
{
    public class User : BaseEntity
    {
        public User(string fullName, string email, string password)
        {
            FullName = fullName;
            Email = email;
            Password = password;
        }

        public string FullName { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
    }
}
