using System;

namespace OOP_lab_2_25_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = -3.14;

            while (x <= 3.1400000001)
            {
                double y = Math.Pow(2, 3 * x) * Math.Sin(x) * Math.Sin(x);

                Console.WriteLine("x = {0,5:f2}, y = {1:f4}", x, y);

                x += 0.314;
            }
        }
    }
}
