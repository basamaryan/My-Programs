using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number");
            string temp = (Console.ReadLine());
            int numEntered = Convert.ToInt32(temp);
            for (int i = 0; i < 11; i++) 
            {
                Console.WriteLine(numEntered + "*" + i + "=" + (numEntered * i));
            }
            Console.ReadLine();
        }
    }
}
