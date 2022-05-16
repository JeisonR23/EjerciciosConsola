using System;

class Potencias{
    public static void Main(){
        int numero, potencia;
         double elevadoAlCuadrado;

        Console.WriteLine("Introduce un numero: ");
        numero = int.Parse(Console.ReadLine());
        Console.WriteLine("Introduce una Potencia: ");
        potencia = int.Parse(Console.ReadLine());
        elevadoAlCuadrado  = Math.Pow(numero, potencia); 
        Console.WriteLine(string.Format("{0} elevado al cuadrado es {1}", numero, elevadoAlCuadrado));
    }
}