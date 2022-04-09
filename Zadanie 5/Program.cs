using System;

namespace Zadanie_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            var fabryka = new FabrykaLodow();
            var sprzedawca = new SprzedawcaLodow(fabryka);
            int j = 0;
            for(int i = 0; i < 7; i++)
            {
                Console.WriteLine("Dzien " + (i + 1).ToString() + ":" + "\n");
                j = rand.Next(1, 5);
                fabryka.UstawTrybProdukcji(rand.Next(1, 7));
                for(int k = 0; k < j; k++)
                {
                    sprzedawca.ZaproponujSpecjalnoscDnia();
                    Console.WriteLine();
                }
                Console.WriteLine("\n");
            }
        }
    }
}
