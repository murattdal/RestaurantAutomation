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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            listBox1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            label6.Visible = false;

            this.Text = "Personel Girişi";
            Yemek karsilama = new Yemek();
            karsilama.karsilama();
            label1.Text = "Lütfen Masa Numarası Seçiniz:";
            string[] masalar = { "Masa 1", "Masa 2", "Masa 3", "Masa 4", "Masa 5", "Masa 6" };
            comboBox1.Items.AddRange(masalar);
            button1.Text = "Devam Et";
            label2.Text = "Çorbalar";
            label3.Text = "Yemek Çeşitleri";
            label4.Text = "Tatlı Çeşitleri";
            label5.Text = "Meşrubatlar";
            label6.Text = "HAFTANIN MENÜSÜNÜ GÖRMEK İÇİN TIKLAYIN";
            checkBox1.Text = "Domates Çorbası 10₺";
            checkBox2.Text = "Tarhana Çorbası 15₺";
            checkBox3.Text = "Mercimek Çorbası 6₺";
            checkBox4.Text = "Ezogelin Çorbası 8₺";
            checkBox5.Text = "Fırın Güveç 22₺";
            checkBox6.Text = "Kuru Fasulye 12₺";
            checkBox7.Text = "Tereyağlı Pilav 6₺";
            checkBox8.Text = "Biber Dolması 15₺";
            checkBox9.Text = "Fırın Sütlaç 8₺";
            checkBox10.Text = "Künefe 12₺";
            checkBox11.Text = "Kemalpaşa 8₺";
            checkBox12.Text = "Baklava 12₺";
            checkBox13.Text = "Su 1₺";
            checkBox14.Text = "Ayran 3₺";
            checkBox15.Text = "Kola 4₺";
            checkBox16.Text = "Çay 2₺";
            button2.Text = "Siparişleri Kaydet";
            button3.Text = "Seçenekleri Temizle";
            button4.Text = "Siparişleri Onayla";
            button5.Text = "Siparişleri Temizle";
            button6.Text = "Haftanın Menüsü";
            button7.Text = "Seçilenleri Temizle";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            listBox1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            label6.Visible = true;
            button7.Visible = true;
            listBox1.Items.Clear();
            listBox1.Items.Add(comboBox1.Text);
            listBox1.Items.Add(" ");

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            checkBox14.Checked = false;
            checkBox15.Checked = false;
            checkBox16.Checked = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Yemek domatesCorbasi = new Corba();
                domatesCorbasi.domates();
            }
            if (checkBox2.Checked == true)
            {
                Yemek mercimekCorbasi = new Corba();
                mercimekCorbasi.mercimek();
            }
            if (checkBox3.Checked == true)
            {
                Yemek tarhanaCorbasi = new Corba();
                tarhanaCorbasi.tarhana();
            }
            if (checkBox4.Checked == true)
            {
                Yemek ezogelinCorbasi = new Corba();
                ezogelinCorbasi.ezogelin();
            }
            if (checkBox5.Checked == true)
            {
                Yemek firinGuvec = new Yemekcesitleri();
                firinGuvec.guvec();
            }
            if (checkBox6.Checked == true)
            {
                Yemek kuruFasulye = new Yemekcesitleri();
                kuruFasulye.kuruFasulye();
            }
            if (checkBox7.Checked == true)
            {
                Yemek pilav = new Yemekcesitleri();
                pilav.pilav();
            }
            if (checkBox8.Checked == true)
            {
                Yemek biberDolmasi = new Yemekcesitleri();
                biberDolmasi.biberDolmasi();
            }
            if (checkBox9.Checked == true)
            {
                Yemek firinSutlac = new Tatlicesitleri();
                firinSutlac.sutlac();
            }
            if (checkBox10.Checked == true)
            {
                Yemek kunefe = new Tatlicesitleri();
                kunefe.kunefe();
            }
            if (checkBox11.Checked == true)
            {
                Yemek kemalpasa = new Tatlicesitleri();
                kemalpasa.kemalpasa();
            }
            if (checkBox12.Checked == true)
            {
                Yemek baklava = new Tatlicesitleri();
                baklava.baklava();
            }
            if (checkBox13.Checked == true)
            {
                Yemek su = new Mesrubat();
                su.su();
            }
            if (checkBox14.Checked == true)
            {
                Yemek ayran = new Mesrubat();
                ayran.ayran();
            }
            if (checkBox15.Checked == true)
            {
                Yemek kola = new Mesrubat();
                kola.kola();
            }
            if (checkBox16.Checked == true)
            {
                Yemek cay = new Mesrubat();
                cay.cay();
            }
            //--------------------------------------
            if (checkBox1.Checked == true)
            {
                listBox1.Items.Add(checkBox1.Text);
            }
            if (checkBox2.Checked == true)
            {
                listBox1.Items.Add(checkBox2.Text);
            }
            if (checkBox3.Checked == true)
            {
                listBox1.Items.Add(checkBox3.Text);
            }
            if (checkBox4.Checked == true)
            {
                listBox1.Items.Add(checkBox4.Text);
            }
            if (checkBox5.Checked == true)
            {
                listBox1.Items.Add(checkBox5.Text);
            }
            if (checkBox6.Checked == true)
            {
                listBox1.Items.Add(checkBox6.Text);
            }
            if (checkBox7.Checked == true)
            {
                listBox1.Items.Add(checkBox7.Text);
            }
            if (checkBox8.Checked == true)
            {
                listBox1.Items.Add(checkBox8.Text);
            }
            if (checkBox9.Checked == true)
            {
                listBox1.Items.Add(checkBox9.Text);
            }
            if (checkBox10.Checked == true)
            {
                listBox1.Items.Add(checkBox10.Text);
            }
            if (checkBox11.Checked == true)
            {
                listBox1.Items.Add(checkBox11.Text);
            }
            if (checkBox12.Checked == true)
            {
                listBox1.Items.Add(checkBox12.Text);
            }
            if (checkBox13.Checked == true)
            {
                listBox1.Items.Add(checkBox13.Text);
            }
            if (checkBox14.Checked == true)
            {
                listBox1.Items.Add(checkBox14.Text);
            }
            if (checkBox15.Checked == true)
            {
                listBox1.Items.Add(checkBox15.Text);
            }
            if (checkBox16.Checked == true)
            {
                listBox1.Items.Add(checkBox16.Text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            checkBox14.Checked = false;
            checkBox15.Checked = false;
            checkBox16.Checked = false;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (Yemek.tutar == 0)
            {
                MessageBox.Show("Sipariş Vermediniz. Lütfen Sipariş Verin.");
            }
            else MessageBox.Show("       Siparişler Onaylanmıştır.\nÖdenmesi Gereken Tutar " + Yemek.tutar.ToString() + " TL'dir.");
            Yemek.tutar = 0;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            checkBox14.Checked = false;
            checkBox15.Checked = false;
            checkBox16.Checked = false;

            listBox1.Items.Clear();

            listBox1.Items.Add(comboBox1.Text);
            listBox1.Items.Add(" ");

            Yemek.tutar = 0;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (comboBox1.Text == "Masa 1")
            {
                listBox1.Items.Add(comboBox1.Text);
                listBox1.Items.Add(" ");
            }
            if (comboBox1.Text == "Masa 2")
            {
                listBox1.Items.Add(comboBox1.Text);
                listBox1.Items.Add(" ");
            }
            if (comboBox1.Text == "Masa 3")
            {
                listBox1.Items.Add(comboBox1.Text);
                listBox1.Items.Add(" ");
            }
            if (comboBox1.Text == "Masa 4")
            {
                listBox1.Items.Add(comboBox1.Text);
                listBox1.Items.Add(" ");
            }
            if (comboBox1.Text == "Masa 5")
            {
                listBox1.Items.Add(comboBox1.Text);
                listBox1.Items.Add(" ");
            }
            if (comboBox1.Text == "Masa 6")
            {
                listBox1.Items.Add(comboBox1.Text);
                listBox1.Items.Add(" ");
            }

            Yemek.tutar = 0;

            checkBox1.Checked = true;
            checkBox5.Checked = true;
            checkBox10.Checked = true;
            checkBox16.Checked = true;

            Yemek domatesCorbasi2 = new Corba();
            domatesCorbasi2.domates();
            listBox1.Items.Add(checkBox1.Text);

            Yemek firinGuvec2 = new Yemekcesitleri();
            firinGuvec2.guvec();
            listBox1.Items.Add(checkBox5.Text);

            Yemek kunefe2 = new Tatlicesitleri();
            kunefe2.kunefe();
            listBox1.Items.Add(checkBox10.Text);

            Yemek cay2 = new Mesrubat();
            cay2.cay();
            listBox1.Items.Add(checkBox16.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int secim = listBox1.SelectedIndex;
            if (secim != -1)
            {
                for (int i = listBox1.SelectedItems.Count - 1; i >= 0; i--)
                {
                    if (listBox1.SelectedItems[i].ToString() == "Domates Çorbası 10₺")
                    {
                        Yemek.tutar -= 10;
                        checkBox1.Checked = false;
                    }
                    if (listBox1.SelectedItems[i].ToString() == "Mercimek Çorbası 6₺")
                    {
                        Yemek.tutar -= 6;
                        checkBox2.Checked = false;
                    }
                    if (listBox1.SelectedItems[i].ToString() == "Tarhana Çorbası 15₺")
                    {
                        Yemek.tutar -= 15;
                        checkBox3.Checked = false;
                    }
                    if (listBox1.SelectedItems[i].ToString() == "Ezogelin Çorbası 8₺")
                    {
                        Yemek.tutar -= 8;
                        checkBox4.Checked = false;
                    }
                    if (listBox1.SelectedItems[i].ToString() == "Fırın Güveç 22₺")
                    {
                        Yemek.tutar -= 22;
                        checkBox5.Checked = false;
                    }
                    if (listBox1.SelectedItems[i].ToString() == "Kuru Fasulye 12₺")
                    {
                        Yemek.tutar -= 12;
                        checkBox6.Checked = false;
                    }
                    if (listBox1.SelectedItems[i].ToString() == "Tereyağlı Pilav 6₺")
                    {
                        Yemek.tutar -= 6;
                        checkBox7.Checked = false;
                    }
                    if (listBox1.SelectedItems[i].ToString() == "Biber Dolması 15₺")
                    {
                        Yemek.tutar -= 15;
                        checkBox8.Checked = false;
                    }
                    if (listBox1.SelectedItems[i].ToString() == "Fırın Sütlaç 8₺")
                    {
                        Yemek.tutar -= 8;
                        checkBox9.Checked = false;
                    }
                    if (listBox1.SelectedItems[i].ToString() == "Künefe 12₺")
                    {
                        Yemek.tutar -= 12;
                        checkBox10.Checked = false;
                    }
                    if (listBox1.SelectedItems[i].ToString() == "Kemalpaşa 8₺")
                    {
                        Yemek.tutar -= 8;
                        checkBox11.Checked = false;
                    }
                    if (listBox1.SelectedItems[i].ToString() == "Baklava 12₺")
                    {
                        Yemek.tutar -= 12;
                        checkBox12.Checked = false;
                    }
                    if (listBox1.SelectedItems[i].ToString() == "Su 1₺")
                    {
                        Yemek.tutar -= 1;
                        checkBox13.Checked = false;
                    }
                    if (listBox1.SelectedItems[i].ToString() == "Ayran 3₺")
                    {
                        Yemek.tutar -= 3;
                        checkBox14.Checked = false;
                    }
                    if (listBox1.SelectedItems[i].ToString() == "Kola 4₺")
                    {
                        Yemek.tutar -= 4;
                        checkBox15.Checked = false;
                    }
                    if (listBox1.SelectedItems[i].ToString() == "Çay 2₺")
                    {
                        Yemek.tutar -= 2;
                        checkBox16.Checked = false;
                    }

                    listBox1.Items.Remove(listBox1.SelectedItems[i]);
                }
            }
        }
        
        private void button8_Click(object sender, EventArgs e)
        {
            form1 form1sec = new form1();
            form1sec.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

