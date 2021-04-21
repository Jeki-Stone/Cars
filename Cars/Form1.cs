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
        private int h = 0;
        private int m = 0;
        private int s = 0;
        private int start = 1;

        public Form1()
        {
            InitializeComponent();
        }

        /// При нажатии на кнопку начинается работа всей программы
        private void button1_Click(object sender, EventArgs e)
        {
            if (start == 1)
                timer1.Start();
            else
                timer1.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            var car1 = new Cars.Class.Car(1, 30, 1);
            var Truck = new Cars.Class.Truck(2, 25, 2);
            var Motorcycle = new Cars.Class.Motorcycle(3, 35, 3);
        }

        /// Таймер
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
        }
    }
}
