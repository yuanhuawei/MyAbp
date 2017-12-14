using System.Web.Mvc;

namespace CardCloud.Web.Controllers
{
    public class AboutController : CardCloudControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}