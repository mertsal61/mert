namespace deneme
{
    public partial class ilkkod : Form
    {
        public ilkkod()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba Dünya");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "Mert";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label6.Text = "Merdo";
            label7.Text = "SAL";
            label8.Text = "Mühendis";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "deneme baþarýlý";
            label9.Text = textBox1.Text;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        private void button5_Click(object sender, EventArgs e)
        {
            label10.Text = textBox2.Text;
            label11.Text = textBox3.Text;
            label12.Text = textBox4.Text;
        }
    }
}