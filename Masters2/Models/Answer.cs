using System;
using System.Collections.Generic;

namespace Masters2.Models
{
    public partial class Answer
    {
        public Answer()
        {
            Results = new HashSet<Result>();
        }

        public int AnswerId { get; set; }
        public int? AnswerTypeId { get; set; }
        public string? AnswerText { get; set; }

        public virtual AnswerType? AnswerType { get; set; }
        public virtual ICollection<Result> Results { get; set; }
    }
}
