namespace YIlan_Macerası
{
    partial class OyunBaslangic
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OyunBaslangic));
            this.baslaButonu = new System.Windows.Forms.Button();
            this.yemEkrani = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.puanEkrani = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sifirlaButonu = new System.Windows.Forms.Button();
            this.oyunGeriButonu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.saniye = new System.Windows.Forms.Label();
            this.dakika = new System.Windows.Forms.Label();
            this.gecenSure = new System.Windows.Forms.Timer(this.components);
            this.hareketZamanlayici = new System.Windows.Forms.Timer(this.components);
            this.oyunSahnesi = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // baslaButonu
            // 
            this.baslaButonu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.baslaButonu.BackColor = System.Drawing.Color.MediumTurquoise;
            this.baslaButonu.Font = new System.Drawing.Font("Pristina", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.baslaButonu.ForeColor = System.Drawing.Color.White;
            this.baslaButonu.Location = new System.Drawing.Point(477, 625);
            this.baslaButonu.Name = "baslaButonu";
            this.baslaButonu.Size = new System.Drawing.Size(304, 44);
            this.baslaButonu.TabIndex = 8;
            this.baslaButonu.Text = "Basla";
            this.baslaButonu.UseVisualStyleBackColor = false;
            this.baslaButonu.Click += new System.EventHandler(this.baslaButonu_Click);
            // 
            // yemEkrani
            // 
            this.yemEkrani.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.yemEkrani.BackColor = System.Drawing.Color.Transparent;
            this.yemEkrani.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yemEkrani.ForeColor = System.Drawing.Color.Lime;
            this.yemEkrani.Location = new System.Drawing.Point(344, 28);
            this.yemEkrani.Name = "yemEkrani";
            this.yemEkrani.Size = new System.Drawing.Size(35, 21);
            this.yemEkrani.TabIndex = 15;
            this.yemEkrani.Text = "0";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Orange;
            this.label3.Location = new System.Drawing.Point(186, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 27);
            this.label3.TabIndex = 14;
            this.label3.Text = "Yediğiniz Yem :";
            // 
            // puanEkrani
            // 
            this.puanEkrani.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.puanEkrani.BackColor = System.Drawing.Color.Transparent;
            this.puanEkrani.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.puanEkrani.ForeColor = System.Drawing.Color.Lime;
            this.puanEkrani.Location = new System.Drawing.Point(711, 27);
            this.puanEkrani.Name = "puanEkrani";
            this.puanEkrani.Size = new System.Drawing.Size(85, 27);
            this.puanEkrani.TabIndex = 13;
            this.puanEkrani.Text = "0";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(613, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Puanınız :";
            // 
            // sifirlaButonu
            // 
            this.sifirlaButonu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sifirlaButonu.BackColor = System.Drawing.Color.MediumTurquoise;
            this.sifirlaButonu.Font = new System.Drawing.Font("Pristina", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.sifirlaButonu.ForeColor = System.Drawing.Color.White;
            this.sifirlaButonu.Location = new System.Drawing.Point(16, 627);
            this.sifirlaButonu.Name = "sifirlaButonu";
            this.sifirlaButonu.Size = new System.Drawing.Size(132, 42);
            this.sifirlaButonu.TabIndex = 10;
            this.sifirlaButonu.Text = "Sıfırla";
            this.sifirlaButonu.UseVisualStyleBackColor = false;
            this.sifirlaButonu.Click += new System.EventHandler(this.sifirlaButonu_Click);
            // 
            // oyunGeriButonu
            // 
            this.oyunGeriButonu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.oyunGeriButonu.BackColor = System.Drawing.Color.MediumTurquoise;
            this.oyunGeriButonu.Font = new System.Drawing.Font("Pristina", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.oyunGeriButonu.ForeColor = System.Drawing.Color.White;
            this.oyunGeriButonu.Location = new System.Drawing.Point(16, 20);
            this.oyunGeriButonu.Name = "oyunGeriButonu";
            this.oyunGeriButonu.Size = new System.Drawing.Size(132, 42);
            this.oyunGeriButonu.TabIndex = 16;
            this.oyunGeriButonu.Text = "Geri";
            this.oyunGeriButonu.UseVisualStyleBackColor = false;
            this.oyunGeriButonu.Click += new System.EventHandler(this.oyunGeriButonu_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(385, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 32);
            this.label2.TabIndex = 17;
            this.label2.Text = "Geçen Süre:";
            // 
            // saniye
            // 
            this.saniye.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saniye.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saniye.ForeColor = System.Drawing.Color.Lime;
            this.saniye.Location = new System.Drawing.Point(569, 28);
            this.saniye.Name = "saniye";
            this.saniye.Size = new System.Drawing.Size(38, 23);
            this.saniye.TabIndex = 18;
            this.saniye.Text = "0";
            // 
            // dakika
            // 
            this.dakika.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dakika.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dakika.ForeColor = System.Drawing.Color.Lime;
            this.dakika.Location = new System.Drawing.Point(526, 28);
            this.dakika.Name = "dakika";
            this.dakika.Size = new System.Drawing.Size(37, 23);
            this.dakika.TabIndex = 21;
            this.dakika.Text = "0";
            // 
            // gecenSure
            // 
            this.gecenSure.Interval = 1000;
            this.gecenSure.Tick += new System.EventHandler(this.gecenSure_Tick);
            // 
            // hareketZamanlayici
            // 
            this.hareketZamanlayici.Enabled = true;
            this.hareketZamanlayici.Tick += new System.EventHandler(this.hareketZamanlayici_Tick);
            // 
            // oyunSahnesi
            // 
            this.oyunSahnesi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.oyunSahnesi.BackColor = System.Drawing.Color.Transparent;
            this.oyunSahnesi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("oyunSahnesi.BackgroundImage")));
            this.oyunSahnesi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.oyunSahnesi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.oyunSahnesi.ForeColor = System.Drawing.Color.White;
            this.oyunSahnesi.Location = new System.Drawing.Point(16, 88);
            this.oyunSahnesi.Name = "oyunSahnesi";
            this.oyunSahnesi.Size = new System.Drawing.Size(770, 517);
            this.oyunSahnesi.TabIndex = 9;
            // 
            // OyunBaslangic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(798, 681);
            this.Controls.Add(this.dakika);
            this.Controls.Add(this.puanEkrani);
            this.Controls.Add(this.saniye);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.oyunGeriButonu);
            this.Controls.Add(this.oyunSahnesi);
            this.Controls.Add(this.baslaButonu);
            this.Controls.Add(this.yemEkrani);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sifirlaButonu);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "OyunBaslangic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yılan Macerası v1.0";
            this.Load += new System.EventHandler(this.SnakeGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button baslaButonu;
        private System.Windows.Forms.Label yemEkrani;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label puanEkrani;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sifirlaButonu;
        private System.Windows.Forms.Button oyunGeriButonu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label saniye;
        private System.Windows.Forms.Label dakika;
        public System.Windows.Forms.Timer gecenSure;
        public System.Windows.Forms.Timer hareketZamanlayici;
        private System.Windows.Forms.Panel oyunSahnesi;
    }
}