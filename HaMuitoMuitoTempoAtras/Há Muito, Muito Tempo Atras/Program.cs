using System;
using Há_Muito__Muito_Tempo_Atras.Entities;

namespace Há_Muito__Muito_Tempo_Atras
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int t = int.Parse(Console.ReadLine());

                ElapsedTime.YearOfEvent(t);
            }
        }
    }
}