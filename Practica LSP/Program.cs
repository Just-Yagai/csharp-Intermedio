using Practica_LSP.Class;

class program
{
    public static void Main()
    {
        FiguraGeometrica figura = new FiguraGeometrica { Base = 5, Altura = 10 };
        Rectangulo rectangulo = new Rectangulo { Base = 5, Altura = 10 };
        Cuadrado cuadrado = new Cuadrado { Base = 5 };

        Console.WriteLine("Área de la Figura Geométrica: " + figura.CalcularArea());
        Console.WriteLine("Área del Rectángulo: " + rectangulo.CalcularArea());
        Console.WriteLine("Área del Cuadrado: " + cuadrado.CalcularArea());
    }
}