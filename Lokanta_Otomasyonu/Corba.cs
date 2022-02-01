using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lokanta_Otomasyonu
{
    public class Corba:Yemek
    {
        public override void domates()
        {
            Yemek domatesFiyat = new Yemek(10);           
        }
        public override void mercimek()
        {
            Yemek mercimekFiyat = new Yemek(15);            
        }
        public override void tarhana()
        {
            Yemek tarhanaFiyat = new Yemek(6);            
        }
        public override void ezogelin()
        {
            Yemek ezogelinFiyat = new Yemek(8);            
        }
    }
}
