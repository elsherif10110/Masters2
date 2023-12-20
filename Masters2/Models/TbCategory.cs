using System;
using System.Collections.Generic;

namespace Masters2.Models
{
    public partial class TbCategory
    {
        public TbCategory()
        {
            TbForms = new HashSet<TbForm>();
        }

        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }

        public virtual ICollection<TbForm> TbForms { get; set; }
    }
}
