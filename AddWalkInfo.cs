using System;
using System.Collections.Generic;

namespace TerjeOppgave1
{
    public class AddWalkInfo
    {
        public static void AddWalkData(WalkHistoryPage walkHistoryPage)
        {
            Console.WriteLine("Date: YYYY-MM-DD");
            string addWalkDate = Console.ReadLine();

            Console.WriteLine("Distance: ");
            double addWalkDistance = Convert.ToDouble(Console.ReadLine());

            walkHistoryPage.AddWalk(addWalkDate, addWalkDistance);
        }
    }
}