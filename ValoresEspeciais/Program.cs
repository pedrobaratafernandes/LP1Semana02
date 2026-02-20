using System;

namespace ValoresEspeciais
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Inteiros com sinal
            Console.WriteLine($"sbyte:  {sbyte.MinValue} a {sbyte.MaxValue}");
            Console.WriteLine($"short:  {short.MinValue} a {short.MaxValue}");
            Console.WriteLine($"int:    {int.MinValue} a {int.MaxValue}");
            Console.WriteLine($"long:   {long.MinValue} a {long.MaxValue}");

            // Inteiros sem sinal
            Console.WriteLine($"byte:   {byte.MinValue} a {byte.MaxValue}");
            Console.WriteLine($"ushort: {ushort.MinValue} a {ushort.MaxValue}");
            Console.WriteLine($"uint:   {uint.MinValue} a {uint.MaxValue}");
            Console.WriteLine($"ulong:  {ulong.MinValue} a {ulong.MaxValue}");

            // Reais
            Console.WriteLine($"float:   {float.MinValue} a {float.MaxValue}");
            Console.WriteLine($"double:  {double.MinValue} a {double.MaxValue}");
            Console.WriteLine($"decimal: {decimal.MinValue} a {decimal.MaxValue}");

        }
    }
}
