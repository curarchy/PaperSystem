using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PaperSystem.Entity
{
    public class QuestionQueryBaseEntity
    {
        public string Keyword { get; set; }

        public int[] Type { get; set; }

        public int[] Level { get; set; }
    }
}
