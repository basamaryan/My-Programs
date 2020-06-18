using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int secNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Third number:");
            int thirdNum = Convert.ToInt32(Console.ReadLine());
            int ANS = firstNum * secNum * thirdNum;
            Console.WriteLine("The answer is " + ANS);
            Console.Read();
        }
        
        }
    }
