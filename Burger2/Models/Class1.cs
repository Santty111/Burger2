using System.ComponentModel.DataAnnotations;

namespace Burger2.Models
{
    public class Promo
    {
        [Required]
        public int PromoId { get; set; }
        public Datetime PromoName { get; set; }
        public string? PromoDescription { get; set; }
        
        public int BurgerId { get; set; }
        public Burger? Burger { get; set; }
        public List<Promo>? Promos { get; set; }

    }
}
