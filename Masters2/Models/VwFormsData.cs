namespace Masters2.Models
{
    public class VwFormsData
    {
        public VwFormsData()
        {
            tbCategory = new TbCategory();
            TbQuestion = new TbQuestion();
            tbAnswer = new TbAnswer();
            tbResult = new TbResult(); 
        }


        public int FormId { get; set; }
        public TbCategory tbCategory { get; set; }
        public TbQuestion TbQuestion { get; set; }
        public TbAnswer tbAnswer { get; set; }
        public DateTime FormDate { get; set; } = DateTime.Now;
        public int AdminId { get; set; }
        public int UserId { get; set; }
        public TbResult tbResult { get; set; }

        public List<string> QustinosList { get; set; } = new List<string>();
        public List<string> AnswersList { get; set; } = new List<string>();

    }
}
