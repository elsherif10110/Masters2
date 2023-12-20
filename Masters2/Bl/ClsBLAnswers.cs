using Masters2.Models;


namespace Masters2.Bl
{
    public class ClsBLAnswers
    {
        public bool Save(ViewFormModel modelView)
        {
            try
            {
                Masters2Context context = new Masters2Context();
                TbAnswer answer = new TbAnswer();

                answer.AnswerName = modelView.AnswerRecord.Trim();


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
