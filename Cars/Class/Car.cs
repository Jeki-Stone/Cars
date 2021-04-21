using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Cars.Class
{
    class Car
    {
        /// <summary>
        /// Объявляем переменные значений траспорта
        /// </summary>
        protected int id;
        protected int speed;
        protected int type;
        protected int chanceBreakage;
        protected int distanceTraveled;
        protected int passengers;
        protected bool start;
        protected bool broken;
        protected DateTime timeStart;
        protected DateTime timeStop;
        protected DateTime timeBroken;
        protected string coordinates;
        protected string pathImg;

        public int Id { get => id; }
        public int Speed { get => speed; }
        public int Type { get => type; }
        public int ChanceBreakage { get => chanceBreakage; }
        public int DistanceTraveled { get => distanceTraveled; }
        public virtual int Passengers { get => passengers; }
        public bool Start { get => start; }
        public bool Broken { get => broken; }
        public DateTime TimeStart { get => timeStart; }
        public DateTime TimeStop { get => timeStop; }
        public DateTime TimeBroken { get => timeBroken; }
        public string Coordinates { get => coordinates; }
        public string PathImg { get => pathImg; }

        public Car() { }

        public Car(int id, int speed, int type) 
        {
            this.id = id;
            this.speed = speed;
            this.type = type;
        }

        private void GetInfo()
        {
            StreamReader sr = new StreamReader(@"..\Cars.cs");
        }
    }
}
