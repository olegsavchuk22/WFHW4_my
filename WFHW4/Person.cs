using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFHW4
{
    public class Person
    {
        public string firstName;
        public string lastName;
        public DateTime birthDate;
        public string country;
        public string city;
        public string sex;

        public Person()
        {
            this.firstName = string.Empty;
            this.lastName = string.Empty;
            this.birthDate = new DateTime();
            this.country = string.Empty;
            this.city = string.Empty;
            this.sex = string.Empty;
        }
        public Person(string firstName, string lastName, DateTime birthDate, string country, string city, string sex)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthDate = birthDate;
            this.country = country;
            this.city = city;
            this.sex = sex;
        }

        public override string ToString()
        {
            return $"{this.firstName}, {this.lastName}, {this.birthDate.ToShortDateString()}, {this.country}, {this.city}, {this.sex}";
        }
        public string ToShortString()
        {
            return $"{this.firstName}, {this.lastName}"; 
        }
    }
}
