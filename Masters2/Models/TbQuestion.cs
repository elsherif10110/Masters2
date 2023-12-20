using System;
using System.Collections.Generic;

namespace Masters2.Models
{
    public partial class TbQuestion
    {
        public TbQuestion()
        {
            TbForms = new HashSet<TbForm>();
        }

        public int QuestionId { get; set; }
        public string? QuestionName { get; set; }

        public virtual ICollection<TbForm> TbForms { get; set; }
    }
}
