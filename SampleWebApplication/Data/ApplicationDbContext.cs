using Microsoft.EntityFrameworkCore;
using SampleWebApplication.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace SampleWebApplication.Data
{
    /// <summary>
    /// アプリケーションのデータベースコンテキストを表します。
    /// </summary>
    public class ApplicationDbContext : DbContext
    {
        /// <summary>
        /// Productsテーブルを取得または設定します。
        /// </summary>
        public DbSet<Product> Products { get; set; }

        /// <summary>
        /// Employeesテーブルを取得または設定します。
        /// </summary>
        public DbSet<Employee> Employees { get; set; }

        /// <summary>
        /// Companiesテーブルを取得または設定します。
        /// </summary>
        public DbSet<Company> Companies { get; set; }

        /// <summary>
        /// Departmentsテーブルを取得または設定します。
        /// </summary>
        public DbSet<Department> Departments { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // パラメータレスコンストラクタを追加（設計時に使用されます）
        public ApplicationDbContext() : base()
        {
        }

        /// <summary>
        /// モデルの構築時にカラムやテーブルの設定を指定します。
        /// </summary>
        /// <param name="modelBuilder">モデルビルダー</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Priceプロパティの精度とスケールを設定
            modelBuilder.Entity<Product>()
                .Property(p => p.Price)
                .HasColumnType("decimal(18, 2)");

            // テストデータのシード
            var products = new Product[]
            {
                new Product { ProductId = 1, Name = "Laptop", Price = 999.99m },
                new Product { ProductId = 2, Name = "Smartphone", Price = 799.99m },
                new Product { ProductId = 3, Name = "Tablet", Price = 499.99m },
                new Product { ProductId = 4, Name = "Monitor", Price = 199.99m },
                new Product { ProductId = 5, Name = "Keyboard", Price = 49.99m },
                new Product { ProductId = 6, Name = "Mouse", Price = 29.99m },
                new Product { ProductId = 7, Name = "Printer", Price = 149.99m },
                new Product { ProductId = 8, Name = "Scanner", Price = 89.99m },
                new Product { ProductId = 9, Name = "Speaker", Price = 69.99m },
                new Product { ProductId = 10, Name = "Headphone", Price = 39.99m },
                new Product { ProductId = 11, Name = "Webcam", Price = 59.99m },
                new Product { ProductId = 12, Name = "Router", Price = 99.99m },
                new Product { ProductId = 13, Name = "Hard Drive", Price = 89.99m },
                new Product { ProductId = 14, Name = "USB Flash Drive", Price = 19.99m },
                new Product { ProductId = 15, Name = "External SSD", Price = 129.99m },
                new Product { ProductId = 16, Name = "Power Bank", Price = 49.99m },
                new Product { ProductId = 17, Name = "Charger", Price = 25.99m },
                new Product { ProductId = 18, Name = "Projector", Price = 299.99m },
                new Product { ProductId = 19, Name = "VR Headset", Price = 399.99m },
                new Product { ProductId = 20, Name = "Smartwatch", Price = 199.99m }
            };

            modelBuilder.Entity<Product>().HasData(products);

            // Companyのシードデータ
            var companies = new Company[]
            {
                new Company { CompanyId = 1, Name = "Tech Innovators Inc." },
                new Company { CompanyId = 2, Name = "Global Solutions Ltd." },
                new Company { CompanyId = 3, Name = "NextGen Technologies" },
                new Company { CompanyId = 4, Name = "Enterprise Hub" },
                new Company { CompanyId = 5, Name = "Creative Minds Corp." },
                new Company { CompanyId = 6, Name = "Future Vision Inc." },
                new Company { CompanyId = 7, Name = "Innovative Solutions" },
                new Company { CompanyId = 8, Name = "Dynamic Enterprises" },
                new Company { CompanyId = 9, Name = "Advanced Systems" },
                new Company { CompanyId = 10, Name = "Smart Tech Solutions" },
                new Company { CompanyId = 11, Name = "Premier Technologies" },
                new Company { CompanyId = 12, Name = "Ultimate Innovations" },
                new Company { CompanyId = 13, Name = "Pioneering Systems" },
                new Company { CompanyId = 14, Name = "Creative Solutions" },
                new Company { CompanyId = 15, Name = "Tech Pioneers" },
                new Company { CompanyId = 16, Name = "Innovative Minds" },
                new Company { CompanyId = 17, Name = "Global Tech Innovators" },
                new Company { CompanyId = 18, Name = "NextGen Enterprises" },
                new Company { CompanyId = 19, Name = "Enterprise Innovators" },
                new Company { CompanyId = 20, Name = "Creative Tech Solutions" },
            };
            modelBuilder.Entity<Company>().HasData(companies);

            // Departmentのシードデータ
            var departments = new Department[]
            {
                new Department { DepartmentId = 1, Name = "IT" },
                new Department { DepartmentId = 2, Name = "Sales" },
                new Department { DepartmentId = 3, Name = "HR" },
                new Department { DepartmentId = 4, Name = "Marketing" },
                new Department { DepartmentId = 5, Name = "Finance" },
                new Department { DepartmentId = 6, Name = "Operations" },
                new Department { DepartmentId = 7, Name = "Customer Support" },
                new Department { DepartmentId = 8, Name = "R&D" },
                new Department { DepartmentId = 9, Name = "Logistics" },
                new Department { DepartmentId = 10, Name = "Procurement" },
                new Department { DepartmentId = 11, Name = "Quality Assurance" },
                new Department { DepartmentId = 12, Name = "Legal" },
                new Department { DepartmentId = 13, Name = "Compliance" },
                new Department { DepartmentId = 14, Name = "Strategy" },
                new Department { DepartmentId = 15, Name = "Product Management" },
                new Department { DepartmentId = 16, Name = "Engineering" },
                new Department { DepartmentId = 17, Name = "Design" },
                new Department { DepartmentId = 18, Name = "Administration" },
                new Department { DepartmentId = 19, Name = "Security" },
                new Department { DepartmentId = 20, Name = "Training" },
            };
            modelBuilder.Entity<Department>().HasData(departments);

            // Employeeのシードデータ
            var employees = new Employee[]
            {
                new Employee { EmployeeId = 1, Name = "田中 太郎", DepartmentId = 1, CompanyId = 1, Salary = 60000, HireDate = new DateTime(2020, 1, 15) },
                new Employee { EmployeeId = 2, Name = "佐藤 花子", DepartmentId = 2, CompanyId = 2, Salary = 58000, HireDate = new DateTime(2019, 3, 10) },
                new Employee { EmployeeId = 3, Name = "鈴木 一郎", DepartmentId = 3, CompanyId = 3, Salary = 61000, HireDate = new DateTime(2018, 7, 22) },
                new Employee { EmployeeId = 4, Name = "高橋 由美", DepartmentId = 4, CompanyId = 4, Salary = 65000, HireDate = new DateTime(2021, 5, 30) },
                new Employee { EmployeeId = 5, Name = "井上 勝", DepartmentId = 5, CompanyId = 5, Salary = 62000, HireDate = new DateTime(2017, 2, 5) },
                new Employee { EmployeeId = 6, Name = "山本 久美", DepartmentId = 6, CompanyId = 6, Salary = 63000, HireDate = new DateTime(2016, 8, 12) },
                new Employee { EmployeeId = 7, Name = "小林 健", DepartmentId = 7, CompanyId = 7, Salary = 59000, HireDate = new DateTime(2015, 9, 18) },
                new Employee { EmployeeId = 8, Name = "加藤 愛", DepartmentId = 8, CompanyId = 8, Salary = 64000, HireDate = new DateTime(2020, 11, 23) },
                new Employee { EmployeeId = 9, Name = "森田 進", DepartmentId = 9, CompanyId = 9, Salary = 60000, HireDate = new DateTime(2019, 4, 27) },
                new Employee { EmployeeId = 10, Name = "山田 裕子", DepartmentId = 10, CompanyId = 10, Salary = 62000, HireDate = new DateTime(2021, 6, 3) },
                new Employee { EmployeeId = 11, Name = "清水 真", DepartmentId = 11, CompanyId = 11, Salary = 65000, HireDate = new DateTime(2018, 1, 8) },
                new Employee { EmployeeId = 12, Name = "斎藤 明", DepartmentId = 12, CompanyId = 12, Salary = 63000, HireDate = new DateTime(2017, 2, 14) },
                new Employee { EmployeeId = 13, Name = "田村 茂", DepartmentId = 13, CompanyId = 13, Salary = 59000, HireDate = new DateTime(2020, 9, 20) },
                new Employee { EmployeeId = 14, Name = "中村 和子", DepartmentId = 14, CompanyId = 14, Salary = 62000, HireDate = new DateTime(2019, 3, 26) },
                new Employee { EmployeeId = 15, Name = "渡辺 幸", DepartmentId = 15, CompanyId = 15, Salary = 64000, HireDate = new DateTime(2016, 10, 31) },
                new Employee { EmployeeId = 16, Name = "西田 修", DepartmentId = 16, CompanyId = 16, Salary = 60000, HireDate = new DateTime(2021, 5, 7) },
                new Employee { EmployeeId = 17, Name = "松本 智子", DepartmentId = 17, CompanyId = 17, Salary = 63000, HireDate = new DateTime(2018, 8, 13) },
                new Employee { EmployeeId = 18, Name = "福田 実", DepartmentId = 18, CompanyId = 18, Salary = 62000, HireDate = new DateTime(2017, 4, 19) },
                new Employee { EmployeeId = 19, Name = "藤田 清", DepartmentId = 19, CompanyId = 19, Salary = 64000, HireDate = new DateTime(2020, 12, 25) },
                new Employee { EmployeeId = 20, Name = "石田 優", DepartmentId = 20, CompanyId = 20, Salary = 65000, HireDate = new DateTime(2019, 5, 1) },
            };
            modelBuilder.Entity<Employee>().HasData(employees);
        }
    }
}
