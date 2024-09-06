using System;
using System.Collections.Generic;
using System.Linq;

namespace AnotherNamespace
{
    public class SurnameProcessor
    {
        private List<string> surnames;

        // Konstruktor, mis initsialiseerib perekonnanimede nimekirja.
        public SurnameProcessor()
        {
            surnames = new List<string> { "Sotsjov", "Sild", "Larionov", "Lavruhin","Kizilova","Haavasaluu" };
        }

        // Meetod pikima perekonnanime leidmiseks
        public string FindLongestSurname()
        {
            if (surnames == null || surnames.Count == 0)
            {
                return "Список фамилий пуст";
            }

            string longestSurname = surnames.OrderByDescending(s => s.Length).First();
            return longestSurname;
        }

        // Meetod perekonnanimede täisnimekirja saamiseks
        public List<string> GetSurnames()
        {
            return surnames;
        }
    }
}
