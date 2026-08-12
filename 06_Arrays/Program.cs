using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri

            // Diziler -> Aynı veri tipindeki çok sayıda veriyi birarada tutmak için kullanılan yapılardır.
            // Örnek diziler:
            //      *Çift sayılar dizisi: 2,4,6,8.. 
            //      *Renkler dizisi: sarı, kırmızı, mavi, turuncu, beyaz..
            //      *Şehirler dizisi: adana, ankara, istanbul, bursa..

            // DeğiskenTuru [] DiziAdı = new DeğiskenTuru[ElemanSayısı]


            string[] colors = new string[4];
            // 4 elemanlı bir dizi oluşturduk.
            // Dikkat! dizilerin ilk elemanı 0'dan başladığından 0,1,2,3 indeksli bir dizimiz oldu.

            colors[0] = "Kırmızı";
            colors[1] = "Sarı";
            colors[2] = "Beyaz";
            colors[3] = "Mavi";
            // Burada dizimizin elemanlarını tanımladık.

            Console.WriteLine(colors); 
            // Burada dizinin tamamını yazdırıyoruz gibi bir yanılgı olabilir,
            // ancak dizinin dizi olduğunu yani("Bu elindeki yapı nedir") sorusunun cevabını öğreniyoruz.
            
            
            Console.WriteLine(colors[2]);
            // Bu satır dizinin '2' indeksli elemanını yani "Beyaz" yazmamızı sağlar.

            Console.WriteLine();
            Console.WriteLine("--------------");

            //--------------------------------------------------------
            string[] cities = new string[5];
            cities[0] = "Milano";
            cities[1] = "Budapeşte";
            cities[2] = "Lyon";
            cities[3] = "Kahire";
            cities[4] = "Üsküp";

            Console.WriteLine(cities[4]);
            // Console.WriteLine(cities[5]); -> Bu satırı yazdığımızda hata alırız çünkü 5 elemanlı bir dizide en fazla 4 indeksli eleman vardır.

            //--------------------------------------------------------

            Console.WriteLine();
            Console.WriteLine("--------------");

            int[] numbers = new int[10];

            numbers[0] = 50;
            numbers[1] = 48;
            numbers[2] = 698;
            numbers[3] = 24;
            numbers[7] = 748;

            // NOT: Console.WriteLine(numbers[6]); -> Burada çıktı '0' olur.
            // Çünkü, Tam sayı formatında bir dizi tanımladığım zaman bir indekse değer ataması yapmazsam  
            // o indeksin default değeri sıfırdır.


            /*
             * -------------------------------------------------------------
             * NOT: DİZİLERDE VARSAYILAN DEĞERLER (DEFAULT VALUES)
             * ------------------------------------------------------------- 
             * Bir dizi (array) tanımlandığında ve indekslere henüz bir 
             * değer atanmadığında, C# o alanları boş bırakmaz. 
             * Veri tipine göre otomatik olarak bir "varsayılan değer" atar:
             * 
             *      - int (Tam sayı)     : 0
             *      - double (Ondalıklı) : 0.0
             *      - bool (Mantıksal)   : false
             *      - string (metin)     : null (Hiçlik / Yokluk)
             *      
             * ÖNEMLİ: String bir dizide boş bir indeks yazdırıldığında 
             * konsol hata vermez; içeride 'null' olduğu için ekrana 
             * hiçbir şey (boşluk) yazdırmaz.
             * NOT: null -> bir değerin var olmaması demektir.
             * ------------------------------------------------------------- 
             */

            string[] cities2 = { "Prag", "Roma", "Atina", "Ankara", "Bursa"};

            Console.WriteLine(cities2[2]);

            Console.WriteLine();
            Console.WriteLine("--------------");

            #endregion


            #region Dizideki Tüm Elemanları Listeleme

            string[] colors2 = { "Sarı", "Kırmızı", "Beyaz", "Mavi", "Yeşil", "Turuncu", "Pembe" };

            for(int i = 0; i < colors2.Length; i++)
            {
                Console.WriteLine(colors2[i]);
            }
            // Bu kodumuzda oluşturduğumuz dizinin uzunluğu boyunca dizide döngü kullanarak
            // tüm elemanları gezen ve onları ekrana yazdıran bir yapı oluşturduk.

            Console.WriteLine();
            Console.WriteLine("--------------");

            int[] numbers2 = { 4, 85, 96, 75, 125, 635, 488, 522, 7456, 2365, 1120 };
            
            for(int i = 0; i < numbers2.Length; i++)
            {
                if (numbers2[i] % 3 == 0)
                {
                    Console.WriteLine(numbers2[i] + " - Bu sayılar 3 sayısına tam bölünür.");
                }
                else
                {
                    Console.WriteLine(numbers2[i] + " - Bu sayılar 3 sayısına tam bölünemez.");
                }
            }

            Console.WriteLine();
            Console.WriteLine("--------------");

            // Bu kodumuzda, oluşturduğumuz dizinin uzunluğu boyunca dizide döngü kullanarak
            // tüm elemanları gezen ve bu elemanlardan 3 sayısına tam bölünenleri 
            // ekrana yazdıran bir yapı oluşturduk.


            // Dizilerde char değişkenleri de tanımlayabiliriz.
            // Ancak char değişkenlerimizi tanımlarken tek tırnak kullanmamız gerekir.

            char[] symbols = { 'a', 'b', 'c', '*', '/', '-' };
            for (int i = 0; i < symbols.Length; i++)
            {
                Console.WriteLine(symbols[i]);
            }

            Console.WriteLine();
            Console.WriteLine("--------------");

            // Dizideki en büyük elemanı bulma
            int[] myArray = { 47, 85, 95, 41, 25, 635, 789, 86, 100 };

            int maxNumber = myArray[0];

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] > maxNumber)
                {
                    maxNumber = myArray[i];
                }
            }
            Console.WriteLine(maxNumber);

            Console.WriteLine();
            Console.WriteLine("--------------");

            #endregion


            #region UYGULAMA: Dizi içinde Filtreleme ve İstatistik

            int[] numbers3 = { 4, 85, 96, 75, 125, 635, 488, 522, 7456, 2365, 1120 };

            int bolunenAdedi = 0;
            int bolunemeyenAdedi = 0;

            // 1. Adım: Önce dizinin ham halini kullanıcıya gösterelim.
            Console.WriteLine("--- İNCELENECEK SAYI LİSTESİ ---");
            Console.WriteLine(string.Join(" | ", numbers3));
            Console.WriteLine("------------------------------\n");

            // 2. Adım: Filtreleme Döngüsü
            for (int i = 0; i < numbers3.Length; i++)
            {
                if (numbers3[i] % 3 == 0)
                {
                    // Dolar ($) işareti sayesinde değişkenleri doğrudan süslü parantez {} içine yazabiliyoruz.
                    Console.WriteLine($"{numbers3[i]} \t -> 3'e tam bölünür.");
                    bolunenAdedi++; // Sayacı 1 artır.
                }
                else
                {
                    Console.WriteLine($"{numbers3[i]} \t -> 3' e tam bölünmez.");
                    bolunemeyenAdedi++; //Sayacı 1 artır.
                }
            }

            // 3. Adım: Sonuçları ekrana basma
            Console.WriteLine("\n-- ANALİZ SONUCU ---");
            Console.WriteLine($"3' e tam bölünen sayı adedi: {bolunenAdedi}");
            Console.WriteLine($"3' e tam bölünemeyen sayı adedi: {bolunemeyenAdedi}");







            /*----------------------------------------------------------------
             * NOT: string.Join METODU NEDİR VE NASIL KULLANILIR?
             *----------------------------------------------------------------
             * Bir dizinin içindeki tüm elemanları, aralarına belirlediğimiz bir 
             * 'ayırıcı' (yapıştırıcı) karakter koyarak tek bir metin (string)
             * haline getirmeye yarar.
             * 
             * 
             * En büyük avantajı: Bizi uzun for döngüleri yazmaktan kurtarır 
             * ve dizinin en son elemanının sonuna fazladan ayırıcı eklemez.
             * Sadece sayı değil, metin dizilerinde de kusursuz çalışır.
             * 
             * Kullanım Formülü:
             * string.Join("Ayırıcı İşaret", DiziAdi);
             * 
             * Örnek Kullanımlar:
             * string[] isimler = {"Ali", "Ayşe", "Veli" };
             * 
             * Console.WriteLine(string.Join("-", isimler));
             * Çıktı: Ali-Ayşe-Veli
             * 
             * Console.WriteLine(string.Join(",", isimler));
             * Çıktı: Ali,Ayşe,Veli
             * 
             * Console.WriteLine(string.Join(" ", isimler));
             * Çıktı: Ali Ayşe Veli
             *----------------------------------------------------------------
             */

            // NOT: Yazıların arasındaki \n ifadesi konsolda bir satır boşluk bırakmaya,
            // \t ise klavyedeki TAB tuşuna basılmış gibi hizalama yapmaya yarar.






            #endregion


            #region Dizi Metotları

            // Length Metodu -> Dizinin eleman sayısını bulmamıza yarar.
            string[] persons = { "ali", "ahmet", "ayşe", "buse", "cem", "deniz" };
            Console.WriteLine(persons.Length);

            Console.WriteLine();
            Console.WriteLine("--------------");

            // Short Metodu -> Dizinin elemanları küçükten büyüğe doğru sıralamaya yarar.
            int[] numbers4 = { 45, 85, 52, 41, 86, 10, 22, 35 };
            Array.Sort(numbers4);
            for(int i = 0; i < numbers4.Length; i++)
            {
                Console.WriteLine(numbers4[i]);
            }

            Console.WriteLine();
            Console.WriteLine("--------------");

            // Reverse Metodu -> Dizinin elemanlarını tam tersi şekilde sıralamaya yarar.
            int[] numbers5 = { 45, 85, 52, 41, 86, 10, 22, 35 };
            Array.Reverse(numbers5);
            for (int i = 0; i < numbers5.Length; i++)
            {
                Console.WriteLine(numbers5[i]);
            }

            Console.WriteLine();
            Console.WriteLine("--------------");

            // Short Metodu + Reverse Metodu birlikte kullanılarak -> Dizinin elemanları büyükten küçüğe doğru sıralamaya yarar.
            int[] numbers6 = { 45, 85, 52, 41, 86, 10, 22, 35 };
            Array.Sort(numbers6);
            Array.Reverse(numbers6);
            for (int i = 0; i < numbers6.Length; i++)
            {
                Console.WriteLine(numbers6[i]);
            }

            Console.WriteLine();
            Console.WriteLine("--------------");

            // Max Metodu -> Dizinin en büyük elemanını bulmaya yarar 
            int[] numbers7 = { 45, 85, 52, 41, 86, 10, 22, 35 };
            Console.WriteLine(numbers7.Max());

            Console.WriteLine();
            Console.WriteLine("--------------");

            // Min Metodu -> Dizinin en küçük elemanını bulmaya yarar 
            int[] numbers8 = { 45, 85, 52, 41, 86, 10, 22, 35 };
            Console.WriteLine(numbers8.Min());

            Console.WriteLine();
            Console.WriteLine("--------------");

            Console.WriteLine("-----");
            int[] numbers9 = { 45, 85, 52, 41, 86, 10, 22, 35 };
            Console.WriteLine("Dizinin en büyük elemanı: " + numbers9.Max() + " | " + "Dizinin en küçük elemanı: " + numbers9.Min());
            Console.WriteLine("-----");

            Console.WriteLine();
            Console.WriteLine("--------------");

            // IndeksOf  Metodu -> Dizi içindeki aranan bir değerin indeks sırasını döndürür.
            string[] customers = { "ali", "buse", "ayşegül", "merve", "çınar", "kaya" };
            int index = Array.IndexOf(customers, "merve");
            Console.WriteLine(index);






            #endregion

            Console.WriteLine();
            Console.WriteLine("--------------");

            #region Kullanıcıdan Değer Alma

            string[] cities3 = new string[5];
            
            for(int i =0; i < cities.Length; i++)
            {
                Console.Write($"Lütfen {i + 1}. Şehri Giriniz: ");
                cities3[i] = Console.ReadLine();
            }

            Console.WriteLine();
            Console.WriteLine("---------");

            for(int i = 0; i < cities3.Length; i++)
            {
                Console.WriteLine(cities3[i]);
            }



            #endregion
           
            Console.WriteLine();
            Console.WriteLine("--------------");

            #region Bir Tam Sayı Dizisinde Dizideki Tüm Elamanları Toplama
            int[] numbers10 = { 10, 20, 30, 40, 50 };
            int sum = 0;

            for(int i = 0; i < numbers10.Length; i++)
            {
                sum += numbers10[i]; 
            }

            Console.WriteLine(sum);

            #endregion

            Console.WriteLine();
            Console.WriteLine("--------------");

            #region Dizideki Elemanları Tek veya Çift Olarak Sınıflandırma

            int[] numbers11 = { 21, 42, 33, 54, 55, 66, 897, 748, 39, 220};
            
            Console.WriteLine("Çift Sayılar: ");
            Console.WriteLine();

            for(int i = 0; i < numbers11.Length; i++)
            {
                if (numbers11[i] % 2 == 0)
                {
                    Console.WriteLine(numbers11[i]);
                }
            }

            Console.WriteLine("--------------");

            Console.WriteLine("Tek Sayılar: ");
            Console.WriteLine();


            for (int i = 0; i < numbers11.Length; i++)
            {
                if (numbers11[i] % 2 == 1)
                {
                    Console.WriteLine(numbers11[i]);
                }
            }


            #endregion

        }
    }
}
