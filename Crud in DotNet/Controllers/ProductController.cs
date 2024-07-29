using Crud_in_DotNet.Data;
/*using Crud_in_DotNet.Models;*/
using Microsoft.AspNetCore.Mvc;

namespace Crud_in_DotNet.Controllers
{
    public class ProductController : Controller
    {
        public maniContext _manicontext;
        public ProductController(maniContext manicontext)
        {
            _manicontext = manicontext;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Product prd)
        {
           _manicontext.tbl_product.Add(prd);
           _manicontext.SaveChanges();
            return RedirectToAction("fetch");
        }
        public IActionResult Fetch()
        {
            var prd  = _manicontext.tbl_product.ToList();
            return View(prd);
        }
    }
}
