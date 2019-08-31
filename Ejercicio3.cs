using System;
using System.Collections.Generic;
using System.Text;

namespace Guia1
{
    class Ejercicio3
    {
        public static void ejer3()
        {
            Console.WriteLine("Ingrese dos numero decimales");

            float numero1 = float.Parse(Console.ReadLine());

            float numero2 = float.Parse(Console.ReadLine());
            Console.WriteLine("\n Eliga una opcion:");
            Console.WriteLine("\n 1- Suma");
            Console.WriteLine("\n 2- Resta");
            Console.WriteLine("\n 3- Multiplicacion");
            Console.WriteLine("\n 4- Division");
            Console.WriteLine();
            int opcion = Convert.ToInt32(Console.ReadLine());
            float total;

            if (opcion == 1)
            {

                total = numero1 + numero2;
                Console.WriteLine("\n La suma de los numeros es {0}", total);
            }
            if (opcion == 2)
            {
                total = numero1 - numero2;
                Console.WriteLine("\n La resta de los numeros es {0}", total);
            }

            if (opcion == 3)
            {
                total = numero1 * numero2;
                Console.WriteLine("\n La multiplicacion de los numeros es {0}", total);
            }

            if (opcion == 4)
            {
                total = numero1 / numero2;
                Console.WriteLine("\n La division de los numeros es {0}", total);
            }


            Console.WriteLine("\n Presione ENTER para salir");
            Console.ReadKey();
        }
    }
}
