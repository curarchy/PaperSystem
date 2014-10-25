using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using PaperSystem.Entity;
using Service;

namespace PaperSystem.Service
{
    public class QuestionService : ServiceBase
    {
        /// <summary>
        /// 新建题目
        /// </summary>
        /// <param name="question"></param>
        /// <returns></returns>
        public static int CreateQuestion(QuestionBaseEntity question) 
        {
            string connectString = DB_CONNECT_STRING;
            string commandText = "INSERT INTO Question (MainContent, AnswerA, Type, Level, Memo) ";
            commandText += "VALUES(@MainContent, @AnswerA, @Type, @Level, @Memo);";

            SQLiteParameter[] parameters = {
                                               new SQLiteParameter("@MainContent", question.MainContent),
                                               new SQLiteParameter("@AnswerA", question.AnswerA),
                                               new SQLiteParameter("@Type", question.Type),
                                               new SQLiteParameter("@Level", question.Level),
                                               new SQLiteParameter("@Memo", question.Memo)
                                           };


            return SQLiteHelper.ExecuteNonQuery(connectString, commandText, System.Data.CommandType.Text, parameters);
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="question"></param>
        /// <returns></returns>
        public static int ModifyQuestion(QuestionBaseEntity question)
        {
            string connectString = DB_CONNECT_STRING;
            string commandText = "UPDATE Question set MainContent = @MainContent, AnswerA = @AnswerA, ";
            commandText += "Type = @Type, Level = @Level, Memo = @Memo Where ID = @ID";

            SQLiteParameter[] parameters = {
                                               new SQLiteParameter("@ID", question.ID),
                                               new SQLiteParameter("@MainContent", question.MainContent),
                                               new SQLiteParameter("@AnswerA", question.AnswerA),
                                               new SQLiteParameter("@Type", question.Type),
                                               new SQLiteParameter("@Level", question.Level),
                                               new SQLiteParameter("@Memo", question.Memo)
                                           };

            return SQLiteHelper.ExecuteNonQuery(connectString, commandText, System.Data.CommandType.Text, parameters);
        }

        /// <summary>
        /// 查询单个实体
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static DataSet QuerySingle(int id) 
        {
            string connectString = DB_CONNECT_STRING;
            string commandText = "select * from Question t where t.ID = @ID ";

            SQLiteParameter[] parameters = {
                                               new SQLiteParameter("@ID", id)
                                           };

            return SQLiteHelper.ExecuteDataSet(connectString, commandText, CommandType.Text, parameters);
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public static DataSet QueryQuestion(QuestionQueryBaseEntity query) 
        {
            string connectString = DB_CONNECT_STRING;
            string commandText = "select ID, Level, MainContent, Type, Memo from Question t where 1=1 ";

            List<SQLiteParameter> parameters = new List<SQLiteParameter>();

            if (!string.IsNullOrEmpty(query.Keyword.Trim()))
            {
                commandText += "and (t.Memo like '%' || @Keyword || '%' ";
                commandText += " or '' || t.ID like '%' || @Keyword || '%' ";
                commandText += " or t.MainContent like '%' || @Keyword || '%' ";
                commandText += " or t.AnswerA like '%' || @Keyword || '%') ";
                SQLiteParameter param = new SQLiteParameter("@Keyword", query.Keyword);
                parameters.Add(param);
            }

            if (query.Level.Count > 0) 
            {
                commandText += "and t.Level in (";
                foreach (int level in query.Level) 
                {
                    commandText += level.ToString() + ",";
                }
                commandText = commandText.TrimEnd(',');
                commandText += ")";
            }

            return SQLiteHelper.ExecuteDataSet(connectString, commandText, CommandType.Text, parameters.ToArray());
        }

        /// <summary>
        /// 批量删除
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public static int DeleteQuestions(List<int> ids) {
            string connectString = DB_CONNECT_STRING;
            string commandText = "delete from Question where ID in ( ";
            foreach (int id in ids)
            {
                commandText += id.ToString() + ",";
            }
            commandText = commandText.TrimEnd(',');
            commandText += ")";

            return SQLiteHelper.ExecuteNonQuery(connectString, commandText, CommandType.Text);
        }
    }
}
