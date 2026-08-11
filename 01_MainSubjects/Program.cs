using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutları
            Console.Write("Merhaba Dünya");
            // Write methodu -> Bir yazıyı yazdığı zaman imleci o yazının en sağına atar.

            Console.WriteLine("Merhaba Dünya");
            // WriteLine methodu -> Bir yazıyı yazdığı zaman imleci o yazının bir altına atar.

            #endregion

            #region Değişkenler

            // Variables -> Veriler üzerinde işlem yapabilmemizi sağlayan
            // ve geçici olarak ramde tutulan programlama değerleridir.


            // değişken_türü değişken_adı; --> şeklinde yazılır.

            // bir satırda birden fazla aynı türden değişken tanımlanabilir.



            #region String Değişkenler
            // Variables -> Veriler üzerinde işlem yapabilmemizi sağlayan
            // ve geçici olarak ramde tutulan programlama değerleridir.


            // değişken_türü değişken_adı; --> şeklinde yazılır.

            // bir satırda birden fazla aynı türden değişken tanımlanabilir.

            string name;
            name = "Murat";
            Console.Write(name);


            // string -> alfabetik türde verilerimizi kullanabilmemizi sağlayan değişken türü.



            #endregion

            #region Int Değişkenler

            // int -> tam sayı verileri yazmamızı sağlayan değişkenlerdir.


            // -- RESTORAN --

            int hamburgerPrice = 300;
            int cokePrice = 40;
            int waterPrice = 20;
            int friesPrice = 100;

            Console.WriteLine("** Restoran Menü Fiyatı **");
            Console.WriteLine();
            
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Console.OutputEncoding -> Konsolun özel simgeleri (Tl sembolü gibi) desteklemesi için kullanılan bir propertydir.
            // System.Text.Encoding.UTF8 -> Bu ise bir sınıf ve özelliktir.

            Console.WriteLine("-- hamburger: " + hamburgerPrice + " \u20BA");
            Console.WriteLine("-- kola: " + cokePrice + " \u20BA");
            Console.WriteLine("-- su: " + waterPrice + " \u20BA");
            Console.WriteLine("-- kızartma: " + friesPrice + " \u20BA");


            Console.WriteLine() ;
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;


            int totalhamburgerPrice = 0;
            int totalcokePrice = 0;
            int totalwaterPrice = 0;
            int totalfriesPrice = 0;



            hamburgerCount = 2;
            cokeCount = 1;
            waterCount = 3;
            friesCount = 4;

            totalhamburgerPrice = hamburgerCount * hamburgerPrice;
            totalcokePrice = cokeCount * cokePrice;
            totalwaterPrice = waterCount * waterPrice;
            totalfriesPrice = friesCount * friesPrice;

            Console.WriteLine();
            Console.WriteLine("Hamburger Tutarı: " + totalhamburgerPrice + "₺");
            Console.WriteLine("Cola Tutarı: " + totalcokePrice + "₺");
            Console.WriteLine("Su Tutarı: " + totalwaterPrice + "₺");
            Console.WriteLine("Kızartma Tutarı: " + totalfriesPrice + "₺");

            int totalPrice = totalhamburgerPrice + totalcokePrice + totalwaterPrice + totalfriesPrice;

            Console.WriteLine(" Toplam Ödenecek Tutar: " + totalPrice + "₺");






            #endregion

            




            #endregion











            Console.Read();
            // Not: Modern .NET sürümlerinde hata ayıklama penceresi otomatik açık kalır,
            // ancak eski sürümlerle uyumluluk ve ders akışı gereği Console.Read(); kullanılabilir.

        }
    }
}

#region Temel C# özellikleri

// Bu bir açıklama satırıdır.

// using -> kütüphane kullanacağımızı belirtir.
// system. ..; -> kütüphanenin adıdır.
// namespace -> projeye verdiğimiz ismi belirtir.
// class ve methotlar sonrasında detaylandırılacak.

// Kodlarımızı Main süslü parantezlerinin içerisine yazıyoruz.
// C# dilinde her satırın sonuna ";" konulmalıdır.

// -- İSİMLENDİRME STANDARTLARI (NAMING CONVENTIONS) --
// 1. camelCase (Küçük Deve Hörgücü):
//    - İlk kelime küçük, sonraki kelimelerin baş harfi büyüktür.
//    - Kullanım yeri: Metot içindeki yerel değişkenler (Örn: int ogrenciYasi = 20;).
// 
// 2. PascalCase (Büyük Deve Hörgücü): 
//    - Bütün kelimelerin baş harfleri büyük yazılır.
//    - Kullanım yeri: Sınıf (Class) ve Metot adları (Örn: void Hesapla() {}).
// 
// Not: Kodun çalışmasını etkilemez ancak okunabilirliği ve profesyonelliği artırır

// -- Operatörler --

// -- Aritmetik Operatörler --
// + -> Bir toplama aritmetik operatörüdür.
// - -> Bir çıkartma aritmetik operatörüdür.
// * -> Bir çarpma aritmetik operatörüdür.
// / -> Bir bölme aritmetik operatörüdür.
// % -> Bir mod alma-kalanı bölme aritmetik operatörüdür.

// -- Atama Operatörleri --
// = -> Bir atama operatörüdür.
// += -> Bir artırarak atama operatörüdür.
// -= -> Bir eksilterek atama operatörüdür.
// *= -> Bir çarparak atama operatörüdür.

// -- Karşılaştırma Operatörleri --
// == -> Bir  eşittir karşılaştırma operatörüdür.
// != -> Bir eşit değildir karşılaştırma operatörüdür.
// > -> Bir büyüktür karşılaştırma operatörüdür.
// < -> Bir küçüktür karşılaştırma operatörüdür.
// >= -> Bir büyük eşittir karşılaştırma operatörüdür.
// <= -> Bir küçük eşittir karşılaştırma operatörüdür.

// -- Mantıksal Operatörler --
// && -> Bir  ve-and mantıksal operatörüdür.
// || -> Bir  veya-or mantıksal operatörüdür.
// !! -> Bir  değil-not mantıksal operatörüdür.




#endregion


