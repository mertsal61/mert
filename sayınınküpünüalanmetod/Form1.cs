namespace sayınınküpünüalanmetod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int kup(int sayi)
        {
            //
        //int sonuc = sayi * sayi * sayi;
        return (int)Math.Pow(sayi, 3);
        }   



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s = Convert.ToInt32(textBox1.Text);
            label1.Text = kup(s).ToString();
        }
    }
}