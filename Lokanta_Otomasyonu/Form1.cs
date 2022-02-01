using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lokanta_Otomasyonu
{
    public partial class form1 : Form
    {       
        public form1()
        {
            InitializeComponent();
        }

        private void form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.AntiqueWhite;
            label1.Text = "Personel Adı:(murat)";
            label2.Text = "Personel Şifresi:(1234)";
            label3.Text = "Personel Girişi\n(Lütfen personel adınızı ve şifrenizi giriniz)";
        }

        private void PersonelGirisBtn_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = textBox1.Text;
            string sifre = textBox2.Text;

            if (kullaniciAdi == "murat" && sifre == "1234")
            {               
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı");
            }
        }

        private void giriskapatmabutonu_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Aquamarine;
            this.Close();
            Application.Exit();
        }
    }
}
