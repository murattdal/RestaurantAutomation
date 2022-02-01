using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lokanta_Otomasyonu
{
    public interface yemekMalzeme
    {
        void karsilama();
        //-------------------
        void domates();
        void mercimek();
        void tarhana();
        void ezogelin();
        //-------------------
        void guvec();
        void kuruFasulye();
        void pilav();
        void biberDolmasi();
        //--------------------
        void sutlac();
        void kunefe();
        void kemalpasa();
        void baklava();
        //--------------------
        void su();
        void ayran();
        void kola();
        void cay();
    }
}
