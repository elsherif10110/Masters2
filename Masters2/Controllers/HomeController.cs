using Masters2.Bl;
using Masters2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Masters2.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        public IActionResult Link()
        {
          
            return View();
        }

        public IActionResult List()
        {
            Masters2Context ctx = new Masters2Context();
            var categories = ctx.TbCategories.ToList();
            return View(categories);
        }



        ////////////////////// فقط لتجربة حفظ الأسئلة/
        string[] GetQustionById(string Text, string Sep)
        {

            string[] Qustions = { };

            Qustions = Text.Split(Sep);

            return Qustions;
        }
        public IActionResult YourAction(string qustions)
        {

            ViewFormModel model = new ViewFormModel();

            model.QustinosList = GetQustionById(qustions, "/").ToList();


            return RedirectToAction("AddQustionsForm");
        }
        //////////////////////////////////////////////////////
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

