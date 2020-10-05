using System;
using System.Collections.Generic;
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


    }
}
