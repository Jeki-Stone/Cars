using System.Drawing;
using System.Windows.Forms;

namespace Cars.Clases
{
    /// <summary>
    /// Класс мотоцикл
    /// </summary>
    class Motorcycle : Car
    {
        protected bool isStroller;

        public override string TransportType { get => "Мотоцикл"; }

        public bool IsStroller { get => isStroller; }
        public Motorcycle(Control parent, string pathImg, string pathImgBroken, int speed, int chanceBreakage, int downTime, bool isStroller, int x, int y)
        {
            this.pathImg = pathImg;
            this.pathImgBroken = pathImgBroken;
            this.speed = speed;
            this.chanceBreakage = chanceBreakage;
            this.downTime = downTime;
            this.isStroller = isStroller;

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
