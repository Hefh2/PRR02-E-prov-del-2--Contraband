using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_prov__Contraband
{
    class CleanCar : Car
    {

        public CleanCar()
        {
            passengers = generator.Next(1, 4);
            //passengers is a random number 1 - 3
            contrabandAmount = 0;
            //contrabandAmount is 0


        }

    }
}
