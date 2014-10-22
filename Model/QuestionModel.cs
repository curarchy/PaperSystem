using PaperSystem.Entity;
using PaperSystem.Service;

namespace PaperSystem.Model
{
    public class QuestionModel
    {
        public static int AddQuestion(QuestionBaseEntity question) {
            return QuestionService.CreateQuestion(question);
        }
    }
}
