using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü

            // For Döngüsü Yazım Kuralları
            // 1. for(başlangıç; koşul; artış/azalış) şeklinde normal parantez () içine 3 temel şart yazılır.
            // 2. Bu parametrelerin arasına virgül değil, noktalı virgül konur.
            // 3. Döngünün şartı bittikten sonra parantez kapatılır, asla noktelı virgül konulmaz.
            // 4. Döngünün tekrar edecek kodları süslüü parantez içine yazılır.

            #region Basit For Döngüsü Örnekleri

            //// For(x;y;z)
            //// x:başlangıç
            //// y:bitiş
            //// z:artış-azalış

            //int i;

            //for (i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("C# Eğitim Kampı");
            //}
            //// i'nin değeri 5'e küçük eşit olana kadar ekrana C# Eğitim Kampı'nı yazdırdık.

            //for (i = 1; i <= 20; i ++)
            //{
            //    Console.WriteLine(i);
            //}
            //// i'nin değeri 20'den küçük eşit olana kadar i'nin değerini ekrana yazdırdık.

            //for (int i = 3; i <= 50; i += 3)
            //{
            //    Console.WriteLine(i);
            //}
            // 3'ten başlayarak 50'den küçük eşit olana kadar i'nin değerini üçer arttırarak ekrana  yazdırdık.

            #endregion

            #region Kullanıcıdan Veri Aldığımız Basit For Döngüsü Örnekleri

            //Console.Write("Lütfen ekrana yazılmasını istediğiniz sayı adedi giriniz: ");
            //// Kullanıcıdan ekrana kaç kez yazdırılacağını öğrenmek için bir mesaj gösteriyoruz.
            //int finishValue = int.Parse(Console.ReadLine());
            //// Kullanıcının klavyeden girdiği metinsel değeri (string),
            //// döngü sınırında kullanabilmek için int.Parse() ile tam sayıya (int) dönüştürüp 'finishValue' değişkenine atıyoruz.

            //for (int i = 1; i <= finishValue; i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet");
            //}
            //// For döngüsü: i sayacını 1'den başlatıyoruz.
            //// Sayaç, kullanıcının girdiği 'finishValue' değerine eşit veya küçük olduğu sürece döngü çalışmaya devam edecek.
            //// Her turun sonunda 'i ++' ile sayaç 1 arttırılıyor.
            //// Döngünün her bir çalışma turunda konsol ekranına alt alta "Yaşasın Cumhuriyet" yazdırıyoruz.


            #endregion

            #region For Döngüsü ile Karar Yapıları

            //for (int i = 0; i <=100; i ++ )
            //{
            //    if( i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}








            #endregion

            #region Ardışık Sayıları Toplama

            //int totalvalue = 0;
            //// Toplam değişkenini saklamak için başlangıç değeri 0 olan bir sepet (değişken) oluşturuyoruz.

            //for (int i = 1; i <= 10; i++) 
            //    // 1'den 10' a kadar 10 tur dönecek olan for döngümüzü başlatıyoruz.
            //{
            //    totalvalue += i;
            //    // i sayacının o anki değerini, önceki toplamın üzerine ekleyerek biriktiriyoruz. (+= operatörü)
            //    // "Soldakinin üzerine sağdakini ekle ve yeni değer olarak yine sola kaydet"
            //    // Yani totalvalue = totalvalue + i demektir

            //    Console.WriteLine(totalvalue);
            //    // 1. Yazdırma (döngünün içinde):
            //    // Bu satır her turda çalışır. O ana kadar yapılan ara toplamları adım adım ekrana yazdırır.

            //}
            //Console.WriteLine(totalvalue);
            //// 2. Yazdırma ( döngünün dışında):
            //// Döngü tamamen bittikten sonra çalışır. Ara adımlarla uğraşmaz, sadece 1'den 10' a kadar sayıların
            //// en son nihai toplam sonucunu (55) ekrana tek seferde yazar.
            #endregion

            #region deneme çalışması 

            //int totalValue = 0;

            //for (int i = 1; i < 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalValue += i;
            //        totalValue++;
            //        Console.WriteLine(totalValue);
            //    }
            //}

            //Console.WriteLine("******");
            //Console.WriteLine(totalValue);

            #endregion

            #region 1 ile 20 arasındaki çift sayıların toplamı

            //int totalValue = 0;

            //for(int i = 1; i < 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(totalValue);
            //        Console.WriteLine("+++++++++++++");            
            //    }
            //    Console.WriteLine(totalValue);
            //    Console.WriteLine("**********");
            //}
            //Console.WriteLine(totalValue);
            //Console.WriteLine("------");






            #endregion

            #region 1 ile 50 arasındaki 7'ye tam bölünen sayıların adedi

            //int count = 0;
            //for (int i = 1; i <= 50; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        count++;
            //    }
            //}
            // Console.WriteLine(count);

            #endregion

            #region Bakteri Örneği (2^n)

            //// Bir bakteri her saatin sonunda kendini ikiye bölerek çoğaltmaktadır. ( 1-2-4-8-16.... şeklinde artıyor yani.)
            //// 24 saatin sonunda kaç bakteri olduğunu bulalım.

            //int bacterium = 1;
            //// Başlangıçta 1 adet bakterimiz var. 

            //for ( int i = 1; i <= 24; i++)
            //// Bu for döngüsü bizim saatimizi belirtiyor olacak.
            //{
            //    bacterium *= 2; 
            //    Console.WriteLine(i + ".Saat Sonunda: " + bacterium);
            //}

            //#endregion

            #endregion

            #endregion


            #region While Döngüsü

            // While (Şart)
            // {
            //   işlemler
            // }

            #region Basit while döngüsü 

            //int i = 1;

            //while( i <= 10)
            //{
            //    Console.WriteLine("Merhaba Döngüler");
            //    i++;
            //}

            #endregion

            #region 1 ile 10 arasında 3'e tam bölünen sayılar

            //int i = 1;
            //while (i <= 10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            #endregion

            #region 1'den 10' a kadar sayıların toplamı 

            //int i = 1;
            //int sum = 0;

            //while (i <= 10)
            //{
            //    sum += i;
            //    i++;
            //}

            //Console.WriteLine(sum);

            #endregion



            #endregion


            #region Deneme

            // Klavyeden girilen 4 basamaklı sayının basamakları toplamını hesaplayan kodu yazınız. 


            //Console.WriteLine("Sayıyı Giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //int onesPlace, tensPlace, hundredPlace, thousandPlace;
            //int sum;

            //onesPlace = number % 10;
            //Console.WriteLine("Birler basamağındaki sayı: " + onesPlace);

            //tensPlace = (number % 100) / 10;
            //Console.WriteLine("Onlar basamağındaki sayı: " + tensPlace);

            //hundredPlace = (number % 1000) / 100;
            //Console.WriteLine("Yüzler basamağındaki sayı: " + hundredPlace);

            //thousandPlace = number / 1000;
            //Console.WriteLine("Binler basamağındaki sayı: " + thousandPlace);

            //sum = onesPlace + tensPlace + hundredPlace + thousandPlace ;
            //Console.WriteLine("Girilen sayının basamakları toplamı: " + sum);

            #endregion


            #region Örnek Sınav Sorusu
            // Klavyeden girilen 3 basamaklı sayının basamakları toplamını hesaplayan kodu yazınız.

            Console.WriteLine("Sayıyı Giriniz: ");
            int number = int.Parse(Console.ReadLine());
            // Kullanıcıdan bir sayı alma ve bunu int dönüşümü yapma

            int onesPlace, tensPlace, hundredPlace;
            int sum;
            // Değişken tanımlama

            onesPlace = number % 10;
            Console.WriteLine(onesPlace);
            // 1.Adım: Sayının birler basamağını bulma (10'a bölümünden kalan)


            tensPlace = (number / 10) % 10;
            Console.WriteLine(tensPlace);
            // 2.Adım: Sayının onlar basamağını bulma
            // (Önce 10'a bölüp yüzler/binler basamağını sağa kaydırıyoruz, sonra 10 ile mod alarak sadece onlar basamağını alıyoruz.)


            hundredPlace = number / 100;
            Console.WriteLine(hundredPlace);
            // 3.Adım: Sayının yüzler basamağını bulma (100'e tam sayı bölmesi yaparak sol basamağı izole ediyoruz(int olduğu için virgülden sonrası yazmaz.).)


            sum = onesPlace + tensPlace + hundredPlace;
            Console.WriteLine(sum);
            // 4.Adım: Elde edilen tüm basamakları birbiriyle toplama ve sonucu ekrana yazdırma



            #endregion

        }
    }
}
