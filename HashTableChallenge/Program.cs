using System;
using System.Collections;

namespace HashTableChallenge
{
    /*
    * Write a program that will iterate through each element of the students array
    * and insert them into a Hashtable.
    * If student.Id already exists in the HT, skip it and display the next error:
    * "Sorry, a student with the same ID already Exists".
    * You can user ContainsKey() to check if an ID exists.
    */
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[5];
            students[0] = new Student(1, "Denis", 88);
            students[1] = new Student(2, "Olaf", 97);
            students[2] = new Student(6, "Ragner", 65);
            students[3] = new Student(1, "Louise", 73);
            students[4] = new Student(4, "Levi", 58);

            // Code for the challenge below.

            Hashtable studentsTable = new Hashtable();

            foreach (Student item in students)
            {
                if (studentsTable.ContainsKey(item.Id))
                {
                    Console.WriteLine($"Sorry, a student with the same ID {item.Id} already Exists");
                    
                    // adding a condition because of the Joker.
                    if (item.Name == "Louise")
                    {
                        Console.WriteLine($"Also sorry, because Superman already killed student {item.Name}");
                    }
                }
                else
                {
                    studentsTable.Add(item.Id, item);
                }   
            }
            Console.WriteLine("Finished loading data into the hashtable.\n");

            // visualize the hashtable
            foreach (Student value in studentsTable.Values)
            {
                Console.WriteLine($"Student ID: {value.Id}, Name: {value.Name}," +
                    $"GPA: {value.GPA}.");
            }
        }
    }
}
