using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_KhajiitBot
{
    public class RatingLogic
    {
        int basic = 1000;
        int nb = 250;
        int templar = 250;
        int sorc = 300;
        int dk = 400;
        int mag = 500;
        int stam = 0;
        int rating;
        int tempValue;
        int gearBlue = 250;
        int gearPurple = 500;
        int gearGold = 650;
        int levelVariable = 50;
        int luck;

        static Random r = new Random();

        public int calculateRating(int charClass, int IsMag, int gear, int level)
        {
            switch(charClass)
            {
                case 1:
                    rating = basic + nb;
                    break;

                case 2:
                    rating = basic + templar;
                    break;

                case 3:
                    rating = basic + sorc;
                    break;

                case 4:
                    rating = basic + dk;
                    break;
            }

            if (IsMag == 1)
            {
                rating = rating + mag;
            }else
            {
                rating = rating + stam;
            }

            switch(gear)
            {
                case 1:
                    rating = rating + gearBlue;
                    break;

                case 2:
                    rating = rating + gearPurple;
                    break;

                case 3:
                    rating = rating + gearGold;
                    break;
            }

            tempValue = level * levelVariable;

            rating = rating + tempValue;

            if (charClass == 3 && IsMag == 1)
            {
                rating = rating + 250;
            }

            if (charClass == 4 && IsMag == 0)
            {
                rating = rating + 100;
            }

            luck = r.Next(25, 175);

            rating = rating + luck;

            return rating;
        }

        public String[] sortByRating(int[] rating, string[] name)
        {
            Array.Sort(rating, name);
            return name;
        }
    }
}
