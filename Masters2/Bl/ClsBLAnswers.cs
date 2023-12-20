using Masters2.Models;


namespace Masters2.Bl
{
    public class ClsBLAnswers
    {
        /*public List<string> Get*/

        /*public string GetAnswersRecord(List<string> answersList)
        {
            string allQ = string.Empty;

            for (int i = 0; i < model.AnswersList.Count; i++)
            {
                if (i != model.AnswersList.Count - 1)
                {
                    allQ += model.AnswersList[i] + " #//# ";
                }
                else
                {
                    allQ += model.AnswersList[i];
                }
            }
        }*/
        public bool Save(ViewFormModel model)
        {
            try
            {
                Masters2Context context = new Masters2Context();
                TbAnswer answer = new TbAnswer();





                context.TbAnswers.Add(answer);

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
