using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tallerdXCsSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //escribir mensaje
            Console.WriteLine("bienbenido as csshar");

                //--Definir Variables--
                int a, b, producto;

            //--Entrada de datos--
            Console.WriteLine("ingrese primer numero");
            //Guardar valor de la consola
            a= int.Parse(Console.ReadLine());
            //a= int.Tryparse(Console.ReadLine()); //Boolean True o False

            Console.WriteLine("ingrese segundo ");
            //Guardar valor de la consola
            b = Convert.ToInt32(Console.ReadLine());
            //b=int.Tryparse(Console.ReadLine()); //Boolean True o False

            //--Proceso--
            producto = a * b;
             //-- Salida Datos --
            //deterner la pantalla paramostrar resultado
        }
    }
}
