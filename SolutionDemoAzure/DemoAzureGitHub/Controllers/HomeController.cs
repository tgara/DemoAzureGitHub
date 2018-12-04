using System.Web.Mvc;
using WcfServiceDemoAzure;

namespace DemoAzureGitHub.Controllers
{
    public class HomeController : Controller
    {
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

            ViewBag.Message = service.GetData(2000);

            return View();
        }
    }
}