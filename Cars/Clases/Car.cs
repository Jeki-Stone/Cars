using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

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

        private PictureBox pictureBox;

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

        public Car(string pathImg, int speed, int chanceBreakage, int downTime, int passengers, int x, int y, Control parent)
        {
            this.pathImg = pathImg;
            this.speed = speed;
            this.chanceBreakage = chanceBreakage;
            this.downTime = downTime;
            this.passengers = passengers;

            this.pictureBox = new PictureBox();
            this.pictureBox.Image = Image.FromFile(pathImg);
            this.pictureBox.Parent = parent;
            this.pictureBox.Width = 50;
            this.pictureBox.Height = 50;
            this.pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox.Location = new Point(x, y);
            this.pictureBox.BringToFront();
            this.pictureBox.Show();            
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
        public float CalculatTheDistanceTraveled()
        {
            // Пройденная дистанция
            float dt ;
            // Вычисляем прошедшее время
            TimeSpan time = DateTime.Now.Subtract(timeStart);
            // Вычислить пройденный путь
            dt = ((float)time.TotalSeconds) / 3600f * speed;
            return dt;
        }

        /// <summary>
        /// Машина перерисовывает себя на новые координаты
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void Draw (int x, int y)
        {
            pictureBox.Location = new Point(x, y);
        }
    }
}
