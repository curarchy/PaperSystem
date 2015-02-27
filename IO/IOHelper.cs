using System.IO;
using System.Text;

namespace PaperSystem.IO
{
    public class IOHelper
    {
        public static string GetStringFromFile(string route)
        {
            StreamReader reader = new StreamReader(route, Encoding.Default);
            return reader.ReadToEnd();
        }

        public static string WriteStringToFile(string content, string filePath)
        {
            FileStream fileStream = new FileStream(filePath, FileMode.Create);
            StreamWriter streamWrite = new StreamWriter(fileStream);
            streamWrite.WriteLine(content);
            streamWrite.Close();
            fileStream.Close();
            return filePath;
        }
    }
}
