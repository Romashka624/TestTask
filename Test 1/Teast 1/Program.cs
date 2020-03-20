using System;

namespace Teast_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            for(int g = 0; g < mas.Length; g++)
            {
                if(g < mas.Length - 1)
                {
                    Console.Write("{0}, ", mas[g]);
                }
                else
                {
                    Console.Write("{0}. ", mas[g]);
                }
            }
            Console.WriteLine("\nInsert value: ");
            int num =  Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < mas.Length; i++)
            {
                for( int k = i; k < mas.Length; k++)
                {
                    if( mas[i] + mas[k] == num)
                    {
                        Console.WriteLine("{0}({1}) + {2}({3}) = {4}", mas[i], i, mas[k], k, num);
                    }
                }
            }
        }
    }
}
