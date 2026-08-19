using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ado.net -> C# dilinde, SQL yapılarını kullanabilmemize olanak sağlayan bir çerçevedir.


            Console.WriteLine("***** C# Veri Tabanlı Ürün-Kategori Bilgi Sistemi *****");
            Console.WriteLine();
            Console.WriteLine();

            string tableNumber;

            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("1- Kategoriler");
            Console.WriteLine("2- Ürünler");
            Console.WriteLine("3- Siparişler");
            Console.WriteLine("4- Çıkış Yap");
            Console.WriteLine("Lütfen getirmek istediğiniz tablo numarasını giriniz: ");
            tableNumber = Console.ReadLine();
            Console.WriteLine("---------------------------------------------------------");

            // SqlConnection -> Sınıf
            // connection -> Nesne
            // Burada sql bağlantımızı oluşturuyoruz.
            SqlConnection connection = new SqlConnection("Data Source=.\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true");
          
            // Bağlantımızı açtık.
            connection.Open();
            
            // Sorguyu açmamıza yarayan kod bloğu
            // Not: Hangi database'i kullanacağımızı belirtmek için connection eklememiz gerekir.
            SqlCommand command = new SqlCommand("Select * From TblCategory", connection);


            // C# yazdığımız kodlarla sql tarafında bir köprü kurmamızı sağlar.
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            // Verilerimizi ram belleğe almamızı sağlar:
            DataTable dataTable = new DataTable();

            // ?
            adapter.Fill(dataTable);

            connection.Close();

            // var değişkeni bütün değişkenleri üzerine alır.
            // Bizim talomuzda farklı veri tipleri olduğu için var kullandık.
            foreach(DataRow row in dataTable.Rows)
            {
                foreach(var item in row.ItemArray)
                {
                    Console.Write(item.ToString());
                }
                Console.WriteLine();
            }



        }
    }
}
