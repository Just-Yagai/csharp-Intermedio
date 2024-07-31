namespace Practica_OOP.Class
{
    public class Estudiante : Persona
    {
        public string? Carrera {  get; set; }
        public string? Matricula { get; set; }  

        public Estudiante(string nombre, int edad, string ciudad, string carrera, string matricula) : base(nombre, edad, ciudad)
        { 
            Carrera = carrera;
            Matricula = matricula;
        }

        public void ShowInformation()
        {
            ShowInfo();
            Console.WriteLine($"Carrera: {Carrera}, Matricula: {Matricula}");
        }
    }
}
