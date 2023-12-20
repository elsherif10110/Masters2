using Masters2.Bl;
using Masters2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Masters2.Controllers
{

    public class FormsController : Controller
    {
        public IActionResult Question()
        {
            

            return View();
        }

        public IActionResult Forms()
        {
            ClsBLQuestion question = new ClsBLQuestion();
            ViewFormModel modelView = new ViewFormModel();

            modelView.QustinosList = question.GetQustionsById(3);

            modelView.AnswersList = new List<string>(new string[modelView.QustinosList.Count]);

            return View(modelView);
        }
        ///Hello Iam Edit
        ///

        public IActionResult btnSaveUserQustions(string qustionsRecord)
        {

            ClsBLQuestion qustions = new ClsBLQuestion();
            ClsTbCategories categories = new ClsTbCategories();
            

            string categoryName = categories.GetCategoryFromQustionRecord(qustionsRecord);



            categories.Save(categoryName);
            qustions.Save(qustionsRecord);

            return RedirectToAction("");
        }


        public IActionResult btnSaveUserAnswers(ViewFormModel qustionsRecord)
        {

           

            return RedirectToAction("");
        }
    }
}