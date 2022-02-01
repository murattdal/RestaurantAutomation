using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lokanta_Otomasyonu
{
    public class Tatlicesitleri:Yemek
    {
        public override void sutlac()
        {
            Yemek sutlacFiyat = new Yemek(8);            
        }
        public override void kunefe()
        {
            Yemek kunefeFiyat = new Yemek(12);            
        }
        public override void kemalpasa()
        {
            Yemek kemalpasaFiyat = new Yemek(8);            
        }
        public override void baklava()
        {
            Yemek baklavaFiyat = new Yemek(12);            
        }
    }
}
