using System;
namespace sale
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, d=1, i = 1;
            a = Convert.ToInt32(Console.ReadLine());
            if (a > 0)
            {
                do
                {
                    d *= i;
                    i = i + 1;
                }
                while (i < a+1);
            }
            Console.WriteLine(d);

        }
    }
}