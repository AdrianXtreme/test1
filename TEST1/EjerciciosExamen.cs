using System.Collections.Specialized;
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
    }
}
