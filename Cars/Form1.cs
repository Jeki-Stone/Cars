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
            if (textBox1.Text != "" && dataGridView1.Rows.Count > 0)
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
                    button3.Enabled = false;
                }
                else
                {
                    timer1.Stop();
                    trec.Stop();
                    button1.Text = "СТАРТ";
                    groupBox1.Enabled = true;
                    textBox1.Enabled = true;
                    button3.Enabled = true;
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
            var trackLength = 2;
            trec = new RacingTrack(trackLength);
            textBox1.Text = trackLength.ToString();
        }

        /// <summary>
        /// Таймер
        /// <summary>
        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = (DateTime.Now - startDt).ToString(@"hh\:mm\:ss\.fff");
            trec.RefreshPositions();

            // Выводит пройденный путь транспорта
            for (int i = 0; i < trec.Cars.Count; i++)
            {
                dataGridView1[9, i].Value = Math.Round(trec.Cars[i].DistanceTraveled, 4);
                if (trec.Cars[i].IsBroken)
                {
                    dataGridView1[2, i].Value = "Прокол";
                    dataGridView1[2, i].Style.BackColor = Color.Red;
                }
                else
                {
                    dataGridView1[2, i].Value = "Исправен";
                    dataGridView1[2, i].Style.BackColor = Color.Lime;
                }
            }

            // Проверяем едит и хоть одна машина
            // Если нет то выдадим окно победителей
            if (!trec.Cars.Any(el => el.IsRun))
            {
                timer1.Stop();
                trec.Stop();
                button1.Text = "СТАРТ";
                groupBox1.Enabled = true;
                textBox1.Enabled = true;
                button3.Enabled = true;
                
                // запоним список финалистов
                var finalResults = new List<FinalResult>();
                int i = 0;
                finalResults = trec.Cars.OrderBy(el => el.TimeStop).Select(el => new FinalResult { Position = ++i, CarName = el.TransportType + " №" + i, SpentTime = (DateTime)el.TimeStop - el.TimeStart }).ToList();

                //for (int i = 0; i < trec.Cars.Count; i++)
                //{
                //    finalResults.Add(new FinalResult { CarName = trec.Cars[i].TransportType + " №" + i, SpentTime = (DateTime)trec.Cars[i].TimeStop - trec.Cars[i].TimeStart });
                //}

                // Вызывает форму финалистов
                Form2 form2 = new Form2(label2.Text, finalResults);
                if (form2.ShowDialog()  == DialogResult.Yes)
                {
                    button1_Click( sender,  e);
                }
            }
        }

        /// <summary>
        /// Добавить машину в коллекцию
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == "" || txtSpeed.Text == "" || textBox3.Text == "" || textBox4.Text == "" )
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
                int speed = Convert.ToInt32(txtSpeed.Text);
                int chanceBreak = Convert.ToInt32(textBox3.Text);
                int repairTime = Convert.ToInt32(textBox4.Text);
                int unikal = 0;
                if (textBox5.Visible == true && textBox5.Text != "")
                    unikal = Convert.ToInt32(textBox5.Text);
                string sidecar = "";
                bool sidcarTF = false;
                if (checkBox1.Checked == true && checkBox1.Visible == true)
                {
                    sidcarTF = true;
                    sidecar = "Есть";
                }
                else
                {
                    sidecar = "Нет";
                }

                // Создаёт класс легковой автомобиль
                if (comboBox2.SelectedIndex == 0)
                {
                    var car = new Car(panel1, @"Img\car.png", @"Img\flag.png", speed, chanceBreak, repairTime, unikal, 353, 188);
                    trec.Cars.Add(car);
                    dataGridView1.Rows.Add(trec.Cars.Count, car.TransportType, "Исправен", speed, chanceBreak, repairTime, unikal);
                }
                // Создаёт класс грузовой автомобиль
                if (comboBox2.SelectedIndex == 1)
                {
                    var truck = new Truck(panel1, @"Img\truck.png", @"Img\flag.png", speed, chanceBreak, repairTime, unikal, 353, 188);
                    trec.Cars.Add(truck);
                    dataGridView1.Rows.Add(trec.Cars.Count, truck.TransportType, "Исправен", speed, chanceBreak, repairTime, null, unikal);
                }
                // Создаёт класс мотоцикл
                if (comboBox2.SelectedIndex == 2)
                {
                    var motorcycle = new Motorcycle(panel1, @"Img\motorcycle.png", @"Img\flag.png", speed, chanceBreak, repairTime, sidcarTF, 353, 188);
                    trec.Cars.Add(motorcycle);
                    dataGridView1.Rows.Add(trec.Cars.Count, motorcycle.TransportType, "Исправен", speed, chanceBreak, repairTime, null, null, sidecar);
                }

                for (int i = 0; i < trec.Cars.Count; i++)
                {
                    dataGridView1[2, i].Style.BackColor = Color.Lime;
                }

                // Очищает поля 
                comboBox2.Text = null;
                CleaningFields();
                textBox5.Visible = false;
                checkBox1.Visible = false;
                label9.Visible = false;

            }
        }

        /// <summary>
        /// Остановка при закрытии формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
            trec.Stop();
        }

        /// <summary>
        /// В зависимости от типа транспорта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                label9.Visible = true;
                label9.Text = "Количество пассажиров:";
                textBox5.Visible = true;
                checkBox1.Visible = false;
                // Очищает поля 
                CleaningFields();
            }
            if (comboBox2.SelectedIndex == 1)
            {
                label9.Visible = true;
                label9.Text = "Количество груза:";
                textBox5.Visible = true;
                checkBox1.Visible = false;
                // Очищает поля 
                CleaningFields();
            }
            if (comboBox2.SelectedIndex == 2)
            {
                label9.Visible = true;
                label9.Text = "Наличее коляски:";
                textBox5.Visible = false;
                checkBox1.Visible = true;
                // Очищает поля 
                CleaningFields();                
            }
        }

        /// <summary>
        /// Очищает поля
        /// </summary>
        private void CleaningFields()
        {
            txtSpeed.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
            checkBox1.Checked = false;
        }

        /// <summary>
        /// Очищает коллекцию машин с трека
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            foreach (var item in trec.Cars)
            {
                item.Dispose();
            }
            trec.Cars.Clear();
            dataGridView1.Rows.Clear();
        }

       
    }
}
