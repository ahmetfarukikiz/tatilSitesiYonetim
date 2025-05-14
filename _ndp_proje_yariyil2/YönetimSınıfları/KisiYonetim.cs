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
                                                                
public class KisiYonetim : DosyaIslemleri
{

    public List<Oturan> Oturanlar { get; private set; } = new List<Oturan>();

    public KisiYonetim() : base("Data.txt") { }


    public bool Ekle(string oturanTipi, string adi, string soyadi, int yas, string tcno, Daire dairesi)
    {
        bool basarili = true;

        switch (oturanTipi)
        {
            case "Misafir": basarili = MisafirEkle(adi,soyadi,yas,tcno,dairesi); break;
            case "AileReisi": basarili = ReisEkle(adi, soyadi, yas, tcno, dairesi); break;
        }

        return basarili;
    }

    private bool MisafirEkle(string adi, string soyadi, int yas, string tcno, Daire dairesi)
    {
        if(Oturanlar.Any(k => k.TCNo == tcno)) { MessageBox.Show("Aynı TC Kimlik No'ya sahip kişi eklenemez", "Kayıt Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }

        Oturanlar.Add(new Misafir(adi, soyadi, yas, tcno, dairesi));

        return true;
    }

    private bool ReisEkle(string adi, string soyadi, int yas, string tcno, Daire dairesi)
    {
        if (Oturanlar.Any(k => k.TCNo == tcno)) { MessageBox.Show("Aynı TC Kimlik No'ya sahip kişi eklenemez", "Kayıt Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }

        Oturanlar.Add(new AileReisi(adi, soyadi, yas, tcno, dairesi));

        return true;
    }

    public void Sil(int index)
    {
        Oturanlar.RemoveAt(index);
    }

    public void DairedekiKisileriGuncelle(List<Daire> tumDaireler) //KişiYönetimdeki kişileri Daire içindeki DairedeOturanlar List ine aktarır/günceller
    {

        foreach(var daire in tumDaireler)
        {
            daire.DairedeOturanlar = new();
            daire.DairedeOturanlar.Clear();
        }

        foreach (var item in Oturanlar)
        {
            item.Dairesi.DairedeOturanlar = Oturanlar.Where(o => o.Dairesi.DaireNo == item.Dairesi.DaireNo).ToList(); //KisiYonetim bilgilerini DairedeOturanlara Kopyalar
        }
       
        foreach(var daire in tumDaireler)
        {
            daire.KisiSayisi = daire.DairedeOturanlar.Count;
       
        }
       
    }


 

    public void DairedekileriSil(List<Oturan> dairedeOturanlar) //Dairede oturanları kökten siler
    {
        Oturanlar = Oturanlar.Except(dairedeOturanlar).ToList();
    }

    public bool Duzenle(int index, Oturan yeniKisi)
    {
        bool yeniDaireEskisineEşit = (yeniKisi.Dairesi == Oturanlar[index].Dairesi);

        foreach (var kontrol in Oturanlar) //Aynı DaireNo ya sahip başka bir daire olamaz
        {
            //eğer duzenlerken aynı Tc No seçilirse bu duzenlemeye engel olmaz
            if (kontrol.TCNo == yeniKisi.TCNo && Oturanlar[index].TCNo != yeniKisi.TCNo)
            {
                MessageBox.Show("Aynı TC No'ya sahip başka bir kişi var", "Daire Düzenlenemedi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        //eğer kişi başka daireye alınmış ve tipi de aile reisi olarak belirlenmiş ise ve yeni dairede zaten bir aileReisi var ise kişi düzenlenemez
        if (!(yeniDaireEskisineEşit) && (yeniKisi.GetType().Name == "AileReisi") && (yeniKisi.Dairesi.DairedeOturanlar.Any(d=>d.GetType().Name == "AileReisi")))
        { 
            MessageBox.Show("Yeni Dairede zaten bir Aile Reisi var", "Kişi Düzenlenemedi", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
            return false; 
        }

        //eğer kişi kendi dairesindeyse ve misafir ise ama dairesinde bir aile reisi varsa onu AileReisi yapamazsın
        if ((yeniDaireEskisineEşit) && !(Oturanlar[index].GetType().Name=="AileReisi") &&  (yeniKisi.GetType().Name=="AileReisi") && Oturanlar[index].Dairesi.DairedeOturanlar.Any(d=>d.GetType().Name=="AileReisi")) 
        {
            MessageBox.Show("Bu Dairede zaten bir Aile Reisi var", "Kişi Düzenlenemedi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        //bir kişi dolu bir odaya alınamaz
        if (!(yeniDaireEskisineEşit) && yeniKisi.Dairesi.MaxKisiSayisi <= yeniKisi.Dairesi.KisiSayisi) 
        { 
            MessageBox.Show("Oda Dolu", "Kayıt Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            return false; 
        } 


        Oturanlar.RemoveAt(index); //indexteki kişiyi siler
        Oturanlar.Insert(index, yeniKisi);  //silinen kişinin indexi yerine güncellenmiş bilgileriyle aynı kişiyi ekler
        return true;
    }

   

   

    public override void DosyaGuncelle()
    {
        var stringSatirlari = Oturanlar.Select(d => $"{d.Adi}\t{d.Soyadi}\t{d.Yas}\t{d.TCNo}\t{d.GetType().Name}\t{d.Dairesi.DaireNo}").ToList();
        File.WriteAllLines(DosyaAdi, stringSatirlari);
    }

    public void DosyadanYukle(MekanYonetim mekanYonetim)
    {   
        if (!File.Exists(DosyaAdi)) return; //dosya yoksa hiç çalışmasın 

        List<string> stringSatirlari = new List<string>(); //satırlarına yüklenecek string listesi
        bool txtHatali = false;

        stringSatirlari = File.ReadAllLines(DosyaAdi).ToList();

        

        foreach (var eleman in stringSatirlari)
        {
            var parcalar = eleman.Split('\t');
            if (parcalar.Length == 6)
            {
                var geciciDairesi = mekanYonetim.Daireler.First(d => d.DaireNo == Convert.ToInt32(parcalar[5].Trim()));


                if (parcalar[4] == "AileReisi")
                {var aileReisi = new AileReisi(
                                parcalar[0], //Adi
                                parcalar[1], //Soyadi
                     int.Parse(parcalar[2]), //Yas
                                parcalar[3], //TCNo
                              geciciDairesi //dairesi                
                    );

                    Oturanlar.Add(aileReisi);
                }

                else if (parcalar[4] == "Misafir")
                {
                    var misafir = new Misafir(
                                parcalar[0], //Adi
                                parcalar[1], //Soyadi
                     int.Parse(parcalar[2]), //Yas
                                parcalar[3], //TCNo
                              geciciDairesi //dairesi                
                    );

                    Oturanlar.Add(misafir);
                }


            }
            else
            {
                txtHatali = true;
            }
        }

        if (txtHatali == true) MessageBox.Show("Dosyalarda bazı hatalı kısımlar bulundu ve temizlendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}

