using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Cars.Clases
{
    class Car : ICar
    {
        /// <summary>
        /// Объявляем переменные значений траспорта
        /// </summary>
        protected string pathImg;
        protected int speed;
        protected int chanceBreakage;
        protected int distanceTraveled;
        protected bool isRun;
        protected bool isBroken;
        protected DateTime timeStart;
        protected DateTime? timeStop;
        protected DateTime? timeBroken;
        protected DateTime? repairСompletionTime;
        protected int downTime;
        protected int passengers;

        public string PathImg { get => pathImg; }
        public int Speed { get => speed; }
        public int ChanceBreakage { get => chanceBreakage; }
        public int DistanceTraveled { get => distanceTraveled; }
        public bool IsRun { get => isRun; }
        public bool IsBroken { get => isBroken; }
        public DateTime TimeStart { get => timeStart; }
        public DateTime? TimeStop { get => timeStop; }
        public DateTime? TimeBroken { get => timeBroken; }
        public DateTime? RepairСompletionTime { get => repairСompletionTime; }
        public int DownTime { get => downTime; }
        public int Passengers { get => passengers; }        

        public Car() { }

        public Car(string pathImg, int speed, int chanceBreakage, int downTime, int passengers)
        {
            this.pathImg = pathImg;
            this.speed = speed;
            this.chanceBreakage = chanceBreakage;
            this.downTime = downTime;
            this.passengers = passengers;
        }

        /// <summary>
        /// Запустить машину
        /// </summary>
        public void Start()
        {
            isRun = true;
            timeStart = DateTime.Now;
        }

        /// <summary>
        /// Остановить машину
        /// </summary>
        public void Stop()
        {
            isRun = false;
            timeStop = DateTime.Now;
        }

        /// <summary>
        /// Вычислить пройденный путь
        /// </summary>
        /// <returns></returns>
        public int CalculatTheDistanceTraveled()
        {
            // Пройденная дистанция
            int dt ;
            // Вычисляем прошедшее время
            TimeSpan time = DateTime.Now.Subtract(timeStart);
            // Вычислить пройденный путь
            dt = Convert.ToInt32(time.TotalSeconds) * speed;
            return dt;
        }
    }
}
