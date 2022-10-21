﻿using System;
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
            }
            return 0;
        }

        public void setPlayerStarts(string whatToSet, int mnozstvo) 
        {
            switch (whatToSet)
            {
                case "HP":
                    zivoty = mnozstvo;
                    break;
                case "Energia":
                    energia = mnozstvo;
                    break;
                case "Sila":
                    sila = mnozstvo;
                    break;
            }
        }
    }
}
