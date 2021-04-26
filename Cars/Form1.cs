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
            if (txtTrackLength.Text != "" && dataGridViewListOfCars.Rows.Count > 0)
            {
                if (!trec.IsStarted)
                {
                    timer1.Start();
                    trec.SetTrackLength(Convert.ToInt32(txtTrackLength.Text));
                    trec.Start();
                    startDt = DateTime.Now;
                    buttonRaceStart.Text = "СТОП";
                    groupBox1.Enabled = false;
                    txtTrackLength.Enabled = false;
                    buttonClearTheListOfCars.Enabled = false;
                }
                else
                {
                    timer1.Stop();
                    trec.Stop();
                    buttonRaceStart.Text = "СТАРТ";
                    groupBox1.Enabled = true;
                    txtTrackLength.Enabled = true;
                    buttonClearTheListOfCars.Enabled = true;
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
            txtTrackLength.Text = trackLength.ToString();
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
                dataGridViewListOfCars[9, i].Value = Math.Round(trec.Cars[i].DistanceTraveled, 4);
                if (trec.Cars[i].IsBroken)
                {
                    dataGridViewListOfCars[2, i].Value = "Прокол";
                    dataGridViewListOfCars[2, i].Style.BackColor = Color.Red;
                }
                else
                {
                    dataGridViewListOfCars[2, i].Value = "Исправен";
                    dataGridViewListOfCars[2, i].Style.BackColor = Color.Lime;
                }
            }

            // Проверяем едит и хоть одна машина
            // Если нет то выдадим окно победителей
            if (!trec.Cars.Any(el => el.IsRun))
            {
                timer1.Stop();
                trec.Stop();
                buttonRaceStart.Text = "СТАРТ";
                groupBox1.Enabled = true;
                txtTrackLength.Enabled = true;
                buttonClearTheListOfCars.Enabled = true;
                
                // Запоним список финалистов
                var finalResults = new List<FinalResult>();
                int i = 0;
                finalResults = trec.Cars.OrderBy(el => el.TimeStop).Select(el => new FinalResult { Position = ++i, CarName = el.TransportType + " №" + i, SpentTime = (DateTime)el.TimeStop - el.TimeStart }).ToList();

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
            if (comboBoxTransportType.Text == "" || txtSpeed.Text == "" || txtPunctureСhance.Text == "" || txtRepairTime.Text == "" )
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
                int chanceBreak = Convert.ToInt32(txtPunctureСhance.Text);
                int repairTime = Convert.ToInt32(txtRepairTime.Text);
                int unikal = 0;
                if (txtPassengersOrCargo.Visible == true && txtPassengersOrCargo.Text != "")
                    unikal = Convert.ToInt32(txtPassengersOrCargo.Text);
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
                if (comboBoxTransportType.SelectedIndex == 0)
                {
                    var car = new Car(panel1, @"Img\car.png", @"Img\carBroken.png", speed, chanceBreak, repairTime, unikal, 353, 188);
                    trec.Cars.Add(car);
                    dataGridViewListOfCars.Rows.Add(trec.Cars.Count, car.TransportType, "Исправен", speed, chanceBreak, repairTime, unikal);
                }
                // Создаёт класс грузовой автомобиль
                if (comboBoxTransportType.SelectedIndex == 1)
                {
                    var truck = new Truck(panel1, @"Img\truck.png", @"Img\truckBroken.png", speed, chanceBreak, repairTime, unikal, 353, 188);
                    trec.Cars.Add(truck);
                    dataGridViewListOfCars.Rows.Add(trec.Cars.Count, truck.TransportType, "Исправен", speed, chanceBreak, repairTime, null, unikal);
                }
                // Создаёт класс мотоцикл
                if (comboBoxTransportType.SelectedIndex == 2)
                {
                    var motorcycle = new Motorcycle(panel1, @"Img\motorcycle.png", @"Img\motorcycleBroken.png", speed, chanceBreak, repairTime, sidcarTF, 353, 188);
                    trec.Cars.Add(motorcycle);
                    dataGridViewListOfCars.Rows.Add(trec.Cars.Count, motorcycle.TransportType, "Исправен", speed, chanceBreak, repairTime, null, null, sidecar);
                }

                for (int i = 0; i < trec.Cars.Count; i++)
                {
                    dataGridViewListOfCars[2, i].Style.BackColor = Color.Lime;
                }

                // Очищает поля 
                comboBoxTransportType.Text = null;
                CleaningFields();
                txtPassengersOrCargo.Visible = false;
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
            if (comboBoxTransportType.SelectedIndex == 0)
            {
                label9.Visible = true;
                label9.Text = "Количество пассажиров:";
                txtPassengersOrCargo.Visible = true;
                checkBox1.Visible = false;
                // Очищает поля 
                CleaningFields();
            }
            if (comboBoxTransportType.SelectedIndex == 1)
            {
                label9.Visible = true;
                label9.Text = "Количество груза, Т:";
                txtPassengersOrCargo.Visible = true;
                checkBox1.Visible = false;
                // Очищает поля 
                CleaningFields();
            }
            if (comboBoxTransportType.SelectedIndex == 2)
            {
                label9.Visible = true;
                label9.Text = "Наличее коляски:";
                txtPassengersOrCargo.Visible = false;
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
            txtPunctureСhance.Text = null;
            txtRepairTime.Text = null;
            txtPassengersOrCargo.Text = null;
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
            dataGridViewListOfCars.Rows.Clear();
        }

        /// <summary>
        /// Ограничение на ввод только цифр
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxTextWrite_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }


        /// <summary>
        /// Ограничение на ввод цифр в диапазоне от 0 до 100
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPunctureСhance_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
                return;
            }
            if (number != 8 && txtPunctureСhance.Text != "" && Convert.ToInt32(txtPunctureСhance.Text + e.KeyChar) > 100)
            {
                txtPunctureСhance.Text = "100";
            }
        }

        /// <summary>
        /// Ограничение на ввод цифр в зависимости от типа транспорта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPassengersOrCargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
                return;
            }
            if (comboBoxTransportType.SelectedIndex == 0)
            {
                if (number != 8 && Convert.ToInt32(txtPassengersOrCargo.Text + e.KeyChar) > 4 && txtPassengersOrCargo.Text + e.KeyChar != "")
                {
                    txtPassengersOrCargo.Text = "4";
                    e.Handled = true;
                }
                
            }
            if (comboBoxTransportType.SelectedIndex == 1)
            {
                if (number != 8 && Convert.ToInt32(txtPassengersOrCargo.Text + e.KeyChar) > 20 && txtPassengersOrCargo.Text + e.KeyChar != "")
                {
                    txtPassengersOrCargo.Text = "20";
                    e.Handled = true;
                }
            }
        }
    }
}
