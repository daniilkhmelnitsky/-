using System;
namespace programma
{
    class Program
    {
        static int Perimetr(int a, int b, int c)
        {
            int p = a + b + c;
            return p;
        }
        static void Main(string[] args)
        {
            int a, b, c;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            int per = Perimetr(a, b, c);
            Console.WriteLine(per);
        }
    }
}
