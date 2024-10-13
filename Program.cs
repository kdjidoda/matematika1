using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matematika
{
    class Program
    {
        static void Main()
        {
            double a;
            double b;
            double c;
            double d;

            Console.WriteLine("Unesi varijablu a: ");
            Console.ReadLine(a, Convert.ToDouble);

            Console.WriteLine("Unesi varijablu b: ");
            Console.ReadLine(b, Convert.ToDouble);

            Console.WriteLine("Unesi varijablu c: ");
            Console.ReadLine(c, Convert.ToDouble);

            Console.WriteLine("Unesi varijablu d: ");
            Console.ReadLine(d, Convert.ToDouble);

            double x = (Math.Pow(a, 2) + Math.Pow(b, 2) + Math.Pow(c, 2) + Math.Pow(d, 2)) /
                       (Math.Pow(a + b, 2) + Math.Pow(c + d, 2));

            Console.WriteLine("Value of x: " + x);
            Console.ReadKey();
        }
    }


}
