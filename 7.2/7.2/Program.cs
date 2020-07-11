using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> wordList = new List<string>();
            Console.WriteLine("Enter a number: ");
            int quantity = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <=quantity; i++)
            {
                Console.WriteLine("Enter a word: ");
                string temp =Console.ReadLine();
                wordList.Add(temp);
            }
            for (int i=0; i < 1; i++)
            {
                Console.WriteLine("The first word is: "+ wordList[i]);
            }
            wordList.Sort();
            Console.WriteLine("The Sorted List Is");
            for (int i = 0; i <= quantity; i++)
            {
                Console.WriteLine(wordList[i]);
            }
            Console.ReadLine();


        }
    }
}
