using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Metotlar

            // Bir yapının metot olduğunu anlamak için sonuna mutlaka parantez "()" açılıp kapanması gerekir.

            // Metotlar ikiye ayrılır:
            // 1- Geriye Değer Döndürmeyen Metotlar (Void)
            // Customer -> Listele, Ekle, Sil, Güncelle
            // Belli işlemleri tekrardan kurtarmak için de programlama için önemli bir yere sahiptir.

            // 2- Geriye Değer Döndüren Metotlar


            #region Void Metotlar

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Merve Çınar");

            //}

            //CustomerList(); 

            //----------------------------------------------

            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);

            //}

            //Sum();




            #endregion

            #region Geriye Değer Döndürmeyen String Parametreli Metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}
            //WriteMethod("Mehmet Yıldırım");
            //WriteMethod("Ahmet Yıldırım");

            //--------------------------------------------

            //void CustomerCard(string name, string surName)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surName);
            //}

            //CustomerCard("Mehmet", "Yıldız");
            //CustomerCard("Ayşegül", "Kara");
            //CustomerCard("Veli", "Kaya");





            #endregion


            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar

            void Sum(int number1, int number2, int number3)
            {
                int result = number1 + number2 + number3;
                Console.WriteLine(result);
            }

            Sum(4, 5, 6);


            #endregion

            #endregion


        }
    }
}
