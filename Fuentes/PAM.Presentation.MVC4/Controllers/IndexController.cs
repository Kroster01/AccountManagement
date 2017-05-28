using System.Configuration;
using System.Web.Mvc;

namespace PAM.Presentation.MVC4.Controllers
{
    public class IndexController : Controller
    {
        public IndexController() 
        {
        }

        public ActionResult Index()
        {
            bool isDevelopmentMode = false;
            var isDevelopmentModeString = ConfigurationManager.AppSettings["IsDevelopment"];
            isDevelopmentMode = bool.TryParse(isDevelopmentModeString, out isDevelopmentMode);
            
            if (isDevelopmentMode)
            {
                return PartialView("../Shared/BaseContent");
                ///return PartialView("../Shared/RegisterUser");
            }
            else
            {
                return PartialView("../Shared/Login");
                ///return PartialView("../Shared/RegisterUser");
            }
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}
