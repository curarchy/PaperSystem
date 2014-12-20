
namespace PaperSystem.Entity
{
    /// <summary>
    /// 问题基类
    /// </summary>
    public class QuestionBaseEntity
    {
        public int ID { get; set; }

        /// <summary>
        /// 题干
        /// </summary>
        public string Question { get; set; }

        /// <summary>
        /// 答案
        /// </summary>
        public string Answer { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        public int Type { get; set; }

        /// <summary>
        /// 难度
        /// </summary>
        public int Level { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Memo { get; set; }

        /// <summary>
        /// 作者
        /// </summary>
        public string Writter { get; set; }

        /// <summary>
        /// 篇目
        /// </summary>
        public int Artical { get; set; }

        /// <summary>
        /// 例字
        /// @translate
        /// </summary>
        public string Keyword { get; set; }

        /// <summary>
        /// 所在段落
        /// </summary>
        public int Paragraph { get; set; }
    }
}
