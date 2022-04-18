using System;
using System.Collections;

namespace HashTables
{
    class Program
    {
        static void Main(string[] args)
        {
            // creation of a new HT
            Hashtable studentsTable = new Hashtable();

            // instances of students
            Student stud1 = new Student(1, "Maria", 98);
            Student stud2 = new Student(2, "Jason", 76);
            Student stud3 = new Student(3, "Clara", 43);
            Student stud4 = new Student(4, "Steve", 55);

            // add students to the HT
            studentsTable.Add(stud1.Id, stud1);
            studentsTable.Add(stud2.Id, stud2);
            studentsTable.Add(stud3.Id, stud3);
            studentsTable.Add(stud4.Id, stud4);

            // Retrieve values (using the ID value, not an index)
            Student storedStudent1 = (Student)studentsTable[1];
            Student storedStudent2 = (Student)studentsTable[stud2.Id];

            // Visualize the objects
            Console.WriteLine($"Student ID: {storedStudent1.Id}, " +
                $"Name: {storedStudent1.Name}, GPA: {storedStudent1.GPA}");
            
            Console.WriteLine($"Student ID: {storedStudent2.Id}, " +
                $"Name: {storedStudent2.Name}, GPA: {storedStudent2.GPA}");

            // in order to access ALL the elements from the HT
            // we have to use the DictionaryEntry and iterate
            Console.WriteLine("Example of iterating all values from the HT.");
            foreach (DictionaryEntry entry in studentsTable)
            {
                Student temp = (Student)entry.Value;
                Console.WriteLine($"ID: {temp.Id} Name: {temp.Name}, GPA: {temp.GPA}");
            }

            // Simplify the loop
            Console.WriteLine("\nExample of iterating all values from the HT, Simplified Version (Values).");
            foreach (Student value in studentsTable.Values)
            {
                Console.WriteLine($"ID: {value.Id} Name: {value.Name}, GPA: {value.GPA}");
            }

            Console.WriteLine(studentsTable.ContainsKey(2));
        }
    }
}
