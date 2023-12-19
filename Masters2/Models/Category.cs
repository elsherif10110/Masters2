using System;
using System.Collections.Generic;

namespace Masters2.Models
{
    public partial class Category
    {
        public Category()
        {
            Forms = new HashSet<Form>();
            Questions = new HashSet<Question>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public virtual ICollection<Form> Forms { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
    }
}
