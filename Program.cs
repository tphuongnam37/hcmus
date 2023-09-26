using System;
using System.ComponentModel.Design;
using System.Reflection.Metadata;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("World is Here!");
            Console.WriteLine("World is Here!");
            Console.WriteLine("World is Here!");
            //Console.Write("I will Print this on the sameline");
            //Console.Write("I will Print this on the sameline");
            //This is a comment
            /*I dont think this will print 
             * Because this just a comment
             */
           /* int a, b;
            Console.WriteLine("Nhap gia tri a:");
            string str = Console.ReadLine();
            a = int.Parse(str);
            b = 20;
            int s;
            s = a + b;
            Console.WriteLine($"{a} + {b} = {s}");
            Console.WriteLine("{0} + {1} = {2}", a, b, s);*/

            int x, y;
            x = 5;y = 10;
            Console.WriteLine(Math.Max(x, y));
            Console.WriteLine(Math.Min(x, y));
            Console.WriteLine(Math.Sqrt(y));
            Console.WriteLine(Math.Abs(- 4.7));
            Console.WriteLine(Math.Round(x - 4.7+9.999));

            int a, b;
            Console.WriteLine("Nhap gia tri a");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap gia tri b");
            b = int.Parse(Console.ReadLine());
            if (a == 0) ;
            {
                if (b == 0) ;
                {
                    Console.WriteLine("Vo so nghiem");
                }
                else
                {
                    Console.WriteLine("Vo nghiem");
                }
            }
            else
            {
                double x = -1.0 * b / a;
                Console.WriteLine($"Nghiem la x = {x}");
            }


        }
    }
}