using System;
using System.Data;
using PaperSystem.Entity;
using System.Collections.Generic;

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
            result.Answer = Convert.ToString(dataRow["Answer"]);
            result.Artical = Convert.ToInt16(dataRow["Artical"]);
            result.ID = Convert.ToInt16(dataRow["ID"]);
            result.Keyword = Convert.ToString(dataRow["Keyword"]);            
            result.Level = Convert.ToInt16(dataRow["Level"]);
            result.Memo = Convert.ToString(dataRow["Memo"]);
            result.Question = Convert.ToString(dataRow["Question"]);
            result.Type = Convert.ToInt16(dataRow["Type"]);
            result.Writter = Convert.ToString(dataRow["Writter"]);
            result.Paragraph = Convert.ToInt16(dataRow["Paragraph"]);

            return result;
        }

        public static List<QuestionBaseEntity> Transform(DataTable dataTable)
        {
            List<QuestionBaseEntity> result = new List<QuestionBaseEntity>();
            foreach (DataRow dr in dataTable.Rows)
            {
                result.Add(Transform(dr));
            }
            return result;
        }
    }
}
