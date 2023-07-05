﻿using System.ComponentModel.DataAnnotations;

namespace FirstApi.Dtos.ProductDtos
{
    public class ProductPostDto
    {
        [Required]
        [MaxLength(35)]
        public string Name { get; set; }
        [Range(0, int.MaxValue)]
        public int BrandId { get;set; }
        [Range(0,int.MaxValue)]
        public decimal SalePrice { get; set; }
        [Range(0, int.MaxValue)]
        public decimal CostPrice { get; set; }
    }
}
