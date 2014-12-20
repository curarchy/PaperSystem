
namespace PaperSystem.Entity
{
    /// <summary>
    /// 文章
    /// </summary>
    public class ArticalEntity
    {
        public int ID { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 正文
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 年级
        /// </summary>
        public int Grade { get; set; }

        /// <summary>
        /// 作者
        /// </summary>
        public string Writter { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Memo { get; set; }

        /// <summary>
        /// 下属题目数量
        /// </summary>
        public int ProblemCount { get; set; }
    }
}
