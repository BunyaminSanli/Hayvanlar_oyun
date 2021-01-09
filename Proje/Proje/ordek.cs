using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;
using System.Drawing;
using System.Data;
using System.ComponentModel;
using System.IO;

namespace Proje
{
    class ordek:Hayvan
    {
        int a = 0;

        void Sescal()
        {

            SoundPlayer sescal = new SoundPlayer();
            string path = Application.StartupPath.ToString() + "\\ordek.wav";
            sescal.SoundLocation = path;
            sescal.Play();
        }
        
            
       


        public override void Can()
        {

            if (enerji>=3)
            {
                enerji = enerji - 3;
            }
            else
            {
                enerji = 0;
                durum = "ÖLDÜ";
            }
            if(enerji==0 && a==0)
            {
                Sescal();

                a = 1; // sürekli çalmaması için 1' e eşitle

            }
        }
       
        public override void UrunOlustur()
        {
            if(sure%5 ==0 && sure/5!=0 && enerji!=0)
            {
                urun = urun + 1;

            }
        }
        public override void UrunSat()
        {
            para = urun * 3;
            urun = 0;
        }
        public override void Yemle()
        {
            if (enerji != 0)
            {
                enerji = 100;
            }
        }
    }
}
