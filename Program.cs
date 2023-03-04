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

            Console.WriteLine("EJERCICIO 3: JERARQUIA DE OPERACIONES");

            //VARIABLES
            double a, b, c;
            double r1, r2, r3, r4;

            //PEDIR DATOS
            Console.WriteLine("INGRESE A");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("INGRESE B");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("INGRESE C");
            c = Convert.ToDouble(Console.ReadLine());

            //OPERACIONES
         
            //INCISIO 1
            r1 = a * b + c;

            //INCISO 2
            r2 = a * (b + c);

            //INCISO 3
            r3 = a / (b * c);

            //INCISO 4
            r4 = (3 * a + 2 * b) / (c * c);

            //RESPUESTAS
            Console.WriteLine("EL RESULTADO DEL PRIMER INCISO ES: " + r1);
            Console.WriteLine("EL RESULTADO DEL SEGUNDO INCISO ES: " + r2);
            Console.WriteLine("EL RESULTADO DEL TERCER INCISO ES: " + r3);
            Console.WriteLine("EL RESULTADO DEL CUARTO INCISO ES: " + r4);

            //EJERCICIO 4
            Console.WriteLine("EJERCICIO 4: FORMULA GENERAL");


            //FORMULA
            double determinante, raiz1, raiz2;


            determinante = (b * b) - (4 * (a) * (c));

            if (determinante <= 0)
            {
                Console.WriteLine("ERROR: LA DETERMINANTE ES INVALIDA");
            }
            else
            {
                raiz1 = (-(b) + Math.Sqrt(determinante)) / (2 * a);
                raiz2 = (-(b) - Math.Sqrt(determinante)) / (2 * a);

                Console.WriteLine("X1 = " + raiz1);
                Console.WriteLine("X2 = " + raiz2);
            }
        }
    }
}
