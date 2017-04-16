using System.Web.Mvc;

namespace PAM.Presentation.MVC4.Controllers
{
    public class HomeController : Controller
    {
        public HomeController() 
        {
            
        }

        public ActionResult Index()
        {
            return View();
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
