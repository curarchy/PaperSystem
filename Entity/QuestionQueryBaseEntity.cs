using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PaperSystem.Entity
{
    public class QuestionQueryBaseEntity
    {
        public string Keyword { get; set; }

        public List<int> Type { get; set; }

        public List<int> Level { get; set; }

        public List<int> Grade { get; set; }
    }
}
