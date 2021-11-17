using System;
namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            string s, b;
            b = "";
            Console.WriteLine("Введите слово ");
            s = Console.ReadLine();
            s = s.ToLower();
            for (int i = s.Length - 1; i>=0; i--)
            {
                b += s[i];
            }
            if(s==b)
            {
                Console.WriteLine("Is polindrom");
            }
            else
            {
                Console.WriteLine("Is not polindrom");
            }
        }
    }
}
