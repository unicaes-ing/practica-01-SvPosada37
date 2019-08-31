using System;
using System.Collections.Generic;
using System.Text;

namespace Guia1
{
    class Ejercicio5
    {
        public static void ejer5()
        {
            Console.WriteLine("Coloque el total de ventes del primer trimestre del ano:  ");
            Console.WriteLine();
            float trimestre1 = float.Parse(Console.ReadLine());
            Console.WriteLine("\n Coloque el total de ventes del segundo trimestre del ano:  ");
            Console.WriteLine();
            float trimestre2 = float.Parse(Console.ReadLine());
            Console.WriteLine("\n Coloque el total de ventes del tercero trimestre del ano:  ");
            Console.WriteLine();
            float trimestre3 = float.Parse(Console.ReadLine());
            Console.WriteLine("\n Coloque el total de ventes del caurto trimestre del ano:  ");
            Console.WriteLine();
            float trimestre4 = float.Parse(Console.ReadLine());
            float promedio;
            promedio = (trimestre1 + trimestre2 + trimestre3 + trimestre4) / 4;
            Console.WriteLine("\n El promerdio de ventas del ano es de: {0:c} ", promedio);

            Console.ReadKey();
        }
    }
}
