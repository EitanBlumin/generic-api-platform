
namespace Serene.GenericAPIPlatform.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("GenericAPIPlatform/ApiTarget"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.ApiTargetRow))]
    public class ApiTargetController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/GenericAPIPlatform/ApiTarget/ApiTargetIndex.cshtml");
        }
    }
}