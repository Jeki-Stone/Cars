using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Clases
{
    class Motorcycle : Car
    {
        protected bool stroller;

        public bool Stroller { get => stroller; }
        public Motorcycle(int speed)
        {
            this.speed = speed;
        }
    }
}
