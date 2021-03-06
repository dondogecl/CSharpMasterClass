using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTables
{
    public class Student
    {
        // properties
        public int Id { get; set; }
        public string Name { get; set; }
        public float GPA { get; set; }

        // Constructors
        public Student(int id, string name, float gpa)
        {
            Id = id;
            Name = name;
            GPA = gpa;
        }
    }
}
