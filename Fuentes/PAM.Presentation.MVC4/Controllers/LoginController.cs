using System.Web.Mvc;

namespace PAM.Presentation.MVC4.Controllers
{
    public class LoginController : Controller
    {
        public LoginController() 
        {
        }

        public ActionResult Index()
        {
            return PartialView("../Shared/Login");
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
