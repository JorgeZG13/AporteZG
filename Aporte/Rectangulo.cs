using System;
namespace Aporte;
public class Rectangulo:Figuras, Interface1
{
    public int Base;

    public int Altura;

    public int Rec;

    public Rectangulo(int Base, int Altura, string Nombre, string Color): base(Nombre, Color)
    {
        this.Base = Base;
        this.Altura = Altura;
    }
    
    

    public void Calcular() 
    {
         Rec = Base * Altura;
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("El Area del " + Nombre + " es de: " + Rec);
        Console.WriteLine("-------------------------------------");
    }


  
}