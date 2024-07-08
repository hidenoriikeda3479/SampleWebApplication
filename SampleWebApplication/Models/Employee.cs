using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SampleWebApplication.Models
{
    /// <summary>
    /// 社員情報
    /// </summary>
    [Table("employees")]
    public class Employee
    {
        /// <summary>
        /// 社員ID
        /// </summary>
        [Key]
        [Column("employee_id")]
        public int EmployeeId { get; set; }

        /// <summary>
        /// 社員名
        /// </summary>
        [Required]
        [MaxLength(100)]
        [Column("name")]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 会社ID
        /// </summary>
        [Column("company_id")]
        public int CompanyId { get; set; }

        /// <summary>
        /// 部署ID
        /// </summary>
        [Column("department_id")]
        public int DepartmentId { get; set; }

        /// <summary>
        /// 給与
        /// </summary>
        [Column("salary")]
        public decimal Salary { get; set; }

        /// <summary>
        /// 入社日
        /// </summary>
        [Required]
        [Column("hire_date")]
        public DateTime HireDate { get; set; }
    }
}
