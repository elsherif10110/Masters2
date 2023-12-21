using Masters2.Models;

namespace Masters2.Bl
{
/*    public class clsTestModel
    {
        public List<string> QustinosList { get; set; } = new List<string>();

        public string Qustions { get; set; } = string.Empty;

        public List<string> AnswersList { get; set; } = new List<string>();

    }*/
    public class ClsBLQuestion
    {
        private string _GetRecordQustinoById(int id)
        {
            try
            {
                Masters2Context context = new Masters2Context();

                string questions = context.TbQuestions.Where(a=>a.QuestionId ==id).Select(a=>a.QuestionName).FirstOrDefault();

                return questions;
            }
            catch
            {
                return string.Empty;
            }
        }


        public List<string> GetQustionsById(int id)
        {

            List<string> Qustions = new List<string>();

            Qustions = _GetRecordQustinoById(id).Split("/*/").ToList();

            return Qustions;
        }

        public int GetLastId()
        {
            try
            {
                Masters2Context context = new Masters2Context();

                return context.TbQuestions.OrderByDescending(a => a.QuestionId).FirstOrDefault().QuestionId;
            }
            catch
            {
                return -1;
            }
        }


        private string _SeprationQustionsFromCategoryName(string QustionRecord)
        {
            List<string> list = new List<string>();
            string JustQustions = string.Empty;
            list = QustionRecord.Split("/*/").ToList();

            for (int i = 1; i < list.Count; i++)
            {
                if (i != list.Count - 1)
                {
                    JustQustions += list[i] + "/*/";
                }
                else
                {
                    JustQustions += list[i];
                }

            }
            return JustQustions;
        }

        public bool Save(string QustionRecord)
        {
            try
            {
                Masters2Context context = new Masters2Context();
                TbQuestion Qustion = new TbQuestion();



                Qustion.QuestionName = _SeprationQustionsFromCategoryName(QustionRecord).Trim();


                context.TbQuestions.Add(Qustion);

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
