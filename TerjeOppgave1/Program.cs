using System;
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
