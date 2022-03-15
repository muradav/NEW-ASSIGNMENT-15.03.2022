using System;

namespace Task.Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Reverse("CodeAcademy"));
            
        }

        static string Reverse(string word)
        {
            string newWord = String.Empty;
            for (int i = word.Length-1; i >= 0; i--)
            {
                newWord += (word[i]);
            }
            return newWord;
        }

       

      
       
        
        
        
    }
}
