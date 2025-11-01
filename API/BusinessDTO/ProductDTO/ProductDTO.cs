using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDTO.ProductDTO
{
    public class ProductDto
    {
        // 🏷️ Basic Product Info
        public int ProductId { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public string SKU { get; set; } = string.Empty;
        public int CategoryId { get; set; }
        public int? SubCategoryId { get; set; }
        public string BrandName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ShortDescription { get; set; } = string.Empty;

        // 💰 Pricing & Inventory
        public decimal MRP { get; set; }
        public decimal SellingPrice { get; set; }
        public int StockQuantity { get; set; }
        public string StockStatus { get; set; } = "In Stock"; // or "Out of Stock"

        // 🖼️ Media
        public string? MainImageUrl { get; set; }
        public List<string>? AdditionalImageUrls { get; set; }
        public string? VideoUrl { get; set; }

        // ⚙️ Attributes / Specifications
        public string? Color { get; set; }
        public string? Size { get; set; }
        public string? Material { get; set; }
        public string? Warranty { get; set; }
        public string? Dimensions { get; set; }

        // 🚚 Shipping
        public decimal? ShippingWeight { get; set; }
        public bool FreeShipping { get; set; }
        public string? DeliveryTime { get; set; }

        // 🔍 SEO Fields
        public string? MetaTitle { get; set; }
        public string? MetaDescription { get; set; }
        public string? MetaKeywords { get; set; }
        public string? UrlSlug { get; set; }

        // 🧩 Miscellaneous
        public List<string>? Tags { get; set; }
        public bool FeaturedProduct { get; set; }
        public string Status { get; set; } = "Active"; // Active / Inactive / Draft
        public int CreatedBy { get; set; }  // Vendor/User ID
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    }

}