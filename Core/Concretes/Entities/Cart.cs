using Core.Abstracts.Bases;

namespace Core.Concretes.Entities
{
    public class Cart : BaseEntity
    {
        //Foreing Keys          =  Sepet direkt müşteriye bağlı.
        public string CustomerId { get; set; } = null!;

        //Navigation Properties
        
        public virtual ICollection<CartItem> Items { get; set; } = [];
        public virtual Customer? Customer { get; set; }
    }
}
