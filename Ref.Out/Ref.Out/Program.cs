using System;

namespace Ref.Out
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             
             "ref" evvelceden deyer isteyir 
             amma method daxilinde deyer menimsedilmesede olar
                         
             amma "out" tam eksine evvelceden deyer menimsedilmese de olar. 
             esas method icinde deyer menimsedilmelidi
             
             */
            
                                   
            
            int num = 5;
            //ChangeNum(ref num);
            ChangeNum(out num);
            Console.WriteLine($"outside {num}");
        }

        static void ChangeNum(out int n)
        {
            n = 10;
            Console.WriteLine($"method {n}");
        }
    }
}
