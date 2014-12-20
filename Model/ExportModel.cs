using System.Collections.Generic;
using PaperSystem.Entity;
using PaperSystem.IO;

namespace PaperSystem.Model
{
    public class ExportModel
    {
        /// <summary>
        /// 生成大题区域
        /// </summary>
        /// <param name="questions">问题集合</param>
        /// <param name="type">问题类型</param>
        /// <param name="index">第几题</param>
        /// <param name="point">单题分值</param>
        /// <returns></returns>
        public static string BuildPaper(List<QuestionBaseEntity> questions, int type, string index, int point = 2)
        {
            switch (type)
            { 
                case 1:
                    return ExportExplainModel.BuildSection(index, questions, point);
                case 2:
                    return ExportWriteModel.BuildSection(index, questions, point);
                case 3:
                    return ExportTranslateModel.BuildSection(index, questions, point);
                default:
                    return "";
            }
        }
        
        public static string WriteStringToFile(string content, string filePath)
        {
            string template = IOHelper.GetStringFromFile(@"ExportDocuments/OriginMain.tpl.html");
            string paper = template.Replace("${content}", content);
            return IOHelper.WriteStringToFile(content, filePath);
        }
    }
}
