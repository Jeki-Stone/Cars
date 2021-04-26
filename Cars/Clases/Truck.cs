using System.Drawing;
using System.Windows.Forms;

namespace Cars.Clases
{
    /// <summary>
    /// Автор: Кузугашев Иван Владимирович
    /// Дата: 26.04.2021
    /// Класс грузовик
    /// </summary>
    class Truck : Car
    {
        protected int amountOfCargo;

        public override string TransportType { get => "Грузовой автомобиль"; }

        public int AmountOfCargo { get => amountOfCargo; }
        public Truck(Control parent, string pathImg, string pathImgBroken, int speed, int chanceBreakage, int downTime, int amountOfCargo, int x, int y)
        {
            this.pathImg = pathImg;
            this.pathImgBroken = pathImgBroken;
            this.speed = speed;
            this.chanceBreakage = chanceBreakage;
            this.downTime = downTime;
            this.amountOfCargo = amountOfCargo;

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
    }
}
