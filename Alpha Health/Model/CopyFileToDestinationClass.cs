using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpha_Health.Model
{
    class CopyFileToDestinationClass
    {
        public static bool Copy(string filePath, string destination)
        {
            try
            {
                string titleOfFile = filePath.Split('\\').Last();
                string fileDestination = destination + titleOfFile;

                File.Copy(filePath, fileDestination, true);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }

    }
}
