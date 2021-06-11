using System.Web.Mvc;

namespace MyProject.Controllers
{
    public class ArticleBlockController : Controller
    {
        public ActionResult ArticleBlock()
        {
            return View("~/Views/Articles/ArticleBlock.cshtml");
        }
    }
}