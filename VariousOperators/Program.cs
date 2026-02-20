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
                Console.WriteLine(n / 2); // dividir por 2
                Console.WriteLine(n << 3); // shift left
                Console.WriteLine(n ^ 6); // XOR
                Console.WriteLine(n > 10 ? true : false); // operador ternario
            }
            else
            {
                Console.WriteLine("numero negativo");
            }

            // resultado de overflow em uints
            uint x = uint.MaxValue; 
            Console.WriteLine(x + 1); // valor não muda (perda de precisão)

            // dois tipos de overflow em floats
            float valor1 = float.MaxValue + 1; // overflow “silencioso” (valor não muda)
            float valor2 = 2 * float.MaxValue; // overflow real → infinito

            Console.WriteLine(valor1);
            Console.WriteLine(valor2); // output ∞
           

            // verificar
            // Console.WriteLine(float.IsInfinity(valor2)); // True
            // Console.WriteLine(valor1 == float.MaxValue); // True
            // Console.WriteLine(valor2 == float.PositiveInfinity); // True
            
            // Underflow: quando precisão do tipo é insuficiente
            float f1, f2;
            f1 = f2 = 10000.0f;
            Console.WriteLine(f1 == f2 + 0.0001f);
        }
    }
}
