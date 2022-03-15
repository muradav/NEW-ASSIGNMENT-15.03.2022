using System;

namespace Value.Reference_types
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num = 5;
            //ChangeNum(num);
            //Console.WriteLine($"outside: {num}");

            int[] numbers = {1, 2, 3, 4};
            ChangeIndex(numbers);
            Console.WriteLine($"outside: {numbers[0]}");
        }

        static void ChangeNum(int n)
        {
            n = 10;
            Console.WriteLine($"method: {n}");

        }

        static void ChangeIndex(int[] arr)
        {
            arr[0] = 10;
            Console.WriteLine($"method: {arr[0]}");
        }

    }
}
