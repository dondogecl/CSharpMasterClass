using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsList
{
    public class ListsExcercise
    {
        // Write a method that returns a list of even integer numbers
        // between 100 and 170 inclusive.

        public static List<int> Solution()
        {
            // TODO: write your solution here
            List<int> pairNumbers = new List<int>();

            for (int i = 100; i <= 170; i++)
            {
                if (i % 2 == 0)
                {
                    pairNumbers.Add(i);
                }
                
            }
            return pairNumbers; 

        }
    }
}
