using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/**************************************************************************** 
 **                               SAKARYA ÜNİVERSİTESİ 
 **                      BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ 
 **                       BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ 
 **                           NESNEYE DAYALI PROGRAMLAMA DERSİ 
 **                              2019-2020 BAHAR DÖNEMİ 
 **
 **                            ÖDEV NUMARASI..........: 1
 **                            ÖĞRENCİ ADI............: Arshad Amir Monsur
 **                            ÖĞRENCİ NUMARASI.......: B171200555
 **                            DERSİN ALINDIĞI GRUP...: A
 **
 *****************************************************************************/

namespace HarhOrtalama_B171200555_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int odev, kisaSinav, vize, finaf;// değişkenleri tanımı
            double sonuc;// değişkeni tanımı
            kisaSinav = Convert.ToInt32(textBox1.Text); // kısa sınav değişkeni 
            odev = Convert.ToInt32(textBox2.Text); // Ödev değişkeni   
            vize = Convert.ToInt32(textBox3.Text); // Vize değişkeni
            finaf = Convert.ToInt32(textBox4.Text); // Final değişkeni
            sonuc = (odev * 0.10) + (kisaSinav * 0.10) + (vize * 0.30) + (finaf * 0.50); // Her notun katkısı 
            label8.Text = Convert.ToString(sonuc); // ortalama
            // if metodu ile kullanım
            // HARF HESABLAMA :

            if (sonuc >= 0 && sonuc < 50)// 0 ve 50 arasında FF ile gösterilir
            {
                label9.Text = "FF";
                label9.ForeColor = Color.Red;//FF kırmızı renkla gösterilir
            }

            if (sonuc >= 50 && sonuc < 60)// 50 ve 60 arasında DD ile gösterilir
            {
                label9.Text = "DD";
                label9.ForeColor = Color.Gold;// DD altın renkla gösterilir
            }


            if (sonuc >= 60 && sonuc < 70)// 60 ve 70 arasında CC ile gösterilir
            {
                label9.Text = "CC";
                label9.ForeColor = Color.Gold;// CC altın renkla gösterilir
            }
            if (sonuc >= 70 && sonuc < 80)// 65 ve 80 arasında CB ile gösterilir
            {
                label9.Text = "CB";
                label9.ForeColor = Color.Orange; //CB renki toruncu ile gösterilir
            }
            if (sonuc >= 80 && sonuc < 85) // 80 ve 85 arasında BB 
            {
                label9.Text = "BB";
                label9.ForeColor = Color.OrangeRed;// BB renki toruncu ile gösterilir
            }
            if (sonuc >= 85 && sonuc < 90)// 85 ve 90 arasında BA ile gösterilir
            {
                label9.Text = "BA";
                label9.ForeColor = Color.GreenYellow;// BA renki yeşilsarı ile gösterilir
            }
            if (sonuc >= 90 && sonuc <= 100)// 90 ve 100 arasında AA ile gösterilir
            {
                label9.Text = "AA";
                label9.ForeColor = Color.Green;//AA renki yeşil ile gösterilir
            }
            // Girdiler yanlış ise !
            if (sonuc > 100)
            {
                label8.Text = "Yanlış notlar girdiniz, lütfen tekrarlaınız.";//Ortalamanın yerine gösterilir
                label9.Text = "Yanlış notlar girdiniz, lütfen tekrarlaınız.";//Harfin yerine gösterilir
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
