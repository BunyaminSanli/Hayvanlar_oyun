using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Proje
{
   abstract class Hayvan
    {
        
        public string durum = "CANLI";
        public int enerji;
        public int para;
        public int urun;
        public int sure = 0;


        public abstract void Can();
        public abstract void Yemle();
        public abstract void UrunOlustur();
        public abstract void UrunSat();

    }
}
