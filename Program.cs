<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TerjeOppgave1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var WalkHistoryPage = CreateWalkHistoryPage();

            while (true)
            {
                MenuText.ShowMenuText(WalkHistoryPage);
            }
        }
        public static WalkHistoryPage CreateWalkHistoryPage()
        {
            string filePath = "C:\\Users\\GET Academy\\Desktop\\Modul 3 Prosjekter\\txtFilTerjeOppg\\txtFilTerjeOppg\\bin\\Debug\\net5.0\\myWalks.txt";
            var WalkHistoryPage = new WalkHistoryPage();
             
            foreach (string s in File.ReadLines(filePath))
            {
                string[] userInput = s.Split(',');
                var stringDouble = userInput[1];
                var kmWalked = Double.Parse(stringDouble, System.Globalization.CultureInfo.InvariantCulture);
                WalkHistoryPage.AddWalk(userInput[0], kmWalked);
            }
            return WalkHistoryPage;
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;

namespace TerjeOppgave1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var WalkHistoryPage = new WalkHistoryPage();
            WalkHistoryPage.AddWalk("2022-07-01", 5.3);
            WalkHistoryPage.AddWalk("2022-07-02", 1.2);
            WalkHistoryPage.AddWalk("2022-07-05", 7.5);
            
            while (true)
            {
                MenuText.ShowMenuText(WalkHistoryPage);
            }
        }
    }
}
>>>>>>> 150dfc1e6ca3ea5bdd1d440cd0e80632ac887a92
