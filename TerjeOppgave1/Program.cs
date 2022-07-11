using System;
using System.Collections.Generic;

namespace TerjeOppgave1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var Day1 = new Data("2022-07-01", 5.3);
            var Day2 = new Data("2022-07-02", 1.2);
            var Day3 = new Data("2022-07-05", 7.5);

            var totalDistance = Day1.Distance + Day2.Distance + Day3.Distance;

            var ListWalkData = new List<Data>();
            ListWalkData.Add(Day1);
            ListWalkData.Add(Day2);
            ListWalkData.Add(Day3);

            var id = 1;
            foreach (var Walk in ListWalkData)
            {
                Walk.printInfo(id);
                id++;
            }

            Console.WriteLine("*********************");
            Console.WriteLine($"Nice Work! You've Walked: {totalDistance} km");
        }
    }
}
