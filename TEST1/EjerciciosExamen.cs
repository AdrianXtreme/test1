﻿using System.Collections.Specialized;
using System.IO;

namespace TEST1
{
    class EjerciciosExamen
    {
        public static int SumaEnteros(int num1, int num2)
        {
            return num1 + num2;
        }

        //Hacer una función que reciba dos reales y devuelva la resta de esos dos reales

        public static double RestaReales(double num1, double num2)
        {
            return num1 - num2;
        }

        //Hacer una función a la que se le pasen dos enteros y devuelva el menor de ellos


        public static int MinValue(int num1, int num2)
        {
            if (num1 < num2)
                return num1;
            else
                return num2;
        }

        //Hacer una función que reciba como parámetro dos enteros y devuelva si el primero es menor que el segundo

        public static bool EsMenor(int num1, int num2)
        {
            bool result;
            if (num1 < num2)
                result = true;
            else
                result = false;
            return result;
        }

        // Hacer una función a la que se le pasen tres strings y devuelva la concatenación de los tres strings

        public static string Cat(string s1, string s2, string s3)
        {
            return s1 + s2 + s3;
        }

        // Hacer una función que reciba dos enteros y devuelva -1 si el primero es menor que el segundo, +1 si el segundo es menor que el primero,
        // y 0 en cualquier otro caso (que sean iguales)

        public static int Compare(int num1, int num2)
        {
            if (num1 > num2)
                return -1;
            if (num1 > num2)
                return 1;
            return 0;
        }

        // Hacer una función que te devuelva el menor de tres enteros

        public static int MinValue2(int a, int b, int c)
        {

            //if (a <= b && a <= c)
            //   return a;
            // if (b < c)
            //   return b;
            // return c;

            if (a <= b)
            {
                if (a < c)
                    return a;
                else
                    return c;
            }

            else
            {
                if (b < c)
                    return b;
                else
                    return c;
            }
        }

        // Hacer una función que reciba un código de error e imprima por pantalla lo siguiente:
        // - "Error grave" si el código de error es 0
        // - "Error moderado" --- 1
        // - "Error leve" --- 2
        // - "Error desconocido" en otro caso

        public static void PrintError(int code)
        {
            switch (code)
            {
                case 0:
                    System.Console.WriteLine("Error grave");
                    break;
                case 1:
                    System.Console.WriteLine("Error moderado");
                    break;
                case 2:
                    System.Console.WriteLine("Error leve");
                    break;
                default:
                    System.Console.WriteLine("Error desconocido");
                    break;

            }

        }

        // Hacer una función a la que se le pase un número e imprima por pantalla una serie como la siguiente:
        // función (10) --> 0, 3, 6, 9
        // función (15) --> 0, 3, 6, 9, 12, 15
        // función (2) --> 0

        public static void PrintSerie(int num)
        {
            int counter = 0;
            while (counter <= num)
            {
                System.Console.Write(counter + ", ");
                counter += 3;
            }
        }

        // Hacer una función que imprima por pantalla la siguiente serie:
        // Serie (10) --> 0, 1, 2, 3, 4, 5, 6, 7, 8, 9
        // Serie (3) --> 0, 1, 2

        public static void PrintSerie2(int n)
        {
            // int i = 0;
            //  while (i < n)
            //  {
            //     System.Console.Write(i + ", ");
            //       i++;
            //  }
            for (int i = 0; i < n; i++)
                System.Console.Write(i + ", ");
        }

        // Hacer una función que imprima por pantalla la siguiente serie:
        // Serie (10) --> 0, 1, 2, 3, 4, 5, 6, 7, 8, 9
        // Serie (3) --> 0, 1, 2

        public static void PrintSerie3(int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (i == n - 1)
                    System.Console.Write(i);
                else
                    System.Console.Write(i + ", ");
            }
            
                
        }

        // Hacer una función a la que se le pase un número "n" e imprima por pantalla "n" asteriscos

        public static void PrintAsteriscos(int n)
        {
            for (int i = 0; i < n; i++)
                System.Console.Write("*");
        }

        // Hacer una función a la que se le pase un número "n" e imprima por pantalla "n" elementos(*+*+)
        public static void PrintSerie4(int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                    System.Console.Write("*");
                else
                    System.Console.Write("+");
            }
        }

        // Hacer una función que devuelva el menor de nueve enteros. Debe ocupar una sola línea
        public static int GetMinValue2(int num1, int num2, int num3, int num4, int num5, int num6, int num7, int num8, int num9)
        {
            int menor1 = MinValue2(num1, num2, num3); int menor2 = MinValue2(num4, num5, num6); int menor3 = MinValue2(num7, num8, num9); return MinValue2(menor1, menor2, menor3);
        }

        // Hacer una función
        public static void PrintAsteriscos2(int n)
        {
            for (int f = 0; f < n; f++)
                        {
                            for (int c = 0; c < n; c++)
                                System.Console.Write("*");
                            System.Console.WriteLine();
                        }
        }
    }
}
