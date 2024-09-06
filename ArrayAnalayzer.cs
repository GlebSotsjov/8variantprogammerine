namespace AnotherNamespace
{
    public class ArrayAnalyzer
    {
        public double FindMax(double[] array)
        {
            double max = array[0];  // Alusta esimesest elemendist kui maksimaalsest elemendist.

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)  // Kui praegune element on suurem kui max, uuendame max-i.
                {
                    max = array[i];
                }
            }

            return max;  // Tagastab maksimaalse väärtuse
        }

        public double FindMin(double[] array)
        {
            double min = array[0];  // Alusta esimesest elemendist kui minimaalsest elemendist.

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)  // Kui praegune element on väiksem kui min, uuendatakse min.
                {
                    min = array[i];
                }
            }

            return min;  // Tagastab minimaalse väärtuse
        }
    }
}
