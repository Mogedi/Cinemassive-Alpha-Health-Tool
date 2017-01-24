using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpha_Health.Model
{
    class GetLatestDirectoryClass
    {
        public static string getLatestDirectory(string directory)
        {
            try
            {
                DirectoryInfo Directory = new DirectoryInfo(directory);
                DirectoryInfo LatestDirectory = Directory.GetDirectories().OrderByDescending(f => f.LastWriteTime).First();
                string LatestDirectoryPath = directory + LatestDirectory.ToString() + "\\";
                return LatestDirectoryPath;
            } catch (Exception)
            {
                return "Path to Directory Does not Exist";
            }
            
        }
    }
}
