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

namespace _ndp_proje_yariyil2.ÖdemeFormları
{
    public partial class OdemeDuzenleForm : Form
    {

        private int _index;
        private KisiYonetim _kisiYonetim;
        private OdemeYonetim _odemeYonetim;

        public OdemeDuzenleForm(int index, KisiYonetim kisiYonetim, OdemeYonetim odemeYonetim)
        {
            InitializeComponent();
            _odemeYonetim = odemeYonetim;
            _kisiYonetim = kisiYonetim;
            _index = index;

            kalanBorcTextBox.Text = (HizmetYonetim.DaireUcreti +(HizmetYonetim.EkKisiUcreti* _odemeYonetim.Odemeler[index].OdemeYapan.Dairesi.KisiSayisi) - _odemeYonetim.Odemeler[index].ToplamOdenenPara).ToString();
            tutarTextBox.Text = _odemeYonetim.Odemeler[index].ToplamOdenenPara.ToString();

            duzenleniyorLabel.Text = $"{_odemeYonetim.Odemeler[index].OdemeYapan.Adi} {_odemeYonetim.Odemeler[index].OdemeYapan.Soyadi} kişisinin ödemesi düzenleniyor";
        }


        private async void odemeDuzenleButton_Click(object sender, EventArgs e)
        {
            if (OdemeDuzenleHataVarMi()) return; //hataVarMi true ise işlemi durdurur
            _odemeYonetim.Duzenle(_index, Convert.ToDouble(tutarTextBox.Text));
            _odemeYonetim.KisiOdemeleriniGuncelle(_kisiYonetim.Oturanlar);
            _odemeYonetim.DosyaGuncelle();
            odemeDuzenleButton.Enabled = false;
            odemeDuzenleButton.Text = "Kişi Düzenlendi";
            await Task.Delay(1000);
            _odemeYonetim.AbonelikKontrol();
            this.Close();
        }

        private bool OdemeDuzenleHataVarMi()
        {
            bool hatali = false;


            if (!double.TryParse(tutarTextBox.Text, out double tutar) || tutar <= 0)
            {
                errorProvider1.SetError(tutarTextBox, "sayı ve , arası boşluk bırakmayın");
                hatali = true;
            }
            else
            {
                errorProvider1.SetError(tutarTextBox, "");
            }

            if (hatali)
            {
                return true; // Hatalı giriş varsa true döndürür
            }

            return false; // hatasız ise yanlış döndürür
        }


        private void geriButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
