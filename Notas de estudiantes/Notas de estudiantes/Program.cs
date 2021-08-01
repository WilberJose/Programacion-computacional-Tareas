using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notas_de_estudiantes
{
 
    class Alumnos
    {
        static void Main(string[] args)
        {
            int CantRepro = 0, CantApro = 0, i = 1;
            double promGrupo = 0, PromAproba = 0, PromDesapro = 0, nota = 0;
            string resp;
            Console.WriteLine("Desea introducir datos?   S/N");
            resp = Console.ReadLine().ToLower();
            while (resp == "s")
            {

                Console.WriteLine("Ingrese la nota obtenida");
                nota = Convert.ToDouble(Console.ReadLine());
                if (nota <= 5)
                {
                    CantRepro++;
                    PromDesapro += nota;
                }
                else
                {
                    CantApro++;
                    PromAproba += nota;
                }
                i++;
                Console.Write("Desea Continuar  S/N ");
                resp = Console.ReadLine().ToLower();
            }
            promGrupo = (PromDesapro + PromAproba) / (i - 1);
            PromAproba = (CantApro * 100) / (i - 1);
            PromDesapro = (CantRepro * 100) / (i - 1);
            Console.WriteLine("Cantidad de aprobados es:" + CantApro);
            Console.WriteLine("Cantidad de reprobados es:" + CantRepro);
            Console.WriteLine("El promedio grupal es de:" + promGrupo + "%");
            Console.WriteLine("El promedio aprobado es de:" + PromAproba + "%");
            Console.WriteLine("El promedio desaprobado es de:" + PromDesapro + "%");
            Console.ReadLine();
        }
    }
}
