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

public class OdemeYonetim : DosyaIslemleri
{
    public List<Odeme> Odemeler { get; private set; }

    public event EventHandler<Odeme> OdemeDegistiDisari;

    public OdemeYonetim() : base("Odeme.txt")
    {
        Odemeler = new List<Odeme>();
    }

    private void odeme_OdemeDegisti(object sender, EventArgs e)
    {
        var odeme = (Odeme)sender;
        if (odeme != null)
        {
            OdemeDegistiDisari?.Invoke(this, odeme);
        }
    }

    public void Ekle(AileReisi aileReis, double anlikOdenenPara)
    {

        

        if (aileReis.Odemesi == null)
        {
            Odeme yeniOdeme = new Odeme(0,aileReis);
            Odemeler.Add(yeniOdeme);
            aileReis.Odemesi = yeniOdeme;
            
            
            
        }


        aileReis.Odemesi.OdemeDegisti -= odeme_OdemeDegisti;
        aileReis.Odemesi.OdemeDegisti += odeme_OdemeDegisti;
    
        
        aileReis.Odemesi.ToplamOdenenPara += anlikOdenenPara;
        

      
    }

    public void KisiOdemeleriniGuncelle(List<Oturan> Oturanlar)
    {
        var aileReisleri = Oturanlar.OfType<AileReisi>();

        foreach (var ar in aileReisleri)
        {
            ar.Odemesi = null; // Önce sıfırla

            // İlgili ödeme varsa ata
            var ilgiliOdeme = Odemeler.FirstOrDefault(o => o.OdemeYapan.TCNo == ar.TCNo);
            if (ilgiliOdeme != null)
            {
                ar.Odemesi = ilgiliOdeme;
            }
        }

    }

    public void OdemesiniSil(Odeme odemesi) //Dairede oturanları kökten siler
    {
       
       Odemeler.Remove(odemesi);
       DosyaGuncelle();
       
    }
    

    public void Sil(int index)
    {
        Odemeler[index].ToplamOdenenPara = 0;
        Odemeler[index].OdemeDegisti -= odeme_OdemeDegisti;
        Odemeler.RemoveAt(index);
    }

    public void Duzenle(int index, double duzenlenenTutar)
    {
        Odemeler[index].OdemeDegisti -= odeme_OdemeDegisti;
        Odemeler[index].OdemeDegisti += odeme_OdemeDegisti;
        Odemeler[index].ToplamOdenenPara = 0;
        Odemeler[index].ToplamOdenenPara += duzenlenenTutar;
       
    }

    public void AboneligiBaslat(Odeme odeme)
    {
        var  index = Odemeler.IndexOf(odeme);
        Odemeler[index].BitisTarihi = DateTime.Now.AddMinutes(5);
        DosyaGuncelle();
    }

    public void AbonelikKontrol()
    {   foreach (var odeme in Odemeler)
        {
            if (odeme.BitisTarihi < DateTime.Now && odeme.ToplamOdenenPara == (HizmetYonetim.DaireUcreti + HizmetYonetim.EkKisiUcreti * odeme.OdemeYapan.Dairesi.KisiSayisi))
            {
          
                odeme.ToplamOdenenPara = 0;
                odeme.OdemeYapan.Dairesi.BorcOdendi = false;
            }
            else if (odeme.BitisTarihi <= DateTime.Now) //ekstra kontrol, bir şey gözden kaçtıysa dahi bitiş tarihi bittiği sürece borcOdendi yi false yapar
            {
                odeme.OdemeYapan.Dairesi.BorcOdendi = false;
            }

        }
        DosyaGuncelle();
    }

    public override void DosyaGuncelle()
    {
        var odemeSatirlari = Odemeler.Select(o => $"{o.OdemeYapan.TCNo}\t{o.ToplamOdenenPara}\t{o.BitisTarihi}").ToList();
        File.WriteAllLines(DosyaAdi, odemeSatirlari);
    }

    public void DosyadanYukle(KisiYonetim kisiYonetim)
    {
        Odemeler.Clear();
        bool txtHatali = false;

        if (!File.Exists(DosyaAdi)) return; //dosya yoksa hiç çalışmasın 

        var stringSatirlari = File.ReadAllLines(DosyaAdi).ToList();

        foreach (var eleman in stringSatirlari)
        {
            var parcalar = eleman.Split('\t');
            if (parcalar.Length == 3)
            {
                //tc No su uyan kişiye ödeme bilgisini kayder
                var geciciKisisi = kisiYonetim.Oturanlar.FirstOrDefault(d => d.TCNo == parcalar[0].Trim()); //bulamazsa null döndürür

                if (geciciKisisi is not null)
                {
                    if (geciciKisisi is AileReisi ar)
                    {
                        Odeme odeme = new(Convert.ToDouble(parcalar[1]), ar, Convert.ToDateTime(parcalar[2]));
                        Odemeler.Add(odeme);
                    }
                }
                else txtHatali = true;
            }
            else
            {
                txtHatali = true;
            }
        }

        if (txtHatali == true) MessageBox.Show("Dosyalarda bazı hatalı kısımlar bulundu ve temizlendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

 







}
