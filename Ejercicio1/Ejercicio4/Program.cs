using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, mayor = 0, menor = 0, rangoI, rangoF;
            Console.WriteLine("ingrese el inicio del rango de numeros a ingresar");
            rangoI = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese el fin del rango de numeros a ingresar");
            rangoF = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine("ingrese el numero " + (i + 1));
                num = Convert.ToInt32(Console.ReadLine());
                if (num >= rangoI && num <= rangoF)
                {
                    if (i == 0 || num > mayor)
                    {
                        mayor = num;
                    }
                    if (i == 0 || num > menor)
                    {
                        menor = num;
                    }
                }
                else
                {
                    Console.WriteLine("El numero ingresado esta fuera del rango");
                }
            }
            Console.WriteLine("el mayor numero ingresado es: " + mayor);
            Console.WriteLine("el menor numero ingresado es: " + mayor);
        }
    }
}