using System;
using System.Collections;

namespace ArrayListCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array List is NON generic collection
            // Array list declaration
            ArrayList myArrayList = new ArrayList();

            // declaring an ArrayList with a predefined amount
            ArrayList secondArrayList = new ArrayList(100);

            myArrayList.Add(25);
            myArrayList.Add("Pony");
            myArrayList.Add(15.0f);
            myArrayList.Add(true);
            myArrayList.Add(10.1);
            myArrayList.Add(9.9);

            // delete specific value
            myArrayList.Remove(15.0f);
            // delete element at index
            myArrayList.RemoveAt(2);
            // See how many elements: Count object
            Console.WriteLine("Number of elements: {0}", myArrayList.Count);

            // see each element
            foreach (object obj in myArrayList)
            {
                Console.WriteLine(obj);
            }

            // to interact with the object we may have to cast
            double sum = 0;

            foreach (object obj in myArrayList)
            {
                if (obj is int)
                {
                    sum += Convert.ToDouble(obj);
                } 
                else if (obj is double)
                {
                    // object type has to be casted to double
                    sum += (double)obj;
                } 
                else if (obj is string)
                {
                    Console.WriteLine(obj);
                }
            }

            Console.WriteLine("Sum total: {0}", sum);
            
        }
    }
}
