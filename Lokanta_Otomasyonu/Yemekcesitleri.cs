using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lokanta_Otomasyonu
{
    public class Yemekcesitleri:Yemek
    {
        public override void guvec()
        {
            Yemek guvecFiyat = new Yemek(22);
        }
        public override void kuruFasulye()
        {
            Yemek fasulyeFiyat = new Yemek(12);
        }
        public override void pilav()
        {
            Yemek pilavFiyat = new Yemek(6);
        }
        public override void biberDolmasi()
        {
            Yemek dolmaFiyat = new Yemek(15);
        }
    }
}
