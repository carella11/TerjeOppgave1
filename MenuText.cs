<<<<<<< HEAD
﻿using System;
using System.Runtime.Intrinsics.Arm;
using System.Xml.Serialization;

namespace TerjeOppgave1
{
    public class MenuText
    {
        public static void ShowMenuText(WalkHistoryPage walkHistoryPage)
        { 
            Console.WriteLine("1. Walk History");
            Console.WriteLine("2. Add Walk");
            var menuChoice = Console.ReadLine();
            Console.Clear();
            
            if (menuChoice == "1")
            {
                walkHistoryPage.ShowHistory();
            }
            else if (menuChoice == "2")
            {
                AddWalkInfo.AddWalkData(walkHistoryPage);
            }
            else 
            {
                Console.WriteLine("Wrong Command");
                ShowMenuText(walkHistoryPage);
            }
        } 
    }
=======
﻿using System;
using System.Runtime.Intrinsics.Arm;
using System.Xml.Serialization;

namespace TerjeOppgave1
{
    public class MenuText
    {
        public static void ShowMenuText(WalkHistoryPage walkHistoryPage)
        { 
            Console.WriteLine("1. Walk History");
            Console.WriteLine("2. Add Walk");
            var menuChoice = Console.ReadLine();
            Console.Clear();
            
            if (menuChoice == "1")
            {
                walkHistoryPage.ShowHistory();
            }
            else if (menuChoice == "2")
            {
                AddWalkInfo.AddWalkData(walkHistoryPage);
            }
            else 
            {
                Console.WriteLine("Wrong Command");
                ShowMenuText(walkHistoryPage);
            }
        } 
    }
>>>>>>> 150dfc1e6ca3ea5bdd1d440cd0e80632ac887a92
}