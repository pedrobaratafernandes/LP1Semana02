using System;
using System.Globalization;
namespace TempConvert
{
    public class Program
    {
        private static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            Console.Write("Temperature: ");
            float temperatura = float.Parse(Console.ReadLine());
            Console.Write("Unit (C/F): ");
            string medida = Console.ReadLine();
            Console.Write($"{temperatura} {medida}");
           
        }
    }
}
