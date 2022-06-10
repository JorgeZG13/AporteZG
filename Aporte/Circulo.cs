using System;
namespace Aporte;
public class Circulo : Figuras, Interface1
{
    public double Pi = 3.14;

    public double Radio;

    public double Cir;

    public Circulo(double Radio, string Nombre, string Color) : base(Nombre, Color)
    {
        this.Radio= Radio;
    }

    public void Calcular()
    {
        Cir = (Radio * Radio) * Pi;
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("El Area del " + Nombre + " es de: " + Cir); 
        Console.WriteLine("-------------------------------------");
    }
} 
