using System;
namespace interfacesYClasesAbstractas
{
	public class Diesel : IMotor
	{
		public Diesel ()
		{
		}
		
		public void arrancar(){
			Console.WriteLine("Inyectar combustible.");
			Console.WriteLine("Iniciar aire.");
			Console.WriteLine("Encender.");
		}
		
		public void detener(){
			Console.WriteLine("Detener inyección.");
		}
	}
}

