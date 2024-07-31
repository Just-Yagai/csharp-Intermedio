using Practica_OOP.Class;

public class Program
{
    public static void Main()
    {
        Rectangulo rectangulo = new Rectangulo(5, 7);
        Circulo circulo = new Circulo(3);
        Triangulo triangulo = new Triangulo(4, 6);

        Console.WriteLine($"Área del Rectángulo: {rectangulo.CalArea()}");
        Console.WriteLine($"Área del Círculo: {circulo.CalArea()}");
        Console.WriteLine($"Área del Triángulo: {triangulo.CalArea()}");
    }
}