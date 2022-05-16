using System;

namespace EJE4
{
    class CelsiusFahrenheit
    {
        static void Main(string[] args)
        {
            double centigrados, fahrenheit;
            Console.Write("Ingresa el numero de grados Centrigrados: ");
            centigrados = double.Parse(Console.ReadLine());
            fahrenheit = (centigrados *9/5) + 32;
            Console.WriteLine("Valor de grados en Fahrenheit es de : " + fahrenheit + " grados Fahrenheit");
            Console.WriteLine();
            Console.Write("Presiona una tecla para terminar . . . ");
            Console.ReadKey();
        }
    }
}