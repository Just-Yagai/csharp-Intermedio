namespace Practica_OOP.Class
{
    public abstract class Figura
    {
        public abstract double CalArea();
    }

    public class Rectangulo : Figura 
    { 
        public double Ancho {  get; set; }
        public double Alto { get; set; }

        public Rectangulo(double ancho, double alto) 
        { 
            Ancho = ancho;
            Alto = alto;        
        } 

        public override double CalArea() 
        {
            return Ancho * Alto;
        }    
    }
}
