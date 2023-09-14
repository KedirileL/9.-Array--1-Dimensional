using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Array__1_Dimensional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaration of arrays
            int[] luckyNumbers = { 1, 2, 5, 7, 8, 9, 10, 11, 12};

            Console.WriteLine(luckyNumbers.Length);
            Console.WriteLine(luckyNumbers[0]);

            string[] friends = new string[5];
            friends[0] = "Peter";
            friends[1] = "John";
            friends[4] = "Lekgale";
            // friends[5] = "JJ Reds";
            Console.WriteLine("For now friend number 1 is " + friends[1]); // if i put [5] it will say outta bounds since the string keeps 0-4 = 5
            friends[1] = Console.ReadLine(); // we can change the array list

            Console.WriteLine("How about friend number one now? " + friends[1]);

            //Freeze console
            Console.ReadLine();

        }
    }
}
