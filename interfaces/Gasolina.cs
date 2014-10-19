using System;
namespace interfacesYClasesAbstractas
{
	public class Gasolina : IMotor
	{
		public Gasolina ()
		{
		}
		
		public void arrancar(){
			Console.WriteLine("Inyectar aire.");
			Console.WriteLine("Iniciar carburación.");
			Console.WriteLine("Encender.");
		}
		
		public void detener(){
			Console.WriteLine("Detener carburación.");
		}
	}
}

