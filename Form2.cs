using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form2 : Form
    {
        bool allowClose = false; // По умолчанию закрывать нельзя

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            allowClose = true; // Разрешаем закрытие
            this.Close();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Если флаг allowClose всё еще false, значит нажали на крестик
            if (!allowClose)
            {
                e.Cancel = true; // Отменяем закрытие
                MessageBox.Show("Ты не всё понял...");
            }
        }
    }
}
