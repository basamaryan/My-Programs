using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the word");
            string wordEntered = (Console.ReadLine());
            Console.Write("Enter the number");
            int numVal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(wordEntered.Remove(numVal -1, 1));
            Console.Read();




        }
    }
}
