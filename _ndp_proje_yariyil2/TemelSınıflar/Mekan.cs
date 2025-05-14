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

namespace _ndp_proje_yariyil2.TemelSınıflar;

public abstract class Mekan
{
    public int Alan { get; protected set; }
}

public class Daire : Mekan
{

    public Daire(int daireNo,int alan, int maxKisiSayisi)
    {
        DaireNo = daireNo;
        Alan = alan;
        MaxKisiSayisi = maxKisiSayisi;
    }

    public Daire(int daireNo, int alan, int maxKisiSayisi, bool borcOdendi)
    {
        DaireNo = daireNo;
        Alan = alan;
        MaxKisiSayisi = maxKisiSayisi;
        BorcOdendi = borcOdendi;
    }



    #region Properties

    public List<Oturan> DairedeOturanlar { get; set; } = new List<Oturan>();

    public int DaireNo { get; private set; }

    public bool BorcOdendi { get; set; } = false;

    
    public int MaxKisiSayisi { get; private set; }
    public int KisiSayisi { get; set; } = 0;
    #endregion

    #region Functions

    public void DaireGuncelle(Daire yeniDaire) //aldığı yeni daire paramteresine göre dairenin değerlerini günceller
    {
        MaxKisiSayisi = yeniDaire.MaxKisiSayisi;
        DaireNo = yeniDaire.DaireNo;
        Alan = yeniDaire.Alan;
    }

    #endregion
}

abstract public class HizmetYeri : Mekan
{

    public HizmetYeri(int alan)
    {
        Alan = alan;
    }

    public HizmetYeri() //default değer
    {
    }


}

public class Havuz : HizmetYeri
{

    public int Derinlik { get; private set; }

    public void Duzenle(int alan,int derinlik)
    {
        Alan = alan;
        Derinlik = derinlik;
    }

    public Havuz(int alan,int derinlik) : base(alan) {
        Derinlik = derinlik;
    }

    public Havuz() : base() //default değer
    {
    
    }

}

public class Fitness : HizmetYeri
{
    public Fitness(int alan) : base(alan) { }

    public Fitness() : base() //default değer
    {

    }

    public void Duzenle(int alan)
    {
        Alan = alan;
    }
}
