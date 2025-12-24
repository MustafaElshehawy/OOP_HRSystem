using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HRSystem
{
    internal abstract class Person
    {
        public string FirstName { get; private set; } //automatic property
        public string LastName { get; private set; }

        public void SetName(string firstName, string lastName)
        {
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
                throw new ArgumentException("Invaild Name");

            FirstName = firstName;
            LastName = lastName;
        }

        private DateOnly _birthDate;
        public DateOnly BirthDate //nourmal property
        {
            get
            {
                return _birthDate;
            }
            set
            {
                if (value < new DateOnly(2002, 4, 10))
                    throw new ArgumentException("Invaild birth date");
                _birthDate = value;
            }

        }
    }
}
