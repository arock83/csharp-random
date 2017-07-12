using System;
using System.Collections.Generic;

namespace random
{
    class Program
    {
        static void Main(string[] args)
        {
            //Using the Random class, generate a list of 20 random numbers that are in the range of 1-50.
            List<int> randoms = new List<int>();
            Random r = new Random();

            for(int i=0; i<20; i++)
            {

                randoms.Add(r.Next(1, 50));
            }
            foreach(int number in randoms)
            {
                Console.WriteLine(number);
            }

            //With the resulting List, populate a new List that contains each number squared. 
            //For example, if the original list is 2, 5, 3, 15, the final list will be 4, 25, 9, 225.
            Console.WriteLine("*************");
            List<int> doubles = new List<int>();

            foreach(int num in randoms)
            {
                doubles.Add(num * num);
            }
            // foreach(int number in doubles)
            // {
            //     Console.WriteLine(number);
            // }

            Console.WriteLine("*************");
            //Then remove any number that is odd from the list of squared numbers.

            doubles.RemoveAll(i => i % 2 != 0);

            foreach(int number in doubles)
            {
                Console.WriteLine(number);
            }

        }
    }
}
