using System;
using AnotherNamespace;

public class Mainclas
{
    static void Main(string[] args)
    {
        // Seame UTF-8 kodeeringu õigeks tekstiks konsoolis
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // Loo objekti nime töötlemiseks
        NameProcessor nameProcessor = new NameProcessor();

        // Küsi kasutajalt nimi
        Console.WriteLine("Sisesta oma nimi:");
        string name = Console.ReadLine();

        // Töötle nimi
        nameProcessor.ProcessName(name);

        // Kuvame nime tähed
        nameProcessor.PrintLetters();

        // Kuvame häälikute statistika
        int vowelsCount = nameProcessor.CountVowels();
        int consonantsCount = nameProcessor.CountConsonants();
        Console.WriteLine($"Nimes on {vowelsCount} täishäälikut ja {consonantsCount} kaashäälikut.");

        // --- Array Generation and Analysis ---

        // Loome juhusliku arvu massiivi
        ArrayGenerator arrayGenerator = new ArrayGenerator();
        int arraySize = 10; // Näiteks loome massiivi suurusega 10
        double[] array = arrayGenerator.GenerateArray(arraySize);

        // Kuvame massiivi elemendid
        Console.WriteLine("Juhuslikult genereeritud massiiv:");
        foreach (var num in array)
        {
            Console.Write($"{num:F2} "); // Kuvame 2 komakohta
        }
        Console.WriteLine();

        // Analüüsime massiivi
        ArrayAnalyzer arrayAnalyzer = new ArrayAnalyzer();
        double max = arrayAnalyzer.FindMax(array);
        double min = arrayAnalyzer.FindMin(array);

        Console.WriteLine($"Maksimaalne väärtus massiivis: {max:F2}");
        Console.WriteLine($"Minimaalne väärtus massiivis: {min:F2}");

        // --- Surname Processing ---

        // Loo objekti perekonnanime töötlemiseks
        SurnameProcessor surnameProcessor = new SurnameProcessor();

        // Kuvame kõik perekonnanimed
        Console.WriteLine("Perekonnanimede nimekiri:");
        foreach (var surname in surnameProcessor.GetSurnames())
        {
            Console.WriteLine(surname);
        }

        // Kuvame pikima perekonnanime
        string longestSurname = surnameProcessor.FindLongestSurname();
        Console.WriteLine($"Pikim perekonnanimi on: {longestSurname}");
    }
}
