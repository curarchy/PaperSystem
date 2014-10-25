using System.Data;

namespace PaperSystem.Service
{
    public class ExcelService : ServiceBase
    {
        public static DataSet GetQuestionsFromExcel(string file)
        {
            return ExcelHelper.ExcelToDataset(file);
        }
    }
}
