using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lokanta_Otomasyonu
{
    public class Mesrubat:Yemek
    {
        public override void su()
        {
            Yemek suFiyat = new Yemek(1);            
        }
        public override void ayran()
        {
            Yemek ayranFiyat = new Yemek(3);            
        }
        public override void kola()
        {
            Yemek kolaFiyat = new Yemek(4);            
        }
        public override void cay()
        {
            Yemek cayFiyat = new Yemek(2);            
        }
    }
}
