using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the first number:");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int secNum = Convert.ToInt32(Console.ReadLine());
            int temp;
            temp = firstNum;
            firstNum = secNum;
            secNum = temp;
            Console.WriteLine("After swapping, the ");
            Console.WriteLine("The first number is  " + firstNum);
            Console.WriteLine("The second number is  " + secNum);
            Console.Read();
        }
    }
}
