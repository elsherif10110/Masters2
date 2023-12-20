using System;
using System.Collections.Generic;

namespace Masters2.Models
{
    public partial class TbResult
    {
        public TbResult()
        {
            TbForms = new HashSet<TbForm>();
        }

        public int ResultId { get; set; }
        public string? ResultName { get; set; }
        public int? UserId { get; set; }
        public int? AdminId { get; set; }
        public DateTime? AnswerDate { get; set; }

        public virtual ICollection<TbForm> TbForms { get; set; }
    }
}
