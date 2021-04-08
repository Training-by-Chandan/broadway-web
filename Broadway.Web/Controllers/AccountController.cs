using System.Web.Mvc;
using Broadway.Web.ViewModel;

namespace Broadway.Web.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginPageViewModel model)
        {
            if (!ModelState.IsValid) return View("Index", model);

            return View();
        }
    }
}