using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SampleWebApplication.Models
{
    /// <summary>
    /// 会社情報
    /// </summary>
    [Table("companies")]
    public class Company
    {
        /// <summary>
        /// 会社ID
        /// </summary>
        [Key]
        [Column("company_id")]
        public int CompanyId { get; set; }

        /// <summary>
        /// 会社名
        /// </summary>
        [Required]
        [MaxLength(100)]
        [Column("name")]
        public string Name { get; set; } = default!;
    }
}
