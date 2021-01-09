/****************************************************************************
**					          SAKARYA ÜNİVERSİTESİ
**				     BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				           BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				          NESNEYE DAYALI PROGRAMLAMA DERSİ
**					          2018-2019 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: 3
**				ÖĞRENCİ ADI............: BÜNYAMİN ŞANLI
**				ÖĞRENCİ NUMARASI.......: B181210040
**                         DERSİN ALINDIĞI GRUP...: 1B
****************************************************************************/




using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje
{
    public partial class Form1 : Form
    {
        inek inek = new inek();
        tavuk tavuk = new tavuk();
        ordek ordek = new ordek();
        keci keci = new keci();



        private int saniye; //TİMER'IN HER SANİYEDE ARTTIRMASI İÇİN PRİVATE BİR DEĞİŞKEN TANIMLARIZ
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000; //TİMER'IN KAÇ MİLİSANİYEDE BİR ARTACAĞINI BELİRLER
            int sayac = saniye++;  //TİMER HER BİR SANİYEDE SANİYE DEĞİŞKENİNİ ARTTIRIR VE SANİYE DEĞERİ SAYACA EŞİTLENİR
            labelSure.Text = Convert.ToString(sayac + "  SN"); //SAYAÇ DEĞERİNİ LABEL'A ATAR


            inek.sure = sayac;
            inek.enerji = progressBarI.Value;
            inek.Can();
            labelDurumI.Text = inek.durum; //hayvanın ölü yada canlı olduğunu gösteren label
            progressBarI.Value = inek.enerji;
            inek.UrunOlustur();
            labelISutu.Text = Convert.ToString(inek.urun + "  L");


            tavuk.sure = sayac;
            tavuk.enerji = progressBarT.Value;
            tavuk.Can();
            labelTDurum.Text = tavuk.durum; //hayvanın ölü yada canlı olduğunu gösteren label
            progressBarT.Value = tavuk.enerji;
            tavuk.UrunOlustur();
            labelTYumurtasi.Text = Convert.ToString(tavuk.urun + "  ADET");


            ordek.sure = sayac;
            ordek.enerji = progressBarO.Value;
            ordek.Can();
            labelODurum.Text = ordek.durum; //hayvanın ölü yada canlı olduğunu gösteren label
            progressBarO.Value = ordek.enerji;
            ordek.UrunOlustur();
            labelOrdek.Text = Convert.ToString(ordek.urun + "  ADET");


            keci.sure = sayac;
            keci.enerji = progressBarK.Value;
            keci.Can();
            labelKDurum.Text = keci.durum; //hayvanın ölü yada canlı olduğunu gösteren label
            progressBarK.Value = keci.enerji;
            keci.UrunOlustur();
            labelKeci.Text = Convert.ToString(keci.urun + "  L");








        }

        private void buttonInek_Click(object sender, EventArgs e) //inek sütü sat butonu
        {
            inek.UrunSat();
            labelKasa.Text = Convert.ToString(Convert.ToInt32(labelKasa.Text) + inek.para);
        }

        private void buttonYemver2_Click(object sender, EventArgs e) // inek yem verme butonu
        {
            inek.Yemle();
            progressBarI.Value = inek.enerji; //inek sınıfındaki enerji değişkeninin değerimi progressbara ata
        }

        private void buttonYemverKeci_Click(object sender, EventArgs e) // keçi yem verme butonu
        {
            keci.Yemle();
            progressBarK.Value = keci.enerji;
        }

        private void buttonYemverTavuk_Click(object sender, EventArgs e) 
        {
            tavuk.Yemle();
            progressBarT.Value = tavuk.enerji; // tavuk sınıfındaki enerji değişkeninin değerimi progressbara ata
        }

        private void buttonYemverOrdek_Click(object sender, EventArgs e) 
        {
            ordek.Yemle();
            progressBarO.Value = ordek.enerji; //ördek sınıfındaki enerji değişkeninin değerimi progressbara ata
        }

        private void buttonTavukSat_Click(object sender, EventArgs e) //tavuk yumurtası sat butonu 
        {
            tavuk.UrunSat();
            labelKasa.Text = Convert.ToString(Convert.ToInt32(labelKasa.Text) + tavuk.para);
        }

        private void buttonOrdekSat_Click(object sender, EventArgs e) //ordek yumurtası sat butonu
        {
            ordek.UrunSat();
            labelKasa.Text = Convert.ToString(Convert.ToInt32(labelKasa.Text) + ordek.para);
        }

        private void buttonKeciSat_Click(object sender, EventArgs e) //keçi sütü sat butonu
        {
            keci.UrunSat();
            labelKasa.Text = Convert.ToString(Convert.ToInt32(labelKasa.Text) + keci.para); 
        }

        private void labelKasa_Click(object sender, EventArgs e)
        {

        }
    }
}
