namespace bilgiyarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0, dogru = 0, yanlis = 0;

        private void BtnB_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            label5.Text=BtnB.Text;
            if(label4.Text==label5.Text)
            {
                dogru++;
                LblDogru.Text=dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlis.Text=yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            label5.Text = BtnC.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void BtnD_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled=true;

            label5.Text = BtnD.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void BtnA_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            label5.Text=BtnA.Text;
            if(label4.Text==label5.Text)
            {
                dogru++;
                LblDogru.Text=dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlis.Text=yanlis.ToString();
                pictureBox2.Visible = true;
            }

        }

        private void BtnSonraki_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = true;
            BtnB.Enabled = true;
            BtnC.Enabled = true;
            BtnD.Enabled = true;
            BtnSonraki.Enabled = false;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
             
            
            
            soruno++;
            LblSoruno.Text = soruno.ToString();

            if(soruno==1)
            {
                richTextBox1.Text = "Cumhuriyet Ka� Y�l�nda �lan Edilmi�tir?";
                BtnA.Text = "1920";
                BtnB.Text = "1921";
                BtnC.Text = "1922";
                BtnD.Text = "1923";
                label4.Text = "1923";
            }
            if(soruno==2)
            {
                richTextBox1.Text = "Hangisi Ege B�lgemizde Bulunmaz?";
                BtnA.Text = "Trabzon";
                BtnB.Text = "�zmir";
                BtnC.Text = "Manisa";
                BtnD.Text = "Ayd�n";

                label4.Text = "Trabzon";
            }
            if (soruno==3)
            {
                richTextBox1.Text = "T�rkiye'nin Ba�kenti Neresidir?";
                BtnA.Text = "�stanbul";
                BtnB.Text = "Ankara";
                BtnC.Text = "Samsun";
                BtnD.Text = "Adana";

                label4.Text = "Ankara";
                BtnSonraki.Text = "Sonuclar";
            }
            if (soruno==4)
            {
                BtnA.Enabled = false;
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled = false;
                BtnSonraki.Enabled = false;
                MessageBox.Show("Do�ru:" + dogru + " \n" + "Yanl��" + yanlis);
            }
        }
    }
}