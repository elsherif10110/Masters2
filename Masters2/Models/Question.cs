using System;
using System.Collections.Generic;

namespace Masters2.Models
{
    public partial class Question
    {
        public Question()
        {
            Results = new HashSet<Result>();
        }

        public int QuestionId { get; set; }
        public string? QuestionText { get; set; }
        public int? CategoryId { get; set; }

        public virtual Category? Category { get; set; }
        public virtual ICollection<Result> Results { get; set; }
    }
}