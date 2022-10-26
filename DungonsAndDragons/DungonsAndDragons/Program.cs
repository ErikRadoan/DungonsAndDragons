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
            Zbrane zbrane = new Zbrane();
            Player player = new Player();
            Random random = new Random();

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
                switch (druhMiestnosti)
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
                string pasca = "";
                int rand_num = random.Next(1, 5);
                switch (rand_num)
                {
                    case 1:
                        pasca = "boli spiky [- 1 život]";
                        player.setPlayerStarts("HP", player.getPlayerStats("HP") - 1);

                        break;
                    case 2:
                        pasca = "bol rolling stone [- 2 energie]";
                        player.setPlayerStarts("Energia", player.getPlayerStats("Energia") - 2);
                        break;
                    case 3:
                        pasca = "bol acid [- 1 Sila do buduceho fightu]";
                        player.setPlayerStarts("Sila", player.getPlayerStats("Sila") - 1);
                        break;
                    case 4:
                        pasca = "bol waterfall [- 10% gold]";
                        player.setPlayerStarts("Gold", (player.getPlayerStats("Gold") / 10) * 9);
                        break;

                }
                Console.WriteLine("V miestnosti " + pasca);
                continuing();
            }
            void miestpoklad()
            {
                int predosli = zbrane.GetPower();
                zbrane.GetRundomGun();
                if (predosli < zbrane.GetPower()) 
                {
                    player.setPlayerStarts("Sila", zbrane.GetPower());
                }
                Console.WriteLine("Poklad");
                Console.ReadLine();
                continuing();
            }
            void miestPrazdna()
            {
                Console.WriteLine("Miestnosť je úplne prázdna [-1 energia]");
                player.setPlayerStarts("Energia", player.getPlayerStats("Energia") - 1);
                Console.ReadLine();
                continuing();
            }
            void miestPrisera()
            {
                Random rd = new Random();
                int rand_num = rd.Next(1, 7);
                switch (rand_num)
                {
                    case 1:
                        //Rat
                        Console.WriteLine("V miestnosti je rat [1 sila]");
                        Console.ReadLine();
                        Combat(1);
                        break;
                    case 2:
                        //Skeleton
                        Console.WriteLine("V miestnosti je skeleton [2 sila]");
                        Console.ReadLine();
                        Combat(2);
                        break;
                    case 3:
                        //Zombie
                        Console.WriteLine("V miestnosti je zombie [3 sila]");
                        Console.ReadLine();
                        Combat(3);
                        break;
                    case 4:
                        //Bandit
                        Console.WriteLine("V miestnosti je bandit [4 sila]");
                        Console.ReadLine();
                        Combat(4);
                        break;
                    case 5:
                        //Goblin
                        Console.WriteLine("V miestnosti je goblin [5 sila]");
                        Console.ReadLine();
                        Combat(5);
                        break;
                    case 6:
                        //Dragon
                        Console.WriteLine("V miestnosti je dragon [8 sily]");
                        Console.ReadLine();
                        Combat(8);
                        break;


                }
            }
            void Combat(int sila){
                
                int random_numPlayer = random.Next(1, 7);
                Console.WriteLine(random_numPlayer);
                int random_num = random.Next(1, 7);
                int playerDMG = (random_numPlayer * player.getPlayerStats("Sila"));
                int priseraDMG = (random_num * sila);
                Console.WriteLine(random_num);
                if (playerDMG > priseraDMG) 
                {
                    string protiKomuFightil = "";
                    switch (sila)
                    {
                        case 1:
                            protiKomuFightil = "[+ 5 gold]";
                            player.setPlayerStarts("Gold", (player.getPlayerStats("Gold") + 5));
                            break;
                        case 2:
                            protiKomuFightil = "[+ 15 gold]";
                            player.setPlayerStarts("Gold", (player.getPlayerStats("Gold") + 15));
                            break;
                        case 3:
                            protiKomuFightil = "[+ 30 gold]";
                            player.setPlayerStarts("Gold", (player.getPlayerStats("Gold") + 30));
                            break;
                        case 4:
                            protiKomuFightil = "[+ 50 gold]";
                            player.setPlayerStarts("Gold", (player.getPlayerStats("Gold") + 50));
                            break;
                        case 5:
                            protiKomuFightil = "[+ 80 gold]";
                            player.setPlayerStarts("Gold", (player.getPlayerStats("Gold") + 80));
                            break;
                        case 8:
                            protiKomuFightil = "[+ 300 gold]";
                            player.setPlayerStarts("Gold", (player.getPlayerStats("Gold") + 300));
                            break;
                    }
                    Console.WriteLine("Vyhral si! " + protiKomuFightil);
                    Console.Read();
                    Console.Clear();
                    continuing();
                }
                else
                {
                    Console.WriteLine("Prehral si, strácaš život a pokračuješ v súboji [- 1 zivot]");
                    Console.Read();
                    Console.Clear();
                    player.setPlayerStarts("HP", player.getPlayerStats("HP") - 1);
                    Combat(sila);
                }
            }
        }
        
    }

}
