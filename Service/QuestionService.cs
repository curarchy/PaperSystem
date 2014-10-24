using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PaperSystem.Entity;
using Service;
using System.Data.SQLite;
using System.Data;

namespace PaperSystem.Service
{
    public class QuestionService : ServiceBase
    {
        /// <summary>
        /// 新建题目
        /// </summary>
        /// <param name="question"></param>
        /// <returns></returns>
        public static int CreateQuestion(QuestionBaseEntity question) {
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
        /// 查询
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public static DataSet QueryQuestion(QuestionQueryBaseEntity query) {
            string connectString = DB_CONNECT_STRING;
            string commandText = "select ID, Level, MainContent, Type, Memo from Question t where 1=1 ";
            return SQLiteHelper.ExecuteDataSet(connectString, commandText, CommandType.Text, null);
        }
    }
}
