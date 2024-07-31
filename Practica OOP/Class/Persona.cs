namespace Practica_OOP.Class
{
    public class Persona
    {
        public string? Nombre {  get; set; }
        public int Edad { get; set; }
        public string? Ciudad { get; set;}

        public Persona (string? nombre, int edad, string? ciudad)
        {
            Nombre = nombre;
            Edad = edad;
            Ciudad = ciudad;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}, Ciudad: {Ciudad}");
        }

        public int CalYears()
        {
            return Edad;
        }
    }
}
