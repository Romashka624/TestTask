using System;

namespace Test_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert the value: \n");
            string st = Console.ReadLine();
            string k = "";
            for(int i = st.Length - 1; i >= 0; i--)
            {
                k = k + st[i];
            }
            if(k == st)
            {
                Console.WriteLine("\"{0} is palindrome. {0} == {1}", st, k);
            }
            else
            {
                Console.WriteLine("\"{0} is not palindrome. {0} != {1}", st, k);
            }
        }
    }
}
