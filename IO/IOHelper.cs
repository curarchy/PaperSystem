using System;
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

        public static string WriteStringToFile(string content)
        {
            string fileName = "C:\\" + DateTime.Now.ToString("yyyyMMdd-hhmmss") + ".doc";
            FileStream fileStream = new FileStream(fileName, FileMode.Create);
            StreamWriter streamWrite = new StreamWriter(fileStream);
            streamWrite.WriteLine(content);
            streamWrite.Close();
            fileStream.Close();
            return fileName;
        }
    }
}
