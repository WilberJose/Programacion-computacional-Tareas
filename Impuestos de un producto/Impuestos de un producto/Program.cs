using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impuestos_de_un_producto
{
    class Program
    {
        static void Main(string[] args)
        {
            double impuesto, precio, preconimpuesto;
            int producto;

            Console.Write("--Menu de opciones--");
            Console.Write("\n1) Frutas");
            Console.Write("\n2) Lacteos");
            Console.Write("\n3) Medicinas");
            Console.Write("\nSelecciona una opcion: ");
            producto = Int32.Parse(Console.ReadLine());

            Console.Write("\nIngresa el impuesto al dia (%): ");
            impuesto = Double.Parse(Console.ReadLine());

                if (producto==1 || producto==2)
            {
                Console.Write("\nIngrese el precio del producto: ");
                    precio = Double.Parse(Console.ReadLine());
                preconimpuesto = ((impuesto / 100) * precio) + precio;
                Console.WriteLine("\nEl precio del producto es: " + preconimpuesto);
                    }

                else if (producto==3)
            {
                Console.Write("\nIngrese el precio del producto: ");
                precio = Double.Parse(Console.ReadLine());
                Console.WriteLine("\nEl precio del producto es: " + precio);
            }
                else
            {
                Console.WriteLine("\nEl producto no esta disponible");
            }
            Console.ReadKey();
        }
    }
}






