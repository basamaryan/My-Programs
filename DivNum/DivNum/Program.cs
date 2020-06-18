using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivNum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int secNum = Convert.ToInt32(Console.ReadLine());
            double ANS = (double)firstNum / secNum;
            Console.WriteLine("The answer is " + ANS);
            Console.Read();
        }
          
        
    }
}
