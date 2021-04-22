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
        DateTime startDt;
    
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
                trec.SetTrackLength(Convert.ToInt32(textBox1.Text));
                trec.Start();
                startDt = DateTime.Now;
                button1.Text = "СТОП";
            }
            else
            {
                timer1.Stop();
                trec.Stop();
                button1.Text = "СТАРТ";
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
            label2.Text = (DateTime.Now - startDt).ToString(@"hh\:mm\:ss");
            trec.RefreshPositions();

            if (!trec.Cars.Any(el => el.IsRun))
            {
                timer1.Stop();
                trec.Stop();
                button1.Text = "СТАРТ";
            }
        }

        /// <summary>
        /// Добавить машину в коллекцию
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            var car = new Car(@"Img\car.png", Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), 4, 353, 188, panel1);
            trec.Cars.Add(car);
            comboBox1.Items.Add(car);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
            trec.Stop();
        }
    }
}
