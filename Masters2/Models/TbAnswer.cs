using System;
using System.Collections.Generic;

namespace Masters2.Models
{
    public partial class TbAnswer
    {
        public TbAnswer()
        {
            TbForms = new HashSet<TbForm>();
        }

        public int AnswerId { get; set; }
        public string? AnswerName { get; set; }

        public virtual ICollection<TbForm> TbForms { get; set; }
    }
}
