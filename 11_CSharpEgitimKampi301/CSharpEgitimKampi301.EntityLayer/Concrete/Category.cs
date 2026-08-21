using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
    public class Category
    {
        public int CategoryId { get; set; }
        // Code-First yaklaşımının içerisinde, bunun birincil anahtar olduğunu
        // ve kendiliğinden otomatik artan olduğunu bildirmek için,
        // mutlaka sınıfın ismiyle birebir aynı olmalı ve sonuna 'Id' getirilmelidir.
        public string CategoryName { get; set; }

        public bool CategoryStatus { get; set; }

        // İlişkiler:
        // Bir kategoride birden fazla ürün olabilir.
        // Bu nedenle ürünlerimizi çoğul ekledik (products)
        // Bire-Çok İlişki -> Örneğin kola bir içecek çeşididir ancak birden fazla içecek çeşitleri vardır.
        public List<Product> Products { get; set; }



    }
}

/*
 --------------- Field-Variable-Property ---------------
Field (Alan) -> Bir classın içerisinde direkt olarak tanımlanıyorsa 'Field'.
* Doğrudan sınıfın süslü parantezleri arasında, herhangi bir metodun dışarısında tanımlanan değişkenlerdir.
* Genellikle sınıfın verilerini (state) tutar.
* Genellikle private(gizli) tanımlanırlar çünkü dış dünyadan doğrudan erişilmesi güvenlik açığı yaratabilir.
* Nesnenin sahip olduğu özellikleri(örneğin bir öğrencinin tcNo'su veya ogrenciAdi gibi) bellekte tutan temel yapı taşlarıdır.
 
Variable (Yerel Değişken) -> Bir method içerisinde tanımlanırsa 'Variable'.
* Bir metodun (Main veya başka bir metot) içerisinde tanımlanan geçici değişkenlerdir. 
* İşlemleri yürütmek için anlık kullanılırlar ve metot bittiğinde bellekten silinirler.
* Algoritmaları çalıştırmak, anlık sonuçları saklamak ve mantıksal işlemleri yürütmak için hayati önem taşır.
* Sınıf seviyesinde yer kaplamazlar, sadece o metot çalışırken var olurlar.
* Örneğin:  int toplam = sayi1 + sayi2


Property (Özellik) -> Bir classın içerisinde get ve set ile tanımlanıyorsa 'Property'.
* Sınıf içerisinde get ve set blokları (kapsülleme-encapsulation mekanizması) barındırır.
* Dışarıdan verilere kontrollü bir şekilde erişilmesini veya veri atanmasını sağlar.
* Genellikle public yapılır.
* Field'lara dışarıdan güvenli bir şekilde ulaşmamızı sağlayan köprülerdir.
* Arka planda get(değeri okuma) ve set(değere yeni atama yapma) operasyonlarını çalıştırır.
* Encapsulation(kapsülleme) prensibinin temelidir.
* Örneğin, bir öğrencinin yaşına dışarıdan birinin yanlışlıkla -5 atamasını,
set bloğu içine koyulan bir if koşuluyla engelleyebiliriz.
* Doğrudan field'a erişim vermek yerine propery kullanmak kodu her zaman güvenli ve esnek yapar.

 */


/*
 --------------- Code-First Yaklaşımı ---------------
* .NET dünyasında Entity Framework(EF) Core ile veritabanı işlemlerini yaparken kullanılan en popüler yöntemlerden biridir.
* Code-First(Önce Kod), Önce C# tarafında sınıflarını(classes) ve property'lerini yazarak veri modelini oluşturduğumuz,
 veritabanın ise bu kodlara bakılarak otomatik olarak (kod tarafından oluşturulduğu yaklaşımdır.

* NASIL ÇALIŞIR? 
*  C# kodunda şu şekilde bir sınıf yazdığımızda:
public class Student
{
    public int Id{ get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
}

Code-First yaklaşımı ve Entity Framework kullanarak komut verdiğimizde,
arka plandaki araçlar bu koda bakar ve SQL Server üzerinde otomatik olarak sütunları
Id, Name ve Surname olan bir Students tablosu oluşturur. 
Yani veritabanını Sql ekranında elle tasarlamak yerine C# sınıflarıyla yönetiriz.

 
  
 */






