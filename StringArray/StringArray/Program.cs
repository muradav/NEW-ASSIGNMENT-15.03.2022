using System;

namespace StringArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Code", "Academy" };
            Console.WriteLine(String.Join(" ", names));

            string word = "Code Academy";
            string[] newArr = word.Split(" ");
            foreach (var item in newArr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
