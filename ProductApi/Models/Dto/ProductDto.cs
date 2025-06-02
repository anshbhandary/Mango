namespace ProductApi.Models.Dto
{
    public class ProductDto
    {
        public int ProductId;
        public string ProductName { get; set; }

        public string ProductDescription { get; set; } = string.Empty;

        public string ProductCategory { get; set; }
    }
}
