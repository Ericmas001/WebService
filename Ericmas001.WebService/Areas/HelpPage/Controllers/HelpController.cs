using System;
using System.Diagnostics.CodeAnalysis;
using System.Web.Http;
using System.Web.Mvc;
using Ericmas001.WebService.Areas.HelpPage.ModelDescriptions;
using Ericmas001.WebService.Areas.HelpPage.Models;

namespace Ericmas001.WebService.Areas.HelpPage.Controllers
{
    /// <summary>
    /// The controller that will handle requests for the help page.
    /// </summary>
    public class HelpController : Controller
    {
        private const string ERROR_VIEW_NAME = "Error";

        [SuppressMessage("ReSharper", "UnusedMember.Global")]
        public HelpController()
            : this(GlobalConfiguration.Configuration)
        {
        }

        private HelpController(HttpConfiguration config)
        {
            Configuration = config;
        }

        private HttpConfiguration Configuration { get; }

        public ActionResult Index()
        {
            ViewBag.DocumentationProvider = Configuration.Services.GetDocumentationProvider();
            return View(Configuration.Services.GetApiExplorer().ApiDescriptions);
        }

        public ActionResult Api(string apiId)
        {
            if (!String.IsNullOrEmpty(apiId))
            {
                HelpPageApiModel apiModel = Configuration.GetHelpPageApiModel(apiId);
                if (apiModel != null)
                {
                    return View(apiModel);
                }
            }

            return View(ERROR_VIEW_NAME);
        }

        public ActionResult ResourceModel(string modelName)
        {
            if (!String.IsNullOrEmpty(modelName))
            {
                ModelDescriptionGenerator modelDescriptionGenerator = Configuration.GetModelDescriptionGenerator();
                ModelDescription modelDescription;
                if (modelDescriptionGenerator.GeneratedModels.TryGetValue(modelName, out modelDescription))
                {
                    return View(modelDescription);
                }
            }

            return View(ERROR_VIEW_NAME);
        }
    }
}