using PaperSystem.Entity;
using PaperSystem.Service;
using System.Data;

namespace PaperSystem.Model
{
    public class QuestionModel
    {
        public static int AddQuestion(QuestionBaseEntity question) {
            return QuestionService.CreateQuestion(question);
        }

        public static DataSet QueryQuestion(QuestionQueryBaseEntity query) {
            return QuestionService.QueryQuestion(query);
        }
    }
}
