using System;

namespace Guia1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Primer ejercicio: ");
            Console.WriteLine("\n Los datos de su mascota son los siguientes.");
            String especie = "\n Gato";
            string nombre = "\n Michi";
            int edad = 2;
            edad = Convert.ToInt32(edad);
            Console.WriteLine("\n Especie: {0}", especie);
            Console.WriteLine("\n Nombre: {0}", nombre);
            Console.WriteLine("\n Edad: {0} años", edad);
            Console.ReadKey();


            Console.WriteLine("\n Segundo ejercicio: ");
            Console.WriteLine();
            Ejercicio2.ejer2();
            Console.WriteLine("\n Tercero ejercicio: ");
            Console.WriteLine();
            Ejercicio3.ejer3();
            Console.WriteLine("\n Cuarto ejercicio: ");
            Console.WriteLine();
            Ejercicio4.ejer4();
            Console.WriteLine("\n Quinto ejercicio: ");
            Console.WriteLine();
            Ejercicio5.ejer5();
            Console.WriteLine("\n Sexto ejercicio: ");
            Console.WriteLine();
            Ejercicio6.ejer6();
            Console.ReadKey();


        }
    }
}
