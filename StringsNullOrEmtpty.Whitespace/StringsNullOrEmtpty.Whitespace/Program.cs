using System;

namespace StringsNullOrEmtpty.Whitespace
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "";
            string word2 = "  ";
            Console.WriteLine(String.IsNullOrEmpty(word));
            Console.WriteLine(String.IsNullOrWhiteSpace(word2));
        }
    }
}
