using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordStore.Core.Entities
{
    public class User : BaseEntity
    {
        public User(string fullName, string email, string password, string phone )
        {
            FullName = fullName;
            Email = email;
            Password = password;
            Phone = phone;
        }

        public string FullName { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public string Phone { get; private set; }
        public string Role { get; private set; }
        public List<Order> Orders { get; private set; }
        public List<Record> Records { get; private set; }
        
    }
}
