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

namespace _ndp_proje_yariyil2.YönetimSınıfları
{
    public abstract class HizmetYonetim(string dosyaYolu) : DosyaIslemleri(dosyaYolu)
    {
        
        public static double DaireUcreti = 5000;
        public static double EkKisiUcreti = 1200;

        public abstract void Ekle(Oturan oturan, bool kullandirildi);
        
        public static void AyarlarTxtGuncelle()
        {
            string ayarVerisi = $"{DaireUcreti}\t{EkKisiUcreti}";
            File.WriteAllText("Ayarlar.txt",ayarVerisi);
        }

        public static void AyarlarTxtdenYukle()
        {
            if (!File.Exists("Ayarlar.txt")) return; //dosya yoksa hiç çalışmasın 

            var ayarVerisi = File.ReadAllText("Ayarlar.txt");
            var parcalar = ayarVerisi.Split('\t');

            if (parcalar.Length == 2)
            {
                DaireUcreti = Convert.ToDouble(parcalar[0]);
                EkKisiUcreti = Convert.ToDouble(parcalar[1]);
            }

            else { MessageBox.Show("Dosyalarda bazı hatalı kısımlar bulundu ve temizlendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

    }

    public class HavuzYonetim : HizmetYonetim
    {
        public List<string> HavuzString { get; private set; } = new List<string>();
        public HavuzYonetim() : base("HavuzKul.txt")
        {
        }

        public override void Ekle(Oturan oturan, bool kullandirildi)
        {
            if (kullandirildi == true) HavuzString.Add($"{oturan.Adi} {oturan.Soyadi} kişisine kullandırıldı  {DateTime.Now.ToString("dd.MM.yyyy HH:mm")}");
            else if (kullandirildi == false) HavuzString.Add($"{oturan.Adi} {oturan.Soyadi} kişisine kullandırılmadı  {DateTime.Now.ToString("dd.MM.yyyy HH:mm")}");
        }

        public override void DosyaGuncelle()
        {
            File.WriteAllLines(DosyaAdi, HavuzString);
        }

        public void DosyadanYukle()
        {
            if (!File.Exists(DosyaAdi)) return; //dosya yoksa hiç çalışmasın 

            HavuzString = File.ReadAllLines(DosyaAdi).ToList();
        }

    }

    public class FitnessYonetim : HizmetYonetim
    {
        public List<string> FitnessString { get; private set; } = new List<string>();
        public FitnessYonetim() : base("FitnessKul.txt")
        {
        }

        public override void Ekle(Oturan oturan, bool kullandirildi)
        {
            if (kullandirildi == true) FitnessString.Add($"{oturan.Adi} {oturan.Soyadi} kişisine kullandırıldı  {DateTime.Now.ToString("dd.MM.yyyy HH:mm")}");
            else if (kullandirildi == false) FitnessString.Add($"{oturan.Adi} {oturan.Soyadi} kişisine kullandırılmadı  {DateTime.Now.ToString("dd.MM.yyyy HH:mm")}");
        }

        public override void DosyaGuncelle()
        {
            File.WriteAllLines(DosyaAdi, FitnessString);
        }

        public void DosyadanYukle()
        {
            if (!File.Exists(DosyaAdi)) return; //dosya yoksa hiç çalışmasın 

            FitnessString = File.ReadAllLines(DosyaAdi).ToList();
        }



    }
}
