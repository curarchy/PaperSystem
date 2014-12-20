using System.Collections.Generic;
using System.Data;
using PaperSystem.Entity;
using PaperSystem.Service;
using PaperSystem.Transform;

namespace PaperSystem.Model
{
    public class ArticalModel
    {
        /// <summary>
        /// 新建文章
        /// </summary>
        /// <param name="artical"></param>
        /// <returns></returns>
        public static int AddArtical(ArticalEntity artical)
        {
            return ArticalService.CreateArtical(artical);
        }

        /// <summary>
        /// 查询文章
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public static DataSet QueryArtical(ArticalQueryEntity query)
        {
            return ArticalService.QueryArtical(query);
        }

        /// <summary>
        /// 查询文章概述
        /// </summary>
        /// <returns></returns>
        public static DataSet QueryAllArtical()
        {
            return ArticalService.QueryAllArtical();
        }

        /// <summary>
        /// 删除文章
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public static int DeleteArticals(List<int> ids)
        {
            return ArticalService.DeletArticals(ids);
        }

        /// <summary>
        /// 根据ID查询文章
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static ArticalEntity QuerySingle(int id)
        {
            DataSet ds = ArticalService.QuerySingle(id);
            DataRow dr = ds.Tables[0].Rows[0];
            if (dr != null)
            {
                return ArticalTransform.Transform(dr);
            }
            return null;
        }

        /// <summary>
        /// 根据名字查询文章
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static ArticalEntity QuerySingle(string name)
        {
            DataSet ds = ArticalService.QuerySingle(name);
            DataRow dr = ds.Tables[0].Rows[0];
            if (dr != null)
            {
                return ArticalTransform.Transform(dr);
            }
            return null;
        }

        public static DataTable GetArticalsFromExcel(string file)
        {
            DataTable dt = new DataTable();

            List<string> tables = new List<string>()
            {
                "文章"
            };

            foreach (string table in tables)
            {
                DataSet tableDs = ExcelService.GetDataSetFromExcel(file, table);
                dt.Merge(tableDs.Tables[0], true, MissingSchemaAction.Add);
            }

            return dt;
        }
    }
}
