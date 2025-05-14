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

namespace _ndp_proje_yariyil2.HizmetFormları;

public partial class HizmetYonetimForm : Form
{
    private MekanYonetim _mekanYonetim;
    private KisiYonetim _kisiYonetim;
    private OdemeYonetim _odemeYonetim;
    private HavuzYonetim _havuzYonetim;
    private FitnessYonetim _fitnessYonetim;
    public HizmetYonetimForm(MekanYonetim mekanYonetim, KisiYonetim kisiYonetim, OdemeYonetim odemeYonetim, HavuzYonetim havuzYonetim, FitnessYonetim fitnessYonetim)
    {
        InitializeComponent();
        _mekanYonetim = mekanYonetim;
        _kisiYonetim = kisiYonetim;
        _odemeYonetim = odemeYonetim;
        _havuzYonetim = havuzYonetim;
        _fitnessYonetim = fitnessYonetim;

        _odemeYonetim.AbonelikKontrol();


        RichTextBoxGuncelle();
        MekanBilgileriGetir();
    }



    private async void sorgulaButton_Click(object sender, EventArgs e)
    {
        bool kullandirilsin;
        string buttonYazisi;
        Color buttonRengi;
        Color eskiButtonRengi = SorgulaButton.BackColor;

        var secilenKisi = _mekanYonetim.Daireler[daireCbx1.SelectedIndex].DairedeOturanlar[kisiCbx1.SelectedIndex];
        if (secilenKisi.Dairesi.BorcOdendi == false)
        {
            kullandirilsin = false;
            buttonYazisi = "Kullandırılmadı";
            buttonRengi = Color.FromArgb(155, 41, 41);
        }
        else
        {
            kullandirilsin = true;
            buttonYazisi = "Kullandırıldı";
            buttonRengi = Color.FromArgb(41, 155, 41);
        }

        if (havuzRadioButton.Checked == true)
        {
            _havuzYonetim.Ekle(secilenKisi, kullandirilsin);
            _havuzYonetim.DosyaGuncelle();

        }
        if (fitnessRadioButton.Checked == true)
        {
            _fitnessYonetim.Ekle(secilenKisi, kullandirilsin);
            _fitnessYonetim.DosyaGuncelle();
        }

        SorgulaButton.Enabled = false;
        SorgulaButton.Text = buttonYazisi;
        SorgulaButton.BackColor = buttonRengi;
        await Task.Delay(1000);
        SorgulaButton.BackColor = eskiButtonRengi;
        SorgulaButton.Text = "Sorgula";

        KutulariSifirla();
        RichTextBoxGuncelle();

    }

    private void HizmetYonetimForm_Load(object sender, EventArgs e)
    {
        daireCbx1.Items.AddRange(_mekanYonetim.Daireler.Select(d => $"Daire{d.DaireNo}    {d.KisiSayisi}/{d.MaxKisiSayisi}").ToArray());
    }


    private void daireCbx1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (daireCbx1.SelectedIndex == -1) return;
        var seciliDaire = _mekanYonetim.Daireler[daireCbx1.SelectedIndex];
        if (seciliDaire.DairedeOturanlar.Count == 0)
        {
            KutulariSifirla();
            MessageBox.Show("Bu Daire Boş", "Daire Seçilemedi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        kisiCbx1.Enabled = true;
        KisiComboBoxGuncelle(seciliDaire);

    }

    private void kisiCbx1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (kisiCbx1.SelectedIndex == -1) return;
        havuzRadioButton.Enabled = true;
        fitnessRadioButton.Enabled = true;
    }

    private void KisiComboBoxGuncelle(Daire seciliDaire)
    {
        kisiCbx1.Items.Clear();
        kisiCbx1.Items.AddRange(seciliDaire.DairedeOturanlar.Select(d => $"{d.Adi} {d.Soyadi}").ToArray());
        kisiCbx1.SelectedIndex = -1;
    }

    private void KutulariSifirla()
    {
        SorgulaButton.Enabled = false;
        daireCbx1.SelectedIndex = -1;
        kisiCbx1.SelectedIndex = -1;
        kisiCbx1.Enabled = false;
        havuzRadioButton.Enabled = false;
        fitnessRadioButton.Enabled = false;
        havuzRadioButton.Checked = false;
        fitnessRadioButton.Checked = false;
    }

    private void RichTextBoxGuncelle()
    {
        havuzRich.Text = "";
        fitnessRich.Text = "";

        foreach (var havuzSatir in _havuzYonetim.HavuzString)
        {
            havuzRich.Text += havuzSatir + "\n";
        }

        foreach (var fitnessSatir in _fitnessYonetim.FitnessString)
        {
            fitnessRich.Text += fitnessSatir + "\n";
        }
    }



    private void geriButton1_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void RadioButton_CheckedChanged(object sender, EventArgs e)
    {
        if (!(havuzRadioButton.Checked == true || fitnessRadioButton.Checked == true)) return;
        SorgulaButton.Enabled = true;
    }

    private void HizmetYonetimForm_MouseDown(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            Capture = false;
            Message m = Message.Create(Handle, 0xA1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }
    }

    private void havuzTemizleButton_Click(object sender, EventArgs e)
    {
        havuzRich.Text = "";
        _havuzYonetim.HavuzString.Clear();
        _havuzYonetim.DosyaGuncelle();
    }

    private void fitnessTemizleButton_Click(object sender, EventArgs e)
    {
        fitnessRich.Text = "";
        _fitnessYonetim.FitnessString.Clear();
        _fitnessYonetim.DosyaGuncelle();
    }

    #region tab3(mekan işlemleri)

    private void MekanBilgileriGetir()
    {

        havuzAlanText.Text = _mekanYonetim.Havuzu.Alan.ToString();
        havuzDerinlikText.Text = _mekanYonetim.Havuzu.Derinlik.ToString();

        fitnessAlanText.Text = _mekanYonetim.Fitnessi.Alan.ToString();

    }

    private void havuzDuzenleButton_Click(object sender, EventArgs e)
    {
        havuzAlanText.Enabled = true;
        havuzDerinlikText.Enabled = true;
        havuzDuzenleButton.Enabled = false;
        havuzKaydetButton.Enabled = true;

    }

    private void fitnessDuzenleButton_Click(object sender, EventArgs e)
    {
        fitnessAlanText.Enabled = true;
        fitnessDuzenleButton.Enabled = false;
        fitnessKaydetButton.Enabled = true;
    }

    private async void havuzKaydetButton_Click(object sender, EventArgs e)
    {
        if (HavuzDuzenleHataVarMi()) return; //hataVarMi true ise işlemi durdurur

        _mekanYonetim.Havuzu.Duzenle(Convert.ToInt32(havuzAlanText.Text), Convert.ToInt32(havuzDerinlikText.Text));

        havuzKaydetButton.Enabled = false;
        havuzKaydetButton.Text = "Kaydedildi";
        await Task.Delay(1000);
        havuzKaydetButton.Text = "Kaydet";

        _mekanYonetim.DosyaGuncelle();

        havuzAlanText.Enabled = false;
        havuzDerinlikText.Enabled = false;
        havuzDuzenleButton.Enabled = true;
        havuzKaydetButton.Enabled = false;
    }

    private async void fitnessKaydetButton_Click(object sender, EventArgs e)
    {
        if (FitnessDuzenleHataVarMi()) return; //hataVarMi true ise işlemi durdurur

        _mekanYonetim.Fitnessi.Duzenle(Convert.ToInt32(fitnessAlanText.Text));

        fitnessKaydetButton.Enabled = false;
        fitnessKaydetButton.Text = "Kaydedildi";
        await Task.Delay(1000);
        fitnessKaydetButton.Text = "Kaydet";

        _mekanYonetim.DosyaGuncelle();

        fitnessAlanText.Enabled = false;
        fitnessDuzenleButton.Enabled = true;
        fitnessKaydetButton.Enabled = false;
    }

    private bool HavuzDuzenleHataVarMi()
    {
        bool hatali = false;

        if (!int.TryParse(havuzAlanText.Text, out int alan) || alan <= 0)
        {
            errorProvider1.SetError(havuzAlanText, "0'dan büyük bir sayı giriniz");
            hatali = true;
        }
        else
        {
            errorProvider1.SetError(havuzAlanText, "");
        }

        if (!int.TryParse(havuzDerinlikText.Text, out int derinlik) || derinlik <= 0)
        {
            errorProvider1.SetError(havuzDerinlikText, "0'dan büyük bir sayı giriniz");
            hatali = true;
        }
        else
        {
            errorProvider1.SetError(havuzDerinlikText, "");
        }


        if (hatali)
        {
            return true; // Hatalı giriş varsa true döndürür
        }

        return false; // hatasız ise yanlış döndürür
    }

    private bool FitnessDuzenleHataVarMi()
    {
        bool hatali = false;

        if (!int.TryParse(fitnessAlanText.Text, out int alan) || alan <= 0)
        {
            errorProvider1.SetError(fitnessAlanText, "0'dan büyük bir sayı giriniz");
            hatali = true;
        }
        else
        {
            errorProvider1.SetError(fitnessAlanText, "");
        }


        if (hatali)
        {
            return true; // Hatalı giriş varsa true döndürür
        }

        return false; // hatasız ise yanlış döndürür
    }
    #endregion

    private void havuzDerinlikText_MouseClick(object sender, MouseEventArgs e)
    {
        var textbox = (MaskedTextBox)sender;
        if (textbox.Text != "") return; //sadece boşsa başa alsın
        textbox.SelectionStart = 0;
    }
}
