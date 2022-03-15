using System;
using System.Text;

namespace String.Builder.Type
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Reverse("CodeAcademy"));
        }

        static StringBuilder Reverse(string word)
        {
            StringBuilder newString = new StringBuilder();
            for (int i = word.Length-1; i >= 0; i--)
            {
                newString.Append(word[i]);
            }
            return newString;
        }
    }
}
