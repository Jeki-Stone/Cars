using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cars.Clases
{
    class Motorcycle : Car
    {
        protected bool stroller;

        public bool Stroller { get => stroller; }
        public Motorcycle(string pathImg, string pathImgBroken, int speed, int chanceBreakage, int downTime, bool stroller, int x, int y, Control parent)
        {
            this.pathImg = pathImg;
            this.pathImgBroken = pathImgBroken;
            this.speed = speed;
            this.chanceBreakage = chanceBreakage;
            this.downTime = downTime;
            this.stroller = stroller;

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
