using System;
namespace interfacesYClasesAbstractas
{
    class Circulo: FiguraGeometrica   {
        private int radio;

        public int Radio  {
            get  {
                return radio; 
            }
            set  {
                radio = value; 
            }
        }

        public Circulo(int radio) {
            Radio = radio;
        }

        public override double Area()   {
            return (double)(Radio*Radio*3.14);
        }

    }
}

