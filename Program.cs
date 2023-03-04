using System;

namespace Labortarotio_01_04
{
    class Program
    {
        static void Main(string[] args)
        {
            //VARIABLES
            int num1;
            int num2;
            double num1d, num2d;
            int suma, resta, div, mod;
            double multiplicacion, division;



            Console.WriteLine("Ejercicio 1: Operaciones aritmeticas");

            Console.Write("Ingrese el primer numero");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el segundo numero");
            num2 = Convert.ToInt32(Console.ReadLine());

            /*CONVERSION IMPLICITA:
            
            num1d = num1;
            num2d = num2;
            */

            //CONVERSION EXPLICITA:
            num1d = (double)num1;
            num2d = (double)num2;


            //SUMA:
            suma = num1 + num2;
            Console.WriteLine(num1 + " + " + num2 + " = " + suma);

            //RESTA:
            resta = num1 - num2;
            Console.WriteLine(num1 + " - " + num2 + " = " + resta);

            //MULTIPLICACION:
            multiplicacion = num1 * num2;
            Console.WriteLine(num1 + " * " + num2 + " = " + multiplicacion);

            //DIVISION:
            division = num1d / num2d;
            Console.WriteLine(num1 + " / " + num2 + " = " + division);

            //DIV:
            div = num1 / num2;
            Console.WriteLine("(ENTEROS) " + num1 + " / " + num2 + " = " + div);

            //MOD:
            mod = num1 % num2;
            Console.WriteLine(num1 + " % " + num2 + " = " + mod);

            //EJERCICIO 2
            Console.WriteLine("EJERCICIO NUMERO 2 OPERACIONES BOOLEANAS");

            if (num1 > num2)
            {
                Console.WriteLine(num1 + " > " + num2);

            }
            else if (num2 > num1)
            {
                Console.WriteLine(num2 + " > " + num1);
            }
            else if (num1 == num2)
            {
                Console.WriteLine(num1 + " = " + num2);
            }


        }
    }
}
