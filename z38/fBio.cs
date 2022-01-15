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
    public partial class fBio : Form
    {
        public fBio()
        {
            InitializeComponent();
        }

        private void fBio_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0; //выбираем индекс комбобокса чтобы не было пустого индекса при старте формы
            this.BackColor = Color.FromArgb(Data.R, Data.G, Data.B); //при клике обновляем цвет формы данными из класса data.
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) //согласно индексам меняем текст и передвигаем кнопку Exit по вертикали.
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0: bExit.Top = 102; textBox1.Text = "Я, Козлова Елизавета Игоревна, родилась 2 февраля 2005 года. До 2 лет я играла с погремушкой и плакала."; break;
                case 1: bExit.Top = 144; textBox1.Text = "Я, Козлова Елизавета, с 3 до 6 лет ходила в детский сад."; break;
                case 2: bExit.Top = 186; textBox1.Text = "Я, Козлова Елизавета, с 6 до 15 лет ходила в школу (окончила 9 классов)."; break;
                case 3: bExit.Top = 228; textBox1.Text = "Я, Козлова Елизавета, с 15 лет и до сих пор обучаюсь в техникуме."; break;
            }
            //textBox1.Text = comboBox1.SelectedIndex.ToString();
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e) //выбирает последний индекс соответствующий настоящему времени.
        {
            comboBox1.SelectedIndex = 3;
        }
    }
}
