using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace TEST1
{
    class Ejercicios
    {
        // Ejercicio: Hacer una función que imprima por pantalla los números del 0 al 99

        public static void Ejercicio1()
        {
            int counter;
            counter = 0;
            while (counter < 100)
            {
                System.Console.WriteLine(counter);
                // counter = counter + 1;
                //counter += 1;
                counter++;
            }
        }

        // Ejercicio: Haz una función que imprima los números pares que hay desde el 0 hasta n

        public static void Ejercicio2(int n)
        {
            int i;
            i = 0;
            while (i < n)
            {
                if (Utils.IsEven(i))
                    System.Console.WriteLine(i);
                i++;
            }
        }

        public static void Ejercicio3(int numerico)
        {
            int i;
            i = 2;
            while (i < numerico)
            {
                if (Utils.IsPrime(numerico))
                    System.Console.WriteLine("Este número es primo");
            }
        }


    }
}
