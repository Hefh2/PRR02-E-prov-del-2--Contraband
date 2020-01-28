using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_prov__Contraband
{
    class Car
    {
        //Introduces the needed variables for the class and it's subs.
        public int passengers;
        public int contrabandAmount;
        public bool alreadyChecked;
        public static Random generator = new Random();

        bool returnBool = false;

        public bool Examine()
        {
            //Checks how much contraband there is, if 0 it returns false.
            if (contrabandAmount == 0)
            {
                returnBool = false;
            }
            else
            {
                //Creates a random number, 1 - 5, if the amount of contraband (1 - 4) is larger than the random number the contraband will be found.
                int contrabandFindChance = generator.Next(1, 6);
                if (contrabandAmount > contrabandFindChance)
                {
                    returnBool = true;
                } 
            }

            return returnBool;
        }

    }
}
