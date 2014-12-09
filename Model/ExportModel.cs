using System.Collections.Generic;
using PaperSystem.Entity;
using PaperSystem.IO;

namespace PaperSystem.Model
{
    public class ExportModel
    {
        public static string BuildPaper(List<QuestionBaseEntity> questions, int type, string index)
        {
            switch (type)
            { 
                case 1:
                    return ExportExplainModel.BuildSection(index, questions);
                case 2:
                    return ExportWriteModel.BuildSection(index, questions);
                case 3:
                    return ExportTranslateModel.BuildSection(index, questions);
                default:
                    return "";
            }
        }
        
        public static string WriteStringToFile(string content)
        {
            string template = IOHelper.GetStringFromFile(@"ExportDocuments/OriginMain.tpl.html");
            string paper = template.Replace("${content}", content);
            return IOHelper.WriteStringToFile(content);
        }
    }
}
