using System;

namespace PadawansTask1
{
    public class Population
    {


        public static int GetYears(int initialPopulation, double percent, int visitors, int currentPopulation)
        {
            int Years = 0;
            double temp = Convert.ToDouble(initialPopulation);


            while (currentPopulation > temp)
            {
                temp = temp * (1 + (percent / 100)) + Convert.ToDouble(visitors);
                Years++;
            }

            return Years;
            throw new NotImplementedException();
        }

        static public void Main()

        {
            int result = GetYears(1500, 5, 100, 55000);
            Console.WriteLine($"Result is: {result} years");
        }
    }


}