
namespace Serene.GenericAPIPlatform.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("GenericAPIPlatform/ApiTargetFieldValues"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.ApiTargetFieldValuesRow))]
    public class ApiTargetFieldValuesController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/GenericAPIPlatform/ApiTargetFieldValues/ApiTargetFieldValuesIndex.cshtml");
        }
    }
}