<<<<<<< HEAD
﻿using System;
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
=======
﻿using System;
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
>>>>>>> 150dfc1e6ca3ea5bdd1d440cd0e80632ac887a92
}