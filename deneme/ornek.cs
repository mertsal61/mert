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
    public partial class ornek : Form
    {
        public ornek()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kayit;
            kayit = textBox1.Text +""+ textBox2.Text +""+ textBox4.Text +"" +""+ textBox5.Text;
            listBox1.Items.Add( kayit);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          //  listBox1.Items.Add(textBox1.Text+textBox2.Text+textBox4.Text+textBox5.Text);
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            //en az 10 yaşında olsun nasıl yazdırılır.
        }
    }
}
