İlk açılışta hata alıyorsanız.

Araçlar -> NuGet Paket Yöneticisi -> Paket Yöneticisi Konsolu

Sekmesinden

Install-Package Portable.BouncyCastle
Install-Package itext7

Kodları ile gerekli paketleri yükleyiniz.

Proje akıllı asistan olup, bir çok temel-orta düzey uygulamanın birleşiminden oluşmuştur.

Yükleme ekranı sonrasında ana menü açılır.

Matematiksel İşlemler (Sekme 1): Matematiksel işlemler sekmesinde 3 alt sekme bulunur.

	Üçgen Alanı (Alt Sekme 1):Üçgen alanı hesaplamak için taban uzunluğu bilgisi ve yükseklik bilgisi kullanıcıdan istenir.
	Çıktı üçgen alanıdır.

	Fibonacci (Alt Sekme 2): Bu sekme bize bilinen fibonacci dizisinin girilen indisteki değerini döndürür.

	Toplama İşlemleri (Alt Sekme 3): Önceden tanımlı basit toplama işlemleri gösterilir.


Dizi ve Koleksiyon İşlemleri (Sekme 2): Dizi ve Koleksiyon İşlemleri sekmesinde 3 alt sekme bulunur.

	En Büyük Değeri Bul (Alt Sekme 1): Önceden tanımlı bir dizinin en büyük değerini döndürür.

	Filtreleme ve Toplama (Alt Sekme 2): Bu alt sekmeye girildiğinde 2 seçenek sunulur. Diziyi manuel ve önceden tanımlı
	olarak seçeiblirsiniz. Bu sekme bir dizinin, girilen belli bir değerden daha büyük olan elemanlarının toplamını 	verecektir. Manuel girilen dizide, dizi elemanları virgül (,) ile ayırılmalıdır, son terimden sonra virgül
	koyulmamalıdır.

	Alt Sekme 3: Önceden tanımlı bir metindeki uzunluğu 5 karakterden büyük olan kelimeleri döner.


String İşlemleri (Sekme 3): Alt sekme bulunmaz. Bir metin girilir, bu metindeki kelime sayısını döner.


Tahmin Oyunu (Sekme 4): Sistem 1-100 arasında random bir sayı tutar. Tahmin etmek için değer girdiğinizde tahmin edilmesi gereken sayının sizin sayınızdan büyük ya da küçük olma bilgisini verir. Toplamda 10 tahmin hakkınız vardır. Ne kadar az tahmin hakkı kullanarak bilebilirseniz o kadar yüksek puan alırsınız.


Banka İşlemleri (Sekme 5): Giriş için tc kimlik numarası ve şifre istenir, belirlenen tc kimlik numarası "12345678912" dir.
Belirlenen şifre ise "yahya123" tür. Banka İşlemleri sekmesinde 2 alt sekme bulunur.

	Bakiye Sorgulama (Alt Sekme 1): Bakiye bilgisini verir.

	(***)Para Çekme(Alt Sekme 2): Kullanıcıdan mail adresi istenir. Kullanıcının doğru mail adresini girmesi önemlidir 	aksi halde dekont bilgisine ulaşamaz. Google uygulama şifremi manuel olarak gireceğim güvenlik amacıyla. Kullanmak 	isteyenler kod satırından kendi google hesaplarını entegre etmeleri gereklidir. Belirlenen bakiye miktarı içerisinde 	para çekme işlemi yapılır ve kullanıcının mailine dekont mantığında çekim işlemi bilgisi iletilir.


Konsol temizleme (Sekme 6): Kullanıcı konsolu temizlenir ve ana menü tekrardan yüklenir. Daha temiz bir görüntü için kullanılır.


Çıkış (Sekme 7): Çıkış mesajı alınır ve herhangibir tuşa basıldığında konsol kapatılır.


Kullanım Kılavuzu (Sekme 8): Bütün programın tanıtımı, kullanım kolaylığı ve genel olarak kullanıcı dostu bir uygulama olması açısından kullanım kılavuzu sekme 8 e konumlandırılmıştır.



Not: Ana programın altında yorum satırı olarak 3 blok kod mevcuttur. Bütün Kodlar ana programı yorum satırı yaptıktan sonra çalıştırılır. 
