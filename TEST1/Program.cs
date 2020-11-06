using System;

namespace TEST1
{
    class Program
    {
        static void Main(string[] args)
        {
            // EjerciciosExamen.PrintSerie10(5);
            while (true)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        EjerciciosExamen.PrintSerie10(i);
                        System.Threading.Thread.Sleep(10);
                        System.Console.Clear();
                    }
                }
            }


        }

     
               
    }

