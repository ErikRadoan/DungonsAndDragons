using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungonsAndDragons
{
    class Dungon
    {
        int miestnostSPascou, miestnostSPokladom, miestnostSPriserou, miestnostSPrazdnotou, celkovichMiestonsti;
        void Dugon()
        {
            genarateRooms();
        }
        public int genarateRooms()
        {
            if (celkovichMiestonsti == 100) 
            {
                return 0;
                //zvladol dungon?
            }
            celkovichMiestonsti++;
            Random rd = new Random();
            int rand_num = rd.Next(1, 5);

            switch (rand_num) 
            {
                case 1:
                    if (!(miestnostSPascou > 20))
                    {
                        miestnostSPascou++;
                        return 1;
                    }
                    else
                    {
                        genarateRooms();
                        return 0;
                    }
                    break;
                case 2:
                    if (!(miestnostSPokladom > 30))
                    {
                        miestnostSPokladom++;
                        return 2;
                    }
                    else
                    {
                        genarateRooms();
                        return 0;
                    }
                    break;
                case 3:
                    if (!(miestnostSPriserou > 40))
                    {
                        miestnostSPriserou++;
                        return 3;
                    }
                    else
                    {
                        genarateRooms();
                        return 0;
                    }
                    break;
                case 4:
                    if (!(miestnostSPrazdnotou > 10))
                    {
                        miestnostSPrazdnotou++;
                        return 4;
                    }
                    else
                    {
                        genarateRooms();
                        return 0;
                    }
                    break;
                    

            }
            return 0;

        }
    }
}
