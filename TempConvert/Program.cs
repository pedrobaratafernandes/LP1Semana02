using System;
using System.Globalization;
using System.Reflection;
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
            float total_cel;
            float total_fah;

            switch (medida)
            {
                case "C":
                    total_fah = temperatura * 1.8f + 32;
                    total_cel = (temperatura - 32) / 1.8f;
                    Console.WriteLine($"{temperatura:f2} C = {total_fah:f2} F");
                    Console.Write($"Absolute value: {total_fah:f2}");
                    break;

                case "F":
                    total_cel = (temperatura - 32) / 1.8f;
                    total_fah = temperatura * 1.8f + 32;
                    Console.WriteLine($"{temperatura:f2} F = {total_cel:f2} C");
                    float total = Math.Abs(total_fah);
                    Console.Write($"Absolute value: {total:f2}");
                    break;

                default:
                    Console.Write("Invalid unit.");
                    break;
            }

        }
    }
}
