using System.Threading;
using System.Text;

namespace zadanie1;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Witaj Wiedźminie! Zwą mnie Ruryk - Pogromca Bestii! Podaj mi nazwę poczwary, a co-nieco opowiem ci o niej. Mój bestiariusz - najlepszy w okolicy - zawiera następujące kreatury:\n1. Szkarłatny Wędrowiec\n2. Król-Jaszczur Drakontor\n3. Mórożerca\n4. Nocny Rozdarty\n5. Żelazna Matrona\n\n");

        Console.Write("Twój wybór: ");
        string? bestia = Console.ReadLine();

        Console.WriteLine("Niech pomyślę.");
        Thread.Sleep(1000);
        Console.WriteLine("Niech pomyślę..");
        Thread.Sleep(1000);
        Console.WriteLine("Niech pomyślę...");

        Thread.Sleep(3000);

        if (bestia == null) return;

        switch (bestia.ToLower())
        {
            case "szkarłatny wędrowiec":

                Console.WriteLine($"{bestia}: Półprzezroczysta, humanoidalna istota spowita szkarłatną mgłą, z długimi kończynami i bez twarzy. Porusza się w ciszy przez mgły i lasy, wyczuwając emocje. Żywi się strachem i żalem. Potrafi przenikać przez ściany i znikać, gdy nie jest obserwowany.");
                break;

            case "król-jaszczur drakontor":

                Console.WriteLine($"{bestia}: Olbrzymi gad o szmaragdowej łusce, z koroną kościanych wyrostków na głowie i szponami jak sierpy. Zamiast zionąć ogniem, emituje falę dźwięku niszczącą skały i paraliżującą przeciwników.");
                break;

            case "mórożerca":

                Console.WriteLine($"{bestia}: Potężna sylwetka przypominająca niedźwiedzia, ale z rogami jelenia i pyskiem pełnym ostrych jak igły zębów. Jego futro pokryte jest lodem i porusza się bezgłośnie. Zamraża powietrze wokół siebie. Jego ryk wywołuje śnieżyce. Poluje tylko w nocy i unika ciepła.");
                break;

            case "nocny rozdarty":

                Console.WriteLine($"{bestia}: Postać złożona z rozszarpanych skrawków czerni, jakby uformowana z cieni samych w sobie. Nie ma jednej formy – jego ciało nieustannie się zmienia. Potrafi rozdzielić się na wiele mniejszych cieni, opanowywać ciała żywych istot i siać paranoję.");
                break;

            case "żelazna matrona":

                Console.WriteLine($"{bestia}: Wysoka postać o humanoidalnej sylwetce wykuta z czarnego metalu, z wnętrzem zasilanym sercem z rdzenia lawy. Twarz przypomina maskę matki – bez wyrazu. Niezwykle silna fizycznie, zdolna regenerować swoje ciało poprzez pochłanianie metalu. Broni wybranych miejsc, chroniąc je przed intruzami.");
                break;

            default:
                Console.WriteLine($"Nie słyszałem o takiej kreaturze... Opowiedz mi o niej nieco więcej potem...");
                break;

        }

    }
}
