using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungonsAndDragons
{
    class Program
    {
        static void Main(string[] args)
        {
            Dungon dungon = new Dungon();
            Player player = new Player();

            startGame();

            void startGame()
            {

                string pokracovanie;
                Console.WriteLine("Vytaj v dungons and dragons !");
                Console.WriteLine("Ak chceš pokračovať napíš: \"pokracuj\"");
                Console.WriteLine("Ak chceš odísť napíš: \"odist\"!");
                Console.WriteLine("Ak chceš vedieť viac o hre napíš: \"info\"");
                pokracovanie = Console.ReadLine();

                switch (pokracovanie)
                {
                    case "pokracuj":
                        Console.WriteLine("Vsupujes do dungonu...");
                        Console.ReadLine();
                        vstupDoMiestnosti(dungon.genarateRooms());
                        break;
                    case "odist":

                        break;
                    case "info":
                        Console.Clear();
                        Console.WriteLine("info");
                        Console.ReadLine();
                        Console.Clear();
                        startGame();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Chyba, skus to znova");
                        Console.ReadLine();
                        Console.Clear();
                        startGame();
                        break;
                }
            }

            void continuing()
            {
                string pokracovanie;
                Console.WriteLine("Ak chceš ísť do ďaľšej miestnosti napíš \"pokracuj\"");
                Console.WriteLine("Ak chceš odísť z dungenu napíš: \"odist\"!");
                Console.WriteLine("Ak si chceš pezreť inventár napíš: \"inv\"");
                pokracovanie = Console.ReadLine();

                switch (pokracovanie)
                {
                    case "pokracuj":
                        Console.WriteLine("Vsupujes do ďalšej miestnosti");
                        Console.ReadLine();
                        Console.Clear();
                        vstupDoMiestnosti(dungon.genarateRooms());
                        break;
                    case "odist":
                        Console.Clear();
                        startGame();
                        break;
                    case "inv":
                        Console.Clear();
                        Console.WriteLine("inv");
                        Console.ReadLine();
                        Console.Clear();
                        continuing();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Chyba, skus to znova");
                        Console.ReadLine();
                        Console.Clear();
                        continuing();
                        break;
                }
            }

            void vstupDoMiestnosti(int druhMiestnosti) 
            {
                switch(druhMiestnosti) 
                {
                    case 1:
                        miestPasca();
                        Console.Clear();
                        break;
                    case 2:
                        miestpoklad();
                        Console.Clear();
                        break;
                    case 3:
                        miestPrisera();
                        Console.Clear();
                        break;
                    case 4:
                        miestPrazdna();
                        Console.Clear();
                        break;
                    default:

                        break;

                }
                
            }

            void miestPasca() 
            {
                Console.WriteLine("Pasca");
                continuing();
            }
            void miestpoklad()
            {
                Console.WriteLine("Poklad");
                continuing();
            }
            void miestPrazdna()
            {
                Console.WriteLine("Miestnosť je úplne prázdna [-1 energia]");
                player.setPlayerStarts("Energia", player.getPlayerStats("Energia") - 1);
                Console.WriteLine(player.getPlayerStats("Energia"));
                Console.ReadLine();
                continuing();
            }
            void miestPrisera()
            {
                Console.WriteLine("Prisera");
                continuing();
            }
        }
        
    }

}
