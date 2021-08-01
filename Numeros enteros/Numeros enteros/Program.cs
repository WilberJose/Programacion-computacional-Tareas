using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeros_enteros
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, c, r;

            Console.Write("Numero 1: ");
            n1 = int.Parse(Console.ReadLine());

            Console.Write("Numero 2: ");
            n2 = int.Parse(Console.ReadLine());

            c = n1 / n2;
            r = n1 % n2;

            Console.WriteLine("El cociente es: " + c);
            Console.WriteLine("El resto es: " + r);
            Console.ReadKey();
        }
    }
}
