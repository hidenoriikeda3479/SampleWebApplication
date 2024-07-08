using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SampleWebApplication.Models
{
    /// <summary>
    /// 部署情報
    /// </summary>
    [Table("departments")]
    public class Department
    {
        /// <summary>
        /// 部署ID
        /// </summary>
        [Key]
        [Column("department_id")]
        public int DepartmentId { get; set; }

        /// <summary>
        /// 部署名
        /// </summary>
        [Required]
        [MaxLength(100)]
        [Column("name")]
        public string Name { get; set; } = default!;
    }
}
