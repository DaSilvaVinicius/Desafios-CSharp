namespace Há_Muito__Muito_Tempo_Atras.Entities
{
    static class ElapsedTime
    {
        public static void YearOfEvent(int yearsElapsed)
        {
            if (yearsElapsed < 2015)
            {
                int yearOfEvent = Year.YearWeAre - yearsElapsed;

                Console.WriteLine(yearOfEvent + " D.C.");
            }
            else
            {
                int yearOfEvent = yearsElapsed - Year.YearWeAre + 1;

                Console.WriteLine(yearOfEvent + " A.C.");
            }
        }
    }
}
