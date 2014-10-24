using System;
using System.Data;
using PaperSystem.Entity;

namespace PaperSystem.Transform
{
    public class QuestionBaseTransform
    {
        /// <summary>
        /// 转实体
        /// </summary>
        /// <param name="dataRow"></param>
        /// <returns></returns>
        public static QuestionBaseEntity Transform(DataRow dataRow)
        {
            QuestionBaseEntity result = new QuestionBaseEntity();
            result.ID = Convert.ToInt16(dataRow["ID"]);
            result.Level = Convert.ToInt16(dataRow["Level"]);
            result.MainContent = Convert.ToString(dataRow["MainContent"]);
            result.Memo = Convert.ToString(dataRow["Memo"]);
            result.Type = Convert.ToInt16(dataRow["Type"]);
            result.AnswerA = Convert.ToString(dataRow["AnswerA"]);

            return result;
        }
    }
}
