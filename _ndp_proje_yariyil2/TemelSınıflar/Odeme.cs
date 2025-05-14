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
namespace _ndp_proje_yariyil2.TemelSınıflar
{
    public class Odeme
    {
        public event EventHandler OdemeDegisti;     

        public Odeme(double OdenenPara, AileReisi odemeYapan)
        {
            OdemeTarihi = DateTime.Now;
            BitisTarihi = DateTime.Now; //henüz ödeme tamamlanmadığından 0 gün var mantığı
            ToplamOdenenPara = OdenenPara;
            OdemeYapan = odemeYapan;
        }

        public Odeme(double OdenenPara, AileReisi odemeYapan, DateTime bitisTarihi)
        {
            BitisTarihi = bitisTarihi;
            ToplamOdenenPara = OdenenPara;
            OdemeYapan = odemeYapan;
        }

        public AileReisi OdemeYapan { get; set; }
        public DateTime OdemeTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }

        

        private double _toplamOdenenPara;
        public double ToplamOdenenPara 
        { 
            get => _toplamOdenenPara; 
            set { 
                _toplamOdenenPara = value;
                OdemeDegisti?.Invoke(this, EventArgs.Empty); //solu sonradan ekledim
            }
        }


        



    }
}
