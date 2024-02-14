using System;

namespace uppgift_6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in 2 tal");
            int tal1 = int.Parse(Console.ReadLine());
            int tal2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Största talet var "+ Störst(tal1, tal2));
            Console.ReadKey();
        }
        static int Störst(int tal1, int tal2)
        {
            if (tal1 >= tal2)
            {

                return tal1;
            }
            else
            {
                return tal2;
            }
        }
    }
}
