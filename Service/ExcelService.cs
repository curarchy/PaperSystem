using System.Data;

namespace PaperSystem.Service
{
    public class ExcelService : ServiceBase
    {
        public static DataSet GetQuestionsFromExcel(string file, string table)
        {
            return ExcelHelper.ExcelToDataset(file, table);
        }


    }
}
