using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Employee: User
    {
        private string _status = "работает";
        public Employee(string position, string experience, string lastName, string firstName, string middleName, string birthDate, string age)
            : base(lastName, firstName, middleName, birthDate, age)
        {
            Position = position;
            Experience = experience;
        }

        public string Position { get; set; }
        public string Experience { get; set; }
        public string Status { get => _status; set => _status = value; }
    }
}
