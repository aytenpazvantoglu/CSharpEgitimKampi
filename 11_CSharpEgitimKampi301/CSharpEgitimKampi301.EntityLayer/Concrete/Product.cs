using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductStock { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductDescription { get; set; }

        // İlişkiler:
        // Her ürünümüzün bir tane kategorisi olmalı.
        // Her bir ürünün bir tane kategorisi olduğu için buraya tekil ekledik.
        // Bire-Çok İlişki -> Örneğin kola bir içecek çeşididir ancak birden fazla içecek çeşitleri vardır.
        public int CategoryId { get; set; }

        // Kategori tablosunun değerlerine ürün üzerinden ulaşabilmemize yarayan kod satırı:
        public virtual Category Category { get; set; }


        public List<Order> Orders { get; set; }


    }
}
