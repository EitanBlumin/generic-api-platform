
namespace Serene.GenericAPIPlatform.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("GenericAPIPlatform/ApiType"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.ApiTypeRow))]
    public class ApiTypeController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/GenericAPIPlatform/ApiType/ApiTypeIndex.cshtml");
        }
    }
}