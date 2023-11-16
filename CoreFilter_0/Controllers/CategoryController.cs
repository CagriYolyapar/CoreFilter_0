using CoreFilter_0.Models.Tools;
using Microsoft.AspNetCore.Mvc;

namespace CoreFilter_0.Controllers
{
    public class CategoryController : Controller
    {


        //Home / Action => Baz Url

        // ?id=asadasd
        // ?value = 1

        public IActionResult CreateCategory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateCategory(Category model)
        {
            return RedirectToAction("Index");
        }


    }
}
