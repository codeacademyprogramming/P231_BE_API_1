using System.ComponentModel.DataAnnotations;

namespace FirstApi.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public string Name { get; set; }
        public decimal SalePrice { get; set; }  
        public decimal CostPrice { get; set; }
        public Brand Brand { get; set; }
    }
}
