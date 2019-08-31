using System;
using System.Collections.Generic;
using System.Text;

namespace Guia1
{
    class Ejercicio6
    {
        public static void ejer6()
        {
            Console.WriteLine("Porfavor, ingrese los datos que se le piden a continuacion.");
            Console.WriteLine("\n Digite su nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("\n Ingrese su sueldo:");
            double sueldo = double.Parse(Console.ReadLine());
            double iss = sueldo * 0.03;
            double afp = sueldo * 0.0625;
            double renta = sueldo * 0.1;
            Console.WriteLine("\n A su sueldo se le desconto: {0:c} del ISSS", iss);
            Console.WriteLine("\n A su sueldo se le desconto: {0:c} de AFP", afp);
            Console.WriteLine("\n A su sueldo se le desconto: {0:c} de renta", renta);
            double total = sueldo - iss - afp - renta;
            Console.WriteLine("\n {0} su sueldo total es {1:c}", nombre, total);
            Console.ReadKey();
        }
    }
}
