
using System;
using System.IO;
using System.Net;
using System.Net.Mail;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Kernel.Pdf;
using iText.Kernel.Crypto;


public abstract class MatematikIslem
{
    public abstract double Hesapla();
    public virtual void BilgiGoster()
    {
        Console.WriteLine("Matematiksel işlem yapılıyor...");
    }
}

public class UcgenAlan : MatematikIslem
{
    private double taban;
    private double yukseklik;

    public UcgenAlan(double taban, double yukseklik)
    {
        this.taban = taban;
        this.yukseklik = yukseklik;
    }

    public override double Hesapla()
    {
        return (taban * yukseklik) / 2;
    }
}

// Polimorfizm için interface ve sınıflar
public interface IMetinIslem
{
    string IslemYap(string metin);
}

public class BuyukHarfIslem : IMetinIslem
{
    public string IslemYap(string metin)
    {
        return metin.ToUpper();
    }
}

public class KucukHarfIslem : IMetinIslem
{
    public string IslemYap(string metin)
    {
        return metin.ToLower();
    }
}

// Kurucu ve yok edici metot için sınıf
public class DiziIslemleri
{
    private int[] dizi;

    public DiziIslemleri(int[] gelenDizi)
    {
        Console.WriteLine("Kurucu metot çalıştı");
        dizi = new int[gelenDizi.Length];
        Array.Copy(gelenDizi, dizi, gelenDizi.Length);
    }

    ~DiziIslemleri()
    {
        Console.WriteLine("Yok edici metot çalıştı");
    }

    public int[] DiziGetir()
    {
        return dizi;
    }
}

// Kalıtım için temel sınıf
public class Musteri
{
    protected string ad;
    protected string soyad;

    public Musteri(string ad, string soyad)
    {
        this.ad = ad;
        this.soyad = soyad;
    }

    public virtual void BilgiGoster()
    {
        Console.WriteLine($"Müşteri: {ad} {soyad}");
    }
}

namespace NesneyeYönelikProgramlamaProjem
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Red;
            while (true)
            {

                Console.Write("Yükleniyor");
                for (int i = 0; i < 3; i++)
                {
                    Thread.Sleep(500);
                    Console.Write(".");
                }
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Green;
                string message1 = " Designed by";
                string message2 = "Yahya BALTACI";
                // Konsol genişliğini al
                int consoleWidth = Console.WindowWidth;

                // Mesaj uzunluğunu al
                int messageLength = message1.Length;

                // Yazıyı ortalamak için gerekli boşluk miktarını hesapla
                int padding = (consoleWidth - messageLength) / 2;

                // Mesajı boşluklarla beraber yazdır
                Console.WriteLine(new string(' ', padding) + message1);
                Console.WriteLine(new string(' ', padding) + message2);
                Console.ForegroundColor = ConsoleColor.Red;

                //Ana Menü
                Console.WriteLine("*********************************");
                Console.WriteLine("*      Akıllı Asistan Menüsü    *");
                Console.WriteLine("*********************************\n");
                Console.WriteLine("*********************************");
                Console.WriteLine("*   1. Matematiksel İşlemler*   *");
                Console.WriteLine("*********************************");
                Console.WriteLine("*2. Dizi ve Koleksiyon İşlemleri*");
                Console.WriteLine("*********************************");
                Console.WriteLine("*      3. String İşlemleri      *");
                Console.WriteLine("*********************************");
                Console.WriteLine("*        4. Tahmin Oyunu        *");
                Console.WriteLine("*********************************");
                Console.WriteLine("*      5. Banka İşlemleri       *");
                Console.WriteLine("*********************************");
                Console.WriteLine("*       6. Konsol Temizle       *");
                Console.WriteLine("*********************************");
                Console.WriteLine("*      7. Collatz Sanısı        *");
                Console.WriteLine("*********************************");
                Console.WriteLine("*      8. Kullanım Kılavuzu     *");
                Console.WriteLine("*********************************");
                Console.WriteLine("*           9. Çıkış            *");
                Console.WriteLine("*********************************");

                Console.Write("Seçiminizi yapın: ");
                string secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        MatematikselIslemler();
                        break;
                    case "2":
                        DiziVeKoleksiyonIslemleri();
                        break;
                    case "3":
                        StringIslemleri();
                        break;
                    case "4":
                        TahminOyunu();
                        break;
                    case "5":
                        Bankaİslemleri();
                        break;

                    case "6":
                        Console.Clear();
                        break;
                    case "9":

                        Console.WriteLine("Çıkış yapılıyor. Hoşça kalın!");
                        Environment.Exit(0);
                        break;
                    case "8":
                        Console.WriteLine("*********************************");
                        Console.WriteLine("*********************************");
                        KullanımKılavuzu();
                        Console.WriteLine("*********************************");
                        Console.WriteLine("*********************************");
                        break;
                    case "7":
                        Collatz.CollatzDeneme();
                        break;
                    default:
                        Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyin.");
                        break;
                }
            }
        }

        static void MatematikselIslemler()
        {//Matematik menüsü
            Console.WriteLine("\n--- Matematiksel İşlemler ---");
            Console.WriteLine("1. Üçgenin Alanını Hesapla");
            Console.WriteLine("2. Fibonacci Hesapla");
            Console.WriteLine("3. Toplama İşlemleri");
            Console.Write("Seçiminizi yapın: ");
            string secim = Console.ReadLine();

            switch (secim)
            {
                case "1":
                    Console.Write("Taban uzunluğu: ");
                    double taban = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Yükseklik: ");
                    double yukseklik = Convert.ToDouble(Console.ReadLine());
                    MatematikIslem ucgenAlan = new UcgenAlan(taban, yukseklik);
                    double alan = ucgenAlan.Hesapla();
                    Console.WriteLine($"Üçgenin alanı: {alan}");
                    break;

                case "2":
                    Console.Write("Fibonacci için bir sayı girin: ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"{n}. Fibonacci sayısı: {Hesaplama.Fibonacci(n)}");
                    break;

                case "3":
                    Console.WriteLine($"3 + 5 = {Hesaplama.CalculateSum(3, 5)}");
                    Console.WriteLine($"2.5 + 3.5 = {Hesaplama.CalculateSum(2.5, 3.5)}");
                    Console.WriteLine($"1 + 2 + 3 = {Hesaplama.CalculateSum(1, 2, 3)}");
                    break;

                default:
                    Console.WriteLine("Geçersiz seçim.");
                    break;
            }
        }

        static void DiziVeKoleksiyonIslemleri()
        {//Dizi ve koleksiyon menüsü
            Console.WriteLine("\n--- Dizi ve Koleksiyon İşlemleri ---");
            Console.WriteLine("1. En Büyük Değeri Bul");
            Console.WriteLine("2. Filtreleme ve Toplama");
            Console.WriteLine("3. Uzunluğu 5'ten Büyük Stringleri Filtrele");
            Console.Write("Seçiminizi yapın: ");
            string secim = Console.ReadLine();

            switch (secim)
            {
                case "1":

                    int[] dizi = { 10, 20, 5, 30, 15 };
                    DiziIslemleri diziIslem = new DiziIslemleri(dizi);
                    int max = Koleksiyonlar.EnBuyukDeger(dizi);
                    Console.WriteLine($"Dizideki en büyük değer: {max}");
                    break;

                case "2":
                    Console.WriteLine("1. Diziyi manuel girmek");
                    Console.WriteLine("2. Diziyi default girmek");
                    Console.Write("Seçiminizi yapın: ");
                    string temp = Console.ReadLine();
                    
                    if (temp == "1")
                    {
                        //Manuel giriş seçilmiştir. 
                        int filtre;
                        while (true)
                        {
                            try
                            {
                                Console.WriteLine("Filtre değeri Giriniz:");
                                string input = Console.ReadLine();

                                // Kullanıcı girdisini kontrol ederek tamsayıya dönüştür
                                if (!int.TryParse(input, out filtre))
                                {
                                    throw new FormatException("Geçersiz filtre değeri! Lütfen sadece bir tamsayı girin.");
                                }
                                break; // Başarılıysa döngüden çık
                            }
                            catch (FormatException ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"Bir hata oluştu: {ex.Message}");
                            }
                        }
                        int[] dizimanuel;
                        while (true)
                        {
                            try
                            {
                                Console.Write("Dizi elemanlarını virgülle ayırarak girin (Örn: 1,2,3): ");
                                string girdi1 = Console.ReadLine();
                                //girilen değerler her virgül (,) işaretinden ayırılmaya başlanır.
                                dizimanuel = girdi1.Split(',').Select(int.Parse).ToArray();

                                break;
                            }
                            catch (FormatException)
                            {
                                //Hata yönetimi yapılır. Biçimsel hatalarda bu mesaj verilir.
                                Console.WriteLine("Hatalı giriş yaptınız! Lütfen sadece virgülle ayrılmış sayılar girin.");
                            }
                            catch (Exception ex)
                            {
                                //Biçimsel hata dışındaki bütün hatalar burada yakalanır ve yönetilir.
                                Console.WriteLine($"Bir hata oluştu: {ex.Message}");
                            }
                        }
                        int toplam = Koleksiyonlar.FiltreliToplam(dizimanuel, filtre);
                        Console.WriteLine($"Filtre değerinden büyük elemanların toplamı: {toplam}");
                    }
                    else if (temp == "2")
                    {
                        int[] dizi2 = { 3, 7, 12, 20, 8 };
                        Console.Write("Filtre değeri girin: ");
                        int filtre = Convert.ToInt32(Console.ReadLine());
                        int toplam = Koleksiyonlar.FiltreliToplam(dizi2, filtre);
                        Console.WriteLine($"Filtre değerinden büyük elemanların toplamı: {toplam}");
                    }

                    break;

                case "3":
                    string[] kelimeler = { "elma", "armut", "muz", "karpuz", "ananas" };
                    var uzunKelimeler = Koleksiyonlar.UzunKelimeler(kelimeler);
                    Console.WriteLine("Uzunluğu 5'ten büyük kelimeler:");
                    foreach (var kelime in uzunKelimeler)
                    {
                        Console.WriteLine(kelime);
                    }
                    break;

                default:
                    Console.WriteLine("Geçersiz seçim.");
                    break;
            }
        }

        static void StringIslemleri()
        {
            Console.WriteLine("\n--- String İşlemleri ---");
            Console.Write("Bir cümle girin: ");
            string cumle = Console.ReadLine();

            // Polimorfizm kullanımı
            IMetinIslem buyukHarf = new BuyukHarfIslem();
            IMetinIslem kucukHarf = new KucukHarfIslem();

            Console.WriteLine($"Büyük harfle: {buyukHarf.IslemYap(cumle)}");
            Console.WriteLine($"Küçük harfle: {kucukHarf.IslemYap(cumle)}");

            int kelimeSayisi = StringIslem.KelimeSayisi(cumle);
            int harfsayısı = StringIslem.HarfSayisi(cumle);
            Console.WriteLine($"Cümledeki kelime sayısı: {kelimeSayisi}\nCümledeki harf sayısı {harfsayısı}");
        }

        static void TahminOyunu()
        {
            //random fonksiyonundan nesne alınır ve nesne üzerinden sayı tutulur.
            Random rnd = new Random();
            int dogruSayi = rnd.Next(1, 101);
            int tahmin;
            int denemeSayisi = 0;
            int puan = 0;

            Console.WriteLine("\n--- Tahmin Oyunu ---");
            do
            {
                denemeSayisi++;

                if (denemeSayisi > 10)
                {
                    Console.WriteLine("10 denemeyi aştınız. Oyunu kaybettiniz!");
                    return;
                }

                Console.Write($"Deneme {denemeSayisi}: Bir sayı tahmin edin (1-100): ");
                try
                {
                    tahmin = Convert.ToInt32(Console.ReadLine());
                    //Büyük küçük kontrolu yapılır ve gerekli mesaj yazdırılır.
                    if (tahmin < dogruSayi)//Girilen sayı küçükse büyük tahmin yapılması istenilir.
                        Console.WriteLine("Daha büyük bir sayı deneyin!");
                    else if (tahmin > dogruSayi)//Girilen sayı büyükse, küçük tahmin yapılması istenilir.
                        Console.WriteLine("Daha küçük bir sayı deneyin!");
                    else
                    {
                        switch (denemeSayisi)
                        {
                            //Tahmin sayınıza göre puanlama tablosu.
                            case 1:
                            case 2:
                                puan = 100;
                                break;
                            case 3:
                            case 4:
                                puan = 90;
                                break;
                            case 5:
                                puan = 80;
                                break;
                            case 6:
                                puan = 70;
                                break;
                            case 7:
                                puan = 60;
                                break;
                            case 8:
                                puan = 50;
                                break;
                            case 9:
                                puan = 40;
                                break;
                            case 10:
                                puan = 30;
                                break;
                        }
                        Console.WriteLine($"Tebrikler, doğru tahmin! Puanınız: {puan}");

                        return;
                    }
                }
                catch (FormatException)
                {
                    //Hata yakalama.
                    Console.WriteLine("Lütfen geçerli bir tam sayı girin.");
                }
            } while (true);
        }
        public static void KullanımKılavuzu()
        {

            //Kullanım kılvavuzu
            Console.WriteLine("İlk açılışta hata alıyorsanız.\r\n\r\nAraçlar -> NuGet Paket Yöneticisi -> Paket Yöneticisi Konsolu\r\n\r\nSekmesind" +
                "en\r\n\r\nInstall-Package Portable.BouncyCastle\r\nInstall-Package itext7\r\n\r\nKodları ile gerekli paketleri yükleyiniz.\r\n\r\n" +
                "Proje akıllı asistan olup, bir çok temel-orta düzey uygulamanın birleşiminden oluşmuştur.\r\n\r\nYükleme ekranı sonrasında ana menü" +
                " açılır.\r\n\r\nMatematiksel İşlemler (Sekme 1): Matematiksel işlemler sekmesinde 3 alt sekme bulunur.\r\n\r\n\tÜçgen Alanı (Alt Se" +
                "kme 1):Üçgen alanı hesaplamak için taban uzunluğu bilgisi ve yükseklik bilgisi kullanıcıdan istenir.\r\n\tÇıktı üçgen alanıdır.\r\n" +
                "\r\n\tFibonacci (Alt Sekme 2): Bu sekme bize bilinen fibonacci dizisinin girilen indisteki değerini döndürür.\r\n\r\n\tToplama İşle" +
                "mleri (Alt Sekme 3): Önceden tanımlı basit toplama işlemleri gösterilir.\r\n\r\n\r\nDizi ve Koleksiyon İşlemleri (Sekme 2): Dizi ve " +
                "Koleksiyon İşlemleri sekmesinde 3 alt sekme bulunur.\r\n\r\n\tEn Büyük Değeri Bul (Alt Sekme 1): Önceden tanımlı bir dizinin en büyü" +
                "k değerini döndürür.\r\n\r\n\tFiltreleme ve Toplama (Alt Sekme 2): Bu alt sekmeye girildiğinde 2 seçenek sunulur. Diziyi manuel ve ön" +
                "ceden tanımlı\r\n\tolarak seçeiblirsiniz. Bu sekme bir dizinin, girilen belli bir değerden daha büyük olan elemanlarının toplamını \t" +
                "verecektir. Manuel girilen dizide, dizi elemanları virgül (,) ile ayırılmalıdır, son terimden sonra virgül\r\n\tkoyulmamalıdır.\r\n\r\n\tAlt" +
                " Sekme 3: Önceden tanımlı bir metindeki uzunluğu 5 karakterden büyük olan kelimeleri döner.\r\n\r\n\r\nString İşlemleri (Sekme 3):" +
                " Alt sekme bulunmaz. Bir metin girilir, bu metindeki kelime sayısını döner.\r\n\r\n\r\nTahmin Oyunu (Sekme 4): Sistem 1-100 arasında" +
                " random bir sayı tutar. Tahmin etmek için değer girdiğinizde tahmin edilmesi gereken sayının sizin sayınızdan büyük ya da küçük olma" +
                " bilgisini verir. Toplamda 10 tahmin hakkınız vardır. Ne kadar az tahmin hakkı kullanarak bilebilirseniz o kadar yüksek puan" +
                " alırsınız.\r\n\r\n\r\nBanka İşlemleri (Sekme 5): Giriş için tc kimlik numarası ve şifre istenir, belirlenen tc kimlik numarası" +
                " \"12345678912\" dir.\r\nBelirlenen şifre ise \"yahya123\" tür. Banka İşlemleri sekmesinde 2 alt sekme bulunur.\r\n\r\n\tBakiy" +
                "e Sorgulama (Alt Sekme 1): Bakiye bilgisini verir.\r\n\r\n\t(***)Para Çekme(Alt Sekme 2): Kullanıcıdan mail adresi istenir." +
                " Kullanıcının doğru mail adresini girmesi önemlidir \taksi halde dekont bilgisine ulaşamaz. Google uygulama şifremi manuel olarak" +
                " gireceğim güvenlik amacıyla. Kullanmak \tisteyenler kod satırından kendi google hesaplarını entegre etmeleri gereklidir. Belirlenen" +
                " bakiye miktarı içerisinde \tpara çekme işlemi yapılır ve \tkullanıcının mailine dekont mantığında çekim işlemi bilgisi iletilir" +
                ".\r\n\r\n\r\nKonsol temizleme (Sekme 6): Kullanıcı konsolu temizlenir ve ana menü tekrardan yüklenir. Daha temiz bir görüntü için" +
                " kullanılır.\r\n\r\n\r\nÇıkış (Sekme 7): Çıkış mesajı alınır ve herhangibir tuşa basıldığında konsol kapatılır.\r\n\r\n\r\nKullanım" +
                " Kılavuzu (Sekme 8): Bütün programın tanıtımı, kullanım kolaylığı ve genel olarak kullanıcı dostu bir uygulama olması açısından kullanım" +
                " kılavuzu sekme 8 e konumlandırılmıştır.\r\n\r\n\r\n\r\nNot: Ana programın altında yorum satırı olarak 3 blok kod mevcuttur. Bütün Kodlar" +
                " ana programı yorum satırı yaptıktan sonra çalıştırılır. \r\n\r\n1. Blok: Yapıcı ve yıkıcı metotlara örnektir\r\n2. Blok: Soyutlama(Abstract)" +
                " örneğidir.\r\n3. Blok: Kalıtım ve çok çeşitlilik örneğidir.");

        }

        static public void Bankaİslemleri()
        {
            BankaClass banka = new BankaClass("", "", 5000);
            Console.WriteLine("Hesaba giriş yapınız");
            Console.WriteLine("Tc kimlik numarası: ");
            banka.tc = Console.ReadLine();
            Console.Write("Şifreniz: ");
            banka.sifre = Console.ReadLine();

            // Giriş kontrolü
            while (banka.tc != "12345678912" || banka.sifre != "yahya123")
            {
                Console.WriteLine("Bilgileriniz yanlış, lütfen tekrar deneyin.");

                Console.Write("TC kimlik numaranız: ");
                banka.tc = Console.ReadLine();

                Console.Write("Şifreniz: ");
                banka.sifre = Console.ReadLine();
            }
            Console.WriteLine("Giriş başarılı!\n");

            // Banka işlemleri
            bool devam = true;

            while (devam)
            {
                Console.WriteLine("1. Bakiye Sorgulama");
                Console.WriteLine("2. Para Çekme");
                Console.WriteLine("3. Çıkış");
                Console.Write("Seçiminiz: ");
                string secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        banka.BakiyeSorgula();
                        break;
                    case "3":
                        Console.WriteLine("Çıkış yapılıyor...");
                        devam = false;
                        break;
                    case "2":
                        // Kullanıcı hesabı oluşturma
                        BankaClass account = new BankaClass("Yahya Birinci", "12345678901", 5000m);

                        // Para çekme işlemi
                        Console.WriteLine("Lütfen alıcı e-posta adresini giriniz: ");
                        string recipientEmail = Console.ReadLine();
                        Console.WriteLine("Bakiyeniz: " + account.Balance);
                        Console.WriteLine("Ne kadar çekmek İstiyorsunuz");
                        decimal x = Convert.ToDecimal(Console.ReadLine());

                        account.Withdraw(x, recipientEmail);
                        break;
                    default:
                        Console.WriteLine("Geçersiz seçim.");
                        break;
                }

                Console.WriteLine();
            }

            Console.WriteLine("İyi günler dileriz!");
        }
    }


}

//Bu class ta overload methotlar kullanılır.
static class Hesaplama
{
    public static double UcgenAlaniHesapla(double taban, double yukseklik)
    {

        double alan = (taban * yukseklik) / 2;
        return alan;
    }

    public static int Fibonacci(int n)
    {

        if (n <= 1)
            return n;
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

    public static int CalculateSum(int a, int b)
    {

        return a + b;
    }

    public static double CalculateSum(double a, double b)
    {

        return a + b;
    }

    public static int CalculateSum(int a, int b, int c)
    {

        return a + b + c;
    }
}

public class BankaClass : Musteri
{

    //Encapsulation yapıları kullanılır.
    private string TC;
    private string SİFRE;
    private string BAKIYE = "5000";

    public string tc
    {
        get
        {
            return TC;
        }
        set
        {
            if (value.Length == 11 && value.All(char.IsDigit))  // Uzunluk 11 mi VE tüm karakterler rakam mı kontrolü
            {
                TC = value;
            }
            else
            {
                if (value.Length != 11)
                {
                    Console.WriteLine("TC kimlik numarası 11 haneli olmalıdır.");
                }
                if (!value.All(char.IsDigit))
                {
                    Console.WriteLine("TC kimlik numarası sadece rakamlardan oluşmalıdır.");
                }
            }
        }
    }

    public string bakiye
    {
        get { return BAKIYE; }
    }

    public void BakiyeSorgula()
    {
        Console.WriteLine($"Güncel bakiyeniz: {BAKIYE}");
    }
    // Encapsulated fields
    private string fullName;
    private string tcNumber;
    private decimal balance;

    // Constructor
    public BankaClass(string fullName, string tcNumber, decimal balance) : base("Varsayılan", "Müşteri")
    {
        this.fullName = fullName;
        this.tcNumber = tcNumber;
        this.balance = balance;
    }

    // Properties
    public string FullName
    {
        get { return fullName; }
        set { fullName = value; }
    }

    public string TCNumber
    {
        get { return tcNumber; }
        set { tcNumber = value; }
    }

    public decimal Balance
    {
        get { return balance; }
        private set { balance = value; }
    }

    // Method to withdraw money
    public void Withdraw(decimal amount, string recipientEmail)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Çekilecek tutar 0 veya daha az olamaz.");
            return;
        }

        if (amount > balance)
        {
            Console.WriteLine("Yetersiz bakiye.");
            return;
        }

        balance -= amount;
        Console.WriteLine($"Hesabınızdan {amount} TL çekilecektir. Kalan bakiye: {balance} TL");
        SendEmail(amount, recipientEmail);//SendEmail fonksiyonu çağırılıyor.
    }

    // Method to send email
    private void SendEmail(decimal amount, string recipientEmail)
    {
        try
        {
            MailMessage mail = new MailMessage();
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");

            mail.From = new MailAddress("yahyabltc@gmail.com"); // Gönderen e-posta adresi
            mail.To.Add(recipientEmail); // Alıcı e-posta adresi
            mail.Subject = "Banka İşlemi Bilgilendirme";
            mail.Body = $"Hesabınızdan {amount} TL çekim işlemi başarıyla gerçekleşmiştir.";

            smtpClient.Port = 587;
            Console.WriteLine("Google uygulama şifrenizi giriniz");
            string temp = Console.ReadLine();// Kullanıcıdan gönderen mail hesabı üzerinden oluşturacağı google uygulama şifresi alınır.
            smtpClient.Credentials = new NetworkCredential("yahyabltc@gmail.com", temp); // Gönderen e-posta ve şifresi
            smtpClient.EnableSsl = true;

            smtpClient.Send(mail);

            Console.WriteLine("E-posta başarıyla gönderildi.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("E-posta gönderiminde bir hata oluştu: " + ex.Message);
        }
    }


    public string sifre
    {
        get { return SİFRE; }
        set
        {
            if (!string.IsNullOrEmpty(value) && value.Length >= 4)//Şifrenin 4 karakter veya daha fazla büyüklükte olup olmadığını ve boşlukları kontrol eder.
            {
                SİFRE = value;
            }
            else
            {
                Console.WriteLine("Şifre en az 4 karakterden oluşmalıdır.");
            }
        }
    }
}

static class Koleksiyonlar
{
    public static int EnBuyukDeger(int[] dizi)
    {

        return dizi.Max();
    }

    public static int FiltreliToplam(int[] dizi, int filtre)
    {

        return dizi.Where(x => x > filtre).Sum();
    }


    public static List<string> UzunKelimeler(string[] dizi)
    {

        return dizi.Where(k => k.Length > 5).ToList();
    }
}

public static class StringIslem
{
    public static int KelimeSayisi(string cumle)
    {

        string[] kelimeler = cumle.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        return kelimeler.Length;
    }
    public static int HarfSayisi(string cumle)
    {
        int count = 0;

        foreach (char c in cumle)
        {
            // Eğer karakter boşluk değilse
            if (char.IsLetter(c))
            {
                count++;
            }
        }

        return count;

    }
}

public static class Collatz
{
    public static void CollatzDeneme()
    {
        // 3x+1 problemi
        long minRange = 0, maxRange = 0;

        while (true)
        {
            try
            {
                Console.WriteLine("Lütfen deneme aralığı için minimum değer giriniz:");
                minRange = long.Parse(Console.ReadLine());

                if (minRange < 0)
                {
                    throw new ArgumentException("Negatif değerler kabul edilmiyor. Lütfen sıfır veya pozitif bir değer girin.");
                }

                break;
            }
            catch (FormatException)
            {
                Console.WriteLine("Hatalı giriş yaptınız! Lütfen geçerli bir tamsayı girin.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Bir hata oluştu: {ex.Message}");
            }
        }

        while (true)
        {
            try
            {
                Console.WriteLine("Lütfen deneme aralığı için maksimum değer giriniz:");
                maxRange = long.Parse(Console.ReadLine());

                if (maxRange < 0)
                {
                    throw new ArgumentException("Negatif değerler kabul edilmiyor. Lütfen sıfır veya pozitif bir değer girin.");
                }

                if (maxRange < minRange)
                {
                    throw new ArgumentException("Maksimum değer, minimum değerden küçük olamaz. Lütfen geçerli bir değer girin.");
                }

                break;
            }
            catch (FormatException)
            {
                Console.WriteLine("Hatalı giriş yaptınız! Lütfen geçerli bir tamsayı girin.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Bir hata oluştu: {ex.Message}");
            }
        }

        // Geçersiz sayılar listesi
        HashSet<long> invalidNumbers = new HashSet<long>();

        // Aranan sayı değişkeni
        long? foundNumber = null;

        for (long i = minRange; i <= maxRange; i++)
        {
            if (!CollatzFunction(i, invalidNumbers))
            {
                // Eğer döngüye girmeyen bir sayı bulunursa, aranan sayı olarak kaydedilir
                foundNumber = i;
                break;
            }
        }

        if (foundNumber.HasValue)
        {
            Console.WriteLine($"Aradığınız sayı: {foundNumber.Value}");
        }
        else
        {
            Console.WriteLine("Aradığınız değer bu aralıkta değil.");
        }
    }

    static bool CollatzFunction(long n, HashSet<long> invalidNumbers)
    {
        long current = n;
        HashSet<long> visitedNumbers = new HashSet<long>();

        while (current != 1)
        {
            // Eğer sayı daha önce geçersiz olarak işaretlendiyse
            if (invalidNumbers.Contains(current))
            {
                return false;
            }

            // Sayı daha önce ziyaret edildiyse döngüye giriyor demektir
            if (visitedNumbers.Contains(current))
            {
                return false;
            }

            visitedNumbers.Add(current);

            // Collatz parçalı fonksiyonu
            if (current % 2 == 0)
            {
                current /= 2;
            }
            else
            {
                current = 3 * current + 1;
            }

            // Eğer sayı aşırı büyük olursa ve işlem tamamlanmazsa
            if (current < 0)
            {
                return false; // Taşma durumu
            }
        }

        // Eğer buraya ulaşıldıysa, sayı 1'e ulaşmıştır
        return true;
    }
}


