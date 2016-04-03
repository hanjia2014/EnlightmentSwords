using System.Web.Mvc;
using Orchard.Localization;
using Orchard;
using Orchard.Themes;
using Orchard.ContentManagement;
using EnlightmentSwords.ContactOffice.Models;

namespace HelloWorld.Controllers {
    [Themed]
    public class HomeController : Controller {
        public IOrchardServices Services { get; set; }
        public IContentManager ContentManager { get; set; }

        public HomeController(IOrchardServices services, IContentManager contentManager) {
            Services = services;
            T = NullLocalizer.Instance;
            ContentManager = contentManager;
        }

        public Localizer T { get; set; }

        public ActionResult Index() {
            return View();
        }

        public ActionResult Contact()
        {
            var officeContentItems = ContentManager.Query<ContactOfficePart, ContactOfficePartRecord>().List();
            return View(officeContentItems);
        }
    }
}
