using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace CardCloud.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : CardCloudControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}