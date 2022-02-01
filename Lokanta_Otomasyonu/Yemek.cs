using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lokanta_Otomasyonu
{
    public class Yemek : Tutar , yemekMalzeme
    {       
        public Yemek():this(0){}
        public Yemek(int dutar)
        {
            tutar += dutar;
        }
        public void karsilama()
        {
            MessageBox.Show("                           Personel girişi başarılı\nLütfen masa numarasını seçip menüden sipariş veriniz.");
        }
        public virtual void domates() { }
        public virtual void mercimek() { }
        public virtual void tarhana() { }
        public virtual void ezogelin() { }
        //-------------------------------------
        public virtual void guvec() { }
        public virtual void kuruFasulye() { }
        public virtual void pilav() { }
        public virtual void biberDolmasi() { }
        //--------------------------------------
        public virtual void sutlac() { }
        public virtual void kunefe() { }
        public virtual void kemalpasa() { }
        public virtual void baklava() { }
        //--------------------------------------
        public virtual void su() { }
        public virtual void ayran() { }
        public virtual void kola() { }
        public virtual void cay() { }

        public sealed override void tutarHesapla()
        {
            MessageBox.Show(tutar.ToString());
        }
    }
}

