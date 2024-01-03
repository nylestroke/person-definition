using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Person
    {
        public string FirstName { get; private set; } = string.Empty;

        public string LastName { get; private set; } = string.Empty;

        public DateTime Birthday { get; private set; }

        public string Sex { get; private set; } = "Not set";

        public Person() { }

        public Person(string firstName, string lastName, DateTime birthday, string sex)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Birthday = birthday;
            this.Sex = sex;
        }

        public int GetAge()
        {
            var today = DateTime.Today;
            var age = today.Year - this.Birthday.Year;
            if (this.Birthday.Date > today.AddYears(-age)) age--;
            return age;
        }
    }
}
