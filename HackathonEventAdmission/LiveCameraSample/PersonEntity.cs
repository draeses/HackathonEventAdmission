using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveCameraSample
{
    class PersonEntity
    {
        public string FirstName { private set; get; }
        public string LastName { private set; get; }
        public string Status { private set; get; }
        public string Role { private set; get; }
        public DateTime Birthday { private set; get; }

        public PersonEntity()
        {
        }

        public PersonEntity(string firstName, string lastName, string status, string role, DateTime birthday)
        {
            FirstName = firstName;
            LastName = lastName;
            Status = status;
            Role = role;
            Birthday = birthday;
        }
    }
}
