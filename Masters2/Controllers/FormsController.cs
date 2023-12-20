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

            modelView.QustinosList = question.GetQustionsById(1);

            modelView.AnswersList = new List<string>(new string[modelView.QustinosList.Count]);

            return View(modelView);
        }
        ///Hello Iam Edit
        ///

        public IActionResult btnSaveUserAnswer(ViewFormModel model)
        {
            ClsBLAnswers answer = new ClsBLAnswers();

            string alls = string.Empty;

            for (int i = 0; i < model.AnswersList.Count; i++)
            {
                if (i != model.AnswersList.Count - 1)
                {
                    model.AnswerRecord += model.AnswersList[i] + " #//# ";
                }
                else
                {
                    model.AnswerRecord += model.AnswersList[i];
                }
            }

            alls = model.AnswerRecord.Trim();

            answer.Save(model);

            return RedirectToAction("");
        }
    }
}
