using System;
using System.Drawing;
using System.Windows.Forms;

namespace Cars.Clases
{
    /// <summary>
    /// класс машин
    /// </summary>
    class Car : ICar, IDisposable
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
        private bool disposedValue;

        public string PathImg { get => pathImg; }
        public string PathImgBroken { get => pathImgBroken; }
        public virtual string TransportType { get => "Легковой автомобиль"; }
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

        public Car(Control parent, string pathImg, string pathImgBroken, int speed, int chanceBreakage, int downTime, int passengers, int x, int y)
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
            distanceTraveled = 0;
            olddistanceTraveled = 0;
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
        /// Останавливает машину по прибытию на финиш
        /// </summary>
        /// <param name="trackLength"></param>
        public void Stop(int trackLength)
        {
            isRun = false;
            distanceTraveled = trackLength;
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
            if (!isBroken)
            {
                var chance = random.Next(0, 10000);
                if (chance <= chanceBreakage)
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

        /// <summary>
        /// Удаляет картинку машинки с трека
        /// </summary>
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: освободить управляемое состояние (управляемые объекты)
                    pictureBox.Dispose();
                }
                // TODO: освободить неуправляемые ресурсы (неуправляемые объекты) и переопределить метод завершения
                // TODO: установить значение NULL для больших полей
                disposedValue = true;
            }
        }
        public void Dispose()
        {
            // Не изменяйте этот код. Разместите код очистки в методе "Dispose(bool disposing)".
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
