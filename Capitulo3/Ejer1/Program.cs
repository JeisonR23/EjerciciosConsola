using System;

namespace EJE1
{
    class TasaCambio
    {
        static void Main(string[] args)
        {
            int numero, resultado;
            
            Console.Write("Ingresa un numero: ");
            numero = int.Parse(Console.ReadLine());
            resultado = numero % 2;
            if (resultado == 0 )
            {
              Console.WriteLine("El numero es par");
            } else{
                Console.WriteLine("El numero es Impar");
            }
            Console.Write("Presiona una tecla para terminar . . . ");
            Console.ReadKey();
        }

    }
}
