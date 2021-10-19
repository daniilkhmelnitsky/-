using System;
namespace maximum
{
   class Program
   {
       static void Main(string[] args)
       {
           double a, b, c;
           a = Convert.ToDouble(Console.ReadLine());
           b = Convert.ToDouble(Console.ReadLine());
           c = Convert.ToDouble(Console.ReadLine());
           Console.WriteLine(Math.Max(a, Math.Max(b,c)));
       }
   } 
}