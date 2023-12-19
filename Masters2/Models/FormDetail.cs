using System;
using System.Collections.Generic;

namespace Masters2.Models
{
    public partial class FormDetail
    {
        public int? FormId { get; set; }
        public int? AnswerId { get; set; }
        public int? AnswerTypeId { get; set; }
        public int? QuestionId { get; set; }

        public virtual Answer? Answer { get; set; }
        public virtual AnswerType? AnswerType { get; set; }
        public virtual Form? Form { get; set; }
        public virtual Question? Question { get; set; }
    }
}
