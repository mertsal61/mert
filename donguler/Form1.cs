namespace donguler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            for(int i = 0; i <= 10; i++)
            {
                toplam=toplam+i;
                toplam = Convert.ToInt32(toplam);   
                label1.Text=toplam.ToString();
            }

        }
    }
}