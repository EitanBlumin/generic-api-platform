
namespace Serene.GenericAPIPlatform.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("GenericAPIPlatform/ApiFields"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.ApiFieldsRow))]
    public class ApiFieldsController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/GenericAPIPlatform/ApiFields/ApiFieldsIndex.cshtml");
        }
    }
}