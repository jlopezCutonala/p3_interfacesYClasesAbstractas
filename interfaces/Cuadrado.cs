using System;
namespace interfacesYClasesAbstractas
{
   class Cuadrado: FiguraGeometrica 
    {
        //atributos
        private int lado;

        public int Lado {
            get {
                return lado; 
            }
            set  {
                lado = value; 
            }
        }

        public Cuadrado(int l)  {
            Lado = l;
        }

        public override double Area()   {
            return Lado*Lado;
        }

    }
}

