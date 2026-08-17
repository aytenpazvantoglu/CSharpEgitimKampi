using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Foreach Döngüsü

            // Foreach(1;2;3;4)

            // 1: Değişken Türü
            // 1: Değişken Adı
            // 1: In
            // 1: Liste, Koleksiyon, Dizi








            #endregion

            #region Foreach Döngüsü Örnekleri

            //string[] cities = { "milano", "roma", "budapeşte", "ankara", "istanbul", "varşova" };

            //foreach(string x  in cities)
            //{
            //    Console.WriteLine(x);   
            //}


            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //foreach(int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}


            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //foreach(int number in numbers)
            //{
            //    if(number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}



            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //int total = 0;

            //foreach(int i in numbers)
            //{
            //    total += i;
            //}
            // Console.WriteLine(total);


            #region Bir Kelimenin Harflerini Ayıran İfade

            //string word = "Merhaba";

            //foreach(char c in word)
            //{
            //    Console.WriteLine(c);
            //}



            #endregion




            #endregion

            #region Listeler (Lists) 

            // TODO: Listeler konusu daha sonra ayrıntılı işlenecek..

            /* ----- C# DİZİLER (ARRAYS) VE LİSTELER (LİSTS) PRATİK NOTLAR -----
             
            ------------------ DİZİLER ------------------ 

            1. Fixed Size ( Sabit Boyutlu):
            Dizilerin sınırlar en baştan belirlidir. Esneklik yoktur.
                (Bu esneklik sorununu 'Listeler' konusu çözecek)

            2. İndeks Sıfırdan Başlar:
            Diziler saymaya 1'den değil, 0'dan başlar.

            3. Type Safety (Katı Veri Tipi Kuralı):
            Bir dizide içerideki tüm elemanlar aynı veri tipinde olmak zorundadır.
                (Bir dizi 'int' olarak açıldıysa, içine sadece tam sayı koyulabilir.)

            4. Foreach ve Dizilerin Uyumu:
            Dizilerin içindeki elemanları tek tek okumak için en iyi yol 'foreach' kullanmaktır.
            Çünkü foreach, dizinin sınırlarını kendi hesaplar.


            ------------------ LİSTELER ------------------ 
            
            1.  Dynamic Size ( Esnek Boyutlu) : 
            Dizilerdeki o "katı sınır" problemi listelerde yoktur. Baştan bir boyut 
            belirtmek zorunda değilsin. İçine istersen 3, istersen 3000 eleman ekleyebilirsin. 
            Sen eleman ekledikçe kapasitesini arka planda otomatik olarak büyütür.

            2. Eleman Ekleme (.Add): 
            Listeye yeni bir eleman eklemek çok kolaydır. İndeks numarası takip etmene gerek kalmaz.
            Örnek: 'sehirler.Add("Ankara");' komutu, elemanı listenin en sonuna zahmetsizce ekler.

            3. Eleman Silme (.Remove / .RemoveAt): 
            Dizilerde aradan bir eleman silmek büyük derttir, ama listelerde tek satırdır.
            İstemediğin bir elemanı doğrudan adını yazarak (liste.Remove("Ali")) veya 
            indeks numarasını vererek (liste.RemoveAt(0)) anında listeden çıkartabilirsin.

            4. Uzunluğu Öğrenme (.Count): 
            Dizilerin içinde kaç eleman olduğunu bulmak için '.Length' kullanıyorduk.
            Listelerde ise bu komut '.Count' olarak değişir. En sık karıştırılan ufak fark budur!

             5. LİSTE TANIMLAMA SÖZDİZİMİ (Syntax): 
            Tanımlarken 'List<VeriTipi> listeAdi = new List<VeriTipi>();' şeklinde 
            küçüktür-büyüktür işaretleri (<>) kullanılır. (Buna Generic yapı denir).
            Dizilerde olduğu gibi, listeler de sadece içine tanımlanan tipte veri alır.

            ---------------------------------------------------

             */


            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,8
            //};
            //// NOT: Bu bir döngü veya if bloğu değil, bir 'Değişken Tanımlama/Atama'işlemidir.
            //// Tıpkı "int a = 5;" yazarken cümlenin sonuna noktalı virgül koyduğumuz gibi,
            //// listenin içini doldurduğumuz bu eşitlik sepetinin sonuna da cümlenin
            //// bittiğini belirtmek için noktalı virgül (;) konulmak zorundadır.

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}





            #endregion

            #region Örnek Sınav Sistemi Uygulaması 

            Console.Write("***** C# Eğitim Kampı Sınav Uygulaması *****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            // Sınıftaki öğrenci sayısını kullanıcıdan alma
            Console.WriteLine("------------------------------");
            Console.Write("Sınıfınızda Kaç Öğrenci Var: ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------");


            // Öğrenci isimlerini ve not ortalamalarını saklayacak diziler
            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for(int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i+1}. öğrencinin ismini giriniz: ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                // Her öğrenci için 3 sınav notu girişi
                for(int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} adlı öğrencinin {j+1}. sınav notunu giriniz: ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value; // Notları topluyoruz.
                }
                Console.WriteLine();


                studentExamAvg[i] = totalExamResult / 3;

            }
         
            // Öğrencilerin sınav ortalamaları
            for(int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("------------------------------");


                Console.WriteLine($"{studentNames[i]} adlı öğrencisin ortalaması: {studentExamAvg[i]}");

                // Öğrencilerin ortalaması ve geçip kalma durumları
                if (studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti. ") ;
                }

                else
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı. ");
                }
                Console.WriteLine("------------------------------");
            }





            #endregion





        }
    }
}
