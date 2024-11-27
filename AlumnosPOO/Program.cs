namespace AlumnosPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Alumno mora = new Alumno("pepe");
           // mora.Nombre = "santiago mora";
            mora.Grupo = "DGD11";
            mora.Contrasena = "abc123";

            Console.WriteLine(mora.Nombre);


        }
    }
}
