using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Alpha_Health.Model
{
    class SetGetLocalDirectoryClass
    {
        public static bool createLocalDirectory(string hostname)
        {
            string path = "C:\\Users\\" + Environment.UserName + "\\" + Assembly.GetCallingAssembly().GetName().Name + "\\" + hostname + "\\";

            bool directoryExist = Directory.Exists(path);

            if (!directoryExist)
            {
                Directory.CreateDirectory(path);
            }

            directoryExist = Directory.Exists(path);

            return directoryExist;
        }

        public static string GetLocalDirectoryClass(string hostname)
        {
            return "C:\\Users\\" + Environment.UserName + "\\" + Assembly.GetCallingAssembly().GetName().Name + "\\" + hostname + "\\";
        }
    }
}
