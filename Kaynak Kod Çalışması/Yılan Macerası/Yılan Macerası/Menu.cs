using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yılan_Macerası
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        
        private void baslaButonu_Click(object sender, EventArgs e)
        {
            Ayarlar.arasesler();
            YIlan_Macerası.OyunBaslangic arayuz = new YIlan_Macerası.OyunBaslangic();
            
                arayuz.Show();
                arayuz.oyunDevamEt();
                this.Hide();
        }

        private void talimatlarButonu_Click(object sender, EventArgs e)
        {
            Ayarlar.arasesler();
            MessageBox.Show("\t\t\t         Talimatlar\n\n-Eğer bölüm olarak klasik bölümünü seçerseniz duvarlardan geçebilir oyuna devam edebilirsiniz.\n-Yada bölüm olarak çerçeveli bölümünü seçerseniz yılan sahne dışından çıkamaz ve duvara temaz ettiğinde oyun biter.\n-Yön vermek için yön tuşlarını kullanmalısınız.\n-Puan toplamak için yemleri yemelisiniz.\n-Oyun zorluğu arttıkça her yemden daha fazla puan alırsınız.\n-Eğer yılan kuyruğuna temas ederse oyun biter.\n-Oyunu duraklatmank için 'P' tuşuna yada sağ altaki 'Duraklat' butonuna basınız.\n-Devam ettirmek için de sağ alttan 'Devam et' butonuna yada 'P' tuşuna basabilirsiniz.");
        }

        private void hakkimizdaButonu_Click(object sender, EventArgs e)
        {
            Yılan_Macerası.Ayarlar.arasesler();
            MessageBox.Show("        Oyunun Yapımcısı\n\n\n-Özgür YILDIZ\n-Emre YÖNET\n-Şenol KARAKURT\n-Ebubekir BİNGÖLOĞLU\n-Emre İREM\n-Osman KAYAN");
        }

        private void cikisButonu_Click(object sender, EventArgs e)
        {
            Yılan_Macerası.Ayarlar.arasesler();
            DialogResult Soru;

            Soru = MessageBox.Show("Oyundan çıkmak istediğinizden emin misiniz ?", "Uyarı",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (Soru == DialogResult.Yes)
            {
                Yılan_Macerası.Ayarlar.cikisSes();
                this.Close();
                Application.Exit();
            }
        }

        private void ayarlarButonu_Click(object sender, EventArgs e)
        {
            Yılan_Macerası.Ayarlar.arasesler();
            Yılan_Macerası.Ayarlar ayar = new Yılan_Macerası.Ayarlar();
            ayar.Show();
            this.Hide();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
