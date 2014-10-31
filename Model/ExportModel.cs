using System.Collections.Generic;
using System.Data;
using PaperSystem.Entity;
using PaperSystem.IO;
using PaperSystem.Transform;

namespace PaperSystem.Model
{
    public class ExportModel
    {
        public static string BuildPaper(List<QuestionBaseEntity> questions)
        { 
            //暂时只有翻译
            string template = IOHelper.GetStringFromFile(@"ExportDocuments/OriginMain.tpl.html");
            string content = ExportTranslateModel.BuildSection("一. ", questions);
            string paper = template.Replace("${content}", content);
            return IOHelper.WriteStringToFile(paper);
        }

        public static string BuildPaper(DataTable dataTable)
        {
            List<QuestionBaseEntity> questions = QuestionBaseTransform.Transform(dataTable);
            return BuildPaper(questions);
        }
    }
}
