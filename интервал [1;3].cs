using System;
namespace промежуток
{
    class Program
    {
        static void Main(string[] args)
        {
           double a, b, c;
           a = Convert.ToDouble(Console.ReadLine());
           b = Convert.ToDouble(Console.ReadLine());
           c = Convert.ToDouble(Console.ReadLine());
           if(1 <= a && a <= 3)
           {
               Console.WriteLine(a);
           }
           if(1<=b && b<=3)
           {
               Console.WriteLine(b);
           }
           
           if(1<=c && c<=3)
           {
               Console.WriteLine(c);
           }

        }
    }
}