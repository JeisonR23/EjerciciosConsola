using System;

namespace ejer5
{
    class AreaYPerimetroDeUnPoligonoRegular
    {
        static void Main(string[] args)
        {
           bool salir = false;
 
            while (!salir) {
 
                try
                {
                    Console.WriteLine("Que Operacion deseas Hacer?");
                    Console.WriteLine("1.Calcular Perimetro");
                    Console.WriteLine("2.Calcular Area");
                    Console.WriteLine("3. Salir");
                    int opcion = Convert.ToInt32(Console.ReadLine());
                   switch (opcion)
                    {
                        case 1:
                        Perimetro();
                         break;
                        case 2:
                            Area();
                            break;
 
                        case 3:
                           Console.WriteLine("Has elegido salir de la aplicación");
                            salir = true;
                            break;
                        default:
                            Console.WriteLine("Elige una opcion entre 1 y 3");
                            break;
                    }

                } catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }



        }
    }

    static void Perimetro(){

       double  longitud_de_lado, numero_de_lados, perimetro;
       Console.Write("Ingresa la longitud de los lados: ");
       longitud_de_lado = double.Parse(Console.ReadLine());
       Console.Write("Ingresa el numero de lados: ");
       numero_de_lados = double.Parse(Console.ReadLine());
       perimetro=numero_de_lados*longitud_de_lado;
       Console.WriteLine("Valor de perimetro: " + perimetro  + " Cm");
       Console.Write("Presiona una tecla para terminar . . . ");
       Console.ReadKey();
        
    }
    static void Area(){

          double apotema, area, longitud_de_lado, numero_de_lados;
            Console.Write("Ingresa el valor de apotema: ");
            apotema = double.Parse(Console.ReadLine());
            Console.Write("Ingresa la longitud de los lados: ");
            longitud_de_lado = double.Parse(Console.ReadLine());
            Console.Write("Ingresa el numero de lados: ");
            numero_de_lados = double.Parse(Console.ReadLine());
            area=apotema*apotema*numero_de_lados*Math.Tan(Math.PI/numero_de_lados);
            Console.WriteLine("Valor de area: " + area +" Cm");
            Console.WriteLine();
            Console.Write("Presiona una tecla para terminar . . . ");
            Console.ReadKey();

    }
}
}