using System;
namespace sale
{
    class Program
    {
        static void Main(string[] args)
        {
           double a;
           a = Convert.ToDouble(Console.ReadLine());
           if(a>500 && a<1000)
           {
               Console.WriteLine(a*0.97);
           }
            if(a>1000)
           {
               Console.WriteLine(a*0.95);
           }
        }
    }
}
