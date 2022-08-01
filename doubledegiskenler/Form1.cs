namespace doubledegiskenler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad, soyad;
            int s1, s2, p1;
            double ortalama;
            ad = textBox1.Text;
            soyad = textBox2.Text;
            s1=Convert.ToInt32(textBox3.Text);
            s2=Convert.ToInt32(textBox4.Text);
            p1= Convert.ToInt32(textBox5.Text);
            ortalama = (s1 + s2 + p1) / 3;
            listBox1.Items.Add(ad + " " + soyad + " ortalama: " + ortalama);


        }
    }
}