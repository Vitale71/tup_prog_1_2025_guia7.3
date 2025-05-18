using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cont = 0, num;
            Console.WriteLine("ingrese un numero entre 0 y 100, si quiere salir ingrese -1");
            num = Convert.ToInt32(Console.ReadLine());
            int mayor = num;
            int menor = num;
            while (num != -1)
            {
                if (num >= 0 && num <= 100)
                {
                    cont++;
                    if (num > mayor)
                    {
                        mayor = num;
                    }
                    if (num < menor)
                    {
                        menor = num;
                    }
                    Console.WriteLine("ingrese un numero entre 0 y 100, si quiere salir ingrese -1");
                    num = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("se ingreso un numero no valido");
                    Console.WriteLine("ingrese un numero entre 0 y 100, si quiere salir ingrese -1");
                    num = Convert.ToInt32(Console.ReadLine());
                }
            }
            if (cont > 0)
            {
                Console.WriteLine("el mayor numero es: " + mayor);
                Console.WriteLine("el menor numero es: " + menor
            }
            else
            {
                Console.WriteLine("no se ingresaron numeros");
            }
        }
    }
}
