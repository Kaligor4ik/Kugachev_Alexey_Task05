using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class User
    {
        public User() { }

        public User(string lastName, string firstName, string middleName, string birthDate, string age)
        {
            LastName = lastName;
            FirstName = firstName;
            MiddleName = middleName;
            BirthDate = birthDate;
            Age = age;
        }

        public string LastName { get; }
        public string FirstName { get; }
        public string MiddleName { get; }
        public string BirthDate { get; }
        public string Age { get; set; }

    }
}