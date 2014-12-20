using System.Data;
using Service;

namespace PaperSystem.Service
{
    public class CommonService : ServiceBase
    {
        /// <summary>
        /// 查询年级
        /// </summary>
        /// <returns></returns>
        public static DataSet QueryGrade()
        {
            string connectString = DB_CONNECT_STRING;
            string commandText = "select ID, Key, Value from Grade ";
            return SQLiteHelper.ExecuteDataSet(connectString, commandText, CommandType.Text);
        }

        /// <summary>
        /// 查询难度
        /// </summary>
        /// <returns></returns>
        public static DataSet QueryLevel()
        {
            string connectString = DB_CONNECT_STRING;
            string commandText = "select ID, Key, Value from Level ";
            return SQLiteHelper.ExecuteDataSet(connectString, commandText, CommandType.Text);
        }

        /// <summary>
        /// 查询类型
        /// </summary>
        /// <returns></returns>
        public static DataSet QueryType()
        {
            string connectString = DB_CONNECT_STRING;
            string commandText = "select ID, Key, Value from Type ";
            return SQLiteHelper.ExecuteDataSet(connectString, commandText, CommandType.Text);
        }
    }
}
