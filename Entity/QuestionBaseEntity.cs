
namespace PaperSystem.Entity
{
    public class QuestionBaseEntity
    {
        public int ID { get; set; }

        public string MainContent { get; set; }

        public string AnswerA { get; set; }

        public string AnswerB { get; set; }

        public string AnswerC { get; set; }

        public string AnswerD { get; set; }

        public int Type { get; set; }

        public int Level { get; set; }

        public string Memo { get; set; }
    }
}
