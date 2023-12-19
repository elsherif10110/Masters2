using System;
using System.Collections.Generic;

namespace Masters2.Models
{
    public partial class Result
    {
        public int ResultId { get; set; }
        public int? FormId { get; set; }
        public int? UserId { get; set; }
        public int? QuestionId { get; set; }
        public int? AnswerId { get; set; }
        public DateTime? ResultDate { get; set; }

        public virtual Answer? Answer { get; set; }
        public virtual Form? Form { get; set; }
        public virtual Question? Question { get; set; }
    }
}
