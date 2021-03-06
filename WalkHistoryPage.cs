
﻿using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace TerjeOppgave1
{
    public class WalkHistoryPage
    {
        public List<Data> ListWalkData { get; set; }
        public WalkHistoryPage()
        {
            ListWalkData = new List<Data>();
        }

        public void ShowHistory()
        {
            var totalDistance = 0.0;
            var id = 1;

            foreach (var Walk in ListWalkData)
            {
                Walk.printInfo(id);
                id++;
                totalDistance = totalDistance + Walk.CalculateDistance();
            }
            Console.WriteLine("*********************");
            Console.WriteLine($"Nice Work! You've walked a total distance of {totalDistance} km");
            Console.WriteLine("*********************");
        }
        public void AddWalk(string addWalkDate, double addWalkDistance)
        {
            ListWalkData.Add(new Data(addWalkDate, addWalkDistance));
        }
    }
}