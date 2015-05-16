
using System.Web;
using System.Web.Mvc;


namespace E_xam_test.Controllers
{
    public class ExamsController : Controller
    {

        // GET: Exams
        public ActionResult Index()
        {
            ViewBag.Message = "lol";

            return View();
        }

        //string name = "<default exam name>"
        public string Add(int id)
        {
            return HttpUtility.HtmlEncode("Added exam with id: " + id);
        }
    }
}