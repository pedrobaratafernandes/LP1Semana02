using System;

namespace Cilindro
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Altura: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Raio: ");
            double r = double.Parse(Console.ReadLine());
            double v = Math.PI * Math.Pow(r, 2) * a;
            Console.WriteLine($"Volume: {v}");
        }
    }
}
