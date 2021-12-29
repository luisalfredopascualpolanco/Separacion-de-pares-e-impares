using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto9._11
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Introduzca la cantidad de valores permitidos en la lista: ");
                int cantidad = int.Parse(Console.ReadLine());
                int[] numeros = new int[cantidad];
                int vuelta = 0;
                int posicion, pares, impares;
                                
                while (vuelta<cantidad)
                {
                    posicion = vuelta + 1; 
                    Console.Write("Introduzca el valor #"+posicion+": ");
                    numeros[vuelta] = int.Parse(Console.ReadLine());
                    vuelta++;
                }
                vuelta = 0;
                pares = 0;
                impares = 0;

                while (vuelta<cantidad)
                {                    
                    if (numeros[vuelta]%2==0)
                    {
                        pares = pares + 1;
                    }
                    else
                    {
                        impares = impares + 1;
                    }
                    vuelta++;
                }
                Console.WriteLine("Hay "+pares+" numeros pares y "+impares+" impares.");
            }
            catch (Exception)
            {
                Console.WriteLine("Usted ha introduce un valor invalido.");
            }
            Console.ReadKey();
        }
    }
}
