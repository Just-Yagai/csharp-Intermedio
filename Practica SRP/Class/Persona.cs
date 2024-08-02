namespace Practica_SRP.Class
{
    //public class Persona
    //{
    //    private string nombre;
    //    private int edad;
    //    private string direccion;
    //    private string correoElectronico;

    //    public void EnviarCorreoElectronico(string mensaje)
    //    {

    //    }

    //    public void ImprimirDatos() 
    //    {
    //        Console.WriteLine($"Nombre: {nombre}");
    //        Console.WriteLine($"Edad: {edad}");
    //        Console.WriteLine($"Direccion: {direccion}");
    //        Console.WriteLine($"Correo Electronico: {correoElectronico}");
    //    }
    //}
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Direccion { get; set; }
        public string CorreoElectronico { get; set; } 

        public Persona (string nombre, int edad, string direccion, string correoElectronico)
        {
            Nombre = nombre;
            Edad = edad;
            Direccion = direccion;
            CorreoElectronico = correoElectronico;
        }
    }

    public class EnviarCorreoElectronico
    {
        public string Mensaje;

        public EnviarCorreoElectronico(string mensaje)
        {
            Mensaje = mensaje;
        }
    }

    public class ImprimirDatos
    {
        public ImprimirDatos(Persona persona)
        {
            Console.WriteLine($"Nombre: {persona.Nombre}");
            Console.WriteLine($"Edad: {persona.Edad}");
            Console.WriteLine($"Dirección: {persona.Direccion}");
            Console.WriteLine($"Correo electrónico: {persona.CorreoElectronico}");
        }
    }
}
