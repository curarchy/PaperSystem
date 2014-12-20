using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using PaperSystem.Entity;
using Service;

namespace PaperSystem.Service
{
    public class ArticalService : ServiceBase
    {
        /// <summary>
        /// 新建文章
        /// </summary>
        /// <param name="artical"></param>
        /// <returns></returns>
        public static int CreateArtical(ArticalEntity artical)
        {
            string connectString = DB_CONNECT_STRING;
            string commandText = "INSERT INTO Artical (Title, Content, Grade, Writter, Memo ) ";
            commandText += "VALUES(@Title, @Content, @Grade, @Writter, @Memo );";

            SQLiteParameter[] parameters = {
                                               new SQLiteParameter("@Title", artical.Title),
                                               new SQLiteParameter("@Content", artical.Content),
                                               new SQLiteParameter("@Grade", artical.Grade),
                                               new SQLiteParameter("@Writter", artical.Writter),
                                               new SQLiteParameter("@Memo", artical.Memo)
                                           };

            return SQLiteHelper.ExecuteNonQuery(connectString, commandText, System.Data.CommandType.Text, parameters);
        }

        /// <summary>
        /// 查询文章
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public static DataSet QueryArtical(ArticalQueryEntity query)
        {
            string connectString = DB_CONNECT_STRING;
            string commandText = "select t.ID, t.Title, substr(t.Content, 1, 100) as Content, t.Writter, t.Grade, ";
            commandText += " t.Memo, q.value as GradeText from Artical t inner join ";
            commandText += " Grade q on t.Grade = q.ID where 1=1 ";

            List<SQLiteParameter> parameters = new List<SQLiteParameter>();

            if (!string.IsNullOrEmpty(query.Keyword.Trim()))
            {
                commandText += "and (t.Content like '%' || @Keyword || '%' ";
                commandText += " or '' || t.ID like '%' || @Keyword || '%' ";
                commandText += " or t.Writter like '%' || @Keyword || '%' ";
                commandText += " or t.Memo like '%' || @Keyword || '%') ";
                SQLiteParameter param = new SQLiteParameter("@Keyword", query.Keyword);
                parameters.Add(param);
            }

            if (query.Grade.Count > 0)
            {
                commandText += " and t.Grade in (";
                foreach (int grade in query.Grade)
                {
                    commandText += grade.ToString() + ",";
                }
                commandText = commandText.TrimEnd(',');
                commandText += ")";
            }

            return SQLiteHelper.ExecuteDataSet(connectString, commandText, CommandType.Text, parameters.ToArray());
        }

        /// <summary>
        /// 查询文章标题
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public static DataSet QueryAllArtical()
        {
            string connectString = DB_CONNECT_STRING;
            string commandText = "select t.ID, t.Title, t.Writter, t.Grade, ";
            commandText += " q.value as GradeText from Artical t inner join ";
            commandText += " Grade q on t.Grade = q.ID ";

            return SQLiteHelper.ExecuteDataSet(connectString, commandText, CommandType.Text);
        }

        /// <summary>
        /// 批量删除
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public static int DeletArticals(List<int> ids)
        {
            string connectString = DB_CONNECT_STRING;
            string commandText = "delete from Artical where ID in ( ";
            foreach (int id in ids)
            {
                commandText += id.ToString() + ",";
            }
            commandText = commandText.TrimEnd(',');
            commandText += ")";

            return SQLiteHelper.ExecuteNonQuery(connectString, commandText, CommandType.Text);
        }

        /// <summary>
        /// 查询单个实体
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static DataSet QuerySingle(int id)
        {
            string connectString = DB_CONNECT_STRING;
            string commandText = "select * from Artical t where t.ID = @ID ";

            SQLiteParameter[] parameters = {
                                               new SQLiteParameter("@ID", id)
                                           };

            return SQLiteHelper.ExecuteDataSet(connectString, commandText, CommandType.Text, parameters);
        }

        /// <summary>
        /// 查询单个实体
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static DataSet QuerySingle(string name)
        {
            string connectString = DB_CONNECT_STRING;
            string commandText = "select * from Artical t where t.Title = @Title ";

            SQLiteParameter[] parameters = {
                                               new SQLiteParameter("@Title", name)
                                           };

            return SQLiteHelper.ExecuteDataSet(connectString, commandText, CommandType.Text, parameters);
        }
    }
}
