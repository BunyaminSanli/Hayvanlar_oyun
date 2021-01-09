using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;

namespace Proje
{
    class tavuk : Hayvan
    {
        int a = 0;
        void Sescal()
        {

            SoundPlayer sescal = new SoundPlayer();
            string path = Application.StartupPath.ToString() + "\\tavuk.wav";
            sescal.SoundLocation = path;
            sescal.Play();
        }
        public override void Can()
        {
           if(enerji>=2)
            {
                enerji = enerji - 2;
            }
            else
            {
                enerji = 0;
                durum = "ÖLDÜ";
            }
           if(enerji==0 && a==0)
            {
                Sescal();
                a = 1;
            }
        }
        public override void Yemle()
        {
            if(enerji!=0)
            {
                enerji = 100;
            }
        }
        public override void UrunOlustur()
        {
            if(sure%3 ==0 && sure/3!=0 && enerji!=0)
            {
                urun = urun + 1;
            }
        }
        public override void UrunSat()
        {
            para = urun;
            urun = 0;
        }
    }
}
