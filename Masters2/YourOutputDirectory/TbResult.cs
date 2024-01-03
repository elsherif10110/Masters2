using System;
using System.Collections.Generic;

namespace Masters2.YourOutputDirectory
{
    public partial class TbResult
    {
        public int ResultId { get; set; }
        public int? FormId { get; set; }
        public string? AnswersString { get; set; }
        public DateTime? AnswerDate { get; set; }
        public int? AnswersUserId { get; set; }
    }
}
