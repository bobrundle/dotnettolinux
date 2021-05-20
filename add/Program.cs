using System;

namespace add
{
    public class Program
    {
        public static int Main(string[] args)
        {
            double sum = 0.0;
            foreach(var arg in args)
            {
                if(double.TryParse(arg, out double addend))
                {
                    sum += addend;
                }
                else
                {
                    Console.Error.WriteLine("Usage: add a1 a2 a3 ...");
                    Console.Error.WriteLine("Add a series of numbers and return the sum");
                    Console.Error.WriteLine("Where: a1, a2, a3 are real or integer numbers");
                    return 1;
                }
            }
            Console.Out.WriteLine(sum);
            return 0;
        }
    }
}
