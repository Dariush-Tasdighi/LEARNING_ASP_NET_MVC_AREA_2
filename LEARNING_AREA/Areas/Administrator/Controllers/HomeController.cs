namespace LEARNING_AREA.Areas.Administrator.Controllers
{
	public class HomeController : System.Web.Mvc.Controller
	{
		public HomeController() : base()
		{
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Index()
		{
			return View();
		}
	}
}
