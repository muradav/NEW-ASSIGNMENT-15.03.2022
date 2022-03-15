using System;

namespace String.Trim
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "    test   ";
            Console.WriteLine(word.Trim());
            Console.WriteLine(word.TrimStart());
            Console.WriteLine(word.TrimEnd());
            
        }
    }
}
