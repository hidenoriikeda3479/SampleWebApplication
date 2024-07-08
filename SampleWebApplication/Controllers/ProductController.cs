using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SampleWebApplication.Data;
using SampleWebApplication.Models;

namespace SampleWebApplication.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductsController(ApplicationDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// 商品一覧表示
        /// </summary>
        /// <returns>商品一覧ビュー</returns>
        public IActionResult Index()
        {
            // データベースから全商品のリストを取得
            var products = _context.Products.ToList();
            return View(products);
        }

        /// <summary>
        /// 商品名による検索
        /// </summary>
        /// <param name="productName">検索する商品名</param>
        /// <returns>検索結果ビュー</returns>
        public IActionResult Search(string productName)
        {
            // データベースから商品リストを取得
            var products = from p in _context.Products
                           select p;

            // 商品名が指定されている場合、その名前を含む商品をフィルタリング
            if (!string.IsNullOrEmpty(productName))
            {
                products = products.Where(p => p.Name.Contains(productName));
            }

            // フィルタリングされた商品リストをビューに渡す
            return View("Index", products.ToList());
        }
    }
}
