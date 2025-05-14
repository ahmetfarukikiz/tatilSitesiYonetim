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

public partial class DaireYonetimForm : Form
{
    private MekanYonetim _mekanYonetim;
    private KisiYonetim _kisiYonetim;
    private OdemeYonetim _odemeYonetim;
    public DaireYonetimForm(MekanYonetim mekanYonetim, KisiYonetim kisiYonetim, OdemeYonetim odemeYonetim)
    {
        _mekanYonetim = mekanYonetim;
        _kisiYonetim = kisiYonetim;
        _odemeYonetim = odemeYonetim;
        InitializeComponent();
        _odemeYonetim.AbonelikKontrol();
    }

    private void DaireYonetimForm_Load(object sender, EventArgs e)
    {
        daireGörButton.Enabled = dairelerListBox.SelectedIndex != -1;
        daireSilButton.Enabled = dairelerListBox.SelectedIndex != -1;
        daireDuzenleButton.Enabled = dairelerListBox.SelectedIndex != -1;
        DaireListBoxGuncelle();
        _mekanYonetim.DosyaGuncelle();

        if (_mekanYonetim.Daireler.Count == 0) daireYokLabel.Visible = true;
    }

    private async void daireEkleButton_Click(object sender, EventArgs e)
    {
        if (DaireEkleHataVarMi()) return; //hataVarMi true ise işlemi durdurur

        bool eklendi;

        eklendi = _mekanYonetim.Ekle(Convert.ToInt32(daireNoTextBox.Text), Convert.ToInt32(AlanTextBox.Text), Convert.ToInt32(maxKisiSayisiTextBox.Text));


        if (eklendi == false) return;

        DaireListBoxGuncelle();
        if (_mekanYonetim.Daireler.Count != 0) daireYokLabel.Visible = false;
        _mekanYonetim.DosyaGuncelle();

        daireEkleButton.Enabled = false;
        daireEkleButton.Text = "Daire Eklendi";
        await Task.Delay(1000);
        daireEkleButton.Enabled = true;
        daireEkleButton.Text = "Ekle";
        daireNoTextBox.Text = (Convert.ToInt32(daireNoTextBox.Text) + 1).ToString(); //aynı daire no hata vereceğinden daireNo textini sonraki sıra numarasına çeviriyor


    }

    private void daireSilButton_Click(object sender, EventArgs e)
    {


        int index = dairelerListBox.SelectedIndex;
        Daire seciliDaire = _mekanYonetim.Daireler[index];

        DialogResult silinecek = MessageBox.Show($"{_mekanYonetim.Daireler[index].DaireNo} Nolu Daire Silinecek", "Emin Misiniz?", MessageBoxButtons.YesNo);

        if (silinecek == DialogResult.No) return;


        _kisiYonetim.DairedekileriSil(seciliDaire.DairedeOturanlar);
        _mekanYonetim.Sil(index);


        DaireListBoxGuncelle();
        if (_mekanYonetim.Daireler.Count == 0) daireYokLabel.Visible = true;
        _mekanYonetim.DosyaGuncelle();
        _kisiYonetim.DosyaGuncelle();

        daireGörButton.Enabled = dairelerListBox.SelectedIndex != -1; //hiçbir şey seçilmediyse bu tuşlar disabled olur 
        daireSilButton.Enabled = dairelerListBox.SelectedIndex != -1;
        daireDuzenleButton.Enabled = dairelerListBox.SelectedIndex != -1;


    }

    private void daireGorButton_Click(object sender, EventArgs e)
    {
        Daire seciliDaire = _mekanYonetim.Daireler[dairelerListBox.SelectedIndex];

        DaireGorForm daireGorForm = new DaireGorForm(seciliDaire);
        daireGorForm.ShowDialog();
    }

    private void daireDuzenleButton_Click(object sender, EventArgs e)
    {
        DaireDuzenleForm daireDuzenleForm = new DaireDuzenleForm(dairelerListBox.SelectedIndex, _mekanYonetim);
        daireDuzenleForm.ShowDialog();
        DaireListBoxGuncelle();
        _mekanYonetim.DosyaGuncelle();
        _kisiYonetim.DosyaGuncelle();
        daireGörButton.Enabled = dairelerListBox.SelectedIndex != -1; //hiçbir şey seçilmediyse bu tuşlar disabled olur 
        daireSilButton.Enabled = dairelerListBox.SelectedIndex != -1;
        daireDuzenleButton.Enabled = dairelerListBox.SelectedIndex != -1;
    }

    public void DaireListBoxGuncelle()
    {

        _mekanYonetim.Daireler.Sort((a, b) => a.DaireNo.CompareTo(b.DaireNo)); //Daireleri daireNo ya göre sıralar //kontrol
        dairelerListBox.Items.Clear();
        foreach (var daireler in _mekanYonetim.Daireler)
        {
            string borc;
            if (daireler.BorcOdendi == true) borc = "Borcu Yok";
            else borc = "Borcu Var";

            dairelerListBox.Items.Add($" {daireler.KisiSayisi}/{daireler.MaxKisiSayisi}\tDaire.{daireler.DaireNo}     \tAlan: {daireler.Alan}m²\t{borc} ");
        }

    }


    private bool DaireEkleHataVarMi()
    {
        bool hatali = false;

        if (!double.TryParse(AlanTextBox.Text, out double alan) || alan <= 0)
        {
            errorProvider1.SetError(AlanTextBox, "0'dan büyük bir sayı giriniz");
            hatali = true;
        }
        else
        {
            errorProvider1.SetError(AlanTextBox, "");
        }


        if (!double.TryParse(maxKisiSayisiTextBox.Text, out double kisisayisi) || kisisayisi <= 0)
        {
            errorProvider1.SetError(maxKisiSayisiTextBox, "0'dan büyük bir sayı giriniz");
            hatali = true;
        }
        else
        {
            errorProvider1.SetError(maxKisiSayisiTextBox, "");
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

    private void dairelerListBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        daireGörButton.Enabled = dairelerListBox.SelectedIndex != -1;
        daireSilButton.Enabled = dairelerListBox.SelectedIndex != -1;
        daireDuzenleButton.Enabled = dairelerListBox.SelectedIndex != -1;
    }

    private void textBoxMouseClickEvent(object sender, MouseEventArgs e) //maskedTextBox'lara tıklandığında yazma yerini en başa alır
    {
        var textbox = (MaskedTextBox)sender;
        if (textbox.Text != "") return; //sadece boşsa başa alsın
        textbox.SelectionStart = 0;
    }

    private void dairelerListBox_MouseDoubleClick(object sender, MouseEventArgs e)
    {
        daireGorButton_Click(sender, e);
    }

    private void geriButton_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void DaireYonetimForm_MouseDown(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            Capture = false;
            Message m = Message.Create(Handle, 0xA1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }
    }
}

