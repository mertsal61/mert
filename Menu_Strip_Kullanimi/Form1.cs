namespace Menu_Strip_Kullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void maviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.CadetBlue;
        }

        private void griToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
        }

        private void turuncuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.OrangeRed;
        }

        private void hakk�m�zdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu proje ezpz taraf�nda yap�ld�", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ��k��ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}