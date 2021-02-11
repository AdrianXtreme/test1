using System;
using System.Collections.Generic;

namespace TEST1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] e = new int[6];
            e[0] = LectorDatos("Introduce el primer número");
            e[1] = LectorDatos("Introduce el primer número");
            e[2] = LectorDatos("Introduce el primer número");
            e[3] = LectorDatos("Introduce el primer número");
            e[4] = LectorDatos("Introduce el primer número");
            e[5] = LectorDatos("Introduce el primer número");
            for (int i = 0; i < 6; i++)
                int suma += e[i];
            

            //   Prueba1(6, 8);
            // EjerciciosExamen.potencia2(5);
            // EjerciciosExamen.PrintSerie10(5);
            //while (true)
            //    {
            //       for (int i = 0; i < 10; i++)
            //        {
            //           EjerciciosExamen.PrintSerie10(i);
            //           System.Threading.Thread.Sleep(10);
            //           System.Console.Clear();
            //       }
            //   }
            // }
            //    List<int> intList = new List<int>();
            //    intList.Add(3);
            //    intList.Add(5);
            //    intList.Add(-1);
            //    intList.Add(0);
            //    intList.Add(7);
            //    intList.Add(-2);
            //
            // PrintList(intList);
            //    IsOnList(intList);

            //    for (int i = 0; i < intList.Count - 1; i++)
            //    {
            //        for (int j = i + 1; j < intList.Count; j++)
            //            if (intList[i] > intList[j])
            //            {
            //                int aux = intList[j];
            //                intList[j] = intList[i];
            //               intList[i] = aux;
            //            }
            //    }
            //    Console.WriteLine();
            //    PrintList(intList);
        }

        public static void Prueba1(int x, int y)
        {
            for (int j = 0; j < y; j++)
            {
                if (j == 0 || j == y - 1)
                {
                    for (int i = 0; i < x; i++)
                        Console.Write("*");
                }
                else
                        Console.WriteLine("*", x - 2 ," ");
                
            }
        }

        public static void Prueba2()
        {

        }
        public static int LectorDatos(string mensaje)
        {
            while (true)
                try
                {
                    Console.WriteLine(mensaje);
                    int n = Convert.ToInt32(Console.ReadLine());
                    return n;
                }
                catch
                {
                    Console.WriteLine("Valor no válido. Por favor, inténtalo de nuevo: ");
                }

        }
        public static void PrintList(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
                Console.WriteLine(list[i]);
        }

        public static bool IsOnList(int n, List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == n)
                    return true;
            }
            return false;
        }

        public static bool BinarySearch(int n, List<int> list)
        {
            int min = 0;
            int max = list.Count - 1;
            while (min <= max)
            {                
                int mid = (min + max) / 2;
                if (list[mid] == n)
                    return true;

                if (n < mid)
                    max = mid - 1;               

                if (n > mid)
                    min = mid + 1;                                
            }
            return false;
        }
    }           
}

