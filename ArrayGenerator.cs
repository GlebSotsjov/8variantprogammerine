using System;

namespace AnotherNamespace
{
    public class ArrayGenerator
    {
        public double[] GenerateArray(int size)
        {
            Random random = new Random();
            double[] array = new double[size];

            // Juhuslike numbrite genereerimine vahemikus -100 kuni 100
            for (int i = 0; i < size; i++)
            {
                array[i] = random.NextDouble() * 200 - 100;  // nextDouble tagastab 0 kuni 1, korrutatakse 200-ga ja nihutatakse -100-ga.
            }

            return array;
        }
    }
}
