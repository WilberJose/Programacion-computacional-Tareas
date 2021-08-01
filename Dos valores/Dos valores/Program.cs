using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dos_valores
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = 0, n2 = 0, s = 0, r = 0, m = 0;
            Console.Write("Escribe el primer numero: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Escribe el segundo numero ");
            n2 = int.Parse(Console.ReadLine());
            s = n1 + n2;
            r = n1 - n2;
            m = n1 * n2;
            Console.WriteLine("La suma de {0} + {1} = {2}", n1, n2, s);
            Console.WriteLine("La resta de {0} + {1} = {2}", n1, n2, r);
            Console.WriteLine("La multiplicacion de {0} + {1} = {2}", n1, n2, m);
            Console.ReadKey();
        }
    }
}
