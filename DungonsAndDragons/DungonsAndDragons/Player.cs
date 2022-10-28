using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungonsAndDragons
{
    class Player
    {
        int zivoty = 5;
        int energia = 12;
        int sila = 0;
        int gold = 0;
        bool effectedPoison = false;
        bool effectedPower = false;

        public int getPlayerStats(string druh) 
        {
            switch (druh)
            {
                case "HP":
                    return zivoty;
                    break;
                case "Energia":
                    return energia;
                    break;
                case "Sila":
                    return sila;
                    break;
                case "Gold":
                    return gold;
                    break;
            }
            return 0;
        }

        public void setPlayerStarts(string whatToSet, int mnozstvo) 
        {
            switch (whatToSet)
            {
                case "HP":
                    zivoty = mnozstvo;
                    if (zivoty <= 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Zomrel si, better luck next time !");
                        Console.ReadLine();
                        Console.WriteLine("");
                        Environment.Exit(0);
                    }
                    break;
                case "Energia":
                    energia = mnozstvo;
                    if (energia <= 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Si moc unavený na to aby si pokračoval.");
                        Console.WriteLine("Na konci si mal: " + gold + " goldu.");
                        Console.ReadLine();
                        Console.WriteLine("");
                        Environment.Exit(0);
                    }
                    break;
                case "Sila":
                    sila = mnozstvo;
                    break;
                case "Gold":
                    gold = mnozstvo;
                    break;
            }
        }
        public void EffectedByPoison(bool maybe) 
        {
            if(maybe == true) 
            {
                sila--;
                effectedPoison = true;
            }
            else if(maybe == false && effectedPoison == true)
            {
                sila++;
                effectedPoison = false;
            }
        }
        public void EffectedByPower(bool maybe)
        {
            if (maybe == true)
            {
                sila =+ 2;
                effectedPower = true;
            }
            else if(maybe == false && effectedPower == true)
            {
                sila =- 2;
                effectedPower = false;
            }
        }
    }
}
