using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SampleWebApplication.Models
{
    /// <summary>
    /// 商品情報
    /// </summary>
    /// 
    [Table("products")]
    public class Product
    {
        /// <summary>
        /// 製品ID
        /// </summary>
        [Key]
        [Column("productId")] 
        public int ProductId { get; set; }

        /// <summary>
        /// 製品名
        /// </summary>
        [Required]
        [MaxLength(100)]
        [Column("product_name")]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 価格
        /// </summary>
        [Range(0.0, 9999.99)]
        [Column("product_price")] 
        public decimal Price { get; set; }
    }
}
