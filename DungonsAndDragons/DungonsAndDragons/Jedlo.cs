using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungonsAndDragons
{
    class Jedlo
    {
        Player player;
        Random rd;
        Program program;
        //kolko v inv
        int appleCount, breadCount, chickenCount, hpPotionCount, gigaPotionCount, powerPotionCount;
        public Jedlo() 
        {
            player = new Player();
           rd = new Random();
            program = new Program();
        }
        public void RandomFood() 
        {
            int foodID = rd.Next(1, 7);

            switch (foodID)
            {
                case 1:
                    Console.WriteLine("Dostal si jablko [+3 energie]");
                    appleCount++;
                    break;
                case 2:
                    Console.WriteLine("Dostal si chleba [+5 energie]");
                    breadCount++;
                    break;
                case 3:
                    Console.WriteLine("Dostal si kura [max energy]");
                    chickenCount++;
                    break;
                case 4:
                    Console.WriteLine("Dostal si HP potion [+2 zivoty]");
                    appleCount++;
                    break;
                case 5:
                    Console.WriteLine("Dostal si GIGA potion [max energy + max zivoty]");
                    appleCount++;
                    break;
                case 6:
                    Console.WriteLine("Dostal si power potion [+ 2 sily na budúci fight]");
                    appleCount++;
                    break;
            }
        }

        public void Use(int foodID)
        {
            switch (foodID)
            {
                case 1:
                    if (appleCount > 0) 
                    {
                        appleCount--;
                        player.setPlayerStarts("Energia", player.getPlayerStats("Enegia") + 3);
                    }
                    else
                    {
                        Console.WriteLine("Nemáš dostatok itemov");
                    }
                    
                    break;
                case 2:
                    if (breadCount > 0)
                    {
                        breadCount--;
                        player.setPlayerStarts("Energia", player.getPlayerStats("Enegia") + 5);
                    }
                    else
                    {
                        Console.WriteLine("Nemáš dostatok itemov");
                    }
                    break;
                case 3:
                    if (chickenCount > 0)
                    {
                        chickenCount--;
                        player.setPlayerStarts("Energia", 12 - player.getPlayerStats("Enegia"));
                    }
                    else
                    {
                        Console.WriteLine("Nemáš dostatok itemov");
                    }
                    break;
                case 4:
                    if (hpPotionCount > 0)
                    {
                        hpPotionCount--;
                        player.setPlayerStarts("HP", player.getPlayerStats("HP") + 2);
                    }
                    else
                    {
                        Console.WriteLine("Nemáš dostatok itemov");
                    }
                    break;
                case 5:
                    if (gigaPotionCount > 0)
                    {
                        gigaPotionCount--;
                        player.setPlayerStarts("HP", 5 - player.getPlayerStats("HP"));
                        player.setPlayerStarts("Energia", 12 - player.getPlayerStats("Enegia"));
                    }
                    else
                    {
                        Console.WriteLine("Nemáš dostatok itemov");
                    }
                    break;
                case 6:
                    if (powerPotionCount > 0)
                    {
                        powerPotionCount--;
                        //
                    }
                    else
                    {
                        Console.WriteLine("Nemáš dostatok itemov");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    break;
                default:
                    Console.WriteLine("Zly znak/neznáme cislo");
                    break;
            }


        }
        public void VipisJedla()
        {
            Console.WriteLine(appleCount + " jablká. <1>");
            Console.WriteLine(breadCount + " chleby. <2>");
            Console.WriteLine(chickenCount + " kuratá. <3>");
            Console.WriteLine(hpPotionCount + " HP potiony. <4>");
            Console.WriteLine(gigaPotionCount + " GIGA potiony. <5>");
            Console.WriteLine(powerPotionCount + " power potiony. <6>");
        }
    }
}
