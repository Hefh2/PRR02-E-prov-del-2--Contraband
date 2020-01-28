using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_prov__Contraband
{
    class ContrabandCar : Car
    {

        public ContrabandCar()
        {
            passengers = generator.Next(1, 5);
            //passengers is a random number 1 - 5
            contrabandAmount = generator.Next(1, 5);
            //contrabandAmount is a random number 1 -4

        }

    }
}
