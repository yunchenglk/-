using System.Web.Mvc;

namespace Learun.Application.Web.Areas.A_SystemInfo
{
    public class A_SystemInfoAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "A_SystemInfo";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "A_SystemInfo_default",
                "A_SystemInfo/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}