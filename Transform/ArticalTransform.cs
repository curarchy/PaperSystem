using System;
using System.Collections.Generic;
using System.Data;
using PaperSystem.Entity;

namespace PaperSystem.Transform
{
    public class ArticalTransform
    {
        /// <summary>
        /// 转实体
        /// </summary>
        /// <param name="dataRow"></param>
        /// <returns></returns>
        public static ArticalEntity Transform(DataRow dataRow)
        {
            ArticalEntity result = new ArticalEntity();
            result.ID = Convert.ToInt16(dataRow["ID"]);
            result.Memo = Convert.ToString(dataRow["Memo"]);
            result.Writter = Convert.ToString(dataRow["Writter"]);
            result.Title = Convert.ToString(dataRow["Title"]);
            result.Content = Convert.ToString(dataRow["Content"]);
            result.Grade = Convert.ToInt16(dataRow["Grade"]);

            return result;
        }

        public static List<ArticalEntity> Transform(DataTable dataTable)
        {
            List<ArticalEntity> result = new List<ArticalEntity>();
            foreach (DataRow dr in dataTable.Rows)
            {
                result.Add(Transform(dr));
            }
            return result;
        }
    }
}
