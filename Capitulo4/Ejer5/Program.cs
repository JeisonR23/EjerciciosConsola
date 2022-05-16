namespace Application
{
 class MainClass
 {
  public static void Main (string[] args)
  {
   

   int ma=0, me=0, cantidad=0;
   Console.WriteLine ("Cuantos Personas va evaluar");
   int edad=int.Parse(Console.ReadLine());
   for(int i =1;i<=edad;i++){
   Console.WriteLine ("Digite una edad: ");
   cantidad=int.Parse(Console.ReadLine()); 
    
    if(i==1){
     ma=cantidad;
     me=cantidad;
    }
    if(cantidad>ma){ma=cantidad;}
    if(cantidad<me){me=cantidad;}
    
   cantidad=0; 
   } 
   Console.WriteLine (" La edad mayor es: "+ma);
   Console.WriteLine (" La edad menor es: "+me);
   
  }
 }
}
