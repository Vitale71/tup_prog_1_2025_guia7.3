using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float num, acum = 0, prom;
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("ingrese el numero " + (i+1));
                num = Convert.ToSingle(Console.ReadLine());
                acum += num;
            }
            prom = acum / 20f;
            Console.WriteLine("el promedio de los 20 numeros es: " + prom);
        }
    }
}
