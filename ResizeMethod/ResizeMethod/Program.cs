using System;

namespace ResizeMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 6, -4 };
            //int[] newArr = Array.Resize (ref numbers, 5);

            int[] newArr1 = ArrayResize(ref numbers, 5);
            foreach (var item in newArr1)
            {
                Console.WriteLine(item);
            }
        }

        static int[] ArrayResize(ref int[] arr, int length)
        {
            int[] newArray = new int[length];
            for (int i = 0; i < arr.Length; i++)
            {
                newArray[i] = arr[i];
            }
            return newArray;
        }
    }
}
