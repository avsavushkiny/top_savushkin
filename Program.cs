using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World! Saransk здесь был я");
            
            int a =  Convert.ToInt32(Console.ReadLine());
    

            switch (a)
            {
                case 100:
                    Console.WriteLine("круглый");
                    break;
                case 10:
                    Console.WriteLine("округлый");
                    break;
                default:
                    Console.WriteLine("шарообразный");
                break;
            }
        }
    }
}