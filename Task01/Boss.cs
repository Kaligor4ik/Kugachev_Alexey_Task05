using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Boss: User
    {
        public Boss(string lastName, string firstName, string middleName, string birthDate, string age)
            :base(lastName, firstName, middleName, birthDate, age)
        {
        }

        public string Position { get; }
        public string Experience { get; set; }
        public string Status { get; }

        public void Punish(Employee e, String status)
        {
            e.Status = status;
        }
    }
}
