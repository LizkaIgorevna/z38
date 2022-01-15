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
    public partial class fDocs : Form
    {
        public fDocs() //документы
        {
            InitializeComponent();
        }

        private void fDocs_Load(object sender, EventArgs e) //при клике обновляем цвет формы данными из класса data.
        {
            this.BackColor = Color.FromArgb(Data.R, Data.G, Data.B);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox1.SelectedIndex)
            {
                case 0: MessageBox.Show("ИНН: 434353544462"); break;
                case 1: MessageBox.Show("Серия: 20 16; Номер: 464637"); break;
                case 2: MessageBox.Show("III-AM № 230067"); break;
            }
        }
    }
}
