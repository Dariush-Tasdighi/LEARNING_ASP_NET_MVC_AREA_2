using System.Web.Mvc;

namespace LEARNING_AREA.Areas.Administrator
{
	public class AdministratorAreaRegistration : AreaRegistration
	{
		public AdministratorAreaRegistration() : base()
		{
		}

		public override string AreaName
		{
			get
			{
				return "Administrator";
			}
		}

		public override void RegisterArea(AreaRegistrationContext context)
		{
			//context.MapRoute(
			//	"Administrator_Default",
			//	"Administrator/{controller}/{action}/{id}",
			//	new { action = "Index", id = UrlParameter.Optional }
			//);

			context.MapRoute(
				"Administrator_Default",
				"Administrator/{controller}/{action}/{id}",
				new { controller = "Home", action = "Index", id = UrlParameter.Optional }
			);
		}
	}
}
