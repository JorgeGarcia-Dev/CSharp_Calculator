/*
En este programa desarrollaremos una pequeña calculadora que se ejecutará desde la consola,
y que realizará las 4 operaciones básicas: sumar, restar, multiplicar y dividir.
*/

using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Esta es tu primer CALCULADORA programada con C#");
            System.Console.WriteLine("Menú: ");
            System.Console.WriteLine("1. Sumar");
            System.Console.WriteLine("2. Restar");
            System.Console.WriteLine("3. Multiplicar");
            System.Console.WriteLine("4. Dividir");
            System.Console.WriteLine("5. Salir");

            bool fin = false;
            int opcion = 0;
            while(!fin)
            {
                System.Console.WriteLine("Elige una opción:");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch(opcion)
                {
                    case 1:
                        System.Console.WriteLine("Has elegido sumar");
                        System.Console.WriteLine("Inserta el primer número a sumar:");
                        int sum1 = Convert.ToInt32(Console.ReadLine());
                        System.Console.WriteLine("Inserta el segundo número a sumar:");
                        int sum2 = Convert.ToInt32(Console.ReadLine());
                        System.Console.WriteLine("El resultado de la suma es: " + (sum1 + sum2));
                        break;

                    case 2:
                        System.Console.WriteLine("Has elegido restar");
                        System.Console.WriteLine("Inserta el número a restar:");
                        int rest1 = Convert.ToInt32(Console.ReadLine());
                        System.Console.WriteLine("Inserta el número sustraendo:");
                        int rest2 = Convert.ToInt32(Console.ReadLine());
                        System.Console.WriteLine("El resultado de la resta es: " + (rest1 - rest2));
                        break;

                    case 3:
                        System.Console.WriteLine("Has elegido multiplicar");
                        System.Console.WriteLine("Inserta el primer número a multiplicar:");
                        int mult1 = Convert.ToInt32(Console.ReadLine());
                        System.Console.WriteLine("Inserta el segundo número a multiplicar:");
                        int mult2 = Convert.ToInt32(Console.ReadLine());
                        System.Console.WriteLine("El resultado de la multiplicación es: " + (mult1 * mult2));
                        break;

                    case 4:
                        System.Console.WriteLine("Has elegido dividir");
                        System.Console.WriteLine("Inserta el número a dividir:");
                        int div1 = Convert.ToInt32(Console.ReadLine());
                        System.Console.WriteLine("Inserta el número divisor:");
                        int div2 = Convert.ToInt32(Console.ReadLine());
                        System.Console.WriteLine("El resultado de la multiplicación es: " + (div1 / div2));
                        break;
                        
                    case 5:
                        fin = true;
                        break;
                }
                System.Console.WriteLine("Programa finalizado");
                System.Console.ReadLine();
            }
        }
    }
}