using System;
namespace Aporte;
public class Figuras
{
    public string Nombre;

    public string Color;

    public Figuras(string Nombre, string Color)
    {
        this.Nombre = Nombre;
        this.Color = Color;
    }
    
    public void Imprimir()
    {
        Console.WriteLine("-------------------------------------"); 
        Console.WriteLine("El nombre de la figura es: " + Nombre);
        Console.WriteLine("El color de la figura es: " + Color);
        Console.WriteLine("-------------------------------------");
    }

    
}



