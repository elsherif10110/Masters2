namespace Masters2.Models
{
    public class QuestionViewModel
    {
        public int QuestionId { get; set; }
        public string QuestionText { get; set; }
        public List<Answer> Answers { get; set; } // قائمة الإجابات المتاحة للسؤال
        public int SelectedAnswerId { get; set; } // الإجابة المختارة
    }
}
