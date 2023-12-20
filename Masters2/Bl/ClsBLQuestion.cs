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

                string questions = context.TbQuestions.Select(a=>a.QuestionName).FirstOrDefault();

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

            Qustions = _GetRecordQustinoById(id).Split(" #//# ").ToList();

            return Qustions;
        }
        
        
    }
}
