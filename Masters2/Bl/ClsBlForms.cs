using Masters2.Models;

namespace Masters2.Bl
{
    public class ClsBlForms
    {

        public TbForm GetById(int id)
        {
            try
            {
                Masters2Context context = new Masters2Context();

                return context.TbForms.Where(a => a.FormId == id).FirstOrDefault();
            }
            catch 
            {
               return new TbForm();
            }
        }

        public bool Save(VwFormsData model)
        {
            try
            {
                Masters2Context context = new Masters2Context();
                TbForm forms = new TbForm();

                // BL
                ClsTbCategories categories = new ClsTbCategories();
                ClsBLAnswers answers = new ClsBLAnswers();
                ClsBLQuestion question = new ClsBLQuestion();
        


                if (categories.Save(model.tbCategory.CategoryName))
                {
                    model.tbCategory.CategoryId = categories.GetLastId();
                }

                if(question.Save(model.TbQuestion.QuestionName))
                {
                    model.TbQuestion.QuestionId = question.GetLastId();
                }

                forms.CategoryId = model.tbCategory.CategoryId;

                forms.QuestionId = model.TbQuestion.QuestionId;

                forms.FormDate = DateTime.Now;

                context.TbForms.Add(forms);

                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
