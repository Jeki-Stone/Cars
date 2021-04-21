using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Clases
{
    class Truck : Car
    {
        protected int amountOfCargo;

        public int AmountOfCargo { get => amountOfCargo; }
        public Truck( int speed)
        {
            this.speed = speed;
        }
    }
}
