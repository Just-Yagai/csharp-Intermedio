using Practica_OCP.Class;
using System;

namespace Practica_OCP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de Impuestos");

            TaxCalculator taxCalculator = new TaxCalculator();

            decimal montoTotal = 0;
            decimal deduccionTotal = 0;

            string[] paises = { "USA", "CA", "RD", "UK" };

            foreach (string pais in paises)
            {
                try
                {
                    decimal impuesto = taxCalculator.Calcular(montoTotal, deduccionTotal, pais);
                    Console.WriteLine($"El impuesto para {pais} es {impuesto}");
                }
                catch(Exception ex) 
                {
                    Console.WriteLine(ex.Message); 
                }
            }
        }
    }
}