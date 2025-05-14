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

namespace _ndp_proje_yariyil2.YönetimSınıfları;

public class MekanYonetim : DosyaIslemleri
{
    public MekanYonetim() : base("Mekan.txt") { }

    public Fitness Fitnessi { get; private set; } = new();

    public Havuz Havuzu { get; private set; } = new();

    public List<Daire> Daireler { get; private set; } = new List<Daire>();

    public bool Ekle(int DaireNo, int Alan, int MaxKisiSayisi)
    {

        foreach (var kontrol in Daireler) //Aynı DaireNo ya sahip başka bir daire olamaz
        {
            if (kontrol.DaireNo == DaireNo) {
                MessageBox.Show("Aynı Daire No'ya sahip Daire eklenemez","Daire Eklenemedi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false; 
            }
        }

        Daireler.Add(new Daire(DaireNo, Alan, MaxKisiSayisi)); //Yeni daire oluşturup Daireler listine ekler
        return true;
    }

    public void Sil(int index)
    {
        Daireler.RemoveAt(index);
    }

    public bool Duzenle(int index, Daire yeniDaire)
    {

        foreach (var kontrol in Daireler) //Aynı DaireNo ya sahip başka bir daire olamaz
        {
            //eğer duzenlerken aynı daire no seçilirse bu duzenlemeye engel olmaz
            if (kontrol.DaireNo == yeniDaire.DaireNo && Daireler[index].DaireNo != yeniDaire.DaireNo)
            {
                MessageBox.Show("Aynı Daire No'ya sahip başka bir daire var", "Daire Düzenlenemedi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        Daireler[index].DaireGuncelle(yeniDaire);
        return true;
    }

    public override void DosyaGuncelle()
    {
        /*Daireler listindeki her bir index elemanını alıp uygun formatta stringe dönüştürüp bir string listesine çevirir //lambda func 
        burada select ve lambda bir foreach döngüsü gibi davranır ve son olarak ToList() e dönüştürülüp yeni list e atanır.*/

        var stringSatirlari = Daireler.Select(d => $"{d.DaireNo}\t{d.Alan}\t{d.MaxKisiSayisi}\t{d.BorcOdendi}").ToList();

        stringSatirlari.Add($"{Havuzu.Alan}\t{Havuzu.Derinlik}");
        stringSatirlari.Add($"{Fitnessi.Alan}");

        File.WriteAllLines(DosyaAdi, stringSatirlari); //stringSatirlari (List<string> tipinde) her bir elemanı satır satır Daire.txt ye yazılıyor

       
    }

    public void DosyadanYukle()
    {
        if (!File.Exists(DosyaAdi)) return; //dosya yoksa hiç çalışmasın 

        List<string> DaireStringi = new List<string>(); //satırlarına yüklenecek string listesi
        bool txtHatali = false;
       
            DaireStringi = File.ReadAllLines(DosyaAdi).ToList();
        
        foreach (var eleman in DaireStringi)
        {
            var parcalar = eleman.Split('\t');
            if (parcalar.Length == 4) //mekan==daire
            {
                var daire = new Daire(
                    int.Parse(parcalar[0]), //DaireNo
                    int.Parse(parcalar[1]), //Alan
                    int.Parse(parcalar[2]), //MaxKisiSayisi
                    bool.Parse(parcalar[3]) //AidatOdendi
                    );

                Daireler.Add(daire);
            }
            else if(parcalar.Length == 2) //mekan == havuz
            {
                var havuz = new Havuz(
                    int.Parse(parcalar[0]), //Alan
                    int.Parse(parcalar[1])  //Derinlik
                    );
                Havuzu = havuz;
            }
            else if(parcalar.Length == 1) //mekan == fitnessdır
            {
                var fitness = new Fitness(int.Parse(parcalar[0]));
                Fitnessi = fitness;
            }

            else {
                txtHatali = true;
            }
        }

        if (txtHatali == true) MessageBox.Show("Dosyalarda bazı hatalı kısımlar bulundu ve temizlendi","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
    }

}
