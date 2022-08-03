using System;
using System.Globalization;

namespace Quarto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcule os valores para X^2+2X+1:");
            Console.WriteLine();

            string [] vet = Console.ReadLine().Split(' ');
            int a = int.Parse(vet[0]);  
            int b = int.Parse(vet[1]);
            int c = int.Parse(vet[2]);

            Console.WriteLine("Os valores para a, b e c são respectivamente:");
            Console.WriteLine();
            Console.WriteLine(a.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(b.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(c.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();

            double Resdelta = (Math.Pow (b, 2) - 4 * a * c);
          
            Console.Write("O valor de delta é:");
            Console.WriteLine(Resdelta);
            Console.WriteLine();
            Console.WriteLine("O valor de X1 e X2 é:");

           double x1 = (-b + Math.Sqrt(Resdelta)) / 2 * a;
           double x2 = (-b - Math.Sqrt(Resdelta)) / 2 * a;

            Console.WriteLine(x1.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine(x2.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine();









        }
    }
}
