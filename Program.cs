//Martin Correa - Liceo Poliotecnico Los Arenales
using System.Runtime.CompilerServices;

public class Estudiante
{
    public string? Nombre { get; set; }
    public string? Apellido { get; set; }
    public void Informacion()
    {
        Console.WriteLine($"Bienvenido: {Nombre} {Apellido} ");
    }
}

//Clase principal del programa 
public class Program
{
    public static void Main()
    {
        Estudiante estudiante1 = new Estudiante();
        estudiante1.Nombre = "Martin";
        estudiante1.Apellido = "Correa";
        estudiante1.Informacion();

        Estudiante estudiante2 = new Estudiante();
        estudiante2.Nombre = "Maribel";
        estudiante2.Apellido = "Galleguillos";
        estudiante2.Informacion();
    }
}