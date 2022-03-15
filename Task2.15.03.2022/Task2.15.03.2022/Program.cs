using System;

namespace Task2._15._03._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 3, -6, -5 };

            int[] newArr = PositiveArray(ref numbers);
            foreach (var item in newArr)
            {
                Console.WriteLine(item);
            }
            
        }

        static int[] PositiveArray(ref int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    arr[i] = -arr[i];

                }
                
            }
            return arr;
        }
    }
}
