using System;
namespace Aporte;
class Program
{
    static void Main(string[] args)
    {

        {
            Cuadrado figura1 = new Cuadrado(10, 10, 10, 10, "Cuadrado", "Azul");
            figura1.Imprimir();


            Rectangulo figura2 = new Rectangulo(20, 15, "Rectangulo", "Morado");
            figura2.Imprimir();


            Circulo figura3 = new Circulo(5.00, "Circulo", "Rojo");
            figura3.Imprimir();


            List<Interface1> listafiguras = new List<Interface1>();
            listafiguras.Add(figura1);
            listafiguras.Add(figura2);
            listafiguras.Add(figura3);

            foreach (Interface1 item in listafiguras)
            {
                item.Calcular();

            }

        }

    }
}






