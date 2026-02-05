using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace самостоятельная_работа
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            const double ratio = 2.5;
            listBox1.Items.Add("Дьюмы | Сантиметры");
            listBox1.Items.Add("------------------");
            for (int incher = 1; incher <= 20; incher++)
            {
                double centimeters = incher * ratio;
                listBox1.Items.Add($"{incher,5} | {centimeters,10}");
            }
        }
    }
}
