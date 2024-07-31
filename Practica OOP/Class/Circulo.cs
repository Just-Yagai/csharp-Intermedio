namespace Practica_OOP.Class
{
    public class Circulo : Figura
    {
        public double Radio {  get; set; }

        public Circulo(double radio) 
        { 
            Radio = radio;
        }

        public override double CalArea()
        {
            return Radio * Radio;
        }
    }
}
