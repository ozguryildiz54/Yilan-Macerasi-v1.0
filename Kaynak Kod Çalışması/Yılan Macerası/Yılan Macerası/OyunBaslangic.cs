using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace YIlan_Macerası
{
    public partial class OyunBaslangic : Form
    {
        #region Variables
        public const Keys up = Keys.Up;
        public const Keys right = Keys.Right;
        public const Keys down = Keys.Down;
        public const Keys left = Keys.Left;

        public static int hizDeger = 100;

        public int posX;
        public int posY;
        public const int xMax = 69;
        public const int xMin = 0;
        public const int yMax = 46;
        public const int yMin = 0;

        public bool noktaKontrol = true;
        public int posPixelCarpan = 11;
        public int oyunPuan = 0;
        public YonEnum konum;
        public Point yemKonum;
        public List<Point> yilanKonum = new List<Point>();
        #endregion
        #region Constructor And Loader

        public OyunBaslangic()
        {
            InitializeComponent();
        }

        public void SnakeGame_Load(object sender, EventArgs e)
        {
            oyunSifirla();
            yilanHizi();

        }
        #endregion

        #region Events

        public void gameTimer_Tick(object sender, EventArgs e)
        {
            oyunDevamEt();
        }

        public void resetButton_Click(object sender, EventArgs e)
        {
            oyunSifirla();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (hareketZamanlayici.Enabled && noktaKontrol)
            {
                noktaKontrol = false;
                yilanYonu(keyData);
            }

            oyunDuraklat(keyData);
            return base.ProcessCmdKey(ref msg, keyData);
        }
        #endregion

        #region Methods
        public void oyunBaslat()
        {

            baslaButonu.Enabled = false;
            yilanHizi();
            hareketZamanlayici.Enabled = true;
        }

        public void oyunDevamEt()
        {
            yilanSonrakiKonum();
            bool isGameEnded = oyunDevamKontrol();

            if (isGameEnded)
            {
                
                gecenSure.Stop();
                Yılan_Macerası.Ayarlar.cikisSes();
                hareketZamanlayici.Enabled = false;
                MessageBox.Show("Puan:" + puanEkrani.Text + "\nSüre:" + dakika.Text + " dk / " + saniye.Text + " sn" + "\nYenilen yem:" + yemEkrani.Text, "Bilgilendirme");
                baslaButonu.Text = "Tekrar Oyna";
                oyunSifirla();
                return;
            }

            yilanKonum.Insert(0, new Point(posX, posY));
            yilanKonum.RemoveAt(yilanKonum.Count - 1);

            if (yemKonum.X == posX * posPixelCarpan && yemKonum.Y == posY * posPixelCarpan)
            {
                yemYendimiKontrol();
            }

            yilanCiz();
            noktaKontrol = true;
        }

        public void oyunSifirla()
        {
            hareketZamanlayici.Enabled = false;
            baslaButonu.Enabled = true;

            gecenSure.Stop();
            saniye.Text = "0";
            dakika.Text = "0";
            yilanOlustur();
            degerleriSifirla();
            yeniYem();
            yilanCiz();
        }

        public void oyunDuraklat(Keys keyData)
        {
            if (keyData == Keys.P)
            {
                hareketZamanlayici.Enabled = !hareketZamanlayici.Enabled;
            }
        }

        public void yilanHizi()
        {
            hizDeger = Yılan_Macerası.Ayarlar.deger;
            hareketZamanlayici.Interval = hizDeger;
        }

        public void degerleriSifirla()
        {
            posX = 12;
            posY = 20;
            oyunPuan = 0;
            konum = YonEnum.Right;
            istatistikYaz();
        }

        public void yilanOlustur()
        {
            yilanKonum.Clear();
            yilanKonum.Add(new Point(12, 20));
            yilanKonum.Add(new Point(11, 20));
            yilanKonum.Add(new Point(10, 20));
        }

        public void yilanSonrakiKonum()
        {
            switch (konum)
            {
                case YonEnum.Down:
                    posY++;
                    break;
                case YonEnum.Up:
                    posY--;
                    break;
                case YonEnum.Left:
                    posX--;
                    break;
                case YonEnum.Right:
                default:
                    posX++;
                    break;
            }
        }

        public bool oyunDevamKontrol()
        {
            if(Yılan_Macerası.Ayarlar.bolum=="Klasik")
            {
                if (posX < xMin)
                {
                    posX = xMax;
                }
                if (posY > yMax)
                {
                    posY = yMin;
                }
                if (posY < yMin)
                {
                    posY = yMax;
                }
                if (posX > xMax)
                {
                    posX = xMin;
                }
            }
            if(Yılan_Macerası.Ayarlar.bolum=="Cerceveli")
            {
                
                if (posX>xMax || posX<xMin || posY>yMax || posY<yMin)
                {
                    return true;
                }
            }

            //Yem yenildi mi?
            if (yilanKonum.Any(t => t.X == posX && t.Y == posY))
            {
                return true;
            }

            return false;
        }

        public void yeniYem()
        {
            Random random = new Random(DateTime.Now.TimeOfDay.Milliseconds);
            int x = 0;
            int y = 0;
            bool contains = true;

            while (contains)
            {
                x = random.Next(xMin, xMax + 1) * posPixelCarpan;
                y = random.Next(yMin, yMax + 1) * posPixelCarpan;

                contains = yilanKonum.Any(t => t.X == x && t.Y == y);
            }

            yemKonum = new Point(x, y);
        }

        public void yemYendimiKontrol()
        {
            Point lastPoint = yilanKonum[yilanKonum.Count - 1];
            yilanKonum.Add(new Point(lastPoint.X, lastPoint.Y));
            if (Yılan_Macerası.Ayarlar.deger == 200)
            {
                oyunPuan += Yılan_Macerası.Ayarlar.deger / 20;
            }
            else if (Yılan_Macerası.Ayarlar.deger == 100)
            {
                oyunPuan += (Yılan_Macerası.Ayarlar.deger * 2) / 5;
            }
            else if (Yılan_Macerası.Ayarlar.deger == 50)
            {
                oyunPuan += (Yılan_Macerası.Ayarlar.deger * 6) / 5;
            }
            else if (Yılan_Macerası.Ayarlar.deger == 10)
            {
                oyunPuan += Yılan_Macerası.Ayarlar.deger * 10;
            }
            else if (Yılan_Macerası.Ayarlar.deger == 5)
            {
                oyunPuan += Yılan_Macerası.Ayarlar.deger * 30;
            }
            istatistikYaz();
            yeniYem();
            Yılan_Macerası.Ayarlar.onePing();
       }

        public void istatistikYaz()
        {
            puanEkrani.Text = oyunPuan.ToString();
            yemEkrani.Text = (yilanKonum.Count - 3).ToString();
        }

        public void yilanYonu(Keys keyData)
        {
            switch (keyData)
            {
                case up:
                    if (konum != YonEnum.Down)
                        konum = YonEnum.Up;
                    break;
                case down:
                    if (konum != YonEnum.Up)
                        konum = YonEnum.Down;
                    break;
                case left:
                    if (konum != YonEnum.Right)
                        konum = YonEnum.Left;
                    break;
                case right:
                default:
                    if (konum != YonEnum.Left)
                        konum = YonEnum.Right;
                    break;
            }
        }

        #endregion

        #region Drawing Methods
        public void yilanCiz()
        {
            oyunSahnesi.Refresh();
            yemCiz();
            foreach (Point item in yilanKonum)
            {
                int xVal = item.X * posPixelCarpan;
                int yVal = item.Y * posPixelCarpan;

                yemNoktasi(xVal, yVal);
            }
        }

        public void yemNoktasi(int x, int y, bool isBlack = true)
        {
            using (Graphics g = this.oyunSahnesi.CreateGraphics())
            {
                Color penColor = isBlack ? Color.Black : Color.Red;
                Pen pen = new Pen(penColor, 5);
                g.DrawRectangle(pen, x, y, 5, 5);
                pen.Dispose();
            }
        }

        public void yemCiz()
        {
            yemNoktasi(yemKonum.X, yemKonum.Y, false);
        }
        #endregion

        public void speedSelection_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            hareketZamanlayici.Stop();
        }

        public void button2_Click(object sender, EventArgs e)
        {
            hareketZamanlayici.Start();
        }

        private void sifirlaButonu_Click(object sender, EventArgs e)
        {
            Yılan_Macerası.Ayarlar.arasesler();
            oyunSifirla();
            gecenSure.Stop();
            baslaButonu.Text = "Başla";
            saniye.Text = "0";
            dakika.Text = "0";
        }

        private void oyunGeriButonu_Click(object sender, EventArgs e)
        {
            hareketZamanlayici.Stop();
            gecenSure.Stop();
            Yılan_Macerası.Ayarlar.arasesler();
            Yılan_Macerası.Menu geri = new Yılan_Macerası.Menu();
            geri.Show();
            this.Hide();
        }

        private void hareketZamanlayici_Tick(object sender, EventArgs e)
        {
            oyunDevamEt();
        }

        private void baslaButonu_Click(object sender, EventArgs e)
        {
            Yılan_Macerası.Ayarlar.baslatSes();
            gecenSure.Start();
            gecenSure.Interval = 1000;
            if (hareketZamanlayici.Enabled == false)
            {

                hareketZamanlayici.Start();
                gecenSure.Start();
                baslaButonu.Text = "Duraklat";
            }
            else
            {

                hareketZamanlayici.Stop();
                gecenSure.Stop();
                baslaButonu.Text = "Devam Et";
            }
        }

        private void gecenSure_Tick(object sender, EventArgs e)
        {
            if (int.Parse(saniye.Text) < 9)
            {
                saniye.Text = "0" + (int.Parse(saniye.Text) + 1).ToString();
            }
            else
            {
                saniye.Text = (int.Parse(saniye.Text) + 1).ToString();
            }
            if (int.Parse(saniye.Text) == 60)
            {
                saniye.Text = "00";
                if (int.Parse(dakika.Text) < 9)
                {
                    dakika.Text = "0" + (int.Parse(dakika.Text) + 1).ToString();
                }
                else
                {
                    dakika.Text = (int.Parse(dakika.Text) + 1).ToString();
                }
            }
        }
    }

    public enum YonEnum
    {
        Undefined,
        Up,
        Right,
        Down,
        Left
    
}
}