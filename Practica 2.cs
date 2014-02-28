
using System;

namespace practica_2
{
	class Program
	{
		public static void Main(string[] args)
		{
			
		double Precio1,Precio2,Precio3;
			double iva=1.16;
			Console.WriteLine("Introduce el precio del refresco ");
			float numer1 =float.Parse(Console.ReadLine());
			Console.WriteLine("Introduce el precio del pan ");
			float numer2=float.Parse(Console.ReadLine());
			Console.WriteLine("troduce el prescio de la tortilla");
			float numer3=float.Parse(Console.ReadLine());
			
		Precio1=numer1*iva;
	    Precio2=numer2*iva;
	   Precio3=numer3*iva;
	   
	   Console.WriteLine("El precio del refresco con iva "+Precio1);
	   Console.WriteLine("El precio del pan con iva "+Precio2);
	   Console.WriteLine("El precio del tortillas con iva"+Precio3);
	   Console.WriteLine("El precio total es"+(Precio1+Precio2+Precio3));
	   
	   
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}