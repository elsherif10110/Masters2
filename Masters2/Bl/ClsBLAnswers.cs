using Masters2.Models;


namespace Masters2.Bl
{
    public class ClsBLAnswers
    {


        public string GetAnswersRecord(VwFormsData model)
        {
            string allQ = string.Empty;

            for (int i = 0; i < model.AnswersList.Count; i++)
            {
                if (i != model.AnswersList.Count - 1)
                {
                    allQ += model.AnswersList[i] + "/*/";
                }
                else
                {
                    allQ += model.AnswersList[i];
                }
            }
            return allQ;
        }
        public bool Save(VwFormsData model)
        {
            try
            {
                Masters2Context context = new Masters2Context();
                TbAnswer answer = new TbAnswer();


                answer.AnswerName = GetAnswersRecord(model);


                context.TbAnswers.Add(answer);

                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public int GetLastId()
        {
            try
            {
                Masters2Context context = new Masters2Context();

                return context.TbAnswers.OrderByDescending(a => a.AnswerId).FirstOrDefault().AnswerId;
            }
            catch
            {
                return -1;
            }
        }
    }
}
