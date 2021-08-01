using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saludo_y_nombre
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            Console.Write("Ingrese su Nombre :"); nombre = Console.ReadLine();
            if (nombre == "Wilber")
            {
                Console.WriteLine();
                Console.WriteLine("Hola Wilber Bienvenido");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("No te conozco");
            }
            Console.ReadKey();
        }
    }
}




