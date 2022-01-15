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
    public partial class fBMC : Form
    {
        public fBMC() //физ.данные
        {
            InitializeComponent();
        }
        private void fBMC_Load(object sender, EventArgs e) //при клике обновляем цвет формы данными из класса data.
        {
            this.BackColor = Color.FromArgb(Data.R, Data.G, Data.B);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked) { label1.Text = "16 лет"; }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked) { label1.Text = "173 см"; }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked) { label1.Text = "45 кг"; }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked) { label1.Text = "Серый"; }
        }
    }
}
