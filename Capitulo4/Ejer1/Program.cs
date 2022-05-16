using System;
 
namespace ejer1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int number=0;
             
            Console.WriteLine("Introduce un número:");
            number=int.Parse(Console.ReadLine());
             
            for(int i=0; i<=10;i++)
            {
                Console.WriteLine(number+"x"+i+"="+(i*number));
            }
             
             
            Console.Write("Presiona cualquier tecla patra continuar. . . ");
            Console.ReadKey(true);
        }
    }
} 