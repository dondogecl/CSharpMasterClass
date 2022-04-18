using System;
using System.Collections.Generic;
using System.Linq;
using DictionaryDemo.Models;

namespace DictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array of employee objects
            Employee[] employees =
            {
                new Employee("CEO", "Gwyn", 95, 200),
                new Employee("Manager", "Joe", 35, 25),
                new Employee("HR", "Lora", 32, 21),
                new Employee("Secretary", "Petra", 28, 18),
                new Employee("Lead Developer", "Artorias", 55, 35),
                new Employee("Intern", "Ernest", 22, 8),
            };

            // Dictionary (it uses collections.generics)
            Dictionary<string, Employee> employeesDirectory = new Dictionary<string, Employee>();

            // insert the data from our array
            foreach (Employee empObj in employees)
            {
                employeesDirectory.Add(empObj.Role, empObj);
            }

            // Access the elements of the Dictionary
            Employee ceo = employeesDirectory["CEO"];

            Console.WriteLine(ceo + "\n");

            // Check if a key exist before retrieveng (to avoid exceptions)
            Console.WriteLine("(Accessing dictionary by keyname)");

            string key = "CFO";
            
            
            if (employeesDirectory.ContainsKey(key))
            {
                Employee empl = employeesDirectory[key];
                Console.WriteLine(empl);
            }
            else
            {
                Console.WriteLine($"There is no employee {key}\n");
            }

            
            // the one before with TryGetValue. This returns the object that matches the query
            
            Console.WriteLine("(Using TryGetValue method)");
            key = "Secretary";

            Employee result = null; // empty employee object that will be populated
            
            if (employeesDirectory.TryGetValue(key, out result))
            {
                Console.WriteLine($"Value for employee {key} retrieved!");
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine($"There is no employee {key}");
            }


            // iterate the dictionary elements. Dict is a struct of K,V pairs
            // using ElementAt(i) to return the K,V pair stored at index i
            Console.WriteLine("\n(ElementAt(i) example)\n");

            for (int i = 0; i < employeesDirectory.Count; i++)
            {
                KeyValuePair<string, Employee> keyValuePair = employeesDirectory.ElementAt(i);
                // Print the key
                Console.WriteLine($"index={i} Key={keyValuePair.Key}.");
                // Storing the valuein an Employee object
                Employee empValue = keyValuePair.Value;
                // printing this new Employee Object
                Console.WriteLine(empValue);
                Console.WriteLine("-------------------");
            }

            
            // Update data in a Dictionary

            string keyToUpdate = "HR";

            if (employeesDirectory.ContainsKey(keyToUpdate))
            {
                employeesDirectory[keyToUpdate] = new Employee("HR", "Eleka", 26, 18);
                Console.WriteLine($"Employee with Role {keyToUpdate} was updated.\n");

                foreach (Employee empObj in employeesDirectory.Values)
                {
                    Console.WriteLine(empObj);
                }
            }
            else
            {
                Console.WriteLine($"Employee with Role {keyToUpdate} was not found and not updated.\n");
            }


            // Remove data from the Dictionary
            string keyToRemove = "Intern";

            if (employeesDirectory.ContainsKey(keyToRemove))
            {
                employeesDirectory.Remove(keyToRemove);
                Console.WriteLine($"\nEmployee with ID {keyToRemove} has been eliminated.\n");
                foreach (Employee empObj in employeesDirectory.Values)
                {
                    Console.WriteLine(empObj);
                }
            }
            else
            {
                Console.WriteLine($"Employee with Role {keyToRemove} was not found and not deleted.\n");
            }

        }
    }
}
