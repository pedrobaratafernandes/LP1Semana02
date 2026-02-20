using System;

namespace VariousOperators
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Insere número inteiro-não negativo: ");
            sbyte n = sbyte.Parse(Console.ReadLine());
            if (n > 0)
            {
                Console.WriteLine(n / 2);
                Console.WriteLine(n << 3);
                Console.WriteLine(n ^ 6);
                Console.WriteLine(n > 10 ? true : false);
            }
            else
            {
                Console.WriteLine("numero negativo");
            }


        }
    }
}
