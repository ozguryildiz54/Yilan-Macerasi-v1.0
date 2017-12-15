namespace Yılan_Macerası
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.baslaButonu = new System.Windows.Forms.Button();
            this.talimatlarButonu = new System.Windows.Forms.Button();
            this.hakkimizdaButonu = new System.Windows.Forms.Button();
            this.cikisButonu = new System.Windows.Forms.Button();
            this.ayarlarButonu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // baslaButonu
            // 
            this.baslaButonu.BackColor = System.Drawing.Color.MediumTurquoise;
            this.baslaButonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baslaButonu.Location = new System.Drawing.Point(666, 34);
            this.baslaButonu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.baslaButonu.Name = "baslaButonu";
            this.baslaButonu.Size = new System.Drawing.Size(151, 58);
            this.baslaButonu.TabIndex = 10;
            this.baslaButonu.Text = "Oyna";
            this.baslaButonu.UseVisualStyleBackColor = false;
            this.baslaButonu.Click += new System.EventHandler(this.baslaButonu_Click);
            // 
            // talimatlarButonu
            // 
            this.talimatlarButonu.BackColor = System.Drawing.Color.MediumTurquoise;
            this.talimatlarButonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.talimatlarButonu.Location = new System.Drawing.Point(509, 114);
            this.talimatlarButonu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.talimatlarButonu.Name = "talimatlarButonu";
            this.talimatlarButonu.Size = new System.Drawing.Size(233, 59);
            this.talimatlarButonu.TabIndex = 11;
            this.talimatlarButonu.Text = "Talimatlar";
            this.talimatlarButonu.UseVisualStyleBackColor = false;
            this.talimatlarButonu.Click += new System.EventHandler(this.talimatlarButonu_Click);
            // 
            // hakkimizdaButonu
            // 
            this.hakkimizdaButonu.BackColor = System.Drawing.Color.MediumTurquoise;
            this.hakkimizdaButonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.hakkimizdaButonu.Location = new System.Drawing.Point(630, 199);
            this.hakkimizdaButonu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hakkimizdaButonu.Name = "hakkimizdaButonu";
            this.hakkimizdaButonu.Size = new System.Drawing.Size(264, 60);
            this.hakkimizdaButonu.TabIndex = 20;
            this.hakkimizdaButonu.Text = "Hakkımızda";
            this.hakkimizdaButonu.UseVisualStyleBackColor = false;
            this.hakkimizdaButonu.Click += new System.EventHandler(this.hakkimizdaButonu_Click);
            // 
            // cikisButonu
            // 
            this.cikisButonu.BackColor = System.Drawing.Color.MediumTurquoise;
            this.cikisButonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cikisButonu.Location = new System.Drawing.Point(692, 279);
            this.cikisButonu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cikisButonu.Name = "cikisButonu";
            this.cikisButonu.Size = new System.Drawing.Size(133, 58);
            this.cikisButonu.TabIndex = 14;
            this.cikisButonu.Text = "Çıkış";
            this.cikisButonu.UseVisualStyleBackColor = false;
            this.cikisButonu.Click += new System.EventHandler(this.cikisButonu_Click);
            // 
            // ayarlarButonu
            // 
            this.ayarlarButonu.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ayarlarButonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ayarlarButonu.Location = new System.Drawing.Point(750, 114);
            this.ayarlarButonu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ayarlarButonu.Name = "ayarlarButonu";
            this.ayarlarButonu.Size = new System.Drawing.Size(172, 59);
            this.ayarlarButonu.TabIndex = 15;
            this.ayarlarButonu.Text = "Ayarlar";
            this.ayarlarButonu.UseVisualStyleBackColor = false;
            this.ayarlarButonu.Click += new System.EventHandler(this.ayarlarButonu_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1059, 703);
            this.Controls.Add(this.ayarlarButonu);
            this.Controls.Add(this.cikisButonu);
            this.Controls.Add(this.hakkimizdaButonu);
            this.Controls.Add(this.talimatlarButonu);
            this.Controls.Add(this.baslaButonu);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yılan Macerası v1.0";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button baslaButonu;
        private System.Windows.Forms.Button talimatlarButonu;
        private System.Windows.Forms.Button hakkimizdaButonu;
        private System.Windows.Forms.Button cikisButonu;
        private System.Windows.Forms.Button ayarlarButonu;
    }
}

