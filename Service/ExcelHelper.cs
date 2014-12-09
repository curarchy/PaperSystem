using System.Data;
using System.Data.OleDb;

namespace PaperSystem.Service
{
    public class ExcelHelper
    {
        public static DataSet ExcelToDataset(string path, string table)
        {
            string strConn = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + path + ";" + "Extended Properties=Excel 8.0;";
            OleDbConnection conn = new OleDbConnection(strConn);
            conn.Open();
            DataSet ds = new DataSet();
            string strExcel = GetSqlByTableName(table);
            OleDbDataAdapter myCommand = new OleDbDataAdapter(strExcel, strConn);
            myCommand.Fill(ds, "table1");
            conn.Close();
            return ds;
        }

        private static string GetSqlByTableName(string table)
        {
            string strExcel = "";
            switch (table)
            { 
                case "加点词解释":
                    strExcel += "select 序号 as ID, 例字 as Keyword, 释义 as Answer, 例句 as Question, 篇目 as Artical, 备注 as Memo1, 难度 as Level1, ";
                    strExcel += " '1' as Type, '加点词解释' as TypeText from [加点词解释$]";
                    break;
                case "翻译":
                    strExcel += "select 序号 as ID, 释义 as Answer, 例句 as Question, 篇目 as Artical, 备注 as Memo1, 难度 as Level1, ";
                    strExcel += " '3' as Type, '翻译' as TypeText from [翻译$]";
                    break;
                case "默写":
                    strExcel += "select 序号 as ID, 答案 as Answer, 例句 as Question, 篇目 as Artical, 备注 as Memo1, 难度 as Level1, ";
                    strExcel += " '2' as Type, '默写' as TypeText from [默写$]";
                    break;
                case "文章":
                    strExcel += "select 篇目 as Title, 作者 as Writter, 正文 as Content, 备注 as Memo1, 学期 as Grade from [文章$]";
                    break;
                default:
                    break;
            }

            return strExcel;
        }
    }
}
