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
            {
                bool es_primo = Utils.IsPrime(numerico);
                if (es_primo)
                    System.Console.WriteLine("El número " + numerico + " es primo");
                else
                    System.Console.WriteLine("El número " + numerico + " no es primo");
            }
        }
        public static void Ejercicio4()
        {
            int n = 0;
            while (n <= 200)
            {
                System.Console.WriteLine(n);
                n++;
            }
        }

        public static void Ejercicio5()
        {
            int n = 0;
            while (n <= 200)
            {
                System.Console.WriteLine(n * 3);
                n++;
            }

        }
        public static void Ejercicio6()
        {
            int n = 0;
            while (n <= 50)
            {
                System.Console.WriteLine(n * n);
                n++;
            }
        }
        public static void Ejercicio7()
        {
            int n = 0;
            while (n <= 50)
            {
                System.Console.WriteLine(n * n + 1);
                n++;
            }


        }
        public static void Ejercicio8()
        {
            int n = 0;
            while (n <= 50)
            {
                System.Console.WriteLine(5 - n);
                n++;
            }


        }
    }
}
