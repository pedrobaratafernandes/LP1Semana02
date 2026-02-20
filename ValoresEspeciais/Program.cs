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


            double ad = double.PositiveInfinity;
            double bd = double.NegativeInfinity;
            double cd = double.PositiveInfinity;

            float af = float.PositiveInfinity;
            float bf = float.NegativeInfinity;
            float cf = float.PositiveInfinity;

            //NaN
            double xd = double.PositiveInfinity / double.PositiveInfinity;
            double xf = float.PositiveInfinity / float.PositiveInfinity;
            
            //NaN Direto 
            float zf = float.NaN;
            double zd = double.NaN;
            Console.WriteLine(ad);
            Console.WriteLine(bd);
            Console.WriteLine(cd);

            Console.WriteLine(af);
            Console.WriteLine(bf);
            Console.WriteLine(cf);


            Console.WriteLine(xd);
            Console.WriteLine(zd);

            Console.WriteLine(xf);
            Console.WriteLine(zf);

        }
    }
}
