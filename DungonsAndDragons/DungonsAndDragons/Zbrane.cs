using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungonsAndDragons
{
    class Zbrane
    {
        string currentGunName;
        int currentGunPower;
        Random random;
        Knife knife;
        Sword sword;
        
        public Zbrane()
        {
            currentGunName = "knife";
            currentGunPower = 1;
            random = new Random();
            knife = new Knife();
            sword = new Sword();
        }
        
        
        public string GetName()
        {
            return currentGunName;
        }

        public int GetPower() 
        {
            return currentGunPower;
        }
        
        public void SetName(string name) 
        {
            currentGunName = name;
        }
        public void SetPower(int power)
        {
            currentGunPower = power;
        }
        
        public void GetRundomGun() 
        {
            int kolkataZbran = random.Next(0, 2);
            switch (kolkataZbran)
            {
                case 0:
                    if(currentGunPower < knife.sila()) 
                    {
                        currentGunName = knife.name();
                        currentGunPower = knife.sila();
                        Console.WriteLine("Dostal si " + knife.name());
                    }
                    else
                    {
                        Console.WriteLine("Dostal si " + knife.name() + "ale už máš silnejšiu zbraň!");
                    }
                    
                    break;
                case 1:
                    if (currentGunPower < sword.sila())
                    {
                        currentGunName = knife.name();
                        currentGunPower = knife.sila();
                        Console.WriteLine("Dostal si " + sword.name());
                    }
                    else
                    {
                        Console.WriteLine("Dostal si " + sword.name() + "ale už máš silnejšiu zbraň!");
                    }
                    break;
            }
        }

    }
}
