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
        protected string pathImgBroken;
        protected int speed;
        protected int chanceBreakage;
        protected float distanceTraveled;
        protected float olddistanceTraveled;
        protected bool isRun;
        protected bool isBroken;
        protected DateTime timeStart;
        protected DateTime? timeStop;
        protected DateTime? timeBroken;
        protected DateTime? repairСompletionTime;
        protected int downTime;
        protected int passengers;

        protected PictureBox pictureBox;
        protected Random random = new Random();

        public string PathImg { get => pathImg; }
        public string PathImgBroken { get => pathImgBroken; }
        public int Speed { get => speed; }
        public int ChanceBreakage { get => chanceBreakage; }
        public float DistanceTraveled { get => distanceTraveled; }
        public bool IsRun { get => isRun; }
        public bool IsBroken { get => isBroken; }
        public DateTime TimeStart { get => timeStart; }
        public DateTime? TimeStop { get => timeStop; }
        public DateTime? TimeBroken { get => timeBroken; }
        public DateTime? RepairСompletionTime { get => repairСompletionTime; }
        public int DownTime { get => downTime; }
        public int Passengers { get => passengers; }        

        public Car() { }

        public Car(string pathImg, string pathImgBroken, int speed, int chanceBreakage, int downTime, int passengers, int x, int y, Control parent)
        {
            this.pathImg = pathImg;
            this.pathImgBroken = pathImgBroken;
            this.speed = speed;
            this.chanceBreakage = chanceBreakage;
            this.downTime = downTime;
            this.passengers = passengers;

            this.isBroken = false;

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
            repairСompletionTime = DateTime.Now;
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
            // Вычисляем прошедшее время
            TimeSpan time = DateTime.Now.Subtract(repairСompletionTime.Value);
            // Вычислить пройденный путь
            distanceTraveled = ((float)time.TotalSeconds) / 3600f * speed + olddistanceTraveled;
            return distanceTraveled;
        }

        /// <summary>
        /// Рассчитываем вероятность поломки машины и меняем её статус поломки
        /// </summary>
        public void CalculatingTheChanceOfBreakage ()
        {
            if (isBroken == false)
            {
                var chance = random.Next(1, 101);
                if (chance <= ChanceBreakage)
                {
                    isBroken = true;
                    olddistanceTraveled = distanceTraveled;
                    pictureBox.Image = Image.FromFile(pathImgBroken);
                    timeBroken = DateTime.Now;
                }
            }
            else
            {
                TimeSpan time = DateTime.Now.Subtract(timeBroken.Value);
                if (downTime <= time.TotalSeconds)
                {
                    isBroken = false;
                    pictureBox.Image = Image.FromFile(pathImg);
                }
                repairСompletionTime = DateTime.Now;
            }
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
