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
            if (textBox1.Text != "" || dataGridView1.Rows.Count > 1)
            {
                if (!trec.IsStarted)
                {
                    timer1.Start();
                    trec.SetTrackLength(Convert.ToInt32(textBox1.Text));
                    trec.Start();
                    startDt = DateTime.Now;
                    button1.Text = "СТОП";
                    groupBox1.Enabled = false;
                    textBox1.Enabled = false;
                }
                else
                {
                    timer1.Stop();
                    trec.Stop();
                    button1.Text = "СТАРТ";
                    groupBox1.Enabled = true;
                    textBox1.Enabled = true;
                }
            }
            else
            {
                // Сообщение если не заданы длина круга и хотя бы 1 машинка
                MessageBox.Show(
                    "Задайте длину круга и добавте хотябы 1 машинку",
                    "Не все данные заполнены",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1);
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

            // Выводит пройденный путь транспорта
            for (int i = 0; i < trec.Cars.Count; i++)
            {
                dataGridView1[8, i].Value = Math.Round(trec.Cars[i].DistanceTraveled, 4);
            }

            // Проверяет едут все машины
            if (!trec.Cars.Any(el => el.IsRun))
            {
                timer1.Stop();
                trec.Stop();
                button1.Text = "СТАРТ";
                groupBox1.Enabled = true;
                textBox1.Enabled = true;
            }
        }

        /// <summary>
        /// Добавить машину в коллекцию
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                // Сообщение если не заданы параметры машинки
                MessageBox.Show(
                    "Заполните все пустые поля",
                    "Не все данные заполнены",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1);
            }
            else
            {
                // Создаёт класс легковой автомобиль
                if (comboBox2.SelectedIndex == 0)
                {
                    var car = new Car(@"Img\car.png", @"Img\flag.png", Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text), 353, 188, panel1);
                    trec.Cars.Add(car);
                    dataGridView1.Rows.Add(trec.Cars.Count - 1, "Легковой автомобиль", Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text));
                }
                // Создаёт класс грузовой автомобиль
                if (comboBox2.SelectedIndex == 1)
                {
                    var truck = new Truck(@"Img\truck.png", @"Img\flag.png", Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text), 353, 188, panel1);
                    trec.Cars.Add(truck);
                    dataGridView1.Rows.Add(trec.Cars.Count - 1, "Грузовой автомобиль", Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), null, Convert.ToInt32(textBox5.Text));
                }
                // Создаёт класс мотоцикл
                if (comboBox2.SelectedIndex == 2)
                {
                    var motorcycle = new Motorcycle(@"Img\motorcycle.png", @"Img\flag.png", Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), true, 353, 188, panel1);
                    trec.Cars.Add(motorcycle);
                    dataGridView1.Rows.Add(trec.Cars.Count - 1, "Мотоцикл", Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), null, null, Convert.ToInt32(textBox5.Text));
                }
                // Очищает поля textBox
                comboBox2.Text = null;
                textBox2.Text = null;
                textBox3.Text = null;
                textBox4.Text = null;
                textBox5.Text = null;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
            trec.Stop();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
                label9.Text = "Количество пассажиров:";
            if (comboBox2.SelectedIndex == 1)
                label9.Text = "Количество груза:";
            if (comboBox2.SelectedIndex == 2)
                label9.Text = "Наличее коляски:";
        }
    }
}
