using System.Collections.Generic;
using PaperSystem.Entity;
using PaperSystem.IO;

namespace PaperSystem.Model
{
    public class ExportExplainModel
    {
        public const string UNDERLINE = "_________";

        public static string BuildQuestion(QuestionBaseEntity question, int index = 1)
        {
            string template = IOHelper.GetStringFromFile(@"ExportDocuments/explain/Question.tpl.html");
            return template.Replace("${index}", index.ToString())
                .Replace("${Question}", question.Question)
                .Replace("${Keyword}", question.Keyword)
                .Replace("${Answer}", UNDERLINE);
        }

        public static string BuildQuestions(List<QuestionBaseEntity> questions)
        {
            string result = "";
            int i = 0;
            foreach (QuestionBaseEntity question in questions)
            {
                i++;
                result += BuildQuestion(question, i);
            }
            return result;
        }

        public static string BuildHeader(string index)
        {
            string template = IOHelper.GetStringFromFile(@"ExportDocuments/explain/QuestionHeader.tpl.html");
            return template.Replace("${index}", index);
        }

        public static string BuildSection(string index, List<QuestionBaseEntity> questions)
        {
            return BuildHeader(index) + BuildQuestions(questions);
        }
    }
}
