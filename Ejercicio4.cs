using System;
using System.Collections.Generic;
using System.Text;

namespace Guia1
{
    class Ejercicio4
    {
        public static void ejer4()
        {
            Console.WriteLine("Digite un numero positivo para sacarle raiz cuadrada");
            Console.WriteLine();
            double numero = Convert.ToDouble(Console.ReadLine());

            double resultado = Math.Sqrt(numero);

            Console.WriteLine("\n La raiz cuadrada de su numero es: {0}", resultado);
            Console.ReadKey();
        }
    }
}
