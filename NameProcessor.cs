using System;
using System.Collections.Generic;
using System.Linq;

namespace AnotherNamespace
{
    public class NameProcessor
    {
        private char[] letters;

        // Glaaslikud tähed
        private readonly char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'ä', 'ö', 'ü', 'õ' };

        // Kaashäälikud tähed
        private readonly char[] consonants = { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z' };

        // Töötle nimi ja salvesta tähed massiivi
        public void ProcessName(string name)
        {
            letters = name.ToLower().ToCharArray();  // Muutame kõik väiketähtedeks ja jagame nime tähtedeks
        }

        // Kuvab kõik tähed
        public void PrintLetters()
        {
            Console.WriteLine("Sinu nime tähed:");
            foreach (char letter in letters)
            {
                Console.Write(letter + " ");
            }
            Console.WriteLine();
        }

        // Loeb täishäälikud
        public int CountVowels()
        {
            return letters.Count(letter => vowels.Contains(letter));  // Loeme, kui palju täishäälikuid on nimes
        }

        // Loeb kaashäälikud
        public int CountConsonants()
        {
            return letters.Count(letter => consonants.Contains(letter));  // Loeme, kui palju kaashäälikuid on nimes
        }
    }
}
