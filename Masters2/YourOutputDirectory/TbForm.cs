using System;
using System.Collections.Generic;

namespace Masters2.YourOutputDirectory
{
    public partial class TbForm
    {
        public int FormId { get; set; }
        public int? CategoryId { get; set; }
        public string? FormTitle { get; set; }
        public string? QuestionString { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? ConstructorId { get; set; }
    }
}
