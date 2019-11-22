using System;

namespace Libreria
{
    class Class1
    {
        static void Main(string[] args)
        {
            double importo1 = 0;
            double importo2 = 0;
            double importoT = 0;
            double sconto = 0;
            Console.Write("Inserisci il prezzo del primo prodotto: ");
            importo1 = double.Parse(Console.ReadLine());
            Console.Write("Inserisci il prezzo del secondo prodotto: ");
            importo2 = double.Parse(Console.ReadLine());
            if (importo1 < importo2)
            {
                sconto = (importo1 / 100) * 50;
                importo1 = importo1 - sconto;
                importoT = importo1 + importo1;
                Console.WriteLine("L'importo totale è "+importoT);
            }
            else if (importo1 > importo2)
            {
                sconto = (importo2 / 100) * 50;
                importo2 = importo2 - sconto;
                importoT = importo1 + importo2;
                Console.WriteLine("L'importo totale è "+importoT);
            }
            Console.ReadLine();

        }
    }
}