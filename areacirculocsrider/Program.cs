// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace tallerdXCsSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var radio = 0.0;
            var resultado = 0.0;
            const double Pi = 3.14159;
            Console.WriteLine("Calcular area de un circulo"); //ac=pi*radio*radio
            Console.WriteLine("Ingrese valor del radio: ");
            radio = double.Parse(Console.ReadLine());
            resultado = Pi * radio * radio;

            Console.WriteLine($"El area del circulo es {resultado}");
        }
    }
}    