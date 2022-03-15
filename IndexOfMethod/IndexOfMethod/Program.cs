using System;

namespace IndexOfMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "CodeAcademy";
            string word2 = "Education";
            Console.WriteLine(word.IndexOf("A"));
            Console.WriteLine(word2.IndexOf("t"));
            Console.WriteLine(word.LastIndexOf("e"));

        }
    }
}
