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
            string commandText = "INSERT INTO Question (Question, Answer, Type, Level, Memo, Artical, Keyword, Paragraph) ";
            commandText += "VALUES(@Question, @Answer, @Type, @Level, @Memo, @Artical, @Keyword, @Paragraph);";

            SQLiteParameter[] parameters = {
                                               new SQLiteParameter("@Question", question.Question),
                                               new SQLiteParameter("@Answer", question.Answer),
                                               new SQLiteParameter("@Type", question.Type),
                                               new SQLiteParameter("@Level", question.Level),
                                               new SQLiteParameter("@Memo", question.Memo),
                                               new SQLiteParameter("@Writter", question.Writter),
                                               new SQLiteParameter("@Artical", question.Artical),
                                               new SQLiteParameter("@Keyword", question.Keyword),
                                               new SQLiteParameter("@Paragraph", question.Paragraph)
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
            string commandText = "UPDATE Question set Question = @Question, Answer = @Answer, ";
            commandText += "Type = @Type, Level = @Level, Memo = @Memo, ";
            commandText += " Artical = @Artical, Keyword = @Keyword, Paragraph = @Paragraph Where ID = @ID";

            SQLiteParameter[] parameters = {
                                               new SQLiteParameter("@ID", question.ID),
                                               new SQLiteParameter("@Question", question.Question),
                                               new SQLiteParameter("@Answer", question.Answer),
                                               new SQLiteParameter("@Type", question.Type),
                                               new SQLiteParameter("@Level", question.Level),
                                               new SQLiteParameter("@Memo", question.Memo),
                                               new SQLiteParameter("@Writter", question.Writter),
                                               new SQLiteParameter("@Artical", question.Artical),
                                               new SQLiteParameter("@Keyword", question.Keyword),
                                               new SQLiteParameter("@Paragraph", question.Paragraph)
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
            string commandText = "select t.ID, t.Level, t.Question, t.Answer, t.Type, t.Memo, t.Artical, t.Grade, t.Paragraph, ";
            commandText += "q.Value as GradeText, r.Value as LevelText, s.Value as TypeText, ";
            commandText += "a.Title as Title, a.Writter as Writter, a.Grade as Grade ";
            commandText += "from Question t inner join Grade q on a.Grade = q.Key ";
            commandText += " inner join Level r on t.Level = r.Key ";
            commandText += " inner join Type s on t.Type = s.Key ";
            commandText += " inner join Artical a on t.Artical = a.ID where 1=1 ";

            List<SQLiteParameter> parameters = new List<SQLiteParameter>();

            if (!string.IsNullOrEmpty(query.Keyword.Trim()))
            {
                commandText += "and (t.Question like '%' || @Keyword || '%' ";
                commandText += " or '' || t.ID like '%' || @Keyword || '%' ";
                commandText += " or t.Answer like '%' || @Keyword || '%' ";
                commandText += " or a.Writter like '%' || @Keyword || '%' ";
                commandText += " or a.Title like '%' || @Keyword || '%' ";
                commandText += " or t.Keyword like '%' || @Keyword || '%' ";
                commandText += " or t.Memo like '%' || @Keyword || '%') ";
                SQLiteParameter param = new SQLiteParameter("@Keyword", query.Keyword);
                parameters.Add(param);
            }

            if (query.Level.Count > 0) 
            {
                commandText += " and t.Level in (";
                foreach (int level in query.Level) 
                {
                    commandText += level.ToString() + ",";
                }
                commandText = commandText.TrimEnd(',');
                commandText += ")";
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

            if (query.Type.Count > 0)
            {
                commandText += " and t.Type in (";
                foreach (int type in query.Type)
                {
                    commandText += type.ToString() + ",";
                }
                commandText = commandText.TrimEnd(',');
                commandText += ")";
            }

            return SQLiteHelper.ExecuteDataSet(connectString, commandText, CommandType.Text, parameters.ToArray());
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public static DataSet QueryQuestionByIDs(List<int> ids)
        {
            string connectString = DB_CONNECT_STRING;
            string commandText = "select ID, Level, Question, Answer, Type, Memo, Writter, Artical, Collection, Grade, Keyword";
            commandText += " from Question where ID in ( ";
            foreach (int id in ids)
            {
                commandText += id.ToString() + ",";
            }
            commandText = commandText.TrimEnd(',');
            commandText += ")";

            return SQLiteHelper.ExecuteDataSet(connectString, commandText, CommandType.Text);
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
