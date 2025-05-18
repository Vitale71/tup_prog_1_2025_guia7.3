using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float acum = 0, prom;
            int cont = 0, num;
            Console.WriteLine("ingrese un numero entre 0 y 100, si el numero esta fuera de ese rango se termina el ingreso de numeros");
            num = Convert.ToInt32(Console.ReadLine());
            while (num >= 0 && num <= 100)
            {
                acum += num;
                cont++;
                Console.WriteLine("ingrese un numero entre 0 y 100, si el numero esta fuera de ese rango se termina el ingreso de numeros");
                num = Convert.ToInt32(Console.ReadLine());
            }
            if (cont > 0)
            {
                prom = acum / cont;
                Console.WriteLine("el promedio de {0} numeros es de: {1}", cont, prom);
            }
            else
            {
                Console.WriteLine("no se ingresaron numeros");
            }
        }
    }
}
