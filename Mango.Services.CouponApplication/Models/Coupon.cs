using System.ComponentModel.DataAnnotations;

namespace Mango.Services.CouponApplication.Models
{
    public class Coupon
    {

        [Key] 
        public int CouponId { get; set; }

        [Required]
        public string? CouponCode { get; set; }

        [Required]
        public Double DiscountAmout { get; set; }

        public int MinAmount { get; set; }
           
    }
}
