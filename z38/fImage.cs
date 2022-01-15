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
    public partial class fImage : Form
    {
        public fImage() //медиафайлы
        {
            InitializeComponent();
        }

        private void fImage_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(Data.R, Data.G, Data.B); //при клике обновляем цвет формы данными из класса data.
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e) //при задержке курсора на боксе1 устанавливаем в боксе2 левую картинку и убираем из бокса1
        {
            pictureBox2.Image = z38.Properties.Resources.bnt320r;
            pictureBox1.Image = null;
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e) //тоже самое только наоборот
        {
            pictureBox1.Image = z38.Properties.Resources.bnt320l;
            pictureBox2.Image = null;
        }
    }
}
