using System;
using System.Collections.Generic;

namespace Masters2.Models
{
    public partial class AnswerType
    {
        public AnswerType()
        {
            Answers = new HashSet<Answer>();
        }

        public int AnswerTypeId { get; set; }
        public string? AnswerTypeName { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<Answer> Answers { get; set; }
    }
}
