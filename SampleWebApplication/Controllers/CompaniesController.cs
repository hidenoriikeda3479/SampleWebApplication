using Microsoft.AspNetCore.Mvc;
using SampleWebApplication.Data;

namespace SampleWebApplication.Controllers
{
    /// <summary>
    /// 会社情報のコントローラークラス
    /// </summary>
    public class CompaniesController : Controller
    {
        /// <summary>
        /// DBコンテキスト
        /// </summary>
        private readonly ApplicationDbContext _context;

        /// <summary>
        /// DBコンストラクタ
        /// </summary>
        /// <param name="context">DBコンテキスト</param>
        public CompaniesController(ApplicationDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// 会社名一覧表示
        /// </summary>
        /// <returns>会社情報一覧ビュー</returns>
        public IActionResult Index()
        {
            // 会社情報を取得
            var companies = _context.Companies.ToList();
            return View(companies);
        }

        /// <summary>
        /// 会社名による検索
        /// </summary>
        /// <param name="companyName">検索する会社名</param>
        /// <returns>検索結果ビュー</returns>
        public IActionResult Search(string companyName)
        {
            // 会社情報を取得
            var companies = from p in _context.Companies
                           select p;

            // 部分一致した会社情報を取得
            if (!string.IsNullOrEmpty(companyName))
            {
                companies = companies.Where(p => p.Name.Contains(companyName));
            }

            // 検索結果で取得された会社情報をビューに渡す
            return View("Index", companies.ToList());
        }
    }
}
