namespace MarketOtomasyonu
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgw_UrunListesi = new System.Windows.Forms.DataGridView();
            this.labelAd = new System.Windows.Forms.Label();
            this.labelKod = new System.Windows.Forms.Label();
            this.labeTur = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_UrunAdi = new System.Windows.Forms.TextBox();
            this.txt_urunkodu = new System.Windows.Forms.TextBox();
            this.txt_BoxSatisFiyati = new System.Windows.Forms.TextBox();
            this.labelGelisFiyat = new System.Windows.Forms.Label();
            this.txt_BoxGelisFiyati = new System.Windows.Forms.TextBox();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.comboBoxUrunTuru = new System.Windows.Forms.ComboBox();
            this.txt_BoxSTT = new System.Windows.Forms.TextBox();
            this.labelSTT = new System.Windows.Forms.Label();
            this.txt_UrunNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_UrunArama = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_UrunListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgw_UrunListesi
            // 
            this.dgw_UrunListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgw_UrunListesi.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgw_UrunListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_UrunListesi.Location = new System.Drawing.Point(28, 12);
            this.dgw_UrunListesi.Name = "dgw_UrunListesi";
            this.dgw_UrunListesi.RowHeadersWidth = 51;
            this.dgw_UrunListesi.RowTemplate.Height = 24;
            this.dgw_UrunListesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgw_UrunListesi.Size = new System.Drawing.Size(1073, 245);
            this.dgw_UrunListesi.TabIndex = 0;
            this.dgw_UrunListesi.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_UrunListesi_CellEnter);
            // 
            // labelAd
            // 
            this.labelAd.AutoSize = true;
            this.labelAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAd.Location = new System.Drawing.Point(12, 294);
            this.labelAd.Name = "labelAd";
            this.labelAd.Size = new System.Drawing.Size(64, 18);
            this.labelAd.TabIndex = 1;
            this.labelAd.Text = "Ürün Adı";
            // 
            // labelKod
            // 
            this.labelKod.AutoSize = true;
            this.labelKod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKod.Location = new System.Drawing.Point(12, 360);
            this.labelKod.Name = "labelKod";
            this.labelKod.Size = new System.Drawing.Size(79, 18);
            this.labelKod.TabIndex = 2;
            this.labelKod.Text = "Ürün Kodu";
            // 
            // labeTur
            // 
            this.labeTur.AutoSize = true;
            this.labeTur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labeTur.Location = new System.Drawing.Point(12, 399);
            this.labeTur.Name = "labeTur";
            this.labeTur.Size = new System.Drawing.Size(74, 18);
            this.labeTur.TabIndex = 3;
            this.labeTur.Text = "Ürün Türü";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 429);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ürün Satış Fiyatı";
            // 
            // txt_UrunAdi
            // 
            this.txt_UrunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_UrunAdi.Location = new System.Drawing.Point(117, 288);
            this.txt_UrunAdi.Name = "txt_UrunAdi";
            this.txt_UrunAdi.Size = new System.Drawing.Size(307, 24);
            this.txt_UrunAdi.TabIndex = 5;
            // 
            // txt_urunkodu
            // 
            this.txt_urunkodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_urunkodu.Location = new System.Drawing.Point(117, 354);
            this.txt_urunkodu.Name = "txt_urunkodu";
            this.txt_urunkodu.Size = new System.Drawing.Size(307, 24);
            this.txt_urunkodu.TabIndex = 6;
            // 
            // txt_BoxSatisFiyati
            // 
            this.txt_BoxSatisFiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_BoxSatisFiyati.Location = new System.Drawing.Point(143, 423);
            this.txt_BoxSatisFiyati.Name = "txt_BoxSatisFiyati";
            this.txt_BoxSatisFiyati.Size = new System.Drawing.Size(307, 24);
            this.txt_BoxSatisFiyati.TabIndex = 8;
            // 
            // labelGelisFiyat
            // 
            this.labelGelisFiyat.AutoSize = true;
            this.labelGelisFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelGelisFiyat.Location = new System.Drawing.Point(12, 466);
            this.labelGelisFiyat.Name = "labelGelisFiyat";
            this.labelGelisFiyat.Size = new System.Drawing.Size(132, 18);
            this.labelGelisFiyat.TabIndex = 11;
            this.labelGelisFiyat.Text = "Ürünün Geliş Fiyatı";
            this.labelGelisFiyat.UseWaitCursor = true;
            // 
            // txt_BoxGelisFiyati
            // 
            this.txt_BoxGelisFiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_BoxGelisFiyati.Location = new System.Drawing.Point(162, 460);
            this.txt_BoxGelisFiyati.Name = "txt_BoxGelisFiyati";
            this.txt_BoxGelisFiyati.Size = new System.Drawing.Size(288, 24);
            this.txt_BoxGelisFiyati.TabIndex = 12;
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(491, 365);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(163, 82);
            this.btn_ekle.TabIndex = 13;
            this.btn_ekle.Text = "EKLE";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(687, 365);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(166, 82);
            this.btn_sil.TabIndex = 14;
            this.btn_sil.Text = "SİL";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(890, 365);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(164, 82);
            this.btn_guncelle.TabIndex = 15;
            this.btn_guncelle.Text = "GÜNCELLE";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // comboBoxUrunTuru
            // 
            this.comboBoxUrunTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxUrunTuru.FormattingEnabled = true;
            this.comboBoxUrunTuru.Items.AddRange(new object[] {
            "Temel İhityaç",
            "Tekel"});
            this.comboBoxUrunTuru.Location = new System.Drawing.Point(117, 391);
            this.comboBoxUrunTuru.Name = "comboBoxUrunTuru";
            this.comboBoxUrunTuru.Size = new System.Drawing.Size(307, 26);
            this.comboBoxUrunTuru.TabIndex = 19;
            // 
            // txt_BoxSTT
            // 
            this.txt_BoxSTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_BoxSTT.Location = new System.Drawing.Point(222, 490);
            this.txt_BoxSTT.Name = "txt_BoxSTT";
            this.txt_BoxSTT.Size = new System.Drawing.Size(258, 24);
            this.txt_BoxSTT.TabIndex = 20;
            // 
            // labelSTT
            // 
            this.labelSTT.AutoSize = true;
            this.labelSTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSTT.Location = new System.Drawing.Point(12, 496);
            this.labelSTT.Name = "labelSTT";
            this.labelSTT.Size = new System.Drawing.Size(184, 18);
            this.labelSTT.TabIndex = 21;
            this.labelSTT.Text = "Ürünün Son Tüketim Tarihi";
            this.labelSTT.UseWaitCursor = true;
            // 
            // txt_UrunNo
            // 
            this.txt_UrunNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_UrunNo.Location = new System.Drawing.Point(117, 319);
            this.txt_UrunNo.Name = "txt_UrunNo";
            this.txt_UrunNo.Size = new System.Drawing.Size(307, 24);
            this.txt_UrunNo.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 23;
            this.label1.Text = "Ürün No";
            this.label1.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 18);
            this.label3.TabIndex = 25;
            this.label3.Text = "İsme Göre ARA";
            // 
            // txt_UrunArama
            // 
            this.txt_UrunArama.Location = new System.Drawing.Point(134, 263);
            this.txt_UrunArama.Name = "txt_UrunArama";
            this.txt_UrunArama.Size = new System.Drawing.Size(290, 22);
            this.txt_UrunArama.TabIndex = 26;
            this.txt_UrunArama.TextChanged += new System.EventHandler(this.txt_UrunArama_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1113, 541);
            this.Controls.Add(this.txt_UrunArama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_UrunNo);
            this.Controls.Add(this.labelSTT);
            this.Controls.Add(this.txt_BoxSTT);
            this.Controls.Add(this.comboBoxUrunTuru);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.txt_BoxGelisFiyati);
            this.Controls.Add(this.labelGelisFiyat);
            this.Controls.Add(this.txt_BoxSatisFiyati);
            this.Controls.Add(this.txt_urunkodu);
            this.Controls.Add(this.txt_UrunAdi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labeTur);
            this.Controls.Add(this.labelKod);
            this.Controls.Add(this.labelAd);
            this.Controls.Add(this.dgw_UrunListesi);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Market Otomasyonu";
            this.TransparencyKey = System.Drawing.Color.Gray;
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_UrunListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw_UrunListesi;
        private System.Windows.Forms.Label labelAd;
        private System.Windows.Forms.Label labelKod;
        private System.Windows.Forms.Label labeTur;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_UrunAdi;
        private System.Windows.Forms.TextBox txt_urunkodu;
        private System.Windows.Forms.TextBox txt_BoxSatisFiyati;
        private System.Windows.Forms.Label labelGelisFiyat;
        private System.Windows.Forms.TextBox txt_BoxGelisFiyati;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.ComboBox comboBoxUrunTuru;
        private System.Windows.Forms.TextBox txt_BoxSTT;
        private System.Windows.Forms.Label labelSTT;
        private System.Windows.Forms.TextBox txt_UrunNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_UrunArama;
    }
}

