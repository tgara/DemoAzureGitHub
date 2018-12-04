using ClassLibraryBll;
using System.Web.Mvc;
using WcfServiceDemoAzure;

namespace DemoAzureGitHub.Controllers
{
    public class HomeController : Controller
    {
        private readonly IClass1 _calcul;

        public HomeController(IClass1 class1)
        {
            _calcul = class1;
        }

        public HomeController()
        {
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            var service = new Service1();

            ViewBag.Message = _calcul.Calcul(service.GetData(2000)) ;

            return View();
        }
    }
}