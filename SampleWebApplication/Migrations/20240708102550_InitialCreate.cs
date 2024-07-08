using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SampleWebApplication.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "companies",
                columns: table => new
                {
                    company_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_companies", x => x.company_id);
                });

            migrationBuilder.CreateTable(
                name: "departments",
                columns: table => new
                {
                    department_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_departments", x => x.department_id);
                });

            migrationBuilder.CreateTable(
                name: "employees",
                columns: table => new
                {
                    employee_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    company_id = table.Column<int>(type: "int", nullable: false),
                    department_id = table.Column<int>(type: "int", nullable: false),
                    salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    hire_date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employees", x => x.employee_id);
                });

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    productId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    product_name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    product_price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.productId);
                });

            migrationBuilder.InsertData(
                table: "companies",
                columns: new[] { "company_id", "name" },
                values: new object[,]
                {
                    { 1, "Tech Innovators Inc." },
                    { 2, "Global Solutions Ltd." },
                    { 3, "NextGen Technologies" },
                    { 4, "Enterprise Hub" },
                    { 5, "Creative Minds Corp." },
                    { 6, "Future Vision Inc." },
                    { 7, "Innovative Solutions" },
                    { 8, "Dynamic Enterprises" },
                    { 9, "Advanced Systems" },
                    { 10, "Smart Tech Solutions" },
                    { 11, "Premier Technologies" },
                    { 12, "Ultimate Innovations" },
                    { 13, "Pioneering Systems" },
                    { 14, "Creative Solutions" },
                    { 15, "Tech Pioneers" },
                    { 16, "Innovative Minds" },
                    { 17, "Global Tech Innovators" },
                    { 18, "NextGen Enterprises" },
                    { 19, "Enterprise Innovators" },
                    { 20, "Creative Tech Solutions" }
                });

            migrationBuilder.InsertData(
                table: "departments",
                columns: new[] { "department_id", "name" },
                values: new object[,]
                {
                    { 1, "IT" },
                    { 2, "Sales" },
                    { 3, "HR" },
                    { 4, "Marketing" },
                    { 5, "Finance" },
                    { 6, "Operations" },
                    { 7, "Customer Support" },
                    { 8, "R&D" },
                    { 9, "Logistics" },
                    { 10, "Procurement" },
                    { 11, "Quality Assurance" },
                    { 12, "Legal" },
                    { 13, "Compliance" },
                    { 14, "Strategy" },
                    { 15, "Product Management" },
                    { 16, "Engineering" },
                    { 17, "Design" },
                    { 18, "Administration" },
                    { 19, "Security" },
                    { 20, "Training" }
                });

            migrationBuilder.InsertData(
                table: "employees",
                columns: new[] { "employee_id", "company_id", "department_id", "hire_date", "name", "salary" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2020, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "田中 太郎", 60000m },
                    { 2, 2, 2, new DateTime(2019, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "佐藤 花子", 58000m },
                    { 3, 3, 3, new DateTime(2018, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "鈴木 一郎", 61000m },
                    { 4, 4, 4, new DateTime(2021, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "高橋 由美", 65000m },
                    { 5, 5, 5, new DateTime(2017, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "井上 勝", 62000m },
                    { 6, 6, 6, new DateTime(2016, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "山本 久美", 63000m },
                    { 7, 7, 7, new DateTime(2015, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "小林 健", 59000m },
                    { 8, 8, 8, new DateTime(2020, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "加藤 愛", 64000m },
                    { 9, 9, 9, new DateTime(2019, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "森田 進", 60000m },
                    { 10, 10, 10, new DateTime(2021, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "山田 裕子", 62000m },
                    { 11, 11, 11, new DateTime(2018, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "清水 真", 65000m },
                    { 12, 12, 12, new DateTime(2017, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "斎藤 明", 63000m },
                    { 13, 13, 13, new DateTime(2020, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "田村 茂", 59000m },
                    { 14, 14, 14, new DateTime(2019, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "中村 和子", 62000m },
                    { 15, 15, 15, new DateTime(2016, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "渡辺 幸", 64000m },
                    { 16, 16, 16, new DateTime(2021, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "西田 修", 60000m },
                    { 17, 17, 17, new DateTime(2018, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "松本 智子", 63000m },
                    { 18, 18, 18, new DateTime(2017, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "福田 実", 62000m },
                    { 19, 19, 19, new DateTime(2020, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "藤田 清", 64000m },
                    { 20, 20, 20, new DateTime(2019, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "石田 優", 65000m }
                });

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "productId", "product_name", "product_price" },
                values: new object[,]
                {
                    { 1, "Laptop", 999.99m },
                    { 2, "Smartphone", 799.99m },
                    { 3, "Tablet", 499.99m },
                    { 4, "Monitor", 199.99m },
                    { 5, "Keyboard", 49.99m },
                    { 6, "Mouse", 29.99m },
                    { 7, "Printer", 149.99m },
                    { 8, "Scanner", 89.99m },
                    { 9, "Speaker", 69.99m },
                    { 10, "Headphone", 39.99m },
                    { 11, "Webcam", 59.99m },
                    { 12, "Router", 99.99m },
                    { 13, "Hard Drive", 89.99m },
                    { 14, "USB Flash Drive", 19.99m },
                    { 15, "External SSD", 129.99m },
                    { 16, "Power Bank", 49.99m },
                    { 17, "Charger", 25.99m },
                    { 18, "Projector", 299.99m },
                    { 19, "VR Headset", 399.99m },
                    { 20, "Smartwatch", 199.99m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "companies");

            migrationBuilder.DropTable(
                name: "departments");

            migrationBuilder.DropTable(
                name: "employees");

            migrationBuilder.DropTable(
                name: "products");
        }
    }
}
