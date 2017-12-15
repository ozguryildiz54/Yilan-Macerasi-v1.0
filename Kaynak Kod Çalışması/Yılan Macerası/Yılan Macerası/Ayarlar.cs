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
namespace Yılan_Macerası
{
    public partial class Ayarlar : Form
    {
        public static int  deger = 100;
        public static bool ses = true;
        public static string bolum = "Klasik";
        public Ayarlar()
        {
            InitializeComponent();
        }

       

        //Ses Metodları
        public static void onePing()
        {
            if(ses==true)
                Console.Beep(5000, 100);

        }
        public static void arasesler()
        {
            if(ses == true)
            Console.Beep(800,150);
        }
        public static void cikisSes()
        {
            if (ses == true)
                Console.Beep(400,200);
        }
        public static void baslatSes()
        {
            if (ses == true)
                Console.Beep(1500, 150);
        }
        

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Yılan_Macerası.Ayarlar.arasesler();
        }

        

        private void ayarlarGeri_Click(object sender, EventArgs e)
        {
            Yılan_Macerası.Ayarlar.arasesler();
            Yılan_Macerası.Menu geri = new Yılan_Macerası.Menu();
            geri.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex == 0)
            {
                deger = 200;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                deger = 100;
            }
            if (comboBox1.SelectedIndex == 2)
            {
                deger = 50;
            }
            if (comboBox1.SelectedIndex == 3)
            {
                deger = 10;
            }
            if (comboBox1.SelectedIndex == 4)
            {
                deger = 5;
            }
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            bolum = "Klasik";
        }

        private void radioButton4_Click(object sender, EventArgs e)
        {
            bolum = "Cerceveli";
        }

        private void radioButton1_Click_1(object sender, EventArgs e)
        {
            ses = true;
        }

        private void radioButton2_Click_1(object sender, EventArgs e)
        {
            ses = false;
        }
    }
}
