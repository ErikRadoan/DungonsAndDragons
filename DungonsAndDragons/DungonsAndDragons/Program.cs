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

            void vstupDoMiestnosti(int druhMiestnosti) 
            {
                switch(druhMiestnosti) 
                {
                    case 1:
                        //miestnost s pascou
                        break;
                    case 2:
                        //miestnost s pascou
                        break;
                    case 3:
                        //miestnost s pascou
                        break;
                    case 4:
                        //miestnost s pascou
                        break;
                    default:

                        break;

                }
            }
        }
        
    }

}
