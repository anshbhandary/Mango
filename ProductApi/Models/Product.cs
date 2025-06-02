using System.ComponentModel.DataAnnotations;

namespace ProductApi.Models
{
    public class Product
    {

        
        public int Id { get; set; }

        [Required]
        public string ProductName { get; set; }

        public string ProductDescription { get; set; }

        public string ProductCategory { get; set; }


    }
}
