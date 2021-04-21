using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Class
{
    class Truck : Car
    {
        public Truck(int id, int speed, int type)
        {
            this.id = id;
            this.speed = speed;
            this.type = type;
        }
    }
}
