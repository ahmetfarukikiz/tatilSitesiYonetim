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

namespace _ndp_proje_yariyil2
{
    public abstract class DosyaIslemleri
    {
        public string DosyaAdi { get; private set; }

        public DosyaIslemleri(string dosyaadi)
        {
            DosyaAdi = dosyaadi;
        }

        abstract public void DosyaGuncelle();
    
       


    }
}
