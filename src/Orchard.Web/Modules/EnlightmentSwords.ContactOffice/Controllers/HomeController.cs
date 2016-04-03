using Orchard.ContentManagement;
using Orchard.Themes;
using System.Web.Mvc;

namespace EnlightmentSwords.ContactOffice.Controllers
{
    [Themed]
    public class HomeController : Controller
    {
        private readonly IContentManager _contentManager;
        public HomeController(IContentManager contentManager)
        {
            _contentManager = contentManager;
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}
