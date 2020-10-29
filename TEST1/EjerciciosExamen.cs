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
    }
}
