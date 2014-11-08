using System;
using System.Collections.Generic;
using System.Data;
using PaperSystem.Entity;

namespace PaperSystem.Transform
{
    public class CommonTransform
    {
        /// <summary>
        /// 转实体
        /// </summary>
        /// <param name="dataRow"></param>
        /// <returns></returns>
        public static CommonEntity Transform(DataRow dataRow)
        {
            CommonEntity result = new CommonEntity();
            result.ID = Convert.ToInt16(dataRow["ID"]);
            result.Key = Convert.ToInt16(dataRow["Key"]);
            result.Value = Convert.ToString(dataRow["Value"]);

            return result;
        }

        public static List<CommonEntity> Transform(DataTable dataTable)
        {
            List<CommonEntity> result = new List<CommonEntity>();
            foreach (DataRow dr in dataTable.Rows)
            {
                result.Add(Transform(dr));
            }
            return result;
        }
    }
}
