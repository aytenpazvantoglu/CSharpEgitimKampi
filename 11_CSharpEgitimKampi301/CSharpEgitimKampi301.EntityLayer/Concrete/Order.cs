using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
    public class Order
    {
        public int OrderId { get; set; }

        // İlişkiler:
        // Bir siparişin içerisinde bir ürün olur.(Birden fazla adet satın alınsa da isim bir kez geçecektir adet arttırılacaktır.)
       
        public int ProductId { get; set; }

        public  virtual Product Product { get; set; }

        // Kaç adet satıldı:
        public int Quantity { get; set; }

        // Birim Fiyatı:
        public decimal UnitPrice { get; set; }

        // Toplam Fiyatı:
        public decimal TotalPrice { get; set; }

        // Bu ürün kime satıldı:
        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
