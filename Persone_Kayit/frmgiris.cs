using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Persone_Kayit
{
    public partial class frmgiris : Form
    {
        public frmgiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti =new SqlConnection("Data Source=MERT\\SQLEXPRESS;Initial Catalog=PersonelVeriTabanı;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from Tbl_Yonetici where KullaniciAd=@p1 and sifre=@p2",baglanti);
            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            komut.Parameters.AddWithValue("@p2", textBox2.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if(dr.Read())
            {
                frmanaform frm =new frmanaform();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı");
            }

            baglanti.Close();
        }

        private void frmgiris_Load(object sender, EventArgs e)
        {

        }
    }
}
