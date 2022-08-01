namespace sinemabufesatis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int kasa = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            int misir, su, cay, bilet,toplam;
            misir=Convert.ToInt32(TxtMisir.Text);
            bilet=Convert.ToInt32(TxtBilet.Text);
            su=Convert.ToInt32(TxtSu.Text);
            cay=Convert.ToInt32(TxtCay.Text);

            toplam = misir * 4 + cay * 2 + su * 1 + bilet * 8;
            LblToplam.Text = toplam.ToString()+" TL";
            kasa = kasa + toplam;
            LblKasa.Text = kasa.ToString() + " TL";


        }

        private void Temizle_Click(object sender, EventArgs e)
        {
            TxtMisir.Text = "";
            TxtCay.Text = "";
            TxtBilet.Text = "";
            TxtSu.Text = "";
            TxtMisir.Focus();
        }
    }
}