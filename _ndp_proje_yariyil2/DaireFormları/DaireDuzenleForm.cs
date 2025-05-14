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

namespace _ndp_proje_yariyil2;

public partial class DaireDuzenleForm : Form
{
    private int _index;
    private MekanYonetim _mekanYonetim;

    public DaireDuzenleForm(int index, MekanYonetim mekanYonetim)
    {
        _index = index;
        _mekanYonetim = mekanYonetim;
        InitializeComponent();
        duzenleniyorLabel.Text = $"Daire {_mekanYonetim.Daireler[_index].DaireNo} düzenleniyor";
        daireNoTextBox.Text = $"{_mekanYonetim.Daireler[_index].DaireNo}";
        AlanTextBox.Text = $"{_mekanYonetim.Daireler[_index].Alan}";
        kisiSayisiTextBox.Text = $"{_mekanYonetim.Daireler[_index].MaxKisiSayisi}";
    }

    private void textBoxMouseClickEvent(object sender, MouseEventArgs e) //maskedTextBox'lara tıklandığında yazma yerini en başa alır
    {
        var textbox = (MaskedTextBox)sender;
        if (textbox.Text != "") return; //sadece boşsa başa alsın
        textbox.SelectionStart = 0;
    }

    private async void daireDuzenleButton_Click(object sender, EventArgs e)
    {
        if (DaireDuzenleHataVarMi()) return; //hataVarMi true ise işlemi durdurur

        Daire yeniDaire = new Daire(Convert.ToInt32(daireNoTextBox.Text), Convert.ToInt32(AlanTextBox.Text), Convert.ToInt32(kisiSayisiTextBox.Text));

        bool basarili;

        basarili = _mekanYonetim.Duzenle(_index, yeniDaire);

        if (basarili == false) return;

        daireDuzenleButton.Enabled = false;
        daireDuzenleButton.Text = "Daire Düzenlendi";
        await Task.Delay(1000);
        this.Close();
    }

    private bool DaireDuzenleHataVarMi()
    {
        bool hatali = false;

        if (Convert.ToInt32(kisiSayisiTextBox.Text) < _mekanYonetim.Daireler[_index].KisiSayisi) { MessageBox.Show($"Max kişi sayısı odada bulunan kişi sayısından ({_mekanYonetim.Daireler[_index].KisiSayisi}) az olamaz", "Kişi Düzenlenemedi", MessageBoxButtons.OK, MessageBoxIcon.Error); hatali = true; }

        if (!double.TryParse(AlanTextBox.Text, out double alan) || alan <= 0)
        {
            errorProvider1.SetError(AlanTextBox, "0'dan büyük bir sayı giriniz");
            hatali = true;
        }
        else
        {
            errorProvider1.SetError(AlanTextBox, "");
        }


        if (!double.TryParse(kisiSayisiTextBox.Text, out double maxkisisayisi) || maxkisisayisi <= 0 || maxkisisayisi < _mekanYonetim.Daireler[_index].KisiSayisi)
        {
            errorProvider1.SetError(kisiSayisiTextBox, "0dan büyük bir sayı giriniz");
            hatali = true;
        }
        else
        {
            errorProvider1.SetError(kisiSayisiTextBox, "");
        }

        if (!double.TryParse(daireNoTextBox.Text, out double daireno) || daireno <= 0)
        {
            errorProvider1.SetError(daireNoTextBox, "0'dan büyük bir sayı giriniz");
            hatali = true;
        }
        else
        {
            errorProvider1.SetError(daireNoTextBox, "");
        }

        if (hatali)
        {
            return true; // Hatalı giriş varsa true döndürür
        }

        return false; // hatasız ise yanlış döndürür
    }

    private void DaireDuzenleForm_Load(object sender, EventArgs e)
    {

    }

    private void geriButton_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}
