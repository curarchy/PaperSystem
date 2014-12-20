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

        /// <summary>
        /// 建造大题文字
        /// </summary>
        /// <param name="index">第几题</param>
        /// <param name="count">题目数量</param>
        /// <param name="point">分值</param>
        /// <returns></returns>
        public static string BuildHeader(string index, int count, int point = 2)
        {
            string template = IOHelper.GetStringFromFile(@"ExportDocuments/explain/QuestionHeader.tpl.html");
            string points = point.ToString() + "*" + count.ToString() + "=" + (count * point).ToString();
            return template.Replace("${index}", index)
                .Replace("${Point}", points);
        }

        public static string BuildSection(string index, List<QuestionBaseEntity> questions, int point = 2)
        {
            return BuildHeader(index, questions.Count, point) + BuildQuestions(questions);
        }
    }
}
