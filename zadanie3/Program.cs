namespace zadanie3;

class Program
{
    static void Main(string[] args)
    {
        decimal cenaKomputera = 0;
        Console.WriteLine("Witaj w konfiguratorze komputera stacjonarnego. Stwórz swój wymarzony zestaw!:");
        Console.WriteLine("Wybierz procesor:");
        Console.WriteLine("1. Intel Core i5-11400F\n2. AMD Ryzen 5 5600X ");
        int procesor = int.TryParse(Console.ReadLine(), out procesor) ? procesor : 0;
        switch (procesor)
        {
            case 1:
                cenaKomputera += 769.00m;
                break;
            case 2:
                cenaKomputera += 1050.00m;
                break;
            default:
                Console.WriteLine("Podano błędne dane");
                break;
        }
        Console.WriteLine($"Obecna wartość zestawu to {cenaKomputera}");
        Console.ReadKey();

    }
}
