namespace progressbar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 75;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            progressBar1.Value += 10;

            

            if (progressBar1.Value > 75)
            {
                button3.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(progressBar1.Value - 10 < 0)
            {
                progressBar1.Value = 0;
            } else
            {
                progressBar1.Value -= 10;
            }
            
            

            if (progressBar1.Value <= 0)
            {
                button2.Enabled = false;
            }
        }
    }
}