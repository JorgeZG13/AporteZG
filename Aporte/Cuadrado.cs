using System;
namespace Aporte;

public class Cuadrado : Figuras, Interface1
{
    public int Lado1;

    public int Lado2;

    public int Lado3;

    public int Lado4;

    public int Lad;

    public Cuadrado(int Lado1, int Lado2, int Lado3, int Lado4, string Nombre, string Color) : base(Nombre, Color)
    {
        this.Lado1 = Lado1;
        this.Lado2 = Lado2;
        this.Lado3 = Lado3;
        this.Lado4 = Lado4;
    }

    public void Calcular()
    {
        Lad = Lado1+Lado2+Lado3+Lado4;
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("El Area del " + Nombre + " es de: " + Lad);
        Console.WriteLine("-------------------------------------");
    }
   

}