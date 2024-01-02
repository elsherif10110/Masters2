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
        
/*
        public IActionResult Forms()
        {
            ClsBLQuestion question = new ClsBLQuestion();
            VwFormsData modelView = new VwFormsData();

            modelView.QustinosList = question.GetQustionsById(12);

            modelView.AnswersList = new List<string>(new string[modelView.QustinosList.Count]);

            return View(modelView);
        }


        public IActionResult btnSaveUserQustions(string qustionsRecord)
        {

            ClsTbCategories categories = new ClsTbCategories();
            ClsBlForms Forms = new ClsBlForms();
            VwFormsData Model = new VwFormsData();

            Model.tbCategory.CategoryName = categories.GetCategoryFromQustionRecord(qustionsRecord);
            Model.TbQuestion.QuestionName = qustionsRecord;

            

            Forms.Save(Model);

            return RedirectToAction("");
        }


        public IActionResult btnSaveUserAnswers(VwFormsData model)
        {

            ClsBLAnswers answers = new ClsBLAnswers();

            answers.Save(model);

            return RedirectToAction("");
        }*/
    }
}