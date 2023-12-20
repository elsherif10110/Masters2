using System;
using System.Collections.Generic;

namespace Masters2.Models
{
    public partial class TbForm
    {
        public int FormId { get; set; }
        public int? CategoryId { get; set; }
        public int? QuestionId { get; set; }
        public int? AnswerId { get; set; }
        public DateTime? FormDate { get; set; }
        public int? AdminId { get; set; }
        public int? UserId { get; set; }
        public int? ResultId { get; set; }

        public virtual TbAnswer? Answer { get; set; }
        public virtual TbCategory? Category { get; set; }
        public virtual TbQuestion? Question { get; set; }
        public virtual TbResult? Result { get; set; }
    }
}
