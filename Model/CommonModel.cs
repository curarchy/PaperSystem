using System.Collections.Generic;
using System.Data;
using PaperSystem.Entity;
using PaperSystem.Service;
using PaperSystem.Transform;

namespace PaperSystem.Model
{
    public class CommonModel
    {
        public static DataSet QueryGrade()
        {
            return CommonService.QueryGrade();
        }

        public static List<CommonEntity> QueryGradeList()
        {
            DataSet ds = QueryGrade();

            return CommonTransform.Transform(ds.Tables[0]);
        }

        public static DataSet QueryLevel()
        {
            return CommonService.QueryLevel();
        }

        public static List<CommonEntity> QueryLevelList()
        {
            DataSet ds = QueryLevel();

            return CommonTransform.Transform(ds.Tables[0]);
        }

        public static DataSet QueryType()
        {
            return CommonService.QueryType();
        }

        public static List<CommonEntity> QueryTypeList()
        {
            DataSet ds = QueryType();

            return CommonTransform.Transform(ds.Tables[0]);
        }
    }
}
