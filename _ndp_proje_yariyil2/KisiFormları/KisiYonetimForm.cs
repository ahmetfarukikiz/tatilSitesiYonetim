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

public partial class KisiYonetimForm : Form
{

    private KisiYonetim _kisiYonetim;
    private MekanYonetim _mekanYonetim;
    private OdemeYonetim _odemeYonetim;

    public KisiYonetimForm(KisiYonetim kisiYonetim, MekanYonetim mekanYonetim, OdemeYonetim odemeYonetim)
    {
        InitializeComponent();
        _kisiYonetim = kisiYonetim;
        _mekanYonetim = mekanYonetim;
        KutulariSifirla(); //comboBox a burda ekleme yapılyıor
        _odemeYonetim = odemeYonetim;
    }

    private void KutulariSifirla()
    {
        dairesiComboBox.Items.Clear();
        adiTextBox.Text = "";
        soyadiTextBox.Text = "";
        yasiTextBox.Text = "";
        tcsiTextBox.Text = "";
        aileReisiRadioBtn.Checked = false;
        misafirRadioBtn.Checked = false;
        dairesiComboBox.Items.AddRange(_mekanYonetim.Daireler.Select(d => $"Daire {d.DaireNo} - {d.KisiSayisi}/{d.MaxKisiSayisi}").ToArray()); //Kişi eklerken Daire seçimi yapılan comboBox ı günceller

    }

    private void KisiYonetimForm_Load(object sender, EventArgs e)
    {
        kisiEkleButton.Enabled = false;

        duzenleSilGörButtonKontrol();
        KisiListBoxGuncelle((a, b) => a.Adi.CompareTo(b.Adi));
        _kisiYonetim.DosyaGuncelle();

        if (_kisiYonetim.Oturanlar.Count == 0) kisiYokLabel.Visible = true;

    }

    private void KisiListBoxGuncelle(Comparison<Oturan> fonksiyon) //overloading sıralamalı  
    {   //Comparison: Func<Oturan,Oturan,int> gibi çalışan hazır bir delegate

        _kisiYonetim.Oturanlar.Sort(fonksiyon); //gönderdiğim fonksiyona göre sıralama yapıyor

        kisilerListBox.Items.Clear();
        kisilerListBox.Items.AddRange(_kisiYonetim.Oturanlar.Select(d =>
        $"{(d.Adi + " " + d.Soyadi).PadRight(19)}" +
        $"{d.Yas.ToString().PadLeft(3)}" +
        $"{d.TCNo.PadLeft(16)}" +
        $"{d.Dairesi.DaireNo.ToString().PadLeft(6)}" +
        $"{d.GetType().Name.PadLeft(15)}").ToArray());

    }
    private void KisiListBoxGuncelle() //overloading sıralamasız
    {
        kisilerListBox.Items.Clear();
        kisilerListBox.Items.AddRange(_kisiYonetim.Oturanlar.Select(d =>
        $"{(d.Adi + " " + d.Soyadi).PadRight(19)}" +
        $"{d.Yas.ToString().PadLeft(3)}" +
        $"{d.TCNo.PadLeft(16)}" +
        $"{d.Dairesi.DaireNo.ToString().PadLeft(6)}" +
        $"{d.GetType().Name.PadLeft(15)}").ToArray());
    }

    private async void kisiEkleButton_Click(object sender, EventArgs e)
    {
        if (KisiEkleHataVarMi()) return; //hataVarMi true ise işlemi durdurur


        bool eklendi;

        Daire seciliDaire = _mekanYonetim.Daireler[dairesiComboBox.SelectedIndex];

        if (seciliDaire.MaxKisiSayisi <= seciliDaire.KisiSayisi) { MessageBox.Show("Oda Dolu", "Kayıt Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error); return; } //oda sınır kontrolü

        string oturanTipi;

        if (aileReisiRadioBtn.Checked) oturanTipi = "AileReisi";
        else oturanTipi = "Misafir";

        if (seciliDaire.DairedeOturanlar.Any(d => d.GetType().Name == "AileReisi") && oturanTipi == "AileReisi") { MessageBox.Show("Bu odada zaten bir Aile Reisi var", "Kayıt Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error); return; } //1 tane aile reisi olsun kontrolü

        eklendi = _kisiYonetim.Ekle(oturanTipi, adiTextBox.Text.Trim(), soyadiTextBox.Text.Trim(), Convert.ToInt32(yasiTextBox.Text.Trim()), tcsiTextBox.Text, seciliDaire);

        if (eklendi == false) return;

        _kisiYonetim.DairedekiKisileriGuncelle(_mekanYonetim.Daireler);
        _kisiYonetim.DosyaGuncelle();

        KisiListBoxGuncelle((a, b) => a.Adi.CompareTo(b.Adi));

        if (_kisiYonetim.Oturanlar.Count != 0) kisiYokLabel.Visible = false;
        _kisiYonetim.DosyaGuncelle();

        kisiEkleButton.Enabled = false;
        kisiEkleButton.Text = "Kişi Eklendi";
        await Task.Delay(1000);
        KutulariSifirla();
        kisiEkleButton.Text = "Kayıt Et";
    }

    private void kisiSilButton_Click(object sender, EventArgs e)
    {
        int index = kisilerListBox.SelectedIndex;
        var silinecekKisi = _kisiYonetim.Oturanlar[index];

        DialogResult silinecekResult = MessageBox.Show($"{silinecekKisi.Adi} {silinecekKisi.Soyadi} Kişisi Silinecek", "Emin Misiniz?", MessageBoxButtons.YesNo);

        if (silinecekResult == DialogResult.No) return;

        _kisiYonetim.Sil(index);
        _kisiYonetim.DairedekiKisileriGuncelle(_mekanYonetim.Daireler);
        KisiListBoxGuncelle();
        KutulariSifirla();
        _kisiYonetim.DosyaGuncelle();
        duzenleSilGörButtonKontrol();

        if (silinecekKisi is AileReisi ar)
        {
            _odemeYonetim.OdemesiniSil(ar.Odemesi);
        }

    }

    private void kisiDuzenleButton_Click(object sender, EventArgs e)
    {
        int index = kisilerListBox.SelectedIndex;

        KisiDuzenleForm kisiDuzenleForm = new KisiDuzenleForm(index, _kisiYonetim, _mekanYonetim);
        kisiDuzenleForm.ShowDialog();

        _kisiYonetim.DairedekiKisileriGuncelle(_mekanYonetim.Daireler);


        KisiListBoxGuncelle();
        KutulariSifirla();
        _odemeYonetim.DosyadanYukle(_kisiYonetim);

        duzenleSilGörButtonKontrol();
    }

    private bool KisiEkleHataVarMi()
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

    private void dairesiComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        kisiEkleButton.Enabled = ( //tuşun aktif olması için hem daireComboBox hem de radioBtn lardan biri seçili olmalı
                                     (dairesiComboBox.SelectedIndex != -1) &&
                                     (aileReisiRadioBtn.Checked || misafirRadioBtn.Checked)
                                 );
    }

    private void aileReisiRadioBtn_CheckedChanged(object sender, EventArgs e)
    {
        kisiEkleButton.Enabled = (//tuşun aktif olması için hem daireComboBox hem de radioBtn lardan biri seçili olmalı
                                     (dairesiComboBox.SelectedIndex != -1) &&
                                     (aileReisiRadioBtn.Checked || misafirRadioBtn.Checked)
                                 );
    }

    private void misafirRadioBtn_CheckedChanged(object sender, EventArgs e)
    {
        kisiEkleButton.Enabled = (//tuşun aktif olması için hem daireComboBox hem de radioBtn lardan biri seçili olmalı
                                     (dairesiComboBox.SelectedIndex != -1) &&
                                     (aileReisiRadioBtn.Checked || misafirRadioBtn.Checked)
                                 );
    }

    private void textBoxMouseClickEvent(object sender, MouseEventArgs e) //maskedTextBox'lara tıklandığında yazma yerini en başa alır
    {
        var textbox = (MaskedTextBox)sender;
        if (textbox.Text != "") return; //sadece boşsa başa alsın
        textbox.SelectionStart = 0;
    }

    private void kisilerListBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        kisiGörButton.Enabled = kisilerListBox.SelectedIndex != -1;
        kisiSilButton.Enabled = kisilerListBox.SelectedIndex != -1;
        kisiDuzenleButton.Enabled = kisilerListBox.SelectedIndex != -1;
    }


    //bastığın tuşa göre kişi listesini sıralar
    //default olarak ada göre sıralar
    #region Sıralama Methodları


    private void adButton_Click(object sender, EventArgs e)
    {
        KisiListBoxGuncelle((a, b) => a.Adi.CompareTo(b.Adi));
        duzenleSilGörButtonKontrol();
    }

    private void yasButton_Click(object sender, EventArgs e)
    {
        KisiListBoxGuncelle((a, b) => b.Yas.CompareTo(a.Yas)); //yasta büyükler üste gelsin diye ters yazdım
        duzenleSilGörButtonKontrol();
    }

    private void tcButton_Click(object sender, EventArgs e)
    {
        KisiListBoxGuncelle((a, b) => a.TCNo.CompareTo(b.TCNo));
        duzenleSilGörButtonKontrol();
    }


    private void daireNoButton_Click(object sender, EventArgs e)
    {
        KisiListBoxGuncelle((a, b) => a.Dairesi.DaireNo.CompareTo(b.Dairesi.DaireNo));
        duzenleSilGörButtonKontrol();
    }

    private void tipButton_Click(object sender, EventArgs e)
    {
        KisiListBoxGuncelle((a, b) => a.GetType().Name.CompareTo(b.GetType().Name));
        duzenleSilGörButtonKontrol();
    }

    private void duzenleSilGörButtonKontrol()
    {
        kisiGörButton.Enabled = kisilerListBox.SelectedIndex != -1;
        kisiSilButton.Enabled = kisilerListBox.SelectedIndex != -1;
        kisiDuzenleButton.Enabled = kisilerListBox.SelectedIndex != -1;
    }

    #endregion

    private void geriButton_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void KisiYonetimForm_MouseDown(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            Capture = false;
            Message m = Message.Create(Handle, 0xA1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }
    }
}
