namespace LEARNING_AREA.Areas.Administrator.Controllers
{
	public class UserController : System.Web.Mvc.Controller
	{
		public UserController() : base()
		{
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult List()
		{
			return View();
		}
	}
}
