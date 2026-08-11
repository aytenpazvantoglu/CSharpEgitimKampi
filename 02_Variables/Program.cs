using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Double Değişkeni

            // double -> Ondalıklı sayı verilerini tutmak için kullanılan değişken veri tipidir.
            // NOT: Kod yazarken ondalık ayracı olarak virgül değil nokta kullanılır.
            // Not: Konsol kısmından ondalık ayracı olarak virgül kullanılır.

            double number;
            number = 4.85;
            Console.WriteLine(number);



            Console.WriteLine("****");

            double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;
            // değişkenlerimizi tanımladık.


            applePrice = 14.85;
            orangePrice = 20.95;
            strawberryPrice = 45;
            potatoPrice = 9.74;
            tomatoPrice = 6.88;
            // değişkenlerimize değer atadık.


            Console.WriteLine("--Elma Birim Fiyatı: " + applePrice +"TL");
            Console.WriteLine("--Portakal Birim Fiyatı: " + orangePrice + "TL");
            Console.WriteLine("--Çilek Birim Fiyatı: " + strawberryPrice + "TL");
            Console.WriteLine("--Patates Birim Fiyatı: " + potatoPrice + "TL");
            Console.WriteLine("--Domates Birim Fiyatı: " + tomatoPrice + "TL");
            // ekrana yazdırdık


            double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;
            // yeni ağırlık değişkenlerimizi tanımladık.


            appleGram = 1.245;
            orangeGram = 2.650;
            strawberryGram = 0.750;
            potatoGram = 4.859;
            tomatoGram = 3.745;
            // yeni değişkenlerimizin değerlerini atadık.


            double appleTotalPrice = appleGram * applePrice;
            double orangeTotalPrice = orangeGram * orangePrice;
            double strawberryTotalPrice = strawberryGram * strawberryPrice;
            double potatoTotalPrice = potatoGram * potatoPrice;
            double tomatoTotalPrice = tomatoGram * tomatoPrice;
            // Toplam değişkenlerini oluşturduk.

            Console.WriteLine();
            Console.WriteLine("Alınan Ürün: Elma -" + "Birim Fiyat: " + applePrice + "-Gramaj: " + appleGram + "-Toplam Tutar: " + appleTotalPrice);
            Console.WriteLine("Alınan Ürün: Portakal -" + "Birim Fiyat: " + orangePrice + "-Gramaj: " + orangeGram + "-Toplam Tutar: " + orangeTotalPrice);
            Console.WriteLine("Alınan Ürün: Çilek -" + "Birim Fiyat: " + strawberryPrice + "-Gramaj: " + strawberryGram + "-Toplam Tutar: " + strawberryTotalPrice);
            Console.WriteLine("Alınan Ürün: Patates -" + "Birim Fiyat: " + potatoPrice + "-Gramaj: " + potatoGram + "-Toplam Tutar: " + potatoTotalPrice);
            Console.WriteLine("Alınan Ürün: Domates -" + "Birim Fiyat: " + tomatoPrice + "-Gramaj: " + tomatoGram + "-Toplam Tutar: " + tomatoTotalPrice);
            // Son durumda değişkenlerimizi topluca ekrana yazdırdık.

            Console.WriteLine();
            double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;
            // toplam alışveriş tutarımızı tutan yeni bir değişken oluşturduk.

            Console.WriteLine() ;
            Console.WriteLine("Alışveriş Toplam Tutar: " + shoppingTotalPrice + "TL") ;
            // toplam alışveriş tutarımızı ekrana yazdırdık.



            #endregion 

            #region Char Değişkenler

            char symbol;
            symbol = 'A';
            Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            // Console.Readline() -> Kullanıcının klavyeden metin/girdi girmesini sağlar ve girilen veriyi string(metin) türünde programa alır.

            Console.WriteLine("*** CSharp Hava Yolları Yolcu Bilgisi ***");
            Console.WriteLine();

            string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentitiyNumber;
            // ilk değişkenlerimizi tanımladık.
            // NOT: ctrl + f diyerek yanda bir panel açabiliriz.
            // Bu panelde karşımıza çıkan "Find" kısmına değiştirmek istediğimiz değişken adını, "Replace" kısmına ise yeni oluşturmak istediğimiz değişken ismini yazıp
            // "Replace All" dersek eğer tüm değişkenlerimizin ismini topluca değiştirebiliriz.

            Console.Write("Yolcu Adı: ");
            passengerName = Console.ReadLine();
            // Burada yaptığımız işlem, ekranda "Yolcu Adı: " kısmını yazıp yanına girilecek olan değeri passengerName değişkenine atamaktır.

            Console.Write("Yolcu Soyadı: ");
            passengerSurname = Console.ReadLine();

            Console.Write("İlçe Bilgisi: ");
            passengerDistrict = Console.ReadLine();

            Console.Write("Şehir Bilgisi: ");
            passengerCity = Console.ReadLine();

            Console.Write("Yolcu Yaşı: ");
            passengerAge = Console.ReadLine();

            Console.Write("Yolcu TC Kimlik No: ");
            passengerIdentitiyNumber = Console.ReadLine();




            Console.WriteLine();
            Console.WriteLine("---------------------");
            Console.WriteLine("Yolcu TC Kimlik No: " + passengerIdentitiyNumber + " - " + "Yolcu Ad Soyad: " + passengerName + " " + passengerSurname + " " + passengerDistrict + " / " + passengerCity + " " + passengerAge);
            // Son olarak aldığımız bilgileri topluca ekranda gösterdik.














            #endregion


            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            // 1. int.Parse() -> Metinsel ifadeyi tam sayıya (int) dönüştürür. Metin boşsa veya sayıya uygun değilse hata (exception) fırlatır.
            // int sayi1 = int.Parse("10");

            // 2. Convert.To.Int32() -> Metni (veya diğer tipleri) int türüne dönüştürür. Parse'tan farkı, gelen değer 'null' (boş) olursa hata fırlatmak yerine 0 döndürmesidir.
            // int sayi2 = Convert.ToUnt32("20");

            // 3. int.TryParse() -> Dönüşümün başarılı olup olmadığını kkontrol ederek güvenli dönüşüm yapar. Hata fırlatmaz; başarılıysa true, başarısızsa false döndürür.
            // bool basariliMi = int.TryParse("30", out int sayi3);

            // 4. .ToString() -> Sayısal veya farklı türdeki bir veriyi metin (string) türüne dönüştürür.
            // int fiyat = 50;
            // string metinFiyat = fiyat.ToString();





            int shoesPrice, compluterPrice, chairPrice, tvPrice;
            shoesPrice = 1000;
            compluterPrice = 20000;
            chairPrice = 5000;
            tvPrice = 12000;
            // ilk değişkenlerimizi aldık.

            int shoesCount, compluterCount, chairCount, tvCount;
            // adet değişkenlerimizi aldık.

            Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            shoesCount = int.Parse(Console.ReadLine());
            // Burada klavyeden girdiğimiz bir değeri int değerine dönüştürdük.
            // Parse -> Dönüştürmek için kullanılan bir methot. integer'ı 32 bit formatında dönüştürüyoruz.

            Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            compluterCount = int.Parse(Console.ReadLine());

            Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            chairCount = int.Parse(Console.ReadLine());

            Console.Write("Lütfen aldığınız televizyon sayısını giriniz: ");
            tvCount = int.Parse(Console.ReadLine());


            int totalPrice = shoesCount * shoesPrice + compluterCount * compluterPrice + chairCount * chairPrice + tvCount * tvPrice;
            // toplam fiyatı bulmak için tüm ürünlerin fiyat ve adetlerinden yola çıkarak bir hesaplama yapıyoruz.

            Console.WriteLine();
            Console.WriteLine("Toplam Ödemeniz Gereken Tutar: " + totalPrice);



            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            double exam1, exam2, exam3, result;
            // değişkenlerimizi tanımladık.

            Console.Write("Lütfen 1.Sınav notunu giriniz: ");
            exam1 = double.Parse(Console.ReadLine());
            // kullanıcıdan sınav notlarını alıp double türüne dönüştürüyoruz.

            Console.Write("Lütfen 2.Sınav notunu giriniz: ");
            exam2 = double.Parse(Console.ReadLine());

            Console.Write("Lütfen 3.Sınav notunu giriniz: ");
            exam3 = double.Parse(Console.ReadLine());

            result = (exam1 + exam2 + exam3) / 3 ;
            // Burada sonuç değişkeninin atamasını yaptık.

            Console.WriteLine();
            Console.WriteLine("Sınav Ortalamanız: " + result);

            #endregion


            #region Klavyeden Karakter Girişleri

            char gender;
            Console.Write("Lütfen cinsiyet seçiniz: (E / K)  ");
            gender = char.Parse(Console.ReadLine());

            Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender);

            #endregion



        }
    }
}
