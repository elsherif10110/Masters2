namespace Masters2.Models
{
    public class ViewFormModel
    {
        public List<string> QustinosList { get; set; } = new List<string>();
        public List<string> AnswersList { get; set; } = new List<string>();


        // لحفظ البيانات في قاعدة البيانات
        public string AnswerRecord { get; set; } = string.Empty;
        public string QustionsRecord { get; set; } = string.Empty;

    }
}
