using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numList = new List<int>();
            Console.WriteLine("Enter a quantity: ");
            int quantity = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= quantity; i++)
            {
                Console.WriteLine("Enter a number: ");
                int temp = Convert.ToInt32(Console.ReadLine());
                numList.Add(temp);
            }
            int maxInd = numList.IndexOf(numList.Max());
            Console.WriteLine("The index of maximum value is: " + maxInd);

            Console.ReadLine();
        }
    }
}
