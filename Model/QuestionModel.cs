using System.Collections.Generic;
using System.Data;
using PaperSystem.Entity;
using PaperSystem.Service;
using PaperSystem.Transform;

namespace PaperSystem.Model
{
    public class QuestionModel
    {
        public static int AddQuestion(QuestionBaseEntity question) 
        {
            return QuestionService.CreateQuestion(question);
        }

        public static DataSet QueryQuestion(QuestionQueryBaseEntity query) 
        {
            return QuestionService.QueryQuestion(query);
        }

        public static int DeleteQuestions(List<int> ids) 
        {
            return QuestionService.DeleteQuestions(ids);
        }

        public static QuestionBaseEntity QuerySingle(int id)
        {
            DataSet ds = QuestionService.QuerySingle(id);
            DataRow dr = ds.Tables[0].Rows[0];
            if (dr != null)
            {
                return QuestionBaseTransform.Transform(dr);
            }
            return null;
        }

        public static int ModifyQuestion(QuestionBaseEntity question)
        {
            return QuestionService.ModifyQuestion(question);
        }

        public static DataSet GetQuestionsFromExcel(string file)
        {
            return ExcelService.GetQuestionsFromExcel(file);
        }
    }
}
