namespace LEARNING_AREA.Controllers
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
