using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIL_201_Odev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int baslangic, bitis;
        private void btnCalistir_Click(object sender, EventArgs e)
        {
            EkranıHazirla();

            baslangic = Convert.ToInt32(mtbBaslangic.Text);
            bitis = Convert.ToInt32(mtbBitis.Text);


            if (Dogrula())
            {
                TekCiftSay();
                AsalSay();
                MukemmelSay();
            }
            else
            {
                MessageBox.Show("Uygun değer girmediniz.Tekrar deneyiniz.");
                EkranıHazirla();
                mtbBaslangic.Text = "";
                mtbBitis.Text = "";
            }
            mtbBaslangic.Text = "1";
            mtbBitis.Text = "";
            mtbBaslangic.Focus();
        }
        private void EkranıHazirla()
        {

            lvTekSayilar.Items.Clear();
            lvCiftSayilar.Items.Clear();
            lvMukemmelSay.Items.Clear();
            lvAsalSayilar.Items.Clear();
            mtbBaslangic.Focus();
        }


        private Boolean Dogrula()
        {
            try
            {
                Convert.ToInt32(mtbBaslangic.Text);
                Convert.ToInt32(mtbBitis.Text);

                if (( Convert.ToInt32(mtbBaslangic.Text) < Convert.ToInt32(mtbBitis.Text)))
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;

            }
        }

        private void TekCiftSay()
        {
            double tekToplam = 0, tekCarpim = 1;
            double ciftCarpim = 1, ciftToplam = 0;
            for (int i = baslangic; i < bitis; i++)
                if (i % 2 == 1)
                {
                    tekToplam += i;
                    tekCarpim *= i;
                    lvTekSayilar.Items.Add(i.ToString());
                }
                else
                {
                    ciftToplam += i;
                    ciftCarpim *= i;
                    lvCiftSayilar.Items.Add(i.ToString());
                }

            lvTekSayilar.Items.Add("Tek Toplam: " + tekToplam);
            lvTekSayilar.Items.Add("Tek Çarpım: " + tekCarpim);
            lvCiftSayilar.Items.Add("Çift Toplam: " + ciftToplam);
            lvCiftSayilar.Items.Add("Çift Çarpım: " + ciftCarpim);
        }

        private void AsalSay()
        {
            double ilkSayi = baslangic;
            double asalToplam = 0, asalCarpim = 1;
            bool durum = true;
            while (ilkSayi < bitis)
            {
                ilkSayi++;
                for (int i = 2; i < ilkSayi; i++)
                {
                    if (ilkSayi % i == 0)
                    {
                        durum = false;
                    }
                }
                if (durum == true && ilkSayi != 1)
                {
                    asalToplam += ilkSayi;
                    asalCarpim *= ilkSayi;
                    lvAsalSayilar.Items.Add(ilkSayi.ToString());
                }
                durum = true;
            }
            lvAsalSayilar.Items.Add("Asal Toplam: " + asalToplam);
            lvAsalSayilar.Items.Add("Asal Çarpım: " + asalCarpim);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            mtbBaslangic.Focus();
            nıUyari.Icon = SystemIcons.Information;
            nıUyari.BalloonTipTitle = "Programa Hoş Geldiniz";
            nıUyari.BalloonTipText = "Nesne Yönelimli Programlama Ödev-1";
            nıUyari.ShowBalloonTip(100);
        }

        private void MukemmelSay()
        {
            double mukemmelToplam = 0, mukemmelCarpim = 1;
            bool MukemmelSayiKontrol;
            for (int sayi = baslangic; sayi < bitis; sayi++)
            {
                double toplam = 0;
                for (int j = 1; j < sayi; j++)
                {
                    if (sayi % j == 0)
                    {
                        toplam = toplam + j;
                    }
                }

                if (sayi == toplam)
                    MukemmelSayiKontrol = true;
                else
                    MukemmelSayiKontrol = false;


                if (MukemmelSayiKontrol == true)
                {
                    lvMukemmelSay.Items.Add(sayi.ToString());
                    mukemmelToplam += sayi;
                    mukemmelCarpim *= sayi;
                }
            }

            lvMukemmelSay.Items.Add("Mükemmel Sayı Toplam: " + mukemmelToplam);
            lvMukemmelSay.Items.Add("Mükemmel Sayı Çarpım: " + mukemmelCarpim);

        }

    }
}
