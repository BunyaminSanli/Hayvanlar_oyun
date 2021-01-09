using System;

namespace Proje
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.urunDeposu = new System.Windows.Forms.Panel();
            this.labelKeci = new System.Windows.Forms.Label();
            this.labelOrdek = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelISutu = new System.Windows.Forms.Label();
            this.labelTYumurtasi = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.urunLabel = new System.Windows.Forms.Label();
            this.panelKontrol = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelKasa = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelSure = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonKeciSat = new System.Windows.Forms.Button();
            this.buttonInekSat = new System.Windows.Forms.Button();
            this.buttonOrdekSat = new System.Windows.Forms.Button();
            this.buttonTavukSat = new System.Windows.Forms.Button();
            this.labelGida = new System.Windows.Forms.Label();
            this.panelHayvan = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.buttonYemverKeci = new System.Windows.Forms.Button();
            this.progressBarK = new System.Windows.Forms.ProgressBar();
            this.labelKDurum = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.buttonYemverInek = new System.Windows.Forms.Button();
            this.progressBarI = new System.Windows.Forms.ProgressBar();
            this.labelDurumI = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.labelAhir = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonYemverOrdek = new System.Windows.Forms.Button();
            this.progressBarO = new System.Windows.Forms.ProgressBar();
            this.labelODurum = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonYemverTavuk = new System.Windows.Forms.Button();
            this.progressBarT = new System.Windows.Forms.ProgressBar();
            this.labelTDurum = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelKumes = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.urunDeposu.SuspendLayout();
            this.panelKontrol.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelHayvan.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // urunDeposu
            // 
            this.urunDeposu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.urunDeposu.Controls.Add(this.labelKeci);
            this.urunDeposu.Controls.Add(this.labelOrdek);
            this.urunDeposu.Controls.Add(this.label5);
            this.urunDeposu.Controls.Add(this.label6);
            this.urunDeposu.Controls.Add(this.labelISutu);
            this.urunDeposu.Controls.Add(this.labelTYumurtasi);
            this.urunDeposu.Controls.Add(this.label8);
            this.urunDeposu.Controls.Add(this.label7);
            this.urunDeposu.Controls.Add(this.urunLabel);
            this.urunDeposu.Location = new System.Drawing.Point(12, 12);
            this.urunDeposu.Name = "urunDeposu";
            this.urunDeposu.Size = new System.Drawing.Size(368, 233);
            this.urunDeposu.TabIndex = 0;
            // 
            // labelKeci
            // 
            this.labelKeci.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelKeci.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKeci.ForeColor = System.Drawing.Color.Red;
            this.labelKeci.Location = new System.Drawing.Point(186, 173);
            this.labelKeci.Name = "labelKeci";
            this.labelKeci.Size = new System.Drawing.Size(179, 48);
            this.labelKeci.TabIndex = 9;
            this.labelKeci.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelOrdek
            // 
            this.labelOrdek.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelOrdek.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelOrdek.ForeColor = System.Drawing.Color.Red;
            this.labelOrdek.Location = new System.Drawing.Point(4, 173);
            this.labelOrdek.Name = "labelOrdek";
            this.labelOrdek.Size = new System.Drawing.Size(176, 48);
            this.labelOrdek.TabIndex = 8;
            this.labelOrdek.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(187, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "KEÇİ SÜTÜ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(5, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "ÖRDEK YUMURTASI";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelISutu
            // 
            this.labelISutu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelISutu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelISutu.ForeColor = System.Drawing.Color.Red;
            this.labelISutu.Location = new System.Drawing.Point(185, 79);
            this.labelISutu.Name = "labelISutu";
            this.labelISutu.Size = new System.Drawing.Size(179, 48);
            this.labelISutu.TabIndex = 5;
            this.labelISutu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTYumurtasi
            // 
            this.labelTYumurtasi.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelTYumurtasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTYumurtasi.ForeColor = System.Drawing.Color.Red;
            this.labelTYumurtasi.Location = new System.Drawing.Point(3, 79);
            this.labelTYumurtasi.Name = "labelTYumurtasi";
            this.labelTYumurtasi.Size = new System.Drawing.Size(176, 48);
            this.labelTYumurtasi.TabIndex = 3;
            this.labelTYumurtasi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(186, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 23);
            this.label8.TabIndex = 2;
            this.label8.Text = "İNEK SÜTÜ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(4, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 23);
            this.label7.TabIndex = 1;
            this.label7.Text = "TAVUK YUMURTASI";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // urunLabel
            // 
            this.urunLabel.BackColor = System.Drawing.Color.Tomato;
            this.urunLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.urunLabel.Location = new System.Drawing.Point(3, 10);
            this.urunLabel.Name = "urunLabel";
            this.urunLabel.Size = new System.Drawing.Size(361, 23);
            this.urunLabel.TabIndex = 0;
            this.urunLabel.Text = "ÜRÜN DEPOSU";
            this.urunLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelKontrol
            // 
            this.panelKontrol.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelKontrol.Controls.Add(this.panel4);
            this.panelKontrol.Controls.Add(this.panel3);
            this.panelKontrol.Controls.Add(this.panel2);
            this.panelKontrol.Location = new System.Drawing.Point(394, 12);
            this.panelKontrol.Name = "panelKontrol";
            this.panelKontrol.Size = new System.Drawing.Size(394, 233);
            this.panelKontrol.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel4.Controls.Add(this.labelKasa);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(222, 128);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(160, 91);
            this.panel4.TabIndex = 2;
            // 
            // labelKasa
            // 
            this.labelKasa.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelKasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKasa.ForeColor = System.Drawing.Color.Red;
            this.labelKasa.Location = new System.Drawing.Point(7, 45);
            this.labelKasa.Name = "labelKasa";
            this.labelKasa.Size = new System.Drawing.Size(147, 38);
            this.labelKasa.TabIndex = 16;
            this.labelKasa.Text = "0";
            this.labelKasa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelKasa.Click += new System.EventHandler(this.labelKasa_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Tomato;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(8, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 23);
            this.label4.TabIndex = 16;
            this.label4.Text = "KASA";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel3.Controls.Add(this.labelSure);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(221, 14);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(162, 96);
            this.panel3.TabIndex = 1;
            // 
            // labelSure
            // 
            this.labelSure.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSure.ForeColor = System.Drawing.Color.Red;
            this.labelSure.Location = new System.Drawing.Point(9, 44);
            this.labelSure.Name = "labelSure";
            this.labelSure.Size = new System.Drawing.Size(146, 42);
            this.labelSure.TabIndex = 10;
            this.labelSure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Tomato;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(9, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "GEÇEN SÜRE";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Controls.Add(this.buttonKeciSat);
            this.panel2.Controls.Add(this.buttonInekSat);
            this.panel2.Controls.Add(this.buttonOrdekSat);
            this.panel2.Controls.Add(this.buttonTavukSat);
            this.panel2.Controls.Add(this.labelGida);
            this.panel2.Location = new System.Drawing.Point(15, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(184, 207);
            this.panel2.TabIndex = 0;
            // 
            // buttonKeciSat
            // 
            this.buttonKeciSat.BackColor = System.Drawing.Color.Honeydew;
            this.buttonKeciSat.ForeColor = System.Drawing.Color.Red;
            this.buttonKeciSat.Location = new System.Drawing.Point(15, 163);
            this.buttonKeciSat.Name = "buttonKeciSat";
            this.buttonKeciSat.Size = new System.Drawing.Size(154, 23);
            this.buttonKeciSat.TabIndex = 14;
            this.buttonKeciSat.Text = "KEÇİ SÜTÜ SAT";
            this.buttonKeciSat.UseVisualStyleBackColor = false;
            this.buttonKeciSat.Click += new System.EventHandler(this.buttonKeciSat_Click);
            // 
            // buttonInekSat
            // 
            this.buttonInekSat.BackColor = System.Drawing.Color.Honeydew;
            this.buttonInekSat.ForeColor = System.Drawing.Color.Red;
            this.buttonInekSat.Location = new System.Drawing.Point(15, 127);
            this.buttonInekSat.Name = "buttonInekSat";
            this.buttonInekSat.Size = new System.Drawing.Size(154, 23);
            this.buttonInekSat.TabIndex = 13;
            this.buttonInekSat.Text = "İNEK SÜTÜ SAT";
            this.buttonInekSat.UseVisualStyleBackColor = false;
            this.buttonInekSat.Click += new System.EventHandler(this.buttonInek_Click);
            // 
            // buttonOrdekSat
            // 
            this.buttonOrdekSat.BackColor = System.Drawing.Color.Honeydew;
            this.buttonOrdekSat.ForeColor = System.Drawing.Color.Red;
            this.buttonOrdekSat.Location = new System.Drawing.Point(15, 89);
            this.buttonOrdekSat.Name = "buttonOrdekSat";
            this.buttonOrdekSat.Size = new System.Drawing.Size(154, 23);
            this.buttonOrdekSat.TabIndex = 12;
            this.buttonOrdekSat.Text = "ÖRDEK YUMURTASI SAT";
            this.buttonOrdekSat.UseVisualStyleBackColor = false;
            this.buttonOrdekSat.Click += new System.EventHandler(this.buttonOrdekSat_Click);
            // 
            // buttonTavukSat
            // 
            this.buttonTavukSat.BackColor = System.Drawing.Color.Honeydew;
            this.buttonTavukSat.ForeColor = System.Drawing.Color.Red;
            this.buttonTavukSat.Location = new System.Drawing.Point(15, 48);
            this.buttonTavukSat.Name = "buttonTavukSat";
            this.buttonTavukSat.Size = new System.Drawing.Size(154, 23);
            this.buttonTavukSat.TabIndex = 11;
            this.buttonTavukSat.Text = "TAVUK YUMURTASI SAT";
            this.buttonTavukSat.UseVisualStyleBackColor = false;
            this.buttonTavukSat.Click += new System.EventHandler(this.buttonTavukSat_Click);
            // 
            // labelGida
            // 
            this.labelGida.BackColor = System.Drawing.Color.Tomato;
            this.labelGida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelGida.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelGida.Location = new System.Drawing.Point(15, 12);
            this.labelGida.Name = "labelGida";
            this.labelGida.Size = new System.Drawing.Size(154, 23);
            this.labelGida.TabIndex = 10;
            this.labelGida.Text = "GIDA FABRİKASI";
            this.labelGida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelHayvan
            // 
            this.panelHayvan.BackColor = System.Drawing.Color.Sienna;
            this.panelHayvan.Controls.Add(this.panel5);
            this.panelHayvan.Controls.Add(this.panel1);
            this.panelHayvan.Location = new System.Drawing.Point(12, 269);
            this.panelHayvan.Name = "panelHayvan";
            this.panelHayvan.Size = new System.Drawing.Size(775, 270);
            this.panelHayvan.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel5.Controls.Add(this.buttonYemverKeci);
            this.panel5.Controls.Add(this.progressBarK);
            this.panel5.Controls.Add(this.labelKDurum);
            this.panel5.Controls.Add(this.pictureBox3);
            this.panel5.Controls.Add(this.buttonYemverInek);
            this.panel5.Controls.Add(this.progressBarI);
            this.panel5.Controls.Add(this.labelDurumI);
            this.panel5.Controls.Add(this.pictureBox4);
            this.panel5.Controls.Add(this.labelAhir);
            this.panel5.Location = new System.Drawing.Point(394, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(371, 248);
            this.panel5.TabIndex = 1;
            // 
            // buttonYemverKeci
            // 
            this.buttonYemverKeci.Location = new System.Drawing.Point(129, 200);
            this.buttonYemverKeci.Name = "buttonYemverKeci";
            this.buttonYemverKeci.Size = new System.Drawing.Size(231, 26);
            this.buttonYemverKeci.TabIndex = 16;
            this.buttonYemverKeci.Text = "YEM VER";
            this.buttonYemverKeci.UseVisualStyleBackColor = true;
            this.buttonYemverKeci.Click += new System.EventHandler(this.buttonYemverKeci_Click);
            // 
            // progressBarK
            // 
            this.progressBarK.Location = new System.Drawing.Point(129, 174);
            this.progressBarK.Name = "progressBarK";
            this.progressBarK.Size = new System.Drawing.Size(231, 16);
            this.progressBarK.TabIndex = 15;
            this.progressBarK.Value = 100;
            // 
            // labelKDurum
            // 
            this.labelKDurum.BackColor = System.Drawing.SystemColors.Control;
            this.labelKDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKDurum.Location = new System.Drawing.Point(129, 146);
            this.labelKDurum.Name = "labelKDurum";
            this.labelKDurum.Size = new System.Drawing.Size(231, 18);
            this.labelKDurum.TabIndex = 14;
            this.labelKDurum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(17, 147);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(91, 81);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // buttonYemverInek
            // 
            this.buttonYemverInek.ForeColor = System.Drawing.Color.Black;
            this.buttonYemverInek.Location = new System.Drawing.Point(129, 101);
            this.buttonYemverInek.Name = "buttonYemverInek";
            this.buttonYemverInek.Size = new System.Drawing.Size(231, 26);
            this.buttonYemverInek.TabIndex = 12;
            this.buttonYemverInek.Text = "YEM VER";
            this.buttonYemverInek.UseVisualStyleBackColor = true;
            this.buttonYemverInek.Click += new System.EventHandler(this.buttonYemver2_Click);
            // 
            // progressBarI
            // 
            this.progressBarI.Location = new System.Drawing.Point(129, 75);
            this.progressBarI.Name = "progressBarI";
            this.progressBarI.Size = new System.Drawing.Size(231, 16);
            this.progressBarI.TabIndex = 11;
            this.progressBarI.Value = 100;
            // 
            // labelDurumI
            // 
            this.labelDurumI.BackColor = System.Drawing.SystemColors.Control;
            this.labelDurumI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelDurumI.Location = new System.Drawing.Point(129, 47);
            this.labelDurumI.Name = "labelDurumI";
            this.labelDurumI.Size = new System.Drawing.Size(231, 18);
            this.labelDurumI.TabIndex = 10;
            this.labelDurumI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(17, 48);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(91, 81);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // labelAhir
            // 
            this.labelAhir.BackColor = System.Drawing.Color.Tomato;
            this.labelAhir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAhir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelAhir.Location = new System.Drawing.Point(17, 10);
            this.labelAhir.Name = "labelAhir";
            this.labelAhir.Size = new System.Drawing.Size(343, 23);
            this.labelAhir.TabIndex = 1;
            this.labelAhir.Text = "AHIR";
            this.labelAhir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.buttonYemverOrdek);
            this.panel1.Controls.Add(this.progressBarO);
            this.panel1.Controls.Add(this.labelODurum);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.buttonYemverTavuk);
            this.panel1.Controls.Add(this.progressBarT);
            this.panel1.Controls.Add(this.labelTDurum);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.labelKumes);
            this.panel1.Location = new System.Drawing.Point(8, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 248);
            this.panel1.TabIndex = 0;
            // 
            // buttonYemverOrdek
            // 
            this.buttonYemverOrdek.Location = new System.Drawing.Point(129, 200);
            this.buttonYemverOrdek.Name = "buttonYemverOrdek";
            this.buttonYemverOrdek.Size = new System.Drawing.Size(231, 26);
            this.buttonYemverOrdek.TabIndex = 16;
            this.buttonYemverOrdek.Text = "YEM VER";
            this.buttonYemverOrdek.UseVisualStyleBackColor = true;
            this.buttonYemverOrdek.Click += new System.EventHandler(this.buttonYemverOrdek_Click);
            // 
            // progressBarO
            // 
            this.progressBarO.Location = new System.Drawing.Point(129, 174);
            this.progressBarO.Name = "progressBarO";
            this.progressBarO.Size = new System.Drawing.Size(231, 16);
            this.progressBarO.TabIndex = 15;
            this.progressBarO.Value = 100;
            // 
            // labelODurum
            // 
            this.labelODurum.BackColor = System.Drawing.SystemColors.Control;
            this.labelODurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelODurum.Location = new System.Drawing.Point(129, 146);
            this.labelODurum.Name = "labelODurum";
            this.labelODurum.Size = new System.Drawing.Size(231, 18);
            this.labelODurum.TabIndex = 14;
            this.labelODurum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(17, 147);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(91, 81);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // buttonYemverTavuk
            // 
            this.buttonYemverTavuk.ForeColor = System.Drawing.Color.Black;
            this.buttonYemverTavuk.Location = new System.Drawing.Point(129, 101);
            this.buttonYemverTavuk.Name = "buttonYemverTavuk";
            this.buttonYemverTavuk.Size = new System.Drawing.Size(231, 26);
            this.buttonYemverTavuk.TabIndex = 12;
            this.buttonYemverTavuk.Text = "YEM VER";
            this.buttonYemverTavuk.UseVisualStyleBackColor = true;
            this.buttonYemverTavuk.Click += new System.EventHandler(this.buttonYemverTavuk_Click);
            // 
            // progressBarT
            // 
            this.progressBarT.Location = new System.Drawing.Point(129, 75);
            this.progressBarT.Name = "progressBarT";
            this.progressBarT.Size = new System.Drawing.Size(231, 16);
            this.progressBarT.TabIndex = 11;
            this.progressBarT.Value = 100;
            // 
            // labelTDurum
            // 
            this.labelTDurum.BackColor = System.Drawing.SystemColors.Control;
            this.labelTDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTDurum.Location = new System.Drawing.Point(129, 47);
            this.labelTDurum.Name = "labelTDurum";
            this.labelTDurum.Size = new System.Drawing.Size(231, 18);
            this.labelTDurum.TabIndex = 10;
            this.labelTDurum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proje.Properties.Resources.tavuk;
            this.pictureBox1.Location = new System.Drawing.Point(17, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // labelKumes
            // 
            this.labelKumes.BackColor = System.Drawing.Color.Tomato;
            this.labelKumes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKumes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelKumes.Location = new System.Drawing.Point(17, 10);
            this.labelKumes.Name = "labelKumes";
            this.labelKumes.Size = new System.Drawing.Size(343, 23);
            this.labelKumes.TabIndex = 1;
            this.labelKumes.Text = "KÜMES";
            this.labelKumes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(801, 551);
            this.Controls.Add(this.panelHayvan);
            this.Controls.Add(this.panelKontrol);
            this.Controls.Add(this.urunDeposu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "ÇİFTLİK BANK";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.urunDeposu.ResumeLayout(false);
            this.panelKontrol.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelHayvan.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Panel urunDeposu;
        private System.Windows.Forms.Label labelKeci;
        private System.Windows.Forms.Label labelOrdek;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelISutu;
        private System.Windows.Forms.Label labelTYumurtasi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label urunLabel;
        private System.Windows.Forms.Panel panelKontrol;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelSure;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonKeciSat;
        private System.Windows.Forms.Button buttonInekSat;
        private System.Windows.Forms.Button buttonOrdekSat;
        private System.Windows.Forms.Button buttonTavukSat;
        private System.Windows.Forms.Label labelGida;
        private System.Windows.Forms.Label labelKasa;
        private System.Windows.Forms.Panel panelHayvan;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button buttonYemverKeci;
        private System.Windows.Forms.ProgressBar progressBarK;
        private System.Windows.Forms.Label labelKDurum;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button buttonYemverInek;
        private System.Windows.Forms.ProgressBar progressBarI;
        private System.Windows.Forms.Label labelDurumI;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label labelAhir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonYemverOrdek;
        private System.Windows.Forms.ProgressBar progressBarO;
        private System.Windows.Forms.Label labelODurum;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonYemverTavuk;
        private System.Windows.Forms.ProgressBar progressBarT;
        private System.Windows.Forms.Label labelTDurum;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelKumes;
        private System.Windows.Forms.Timer timer1;
    }
}

