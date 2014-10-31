using System.Data;
using System.Data.OleDb;

namespace PaperSystem.Service
{
    public class ExcelHelper
    {
        public static DataSet ExcelToDataset(string Path)
        {
            string strConn = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + Path + ";" + "Extended Properties=Excel 8.0;";
            OleDbConnection conn = new OleDbConnection(strConn);
            conn.Open();
            DataSet ds = new DataSet();
            string strExcel = "select 序号 as ID, 例字 as Keyword, 释义 as Answer, 例句 as Question, 篇目 as Artical, ";
            strExcel += " 选自 as Collection, 作者 as Writter from [sheet1$]";
            OleDbDataAdapter myCommand = new OleDbDataAdapter(strExcel, strConn);
            myCommand.Fill(ds, "table1");
            conn.Close();
            return ds;
        }
    }
}
