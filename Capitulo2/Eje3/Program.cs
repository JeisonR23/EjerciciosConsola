using System;

namespace Eje3
{
    class GradosRadianes
    {
        static void Main(string[] args)
        {
            double grados, pi=3.1416 , radianes;

            Console.Write("Ingresa la cantidad de grados: ");
            grados = double.Parse(Console.ReadLine());
            radianes = grados*(pi/180);
            Console.WriteLine("La cantidad de radianes es: " + radianes);
            Console.WriteLine();
            Console.Write("Presiona una tecla para terminar . . . ");
            Console.ReadKey();
        }
    }
}