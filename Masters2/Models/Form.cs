using System;
using System.Collections.Generic;

namespace Masters2.Models
{
    public partial class Form
    {
        public Form()
        {
            Results = new HashSet<Result>();
        }

        public int FormId { get; set; }
        public DateTime? FormDate { get; set; }
        public int? CategoryId { get; set; }
        public int? AdminId { get; set; }
        public int? UserId { get; set; }

        public virtual Category? Category { get; set; }
        public virtual ICollection<Result> Results { get; set; }
    }
}
