namespace sınıficindedegerdondurendeger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            islem isl= new islem();
            isl.topla(7, 6);
            Console.ReadLine();
        }
    }
}