using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace z38
{
    public partial class fHB : Form
    {
        public fHB() //хобби
        {
            InitializeComponent();
        }
        int time = 0; //инициализация переменной времени
        private void fHB_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(Data.R, Data.G, Data.B); //при клике обновляем цвет формы данными из класса data.
            timer1.Enabled = true; //активируем таймер при открытии формы
            button1.Text = "Здесь я расскажу вам о своих хобби."; //обновляем текст кнопки на нужный
        }
        private void button1_Click(object sender, EventArgs e) //закрытие формы при нажатии на кнопку
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e) //цикл таймера
        {
            time++; //инкремент переменной тайм
            switch (time) //обрабатываем варианты переменной тайм
            {
                case 1: button1.Text = "Я играю в баскетбол"; break;
                case 2: button1.Text = "Совместно играю в игры"; break;
                case 3: button1.Text = "Вот и все мои хобби, можно закрыть."; time = 0; break; //сбрасываем тайм чтоб зациклить цикл кейсов
            }
        }
    }
}
