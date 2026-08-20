-- SQL'de, iki tane tire işareti satırı yorum satırına dönüştürür.


-- Select Insert Update Delete Komutları:



-- Selecet * From -> Tüm tabloyu ekrana getirir.
-- "*" işareti tüm hepsini çağırmamızı sağlar
--Select * From TblCategory


-- Sadece belirli bir sütun ekrana getirmek isteğimizde:
--Select ProductName, ProductPrice From TblProduct


-- Şartlı Sorgulamalar:
-- Ürün adı sütlaç olan veriye ait bütün sütunları getirmek istersek:
--Select * From TblProduct Where ProductName = 'Sütlaç'

-- Birden fazla şarta göre de işlem yapılabilir:
-- Select * From TblProduct Where ProductPrice<80 And ProductStatus=1

-- Tabloya yeni veri eklemek için kullanılır.
-- INSERT INTO TblProduct (ProductName, ProductPrice, ProductStatus) values ('Hamburger',150.00,1)

-- Veri Güncelleme- Var olan bir kaydı değiştirmek/güncellemek için kullanılır.
-- NOT: Where koşulu unutulursa tüm tablo güncellenir!!
-- Update TblProduct SET ProductPrice = 200.00 WHERE ProductId = 5

-- Tablodan bir kaydı silmek:
-- Delete From TblProduct where ProductID = 5

-- SqlConnection: C# projesi ile SQL Server veritabanı arasında bağlantı kuran sınıftır.
-- Kullanımı: SqlConnection connection = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=EgitimKampiDb;Integrated Security=true");
-- Data Source / Initial Catalog / Integrated Security: Bağlantı cümlesinin içindeki parametrelerdir.
-- Data Source: Sunucun adını belirtir.
-- Initial Catalog: Hangi veritabanına bağlanacağımızı seçer.
-- Integrated Security=true: Windows kimlik doğrulaması kullanarak ek şifre istemeden bağlanmayı sağlar.

-- connection.Open() / connection.Close(): Veritabanı kapısını açar ve işimiz bitince güvenli bir şekilde kapatır.

-- SqlCommand: SQL veritabanında çalıştıracağımız komutları (select,ınsert vb.) C# içerisininden göndermemizi sağlayan sınıftır.

-- Parameters.AddWithValue(): SQL sorgularının içinde dışarıdan (kullanıcıdan alınan verilerle) güvenli bir şekilde parametre(@deger) aktarmamızı sağlar.

-- ExecuteNonQuery(): Geriye tablo döndürmeyen komutları(ekleme Insert, Güncelleme Update, Silme Delete) veritabanında çalıştırmak için kullanılır.

-- SqlDataAdapter: SQL'den gelen verileri alıp C# içindeki bir tablo yapısına doldurmak için kullanılan bir köprü/adaptördür.

-- adapter.Fill(dataTable): Adaptörün çektiği verileri RAM üzerindeki tabloya doldurmasını sağlar.

-- DataTable: Veritabanından gelen verileri satır ve sütun şeklinde RAM'de geçici olarak saklayan tablo nesnesidir.

-- .Rows ve .ItemArray: DataTable içerisindeki satırları tek tek dönmek ve satırın içindeki hücre verilerine ulaşmak için kullanılır.



-- command.Parameters.AddWithValue("@parametreAdi", deger);  -> yöntemi kullanılarak,
-- verilerin doğrudan sorgu metnine yazılmak yerine parametre olarak güvenli bir şekilde veritabanına iletilir.
-- Bu sayede hem olası güvenlik açıklarının önüne geçilmiş olur hem de özel karakterlerin (tırnak işareti vb.) sorguyu bozması engellenir.



