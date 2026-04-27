using System.ComponentModel.DataAnnotations;

namespace AspNetCore_BigDataOrdersDashboard.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string ProductSku { get; set; }
        public string ProductDescription { get; set; }
        public string CountryOfOrigin { get; set; }
        public double Price { get; set; }
        public int StockQuantity { get; set; }
        public string ProductImageUrl { get; set; }
        public DateTime CreatedAt { get; set; }
        public byte ProductStatus { get; set; }

        public Category Category { get; set; }
    }
}
