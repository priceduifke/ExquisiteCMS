using System.Web.Mvc;

namespace ExquisiteCMS.Areas.Webpage
{
    public class WebpageAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Webpage";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Webpage_default",
                "Webpage/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
