

namespace Eje1
{
    class perimetro
    {
        static void Main(string[] args)
        {
            double  longitud_de_lado, numero_de_lados, perimetro;
           
            Console.Write("Ingresa la longitud de los lados: ");
            longitud_de_lado = double.Parse(Console.ReadLine());
            Console.Write("Ingresa el numero de lados: ");
            numero_de_lados = double.Parse(Console.ReadLine());
            perimetro=numero_de_lados*longitud_de_lado;
            Console.WriteLine("Valor de perimetro: " + perimetro  + " Cm");
            
            Console.WriteLine();
            Console.Write("Presiona una tecla para terminar . . . ");
            Console.ReadKey();
        }
    }
}