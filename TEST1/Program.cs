﻿using System;
using System.Collections.Generic;

namespace TEST1
{
    class Program
    {



        static void Main(string[] args)
        {
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
            List<int> intList = new List<int>();
            intList.Add(3);
            intList.Add(5);
            intList.Add(-1);
            intList.Add(0);
            intList.Add(7);
            intList.Add(-2);

            PrintList(intList);

            for (int i = 0; i < intList.Count - 1; i++)
            {
                for (int j = i + 1; j < intList.Count; j++)
                    if (intList[i] > intList[j])
                    {
                        int aux = intList[j];
                        intList[j] = intList[i];
                        intList[i] = aux;
                    }
            }
            Console.WriteLine();
            PrintList(intList);
        }

        public static void PrintList(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
                Console.WriteLine(list[i]);
        }

    }           
}

