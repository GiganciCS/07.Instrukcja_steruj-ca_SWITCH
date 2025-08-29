namespace zadanie2;

class Program
{
    static void Main(string[] args)
    {
        int liczbaDoOdgadniecia;
        int liczbaProb = 0;
        int roznica, podanaLiczba;

        Random maszynaLosujaca = new Random(DateTime.Now.Day);
        liczbaDoOdgadniecia = maszynaLosujaca.Next(1, 11);


        // 1 próba
        Console.WriteLine("Podaj liczbę od 1 do 10:");
        podanaLiczba = int.TryParse(Console.ReadLine(), out podanaLiczba) ? podanaLiczba : 0;
        liczbaProb++;

        roznica = Math.Abs(liczbaDoOdgadniecia - podanaLiczba);

        switch (roznica)
        {
            case 0:
                Console.WriteLine($"Brawo, udało ci się odgadnąć wylosowaną liczbę w {liczbaProb} próbie!");
                return;

            case 1:
                Console.WriteLine($"Bardzo ciepło!");
                break;

            case 2:
                Console.WriteLine($"Ciepło!");
                break;

            case 3:
                Console.WriteLine($"Letnio!");
                break;

            case 4:
                Console.WriteLine($"Chłodno!");
                break;
            default:
                Console.WriteLine($"Zimno!");
                break;
        }

        // 2 próba
        Console.WriteLine("Podaj liczbę od 1 do 10:");
        podanaLiczba = int.TryParse(Console.ReadLine(), out podanaLiczba) ? podanaLiczba : 0;
        liczbaProb++;

        roznica = Math.Abs(liczbaDoOdgadniecia - podanaLiczba);

        switch (roznica)
        {
            case 0:
                Console.WriteLine($"Brawo, udało ci się odgadnąć wylosowaną liczbę w {liczbaProb} próbie!");
                return;

            case 1:
                Console.WriteLine($"Bardzo ciepło!");
                break;

            case 2:
                Console.WriteLine($"Ciepło!");
                break;

            case 3:
                Console.WriteLine($"Letnio!");
                break;

            case 4:
                Console.WriteLine($"Chłodno!");
                break;
            default:
                Console.WriteLine($"Zimno!");
                break;
        }

        // 3 próba
        Console.WriteLine("Podaj liczbę od 1 do 10:");
        podanaLiczba = int.TryParse(Console.ReadLine(), out podanaLiczba) ? podanaLiczba : 0;
        liczbaProb++;

        roznica = Math.Abs(liczbaDoOdgadniecia - podanaLiczba);

        switch (roznica)
        {
            case 0:
                Console.WriteLine($"Brawo, udało ci się odgadnąć wylosowaną liczbę w {liczbaProb} próbie!");
                return;

            case 1:
                Console.WriteLine($"Bardzo ciepło!");
                break;

            case 2:
                Console.WriteLine($"Ciepło!");
                break;

            case 3:
                Console.WriteLine($"Letnio!");
                break;

            case 4:
                Console.WriteLine($"Chłodno!");
                break;
            default:
                Console.WriteLine($"Zimno!");
                break;
        }

        // Jeśli się nie uda
        Console.WriteLine($"Niestety, nie udało ci się odgadnąć liczby! Prawidłowa liczba to: {liczbaDoOdgadniecia}");

    }
}
