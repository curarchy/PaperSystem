using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PaperSystem.Entity;
using Service;

namespace PaperSystem.Service
{
    public class QuestionService : ServiceBase
    {
        public static int CreateQuestion(QuestionBaseEntity question) {
            string connectString = DB_CONNECT_STRING;
            string commandText = "INSERT INTO Question VALUES(NULL, NULL, 'hello world', NULL, NULL, NULL, NULL, NULL);";
            //commandText = "CREATE TABLE Question (ID INTEGER PRIMARY KEY, Level NUMERIC, MainContent TEXT, AnswerA TEXT, AnswerB TEXT, AnswerC TEXT, AnswerD TEXT, Type NUMERIC);";

            return SQLiteHelper.ExecuteNonQuery(connectString, commandText, System.Data.CommandType.Text, null);
        }
    }
}
