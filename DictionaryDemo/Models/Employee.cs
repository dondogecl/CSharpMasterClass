using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryDemo.Models
{
    public class Employee
    {
        // properties
        public string Role { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public float Rate { get; set; }

        public float Salary {
            get 
            {
                // Yearly Salary. Rate/h * days * weeks * months
                return Rate * 8 * 5 * 4 * 12;
            }
        }

        // constructors
        public Employee(string role, string name, int age, float rate)
        {
            this.Role = role;
            this.Name = name;
            this.Age = age;
            this.Rate = rate;
          
        }

        // methods
        public override string ToString()
        {
            return $"Employee Role: {Role}, Name: {Name}, Age: {Age}, Rate {Rate}, and Salary: {Salary}";
        }
    }
}
