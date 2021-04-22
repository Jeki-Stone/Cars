using Cars.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cars
{
    public partial class Form1 : Form
    {
        RacingTrack trec;
        private int h = 0;
        private int m = 0;
        private int s = 0;
        private bool start = false;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// При нажатии на кнопку начинается работа всей программы
        /// <summary>
        private void button1_Click(object sender, EventArgs e)
        {
            if (!trec.IsStarted)
            {
                timer1.Start();
                trec.Start();
            }
            else
            {
                timer1.Stop();
                trec.Stop();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            trec = new RacingTrack(1000);

            //trec.SetTrackLength(2000);
            //var car1 = new Cars.Class.Car(30);
            //var Truck = new Cars.Class.Truck(25);
            //var Motorcycle = new Cars.Class.Motorcycle(35);
            //trec.Cars.Add()
        }

        /// <summary>
        /// Таймер
        /// <summary>
        private void timer1_Tick(object sender, EventArgs e)
        {
            string time;

            s += 1;
            if (s == 60)
            {
                s = 0;
                m += 1;
            }
            if (m == 60)
            {
                m = 0;
                h += 1;
            }

            time = h + ":" + m + ":" + s;
            label2.Text = time;

            int ximg = 0;
            int yimg = 0;
            trec.RefreshPositions(ref ximg, ref yimg);
            ximg -= 25;
            yimg -= 25;
            pictureBox2.Location = new Point(ximg, yimg);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var car = new Car(@"\Img\car.png", Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), 4);
            trec.Cars.Add(car);
            comboBox1.Items.Add(car);
        }
    }
}
