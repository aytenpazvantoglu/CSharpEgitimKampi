using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {

           

            #region If Else Karar Yapısı

            // Karar Yapılarından sonra ';' kullanılmaz.
            // Ctrl + K basıp ardından Ctrl + D basarak kodlarımızı daha temiz bir hale getirebiliriz.


            // NOT: Eğer karar yapılarını kullanırken 'else' cloğuna yer vermek istemiyorsak, 
            // sonuç değişkenimizin koşulllara hiç girmeme ihtimaline karşı başlangıçta bir ilk değer (örneğin 0 veya boş string "") alması gerekir.
            // Bunun sebebi, C# derleyicisinin "bu değişkenin içinde kesinlikle okunabilir bir değer var" garantisi istemesidir.
            // Eğer ilk değer atamazsak ve if şartları sağlanmazsa, derleyici hata verir.

            #region Basit Şifre Kontrolü

            //Console.Write("Lütfen Şifreyi Giriniz: ");
            //string password;
            //password = Console.ReadLine();
            //Konsol ekranında okunan yazı, password'a atansın..

            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}

            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}

            #endregion

            #region Basit Ülke-Şehir Kontrolü

            //string capital, country;
            //Console.Write("Başkenti Giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülke Giriniz:");
            //country = Console.ReadLine();

            //if(capital == "ankara" & country == "türkiye")
            //{
            //    Console.Write("Veriler Doğrulandı.");
            //}

            //else
            //{
            //    Console.Write("Hatalı Bilgi");
            //}
            #endregion

            #region Basit Sayı Kontrolü

            //int number;
            //Console.Write("Sayıyı Giriniz: ");
            //number = int.Parse(Console.ReadLine());
            //if (number == 5)
            //{
            //    Console.WriteLine("Sayı Doğru.");
            //}

            //else
            //{
            //    Console.WriteLine("Sayı Hatalı.");
            //}

            #endregion

            #region Sınav Ortalaması Hesaplama ve Derecelendirme

            //int exam1, exam2, exam3, average;
            //string result = "Hata!";  // İlk değer ataması yapmayı tercih ettik.
            //// Değişkenlerimizi tanımladık.

            //Console.Write("Sınav1: ");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav2: ");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //// Console.Write() metodu kullanıcıdan metin (string) alır.
            //// Matematiksel ortalama hesaplayabilmek için int.Parse() ile bu metni tam sayıya (int) dönüştürüyoruz.

            //average = (exam1 + exam2 + exam3) / 3;
            //// Girilen sınav notlarının ortalamasını hesaplıyoruz.

            //Console.WriteLine("Sınavların Ortalaması: " + average);
            ////Hesaplanan ortalama değerini konsol ekranına yazdırıyoruz.

            //if (average > 0 & average <= 50)
            //{
            //    result = "Sonuç Kötü.";
            //}

            //if (average > 50 & average <= 70)
            //{
            //    result = "Sonuç Orta.";
            //}

            //if (average > 70 & average <= 84)
            //{
            //    result = "Sonuç İyi.";
            //}

            //if (average > 84)
            //{
            //    result = "Sonuç Çok İyi.";
            //}

            //Console.WriteLine(result);

            // Bu örneğimizdeki gibi else komutunu kullanmak istemiyorsak o halde sonuç değişkenimize bir ilk değer atamamız gerekir.
            // Bunun sebebi, sonuç değişkenimiz if'lerin içerisine girmiyorsa null olmaması içindir.

            #endregion

            #region Veya (|) ile If Kullanımı Örneği

            //string city;
            //Console.Write("Lütfen Şehir Giriniz: ");
            //city = Console.ReadLine();

            //if (city == "adana" | city == "ankara" | city == "bursa" | city == "trabzon")
            //{
            //    Console.Write("Şehir Mevcut.");
            //}

            //else
            //{
            //    Console.Write("Şehir Mevcut Değil.");
            //}

            #endregion

            #region =! operatörü kullanım örneği

            //Console.Write("Lütfen Kullanıcı Adını Giriniz: ");
            //string username = Console.ReadLine();

            //if (username != "admin")
            //{
            //    Console.Write("Bu kullanıcı adı kabul edilemez. ");
            //}

            //else
            //{
            //    Console.Write("Hoşgeldiniz.");
            //}




            #endregion

            #endregion



            #region Mod İşlemleri

            #region Basit Mod Alma Örneği

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            #endregion

            #region Kullanıcıdan Alınan Sayıların Modunu Hesaplama Örneği (Basit)

            //Console.Write("Lütfen 1. Sayıyı Giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. Sayıyı Giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //Console.Write("1. Sayının 2. sayıya bölümünden kalan sayı: "+ result);

            #endregion

            #region Basit Tek-Çift Örneği

            //Console.Write("Lütfen sayıyı giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //if(number % 2 == 0)
            //{
            //    Console.Write("Sayı Çifttir.");
            //}

            //else
            //{
            //    Console.Write("Sayı Tektir.");
            //}

            #endregion

            #endregion



            #region Char Değişkenleri ile Karar Yapıları

            #region Klavyeden girilen harfe göre takımı bulma örneği

            //char team;
            //Console.Write("Lütfen takım sembolünü giriniz: ");
            //team = char.Parse(Console.ReadLine());

            //if (team == 'g' | team == 'G')
            //{
            //    Console.Write("Galatasaray");
            //}

            //if (team == 'f' | team == 'F') 
            //{
            //    Console.Write("Fenerbahçe");
            //}

            //if (team == 'b' | team == 'B') 
            //{
            //    Console.Write("Beşiktaş");
            //}

            //if (team == 't' | team == 'T') 
            //{
            //    Console.Write("Trabzonspor");
            //}

            //else
            //{
            //    Console.Write("Mevcut takım bulunamadı.");
            //}


            #endregion

            #endregion



            #region Örnek Proje Uygulaması Basit Menü Seçimi


            //Console.WriteLine("*** C# Eğitim Kampı Restoran ***");
            //Console.WriteLine();
            //Console.WriteLine("------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("------------------");
            //Console.WriteLine();

            //string menuItem;

            //Console.Write("Detayını görmek istediğiniz menü seçimi: ");
            //menuItem = Console.ReadLine();

            //if(menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------ Ana Yemekler ------------");
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("2-Kızartma Tabağı");
            //    Console.WriteLine("3-Fasulye Pilav");
            //    Console.WriteLine("4-Fırında Somon");
            //    Console.WriteLine("5-Patlıcan Musakka");
            //    Console.WriteLine("--------------------------------------");

            //}

            //if(menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------ Çorbalar ------------");
            //    Console.WriteLine("1-Mercimek Çorbası");
            //    Console.WriteLine("2-Ezogelin Çorbası");
            //    Console.WriteLine("3-Tavuk Çorbası");
            //    Console.WriteLine("4-Kelle Paça");
            //    Console.WriteLine("5-İşkembe");
            //    Console.WriteLine("----------------------------------");
            //}

            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------ Pizzalar ------------");
            //    Console.WriteLine("1-Akdeniz Pizza");
            //    Console.WriteLine("2-Margarita");
            //    Console.WriteLine("3-Tavuklu Pizza");
            //    Console.WriteLine("3-Karışık Pizza");
            //    Console.WriteLine("----------------------------------");
            //}

            //if( menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------ İçecekler ------------");
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Ayran");
            //    Console.WriteLine("3-Su");
            //    Console.WriteLine("4-Gazoz");
            //    Console.WriteLine("5-Meyve Suyu");
            //    Console.WriteLine("-----------------------------------");
            //}

            //if( menuItem=="5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------ Tatlılar ------------");
            //    Console.WriteLine("1-Trileçe");
            //    Console.WriteLine("2-Kazandibi");
            //    Console.WriteLine("3-Sütlaç");
            //    Console.WriteLine("4-Supangle");
            //    Console.WriteLine("5-Profiterol");
            //    Console.WriteLine("----------------------------------");
            //}











            #endregion

            #region Switch Case

            // Aynı değişkenin birden fazla sabit değeri kontrol edilirken,
            // arka arkaya yazılan karmaşık 'if-else if' bloklarının yarattığı kod kalabalığını önler.

            // Anahtar Değişken (switch): Kontrol edilmek istenen değişken parantez içine yazılır.
            // Durumlar (case): Değişkenin alabileceği her bir sabit değer 'case' ifadesinden sonra belirtilir.
            // Durdurma (break): Bir 'case' bolğu eşleştiğinde, işlemin tamamlandığını ve switch yapısından çıkılması gerektiğini belirtir.
            // Not: C# dilinde 'break' (veya return/throw) kullanımı zorunludur.
            // Varsayılan Durum ( default): Tanımlanan 'case' değerlerinin hiçbirinin değişkenle eşleşmediği durumlarda çalışacak olan,
            // isteğe bağlı ama tamamen güvenli kod yazımı için önerilen bloktur.

            // 'case' ifadelerinin yanına yazılan değerler mutlaka "sabit" (constant) olmalıdır.
            // Değişkenler veya dinamik ifadeler 'case' değeri olarak doğrudan kullanılamaz.
            // switch yapısı genellikle tam sayılar (int,char,byte), string ve enum (numaralandırma) türleri ile kullanılır.
            // Aynı switch bloğu içerisinde birden fazla aynı 'case' değeri tanımlanamaz, derleme hatası verir.



            #region Klavyeden Girilen Sayıya Göre Yılın Ayları Veren Uygulama

            //Console.Write("lütfen Ay Girişi Yapınız: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch(monthNumber)
            //{
            //    case 1: Console.Write("Ocak"); break;
            //    case 2: Console.Write("Şubat"); break;
            //    case 3: Console.Write("Mart"); break;
            //    case 4: Console.Write("Nisan"); break;
            //    case 5: Console.Write("Mayıs"); break;
            //    case 6: Console.Write("Haziran"); break;
            //    case 7: Console.Write("Temmuz"); break;
            //    case 8: Console.Write("Ağustos"); break;
            //    case 9: Console.Write("Eylül"); break;
            //    case 10: Console.Write("Ekim"); break;
            //    case 11: Console.Write("Kasım"); break;
            //    case 12: Console.Write("Aralık"); break;
            //    default: Console.Write("Hatalı veri girişi"); break;
            //}


            #endregion

            #region Basit Hesap Makinesi

            //int number1, number2, result;
            //char symbol;

            //Console.Write("1. Sayıyı Giriniz: ");
            //number1 = int.Parse(Console.ReadLine());

            //Console.Write("2. Sayıyı Giriniz: ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen yapmak istediğiniz işlemi giriniz: ");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Toplam: " + result);
            //        break;

            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Fark: " + result);
            //        break;

            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Çarpım: " + result);
            //        break;
                
            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Bölüm: " + result);
            //        break;
            //}



            #endregion




            #endregion










        }
    }
}
