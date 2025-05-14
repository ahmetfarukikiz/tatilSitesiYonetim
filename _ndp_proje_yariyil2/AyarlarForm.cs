/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2024-2025 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: Proje
**				ÖĞRENCİ ADI............: Ahmet Faruk İkiz
**				ÖĞRENCİ NUMARASI.......: B241210040   
**              DERSİN ALINDIĞI GRUP...: B Grubu
****************************************************************************/

using _ndp_proje_yariyil2.YönetimSınıfları;

namespace _ndp_proje_yariyil2
{
    public partial class AyarlarForm : Form
    {

        public AyarlarForm()
        {
            InitializeComponent();
            daireUcretiTextBox.Text = HizmetYonetim.DaireUcreti.ToString();
            kisiUcretiTextBox.Text = HizmetYonetim.EkKisiUcreti.ToString();
        }

        private async void kaydetButton_Click(object sender, EventArgs e)
        {
            if (AyarDuzenleHataVarMi()) return; //hataVarMi true ise işlemi durdurur

            HizmetYonetim.DaireUcreti = Convert.ToDouble(daireUcretiTextBox.Text);
            HizmetYonetim.EkKisiUcreti = Convert.ToDouble(kisiUcretiTextBox.Text);
            HizmetYonetim.AyarlarTxtGuncelle();
            kaydetButton.Enabled = false;
            kaydetButton.Text = "Kaydedildi";
            await Task.Delay(1000);
            this.Close();
        }

        private void geriButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private bool AyarDuzenleHataVarMi()
        {
            bool hatali = false;

            if (!double.TryParse(daireUcretiTextBox.Text, out double daireUcreti) || daireUcreti <= 0)
            {
                errorProvider1.SetError(daireUcretiTextBox, "0'dan büyük bir sayı giriniz");
                hatali = true;
            }
            else
            {
                errorProvider1.SetError(daireUcretiTextBox, "");
            }

            if (!double.TryParse(kisiUcretiTextBox.Text, out double kisiUcreti) || kisiUcreti <= 0)
            {
                errorProvider1.SetError(kisiUcretiTextBox, "0'dan büyük bir sayı giriniz");
                hatali = true;
            }
            else
            {
                errorProvider1.SetError(kisiUcretiTextBox, "");
            }


            if (hatali)
            {
                return true; // Hatalı giriş varsa true döndürür
            }

            return false; // hatasız ise yanlış döndürür
        }
    }
}
