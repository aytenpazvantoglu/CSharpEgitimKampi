using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Alt alta 10 tane yıldız oluşturma.

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("*");
            //}


            #endregion

            #region Yan yana 10 tane yıldız oluşturma.

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write ("*");
            //}

            #endregion

            #region Alt alta 10 tane yıldız oluşturma her satırda 10 tane yıldız olsun..

            //for ( int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("**********");
            //}

            #endregion

            #region Yıldız kullanarak Dik üçgen biçiminde (alt satıra indikçe birer artacak) şekil oluşturma

            //for ( int i = 0; i <= 5; i++)
            //{
            //    for( int j = 1 ; j <= i ; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine("*");
            //}




            #endregion

            #region Ters Dik Üçgen Şekli

            //for ( int i =5; i >= 1; i-- )
            //{
            //    for ( int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}



            #endregion

            #region Dik Üçgen ve Ters Dik Üçgen Şekli 

            //for ( int i = 1; i <=5 ; i++ )
            //{
            //    for ( int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for(int k = 4; k > 1; k--)
            //{
            //    for(int m = 1; m <= k; m++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Baklava  Dilimi

            /* -------------------------------------------------
               ALGORİTMA PLANI: Baklava Dilimi (Rombüs) Çizimi
              ------------------------------------------------
               1. Amaç: Konsool ekranında yıldızlar (*) kullanarak simetrik bir baklava deseni oluşturmak.
               2. Desen Yapısı (7'li örnek):
                  - 1.Satır: 3 boşluk, 1 yıldız (*)
                   - 2.Satır: 2 boşluk, 3 yıldız (***)
                   - 3.Satır: 1 boşluk, 5 yıldız (*****)
                  - 4.Satır: 0 boşluk, 7 yıldız (*******) -> En geniş nokta (orta kısım)
                   - 5.Satır: 1 boşluk, 5 yıldız (*****)
                   - 6.Satır: 2 boşluk, 3 yıldız (***)
                   - 7.Satır: 3 boşluk, 1 yıldız (*)
             
                3. Matematiksel Kurallar:
                    - Üst kısımda boşluklar 1'er 1'er azalır, yıldızlar 2'şer 2'şer artar.
                    - Üst kısımda boşluklar 1'er 1'er artar, yıldızlar 2'şer 2'şer azalır.
                    - Bu simetriyi kurmak için şekli iki ana döngüye (üst ve alt) bölerek ilerliyoruz.
            -------------------------------------------------------------------------------------------------------
             
             
             */

            for ( int i = 0; i<=5;  i++ )
            {
                for ( int j = 1; j<=i;j++)
                {
                    Console.Write("*");
                }    
            }




            #endregion


        }
    }
}
