using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpha_Health.Model
{
    class GetLastestFileInDirectoryClass
    {
        public static string getLatestFileInEachDirectory(string directory)
        {
            try
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(directory);
                FileInfo latestFile = directoryInfo.GetFiles().OrderByDescending(f => f.LastWriteTime).First();
                string latestFilePath = directory + latestFile.ToString();
                return latestFilePath;
            }
            catch (Exception)
            {
                return "Path to Directory Does not Exist";
            }
            
        }
    }
}
