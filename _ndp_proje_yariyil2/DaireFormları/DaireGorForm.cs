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
using System.Data;

namespace _ndp_proje_yariyil2;

public partial class DaireGorForm : Form
{

    private readonly Daire _daire;
    public DaireGorForm(Daire daire)
    {
        _daire = daire;
        InitializeComponent();
        daireBosLabel.BackColor = dairedeOturanlarListBox.BackColor;
        label2.Text = "Daire " + _daire.DaireNo.ToString();
    }
    
   private void DaireGorForm_Load(object sender, EventArgs e)
   {
        if (_daire.DairedeOturanlar.Count == 0) { daireBosLabel.Visible = true; return; }

        dairedeOturanlarListBox.Items.Clear();
        dairedeOturanlarListBox.Items.AddRange(_daire.DairedeOturanlar.Select(d => $"{d.Adi} {d.Soyadi}\t{d.Yas}\t{d.TCNo}\t{d.GetType().Name}").ToArray());

    }


    private void geriButton_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}

