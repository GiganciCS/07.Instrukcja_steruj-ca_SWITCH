namespace rozgrzewka;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Podaj numer dnia tygodnia (1-7) :");
        int dzien = int.Parse(Console.ReadLine());
        switch (dzien)
        {
            case 1:
                Console.WriteLine($"{dzien} dzień tygodnia to poniedziałek.");
                break;
            case 2:
                Console.WriteLine($"{dzien} dzień tygodnia to wtorek.");
                break;
            case 3:
                Console.WriteLine($"{dzien} dzień tygodnia to środa.");
                break;
            case 4:
                Console.WriteLine($"{dzien} dzień tygodnia to czwartek.");
                break;
            case 5:
                Console.WriteLine($"{dzien} dzień tygodnia to piątek.");
                break;
            case 6:
                Console.WriteLine($"{dzien} dzień tygodnia to sobota.");
                break;
            case 7:
                Console.WriteLine($"{dzien} dzień tygodnia to niedziela.");
                break;
            default:
                Console.WriteLine("Nieprawidłowy numer dnia tygodnia!");
                break;
        }
        Console.ReadKey();

    }
}
