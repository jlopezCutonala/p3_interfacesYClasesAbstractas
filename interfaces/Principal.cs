using System;

namespace interfacesYClasesAbstractas
{
	class Principal
	{
		public void interfaces(){
			System.Collections.ArrayList arreglo = new System.Collections.ArrayList();
			Gasolina motorGasolina = new Gasolina();
			motorGasolina.arrancar();
			motorGasolina.detener();
			arreglo.Add(motorGasolina);			
			Console.WriteLine("");
			
			Diesel motorDiesel = new Diesel();
			motorDiesel.arrancar();
			motorDiesel.detener();
			arreglo.Add(motorDiesel);
			
			Console.WriteLine("");
			
			foreach(IMotor motor in arreglo){
				motor.arrancar();
			}
			
		}
		
		public void clasesAbstractas(){
			System.Collections.ArrayList arreglo = new System.Collections.ArrayList();
			Cuadrado cuadrado = new Cuadrado(5);
			Console.WriteLine("El área del cuadrado es " + cuadrado.Area());
			arreglo.Add(cuadrado);
			
			Circulo circulo = new Circulo(5);
			Console.WriteLine("El área del circulo es " + circulo.Area());
			
			Console.WriteLine("");
			arreglo.Add(circulo);
			
			foreach(FiguraGeometrica figura in arreglo){
				Console.WriteLine("El área es " + figura.Area());
			}
		}
		
		public static void Main (string[] args)
		{
			Principal programa = new Principal();
			//programa.interfaces();
			programa.clasesAbstractas();
		}
	}
}

