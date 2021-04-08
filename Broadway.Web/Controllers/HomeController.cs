using System.Web.Mvc;
using Broadway.Web.ViewModel;

namespace Broadway.Web.Controllers
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
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Bikram()
        {
            return View("~/Views/Student/BikramSharma.cshtml");
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel model)
        {
            ViewBag.Kamlesh = "My Name is Kamlesh";
            ViewBag.Bikram = "My Name is Bikram";
            ViewBag.Saroj = "My Name is Saroj";

            ViewData["Chandan"] = "My Name is Chandan";
            var result = new LoginResultViewModel();
            result.Message = "You have successfully logged in";
            result.Username = model.Username;

            return View(result);
        }

       
    }
}