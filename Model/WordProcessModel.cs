using System;
using PaperSystem.Entity;
using System.Text.RegularExpressions;

namespace PaperSystem.Model
{
    public class WordProcessModel
    {
        public static int GuessParagraph(int articalID, string question)
        {
            ArticalEntity artical = ArticalModel.QuerySingle(articalID);
            return GuessParagraph(artical.Content, question);
        }

        /// <summary>
        /// 猜题目在文章第几段
        /// </summary>
        /// <param name="content"></param>
        /// <param name="question"></param>
        /// <returns></returns>
        public static int GuessParagraph(string content, string question)
        {
            if (!content.Contains(question))
            {
                return 0;
            }

            // 先去掉头尾空格。
            content = content.Trim();

            // 合并所有空格
            Regex regex = new Regex(@"\s+");
            content = regex.Replace(content, " ");

            // 正文按关键字分割
            string[] result = content.Split(new String[] { question }, StringSplitOptions.RemoveEmptyEntries);

            // 第一个数组里的空格数 + 1，就是所在段落数
            return Regex.Matches(result[0], " ").Count + 1;
        }
    }
}
