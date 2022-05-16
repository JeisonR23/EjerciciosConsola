using System;

namespace EJE5
{
    class TasaCambio
    {
        static void Main(string[] args)
        {
            double dolar, euro, pesos, valorCamboDolar, valorCamboEuro;
            
            Console.Write("Ingresa el numero de pesos: ");
            pesos = double.Parse(Console.ReadLine());
            Console.Write("Ingresa el valor de Cambio del Dolar: ");
            valorCamboDolar= double.Parse(Console.ReadLine());
             Console.Write("Ingresa el valor de Cambio del Euro: ");
            valorCamboEuro = double.Parse(Console.ReadLine());
            dolar = pesos /valorCamboDolar;
            euro = pesos /valorCamboEuro;
            Console.WriteLine("La cantidad de dolares es de : " + dolar + " dolares");
              Console.WriteLine("La cantidad de Euros es de : " + euro + " euros");
            Console.WriteLine();
            Console.Write("Presiona una tecla para terminar . . . ");
            Console.ReadKey();
        }
    }
}
