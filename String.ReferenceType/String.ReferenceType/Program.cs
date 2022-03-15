using System;

namespace String.ReferenceType
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "Hello";
            string word2 = word;
            word2 = "hi";
            //Console.WriteLine(word2);

            string word3 = "hi";
            Console.WriteLine(word2 == word3);


        }


    }
}
