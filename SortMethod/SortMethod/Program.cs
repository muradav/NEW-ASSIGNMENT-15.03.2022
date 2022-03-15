using System;

namespace SortMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, -2, 5, 0 };
            Array.Sort(numbers);
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
