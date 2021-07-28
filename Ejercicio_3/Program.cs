using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaracion de variable. 

            int num1, num2, divi;

            // Captura de datos. 

            Console.WriteLine("INGRESAR EL PRIMER DIGITO: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("INGRESAR EL SEGUNDO DIGITO: ");
            num2 = Convert.ToInt32(Console.ReadLine()); 

            // Condicion 

            if (num2 <= 0)
            {
                Console.WriteLine("ERROR: NO SE PUEDE DIVIDIR ENTRE 0");
            }
            else
            {
                divi = num1 / num2;

                // Mostrar en patalla. 

                Console.WriteLine("LA DIVISION DEL PRIMER DIGITO ENTRE SEGUNDO DIGITO ES: {0}", divi); 

            }
            Console.ReadKey(); 
        }
    }
}
