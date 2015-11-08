using System.Diagnostics.CodeAnalysis;
using System.Web.Http;
using System.Web.Mvc;
using Ericmas001.WebService.Areas.HelpPage.App_Start;

namespace Ericmas001.WebService.Areas.HelpPage
{
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public class HelpPageAreaRegistration : AreaRegistration
    {
        public override string AreaName => "HelpPage";

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "HelpPage_Default",
                "Help/{action}/{apiId}",
                new { controller = "Help", action = "Index", apiId = UrlParameter.Optional });

            HelpPageConfig.Register(GlobalConfiguration.Configuration);
        }
    }
}