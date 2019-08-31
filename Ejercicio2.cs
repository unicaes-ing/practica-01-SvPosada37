using System;
using System.Collections.Generic;
using System.Text;

namespace Guia1
{
    class Ejercicio2
    {
            public static void ejer2()
        {
            Console.WriteLine("Sus datos personales son lo siguientes:");

            string nombre = "Jose";
            string cargo = "Ejecutivo";
            string correo = "humberto.poada@gmail.com";
            int edad = 27;
            edad = Convert.ToInt32(edad);
            string contrato = "14 de enero de 2000";
            int sueldo = 5000;
            sueldo = Convert.ToInt32(sueldo);
            Console.WriteLine("\n Su nombre es: {0}", nombre);
            Console.WriteLine("\n Tiene el cargo de {0}", cargo);
            Console.WriteLine("\n El correo que nos ha proporcionado es {0}", correo);
            Console.WriteLine("\n Usted tiene {0} años", edad);
            Console.WriteLine("\n Lo contratamos el {0}", contrato);
            Console.WriteLine("\n Su suedo es {0:c}", sueldo);
            Console.ReadKey();
        }
    }
}
