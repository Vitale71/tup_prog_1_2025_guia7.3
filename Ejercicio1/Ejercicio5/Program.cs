using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float porcP, porcN, porcI;
            int positivo = 0;
            int negativo = 0;
            int indeciso = 0;
            int cont = 0;
            Console.WriteLine("ingrese la primera opinion");
            Console.WriteLine("ingrese (0) para positivo, (1) para negativo, (2) para indeciso y (-1) si no hay encuestado");
            int opinion = Convert.ToInt32(Console.ReadLine());
            while (opinion != -1)
            {
                cont++;
                switch (opinion)
                {
                    case 0:
                        positivo++;
                    break;

                    case 1:
                        negativo++;
                    break;

                    case 2:
                        indeciso++;
                    break;

                    default:
                        Console.WriteLine("opción invalida");
                        cont--;
                    break;
                }
                Console.WriteLine("ahora ingrese la siguiente opinion");
                Console.WriteLine("ingrese (0) para positivo, (1) para negativo, (2) para indeciso y (-1) si no hay encuestado");
                opinion = Convert.ToInt32(Console.ReadLine());
            }
            if (cont != 0)
            {
                porcP = (positivo * 100f) / cont;
                porcN = (negativo * 100f) / cont;
                porcI = (indeciso * 100f) / cont;
                Console.WriteLine("el porcentaje de {0} opiniones positivas es: {1}", cont, porcP);
                Console.WriteLine("el porcentaje de {0} opiniones negativas es: {1}", cont, porcN);
                Console.WriteLine("el porcentaje de {0} opiniones indecisas es: {1}", cont, porcI);
            }
            else
            {
                Console.WriteLine("no se ingreso ninguna opinion");
            }
        }
    }
}
