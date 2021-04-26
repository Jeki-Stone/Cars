
namespace Cars
{
    /// <summary>
    /// Автор: Кузугашев Иван Владимирович
    /// Дата: 26.04.2021
    /// </summary>
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonRaceStart = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonClearTheListOfCars = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtPassengersOrCargo = new System.Windows.Forms.TextBox();
            this.txtRepairTime = new System.Windows.Forms.TextBox();
            this.buttonAddTransport = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPunctureСhance = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSpeed = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxTransportType = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtTrackLength = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewListOfCars = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListOfCars)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRaceStart
            // 
            this.buttonRaceStart.Location = new System.Drawing.Point(530, 362);
            this.buttonRaceStart.Name = "buttonRaceStart";
            this.buttonRaceStart.Size = new System.Drawing.Size(182, 58);
            this.buttonRaceStart.TabIndex = 9;
            this.buttonRaceStart.Text = "СТАРТ";
            this.buttonRaceStart.UseVisualStyleBackColor = true;
            this.buttonRaceStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonClearTheListOfCars);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.txtPassengersOrCargo);
            this.groupBox1.Controls.Add(this.txtRepairTime);
            this.groupBox1.Controls.Add(this.buttonAddTransport);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPunctureСhance);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtSpeed);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.comboBoxTransportType);
            this.groupBox1.Location = new System.Drawing.Point(444, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 240);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данные для нового транспорта";
            // 
            // buttonClearTheListOfCars
            // 
            this.buttonClearTheListOfCars.Location = new System.Drawing.Point(20, 192);
            this.buttonClearTheListOfCars.Name = "buttonClearTheListOfCars";
            this.buttonClearTheListOfCars.Size = new System.Drawing.Size(148, 31);
            this.buttonClearTheListOfCars.TabIndex = 10;
            this.buttonClearTheListOfCars.Text = "Очистить список";
            this.buttonClearTheListOfCars.UseVisualStyleBackColor = true;
            this.buttonClearTheListOfCars.Click += new System.EventHandler(this.button3_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(161, 156);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(71, 19);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Коляска";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            // 
            // txtPassengersOrCargo
            // 
            this.txtPassengersOrCargo.Location = new System.Drawing.Point(161, 154);
            this.txtPassengersOrCargo.MaxLength = 3;
            this.txtPassengersOrCargo.Name = "txtPassengersOrCargo";
            this.txtPassengersOrCargo.Size = new System.Drawing.Size(167, 23);
            this.txtPassengersOrCargo.TabIndex = 6;
            this.txtPassengersOrCargo.Visible = false;
            this.txtPassengersOrCargo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassengersOrCargo_KeyPress);
            // 
            // txtRepairTime
            // 
            this.txtRepairTime.Location = new System.Drawing.Point(161, 125);
            this.txtRepairTime.MaxLength = 3;
            this.txtRepairTime.Name = "txtRepairTime";
            this.txtRepairTime.Size = new System.Drawing.Size(167, 23);
            this.txtRepairTime.TabIndex = 5;
            this.txtRepairTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTextWrite_KeyPress);
            // 
            // buttonAddTransport
            // 
            this.buttonAddTransport.Location = new System.Drawing.Point(234, 192);
            this.buttonAddTransport.Name = "buttonAddTransport";
            this.buttonAddTransport.Size = new System.Drawing.Size(86, 31);
            this.buttonAddTransport.TabIndex = 8;
            this.buttonAddTransport.Text = "Добавить";
            this.buttonAddTransport.UseVisualStyleBackColor = true;
            this.buttonAddTransport.Click += new System.EventHandler(this.button2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "Выберете тип транспорта";
            this.label9.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "Время ремонта,  сек:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Тип транспорта:";
            // 
            // txtPunctureСhance
            // 
            this.txtPunctureСhance.Location = new System.Drawing.Point(161, 97);
            this.txtPunctureСhance.MaxLength = 3;
            this.txtPunctureСhance.Name = "txtPunctureСhance";
            this.txtPunctureСhance.Size = new System.Drawing.Size(167, 23);
            this.txtPunctureСhance.TabIndex = 4;
            this.txtPunctureСhance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPunctureСhance_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Скорость, км/ч:";
            // 
            // txtSpeed
            // 
            this.txtSpeed.Location = new System.Drawing.Point(161, 70);
            this.txtSpeed.MaxLength = 3;
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.Size = new System.Drawing.Size(167, 23);
            this.txtSpeed.TabIndex = 3;
            this.txtSpeed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTextWrite_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Шанс прокола колеса, %:";
            // 
            // comboBoxTransportType
            // 
            this.comboBoxTransportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTransportType.FormattingEnabled = true;
            this.comboBoxTransportType.Items.AddRange(new object[] {
            "Легковой автомобиль",
            "Грузовой автомобиль",
            "Мотоцикл"});
            this.comboBoxTransportType.Location = new System.Drawing.Point(161, 36);
            this.comboBoxTransportType.Name = "comboBoxTransportType";
            this.comboBoxTransportType.Size = new System.Drawing.Size(167, 23);
            this.comboBoxTransportType.TabIndex = 2;
            this.comboBoxTransportType.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(498, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Длина круга, км";
            // 
            // txtTrackLength
            // 
            this.txtTrackLength.Location = new System.Drawing.Point(605, 12);
            this.txtTrackLength.MaxLength = 3;
            this.txtTrackLength.Name = "txtTrackLength";
            this.txtTrackLength.Size = new System.Drawing.Size(100, 23);
            this.txtTrackLength.TabIndex = 1;
            this.txtTrackLength.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(524, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 45);
            this.label2.TabIndex = 5;
            this.label2.Text = "00:00:00.000";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cars.Properties.Resources.ring;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(426, 426);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::Cars.Properties.Resources.ring2;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 426);
            this.panel1.TabIndex = 10;
            // 
            // dataGridViewListOfCars
            // 
            this.dataGridViewListOfCars.AllowUserToAddRows = false;
            this.dataGridViewListOfCars.AllowUserToDeleteRows = false;
            this.dataGridViewListOfCars.AllowUserToOrderColumns = true;
            this.dataGridViewListOfCars.AllowUserToResizeRows = false;
            this.dataGridViewListOfCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListOfCars.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.ColumnStatus,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dataGridViewListOfCars.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewListOfCars.Location = new System.Drawing.Point(13, 448);
            this.dataGridViewListOfCars.Name = "dataGridViewListOfCars";
            this.dataGridViewListOfCars.RowHeadersVisible = false;
            this.dataGridViewListOfCars.RowTemplate.Height = 25;
            this.dataGridViewListOfCars.Size = new System.Drawing.Size(775, 191);
            this.dataGridViewListOfCars.TabIndex = 11;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "№";
            this.Column1.Name = "Column1";
            this.Column1.Width = 30;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Тип транспорта";
            this.Column2.Name = "Column2";
            this.Column2.Width = 137;
            // 
            // ColumnStatus
            // 
            this.ColumnStatus.HeaderText = "Статус";
            this.ColumnStatus.Name = "ColumnStatus";
            this.ColumnStatus.Width = 65;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Скорость Км/ч";
            this.Column3.Name = "Column3";
            this.Column3.Width = 70;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Шанс прокола колеса";
            this.Column4.Name = "Column4";
            this.Column4.Width = 70;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Время ремонта";
            this.Column5.Name = "Column5";
            this.Column5.Width = 70;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Число пассажир";
            this.Column6.Name = "Column6";
            this.Column6.Width = 80;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Количество груза, Т";
            this.Column7.Name = "Column7";
            this.Column7.Width = 80;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Наличие коляски";
            this.Column8.Name = "Column8";
            this.Column8.Width = 80;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Пройденный путь Км.";
            this.Column9.Name = "Column9";
            this.Column9.Width = 90;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 651);
            this.Controls.Add(this.dataGridViewListOfCars);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTrackLength);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRaceStart);
            this.Name = "Form1";
            this.Text = "Трек";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListOfCars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRaceStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTrackLength;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonAddTransport;
        private System.Windows.Forms.ComboBox comboBoxTransportType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPunctureСhance;
        private System.Windows.Forms.TextBox txtSpeed;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtRepairTime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPassengersOrCargo;
        private System.Windows.Forms.Label Километров;
        private System.Windows.Forms.Button buttonClearTheListOfCars;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridView dataGridViewListOfCars;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}

