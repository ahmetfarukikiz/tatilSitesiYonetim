# _ndp_proje_yariyil2y

Ödevin içeriğine göre anladıklarım:
-Aile Reisinin görevi: Bulunduğu dairede ödeme yetkisine sahip olan ve yönetimle muhattap
olan site sakinidir. Sorumluluğu dairesindekiler ve kendisinin ödemesini yapıp dairenin aidatını ödemektir. 
Aile Reisinin aidatını ödediği dairelerde oturan herkes havuz ve fitness'ı kullanabilir. Bir dairede birden fazla
olamaz.

-Misafir: Ödeme yetkisi olmayan site sakinidir. Bulunduğu dairede bir Aile Reisi varsa ve ödemesini yaparsa
Havuz ve Fitness ı kullanabilirler.

-Ödevde her dairenin borcunu ayrı ayrı belirlemek yerine bir aidat sistemi tasarladım. Bu aidat sistemine 
göre  Ayarlar menüsünde: her dairenin belirlenebilecek bir 0 kişilik aidat değeri vardır ve
her eklenen kişi için ücretin ne kadar artacağına dair de bir fiyat ayarı vardır. 

Örnek: ana aidat 5000TL ve kişi başı fiyat 1500TL ise;
5000TL + 2kişi(1500TL) = 8000TL bir aidat istenecektir.

Aidat süresi dolan (ödevde 5dk) kişilerin ödemesi sıfırlanır.

*Ödevimde kayıt sistemi bulunuyor. Program kapansa dahi bütün bilgiler kalmaya devam eder.

*Nesneler, Listeler birbiriyle ilişkilidir. Her class ın nesneleri list olarak kendi yönetim sınıfında bulunmasına ek olarak,
Her dairenin içinde DairedeOturanlar diye bir Oturan listesi bulunur.
Ve her Oturan nesnesinin içinde Dairesi diye bir Daire tipinde field bulunur. Odeme class'ının içinde OdemeYapan
isminde bir field bulunur. Dolayısıyla herhangi bir daire silindiğinde içindeki kişiler ve kişilerin ödeme bilgileri de silinir.
*Eğer bir dairenin daireNosu güncellenirse onun içinde oturan kişilerin de daire No ları görünür biçimde güncellenir
