using System;

namespace String.ToUpper.ToLower
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "CodeAcademy";
            string word2="codeacademy";

            //Console.WriteLine(word.Equals(word2));
            Console.WriteLine(word.ToLower().Equals(word2.ToLower()));
            //Console.WriteLine(word.ToUpper());
            //Console.WriteLine(word.ToLower());
        }
    }
}
