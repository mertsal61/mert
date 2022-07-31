using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deneme
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.UseSystemPasswordChar = !textBox1.UseSystemPasswordChar;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string tmp = textBox2.Text;
            textBox2.Text = textBox3.Text;
            textBox3.Text = tmp;

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = "asd";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            object tmp = comboBox1.SelectedItem;
            comboBox1.SelectedItem = comboBox2.SelectedItem;
            comboBox2.SelectedItem= tmp;

        }
    }
}
