using System;
using System.Globalization;

namespace Uri1117
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a primeira nota = ");

            double media = 0.0;
            double nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            while (nota1 < 0.0 || nota1 > 10.0)
            {
                Console.WriteLine("Nota invalida");
                Console.Write("Digite novamente = ");
                nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            }
            
            Console.Write("Digite a nota 2 = ");
            double nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            while (nota2 < 0.0 || nota2 > 10.0)
            {
                Console.WriteLine("Nota invalida");
                Console.Write("Digite novamente = ");
                nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            media = (nota1 + nota2) / 2.0;

            Console.WriteLine("Media = " + media.ToString("f2", CultureInfo.InvariantCulture));

        }
    }
}
