using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            int firstVal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int secondVal= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third number: ");
            int thirdVal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter fourth number: ");
            int fourthVal = Convert.ToInt32(Console.ReadLine());
            List<int> numberList = new List<int>();
            numberList.Add(firstVal);
            numberList.Add(secondVal);
            numberList.Add(thirdVal);
            numberList.Add(fourthVal);
            foreach (int i in numberList)
            {
                if (i%2 == 0)
                {
                    Console.WriteLine(i + " is an even number");
                }
                else
                {
                    Console.WriteLine(i + " is an odd number");
                }
            }

            Console.ReadLine();
        }
    }
}
