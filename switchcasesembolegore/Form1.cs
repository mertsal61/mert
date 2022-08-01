namespace switchcasesembolegore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void YAP_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2;
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);
            string sembol;
            sembol = textBox3.Text;
            switch (sembol)
            {
                case ("+"): textBox3.Text = (sayi1 + sayi2).ToString(); break;
                case ("-"): textBox3.Text = (sayi1 - sayi2).ToString(); break;
                case ("*"): textBox3.Text = (sayi1 * sayi2).ToString(); break;
                case ("/"): textBox3.Text = (sayi1 / sayi2).ToString(); break;
                default: textBox3.Text = "FIX"; break;
            }
        }
    }
}