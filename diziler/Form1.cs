namespace diziler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int[] sayilar = { 0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20 };
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i]%2==0 && sayilar[i]>10)
                {
                    listBox1.Items.Add(sayilar[i]);
                }
            }

        }
    }
}