using System;

namespace ejemploHerencia2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instancio un objeto de la clase CajaAhorro
            CajaAhorro cajita = new CajaAhorro(1000);
            cajita.Saldo = 0;
            Persona personita =
                new Persona("Josele", 3000, cajita);
            Console.WriteLine(personita);
            personita.Nombre = "Pepito";
            Console.Write($"Ingrede dinero de {personita.Nombre}: ");
            personita.incrementarSaldo(1000);
            Console.WriteLine(personita);
            Console.WriteLine("Dinero en caja de Alvarito: $"+cajita.Saldo);
            Console.WriteLine("toString() de alvaro " + personita);
            Console.WriteLine("toString() de cajita "+ cajita);
        }
    }
}