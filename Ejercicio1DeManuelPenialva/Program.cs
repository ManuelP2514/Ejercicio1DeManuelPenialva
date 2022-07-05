using System;

namespace Ejercicio1DeManuelPenialva
{
    class Program
    {
        static void Main(string[] args)
        {
            double CantidadDePesos, Dolares, Euros;
            Console.WriteLine(" Ingrese La Cantidad De Pesos ");
            CantidadDePesos = double.Parse(Console.ReadLine());
            Dolares = (CantidadDePesos * 230);
            Console.WriteLine($"La Cantidad De Dolares Que Puede Comprar Con Los Pesos Ingresados Es De {Dolares} Dolares");
            Euros = Dolares * 1.17;
            Console.WriteLine($"El Equivalente En Euros Es {Euros} Euros");

        }
    }
}
