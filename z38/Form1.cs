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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ColorChange(object sender, EventArgs e)
        {
            if (ColorR.Checked) { Data.R = 255; } else { Data.R = 64; } //переводим состояние чекбоксов в значение цветов. Значение цветов в классе дата.
            if (ColorG.Checked) { Data.G = 255; } else { Data.G = 64; }
            if (ColorB.Checked) { Data.B = 255; } else { Data.B = 64; }
            this.BackColor = Color.FromArgb(Data.R, Data.G, Data.B); //при клике обновляем цвет формы данными из класса data.
            panel1.BackColor = Color.FromArgb(255 - Data.R/2, 255 - Data.G/2, 255 - Data.B/2); //почти инвертируем цвет панели1 чтоб она визуально отличалась.
        }

        //private void ColorG_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (ColorG.Checked) { Data.G = 255; } else { Data.G = 0; }
        //    this.BackColor = Color.FromArgb(Data.R, Data.G, Data.B);
        //}

        //private void ColorB_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (ColorB.Checked) { Data.B = 255; } else { Data.B = 0; }
        //    this.BackColor = Color.FromArgb(Data.R, Data.G, Data.B);
        //}

        private void bBio_Click(object sender, EventArgs e) //кнопка открытия формы с биографией.
        {
            fBio biograf = new fBio();
            biograf.ShowDialog(); //блокируем основную форму при открытии новой во избежание палива с невозможностью смены цвета уже открытой формы.
        }

        private void Form1_Load(object sender, EventArgs e) //инициализация цвета формы1 для сихронизации с данными в классе data.
        {
            Data.R = Data.G = Data.B = 64;
            this.BackColor = Color.FromArgb(Data.R, Data.G, Data.B);
            panel1.BackColor = Color.FromArgb(255 - Data.R / 2, 255 - Data.G / 2, 255 - Data.B / 2); //почти инвертируем цвет панели1 чтоб она визуально отличалась.
        }

        private void bReset_Click(object sender, EventArgs e) //сброс значений ргб, чекбоксов, обновления цвета формы.
        {
            Data.R = Data.G = Data.B = 64;
            ColorR.Checked = ColorG.Checked = ColorB.Checked = false;
            this.BackColor = Color.FromArgb(Data.R, Data.G, Data.B);
        }

        private void bBiometric_Click(object sender, EventArgs e) //кнопка открытия формы с физ.данными.
        {
            fBMC biometr = new fBMC();
            biometr.ShowDialog();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e) //смена иконок и названия формы при смене вкладок табконтрола.
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0: this.Text = "important"; this.Icon = z38.Properties.Resources._256l; break;
                case 1: this.Text = "hehe"; this.Icon = z38.Properties.Resources._256r; break;
            }
        }

        private void bDocs_Click(object sender, EventArgs e) //кнопка открытия формы с документами
        {
            fDocs doki = new fDocs();
            doki.ShowDialog();
        }

        private void bHobby_Click(object sender, EventArgs e) //кнопка открытия формы с хобби.
        {
            fHB hobby = new fHB();
            hobby.ShowDialog();
        }

        private void bMedia_Click(object sender, EventArgs e) //кнопка открытия формы с медиафайлами.
        {
            fImage mda = new fImage();
            mda.ShowDialog();
        }
    }
}
