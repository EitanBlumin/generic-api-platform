
namespace Serene.GenericAPIPlatform.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("GenericAPIPlatform/ApiHeaders"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.ApiHeadersRow))]
    public class ApiHeadersController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/GenericAPIPlatform/ApiHeaders/ApiHeadersIndex.cshtml");
        }
    }
}