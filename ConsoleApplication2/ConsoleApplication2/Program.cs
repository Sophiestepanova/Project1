
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random b = new Random();
            int t = b.Next(-12, 12);
            double k = t * b.NextDouble();
            Console.WriteLine("{0} {1}", t, k);
            Console.Read();
        }
    }
}