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
        public IActionResult Delete(int id)
        {
            var data = _manicontext.tbl_product.Find(id);
            _manicontext.tbl_product.Remove(data);
            _manicontext.SaveChanges();
            return RedirectToAction("Fetch");
        }
        public IActionResult Update(int id)
        {
          return View(_manicontext.tbl_product.Find(id));
        }
        [HttpPost]
        public IActionResult Update(Product prd)
        {
            _manicontext.tbl_product.Update(prd);
            _manicontext.SaveChanges();
            return RedirectToAction("Fetch");
        }
    }
}
