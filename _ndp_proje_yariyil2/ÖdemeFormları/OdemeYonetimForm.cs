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

using _ndp_proje_yariyil2.TemelSınıflar;
using _ndp_proje_yariyil2.YönetimSınıfları;
using System.Data;

namespace _ndp_proje_yariyil2.ÖdemeFormları
{
    public partial class OdemeYonetimForm : Form
    {
        private KisiYonetim _kisiYonetim;
        private MekanYonetim _mekanYonetim;
        private OdemeYonetim _odemeYonetim;
        public OdemeYonetimForm(OdemeYonetim odemeYonetim, MekanYonetim mekanYonetim, KisiYonetim kisiYonetim)
        {


            _odemeYonetim = odemeYonetim;
            _kisiYonetim = kisiYonetim;
            _mekanYonetim = mekanYonetim;
            InitializeComponent();

            #region tab1
            OdemeListBoxGuncelle();
            odemeDuzenleButton.Enabled = odemelerListBox.SelectedIndex != -1;
            odemeSilButton.Enabled = odemelerListBox.SelectedIndex != -1;
            #endregion

            #region tab2
            tutarTextBox.Enabled = dairesiComboBox.SelectedIndex != -1;
            odemeAlButton.Enabled = dairesiComboBox.SelectedIndex != -1;

            dairesiComboBox.Items.AddRange(_mekanYonetim.Daireler.Select(d => $"Daire {d.DaireNo} - {d.KisiSayisi}/{d.MaxKisiSayisi}").ToArray());
            #endregion

            _odemeYonetim.OdemeDegistiDisari -= OdemeYonetim_OdemeDegistiDisari;
            _odemeYonetim.OdemeDegistiDisari += OdemeYonetim_OdemeDegistiDisari;

            _odemeYonetim.AbonelikKontrol();



        }

        private void OdemeYonetim_OdemeDegistiDisari(object sender, Odeme odeme) //odeme her değiştiğinde bu şartları kontrol eder. süre dolduğunda ödeme sıfırlanır ve bu event çalışır sonrasında daire.BorcuOdendi = false yapar
        {
            odeme.OdemeYapan.Dairesi.BorcOdendi = (odeme.ToplamOdenenPara == HizmetYonetim.DaireUcreti + (HizmetYonetim.EkKisiUcreti * odeme.OdemeYapan.Dairesi.KisiSayisi)); //ödeme tamamlandıysa ödemeyi yapan kişinin dairesinin BorcOdendi'sini true yapar
            if (odeme.ToplamOdenenPara == HizmetYonetim.DaireUcreti + (HizmetYonetim.EkKisiUcreti * odeme.OdemeYapan.Dairesi.KisiSayisi))
            { 
                _odemeYonetim.AboneligiBaslat(odeme); 
            }
            else { odeme.BitisTarihi = DateTime.Now; }
            _mekanYonetim.DosyaGuncelle();
            _odemeYonetim.KisiOdemeleriniGuncelle(_kisiYonetim.Oturanlar);
        }

        private async void odemeEkleButton_Click(object sender, EventArgs e)
        {
            
            int index = dairesiComboBox.SelectedIndex;
            var dairesi = _mekanYonetim.Daireler[index];
            var aileReisi = dairesi.DairedeOturanlar.Find(d => d is AileReisi); //seçilen dairedeki aile reisini bana bul

            if (OdemeEkleHataVarMi() == true) return;

            if (aileReisi is AileReisi ar) //Aile Reisinin tipine kesin olarak karar veriyoruz
            {
                if (Convert.ToDouble(tutarTextBox.Text) > Convert.ToDouble(kalanBorcTextBox.Text))
                {
                    MessageBox.Show("Kalan borç değeri üzerinde ödeme yapılamaz", "Ödeme Yapılamadı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                _odemeYonetim.Ekle(ar, Convert.ToDouble(tutarTextBox.Text));

                odemeAlButton.Enabled = false;
                odemeAlButton.Text = "Ödeme Alındı";
                await Task.Delay(1000);
                KutulariSifirla();
                odemeAlButton.Text = "Ödeme Al";

            }


            _odemeYonetim.KisiOdemeleriniGuncelle(_kisiYonetim.Oturanlar);
            _odemeYonetim.DosyaGuncelle();
            OdemeListBoxGuncelle();
            KutulariSifirla();
            odemeYokLabel.Visible = _odemeYonetim.Odemeler.Count == 0;

        }

        private void odemeSilButton_Click(object sender, EventArgs e)
        {
           
            int odemeIndex = odemelerListBox.SelectedIndex;
            var secilenOdeme = _odemeYonetim.Odemeler[odemeIndex];
            DialogResult silinecekResult = MessageBox.Show($"{secilenOdeme.OdemeYapan.Adi} {secilenOdeme.OdemeYapan.Soyadi} Kişisinin ödemesi Silinecek", "Emin Misiniz?", MessageBoxButtons.YesNo);

            if (silinecekResult == DialogResult.No) return;

            _mekanYonetim.DosyaGuncelle();
            _odemeYonetim.Sil(odemeIndex);
            _odemeYonetim.KisiOdemeleriniGuncelle(_kisiYonetim.Oturanlar);
            OdemeListBoxGuncelle();
            KutulariSifirla();
            _odemeYonetim.DosyaGuncelle();
            duzenleSilGörButtonKontrol();
            odemeYokLabel.Visible = _odemeYonetim.Odemeler.Count == 0;
        }

        private void odemeDuzenleButton_Click(object sender, EventArgs e)
        {
            int index = odemelerListBox.SelectedIndex;

            OdemeDuzenleForm odemeDuzenleForm = new OdemeDuzenleForm(index, _kisiYonetim, _odemeYonetim);
            odemeDuzenleForm.ShowDialog();


            _odemeYonetim.KisiOdemeleriniGuncelle(_kisiYonetim.Oturanlar);
            OdemeListBoxGuncelle();
            KutulariSifirla();
            _odemeYonetim.DosyaGuncelle();
            duzenleSilGörButtonKontrol();
            _mekanYonetim.DosyaGuncelle();
        }


        private void duzenleSilGörButtonKontrol()
        {
            odemeSilButton.Enabled = odemelerListBox.SelectedIndex != -1;
            odemeDuzenleButton.Enabled = odemelerListBox.SelectedIndex != -1;

        }

        private void OdemeListBoxGuncelle()
        {
            odemelerListBox.Items.Clear();
            odemelerListBox.Items.AddRange(_odemeYonetim.Odemeler.Select(o => $"{o.OdemeYapan.Adi}" +
            $" {o.OdemeYapan.Soyadi}\t" +
            $" Daire:{o.OdemeYapan.Dairesi.DaireNo}\t" +
            $" {o.ToplamOdenenPara}TL Ödendi" +
            $" \t{Math.Max((o.BitisTarihi - DateTime.Now).Minutes+1, 0)} Dakika Kaldı").ToArray()); //burda Math.Max 0 dan düşük olunca eksiye girmesini engeller

        }

        private void dairesiComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            tutarTextBox.Enabled = dairesiComboBox.SelectedIndex != -1;
            odemeAlButton.Enabled = dairesiComboBox.SelectedIndex != -1;
            if (dairesiComboBox.SelectedIndex != -1) AileReisiBilgisiAktar();
        }

        private void AileReisiBilgisiAktar()
        {
            int index = dairesiComboBox.SelectedIndex;
            var aileReisi = _mekanYonetim.Daireler[index].DairedeOturanlar.Find(d => d.GetType().Name == "AileReisi"); //seçilen dairedeki aile reisini bana bul
            if (aileReisi is null)
            {
                KutulariSifirla();
                MessageBox.Show($"{_mekanYonetim.Daireler[index].DaireNo} nolu dairenin Aile Reisi bulunmadığından bu daire için ödeme yapamazsınız", "Daire Seçilemedi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            adiTextBox.Text = aileReisi.Adi;
            soyadiTextBox.Text = aileReisi.Soyadi;
            yasiTextBox.Text = aileReisi.Yas.ToString();
            tcsiTextBox.Text = aileReisi.TCNo;

            if (aileReisi is AileReisi ar) //Aile Reisinin tipine kesin olarak karar veriyoruz
            {
                if (ar.Odemesi is null) kalanBorcTextBox.Text = (HizmetYonetim.DaireUcreti + (HizmetYonetim.EkKisiUcreti * ar.Dairesi.KisiSayisi)).ToString();
                else kalanBorcTextBox.Text = (HizmetYonetim.DaireUcreti + (HizmetYonetim.EkKisiUcreti * ar.Dairesi.KisiSayisi) - ar.Odemesi.ToplamOdenenPara).ToString();

                if (Convert.ToDouble(kalanBorcTextBox.Text) < 0) kalanBorcTextBox.Text = "0";

                if (kalanBorcTextBox.Text == "0")
                {
                    tutarTextBox.Enabled = false;
                    odemeAlButton.Enabled = false;
                }
            }
        }



        private bool OdemeEkleHataVarMi()
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

        private void KutulariSifirla()
        {
            adiTextBox.Text = "";
            soyadiTextBox.Text = "";
            yasiTextBox.Text = "";
            tcsiTextBox.Text = "";
            tutarTextBox.Text = "";
            kalanBorcTextBox.Text = "";
            dairesiComboBox.SelectedIndex = -1;
            tutarTextBox.Enabled = dairesiComboBox.SelectedIndex != -1;
            odemeAlButton.Enabled = dairesiComboBox.SelectedIndex != -1;

        }

        private void odemelerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            odemeDuzenleButton.Enabled = odemelerListBox.SelectedIndex != -1;
            odemeSilButton.Enabled = odemelerListBox.SelectedIndex != -1;
        }



        private void yenileButton_Click(object sender, EventArgs e)
        {
            OdemeListBoxGuncelle();
            _odemeYonetim.AbonelikKontrol();
        }

        private void geriButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OdemeYonetimForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Capture = false;
                Message m = Message.Create(Handle, 0xA1, new IntPtr(2), IntPtr.Zero);
                this.WndProc(ref m);
            }
        }

        private void tutarTextBox_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void odemeListesiTabPage_Click(object sender, EventArgs e)
        {

        }

        private void OdemeYonetimForm_Load(object sender, EventArgs e)
        {

            odemeYokLabel.Visible = _odemeYonetim.Odemeler.Count == 0;
        }
    }
}
