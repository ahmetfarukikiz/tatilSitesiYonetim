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

namespace _ndp_proje_yariyil2;

public partial class KisiDuzenleForm : Form
{

    private int _kisiIndex;
    private KisiYonetim _kisiYonetim;
    private MekanYonetim _mekanYonetim;
    private Daire _eskiDairesi;
    public KisiDuzenleForm(int index, KisiYonetim kisiYonetim, MekanYonetim mekanYonetim)
    {
        _kisiYonetim = kisiYonetim;
        _mekanYonetim = mekanYonetim;
        _kisiIndex = index;
        InitializeComponent();

        dairesiComboBox.Items.AddRange(_mekanYonetim.Daireler.Select(d => $"Daire {d.DaireNo} - {d.KisiSayisi}/{d.MaxKisiSayisi}").ToArray());
        duzenleniyorLabel.Text = $"{_kisiYonetim.Oturanlar[_kisiIndex].Adi} {_kisiYonetim.Oturanlar[_kisiIndex].Soyadi} kişisi düzenleniyor";
        adiTextBox.Text = $"{_kisiYonetim.Oturanlar[_kisiIndex].Adi}";
        soyadiTextBox.Text = $"{_kisiYonetim.Oturanlar[_kisiIndex].Soyadi}";
        yasiTextBox.Text = $"{_kisiYonetim.Oturanlar[_kisiIndex].Yas}";
        tcsiTextBox.Text = $"{_kisiYonetim.Oturanlar[_kisiIndex].TCNo}";

        _eskiDairesi = _mekanYonetim.Daireler.First(d => d.DaireNo == _kisiYonetim.Oturanlar[index].Dairesi.DaireNo);  //_kisiIndex in dairesi bulunuyor  
        int daireIndex = _mekanYonetim.Daireler.FindIndex(d => d.DaireNo == _eskiDairesi.DaireNo); //sonrasında o dairenin Daireler listesindeki indexi bulunuyor
        dairesiComboBox.SelectedIndex = daireIndex;

        if (_kisiYonetim.Oturanlar[_kisiIndex].GetType().Name == "AileReisi") aileReisiRadioBtn.Checked = true;
        if (_kisiYonetim.Oturanlar[_kisiIndex].GetType().Name == "Misafir") misafirRadioBtn.Checked = true;
    }


    private async void kisiDuzenleButton_Click(object sender, EventArgs e)
    {
        if (KisiDuzenleHataVarMi()) return; //hataVarMi true ise işlemi durdurur

        Daire seciliDaire = _mekanYonetim.Daireler[dairesiComboBox.SelectedIndex];
        Oturan yeniKisi;

        if (aileReisiRadioBtn.Checked == true)
        {
            yeniKisi = new AileReisi(adiTextBox.Text, soyadiTextBox.Text, Convert.ToInt32(yasiTextBox.Text), tcsiTextBox.Text, seciliDaire);
        }
        else
        {
            yeniKisi = new Misafir(adiTextBox.Text, soyadiTextBox.Text, Convert.ToInt32(yasiTextBox.Text), tcsiTextBox.Text, seciliDaire);
        }

        

        bool basarili;

        basarili = _kisiYonetim.Duzenle(_kisiIndex, yeniKisi);  
        _kisiYonetim.DairedekiKisileriGuncelle(_mekanYonetim.Daireler);
        _kisiYonetim.DosyaGuncelle();
        

        if (basarili == false) return;

        kisiDuzenleButton.Enabled = false;
        kisiDuzenleButton.Text = "Kişi Düzenlendi";
        await Task.Delay(1000);
        this.Close();
    }


    private void geriButton_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private bool KisiDuzenleHataVarMi()
    {
        bool hatali = false;

        if (string.IsNullOrWhiteSpace(adiTextBox.Text))
        {
            errorProvider1.SetError(adiTextBox, "Bu kısım boş bırakılamaz");
            hatali = true;
        }
        else
        {
            errorProvider1.SetError(adiTextBox, "");
        }

        if (string.IsNullOrWhiteSpace(soyadiTextBox.Text))
        {
            errorProvider1.SetError(soyadiTextBox, "Bu kısım boş bırakılamaz");
            hatali = true;
        }
        else
        {
            errorProvider1.SetError(soyadiTextBox, "");
        }


        if (!int.TryParse(yasiTextBox.Text, out int yas) || yas <= 0)
        {
            errorProvider1.SetError(yasiTextBox, "0'dan büyük bir sayı giriniz");
            hatali = true;
        }
        else
        {
            errorProvider1.SetError(yasiTextBox, "");
        }


        if (!long.TryParse(tcsiTextBox.Text, out long tcsi) || tcsi < 10000000000 || tcsi > 99999999999)
        {
            errorProvider1.SetError(tcsiTextBox, "11 basamaklı bir sayı giriniz");
            hatali = true;
        }
        else
        {
            errorProvider1.SetError(tcsiTextBox, "");
        }


        if (hatali)
        {
            return true; // Hatalı giriş varsa true döndürür
        }

        return false; // hatasız ise yanlış döndürür
    }

  
}
