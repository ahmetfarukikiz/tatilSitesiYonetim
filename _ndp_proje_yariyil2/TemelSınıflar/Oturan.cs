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
public abstract class Oturan
{
    protected Oturan(string adi, string soyadi, int yas, string tcKimlikNo, Daire dairesi)
    {
        Adi = adi;
        Soyadi = soyadi;
        Yas = yas;
        Dairesi = dairesi;
        TCNo = tcKimlikNo;

    }

    #region Properties
    public string Adi { get; private set; }
    public string Soyadi { get; private set; }
    public int Yas { get; private set; }
    public string TCNo { get; private set; }
    public Daire Dairesi { get; private set; }
    #endregion


}
    
public class AileReisi : Oturan
{

    public Odeme? Odemesi { get; set; } 

    public AileReisi(string adi, string soyadi, int yas,string tcKimlikNo, Daire dairesi) : base(adi, soyadi, yas, tcKimlikNo,dairesi) {  }


}

public class Misafir : Oturan
{
    public Misafir(string adi, string soyadi, int yas,string tckimlikNo, Daire dairesi) : base(adi, soyadi, yas, tckimlikNo, dairesi)  { }


}




