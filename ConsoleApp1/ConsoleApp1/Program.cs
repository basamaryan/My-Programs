using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a new word");
            string newWord = (Console.ReadLine());
            int length = (newWord.Length);
            string start = newWord.Substring(0, 1);
            string middle = newWord.Substring(1, length - 2);
            string end = newWord.Substring(length - 1, 1);
            Console.WriteLine(end + middle + start);
            Console.ReadLine();






        }
    }
}
