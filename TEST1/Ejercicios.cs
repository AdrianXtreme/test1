﻿using System;
using System.Collections.Generic;
using System.Net.Security;
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
        public static void Ejercicio9()
        {
            int n = 0;
            while (n <= 50)
            {   
                // if (n % 2 == 0)
                if (Utils.IsEven(n))
                    System.Console.WriteLine(n);
                else
                    System.Console.WriteLine(-n);
                n++;
            }
        }
        public static void Ejercicio10()
        {
            int aa = 0;
            int a = 1;
            int n = 0;
            System.Console.WriteLine(aa);
            System.Console.WriteLine(a);
            while (n <= 50)
            {
                System.Console.WriteLine(a + aa);
                int aux = a;
                a = a + aa;
                aa = aux;

                n++;
            }
        }

        public static void Asteriscos(int count)
        {
                int i = 0;
            while (i < count)
            {
                System.Console.Write("*");
                i++;
            }
                
        }
        public static void Asteriscos1(int count)
        {
            for (int i = 0; i < count; i++)
            {
                System.Console.Write("*");
            }

        }
    }
}
