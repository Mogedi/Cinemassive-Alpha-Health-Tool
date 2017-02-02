using System;
using System.IO;
using System.Windows;

namespace Alpha_Health.Model
{
    class DoesDirectoryExistClass
    {
        public static bool doesDirectoryExist(string directory)
        {
            try
            {
                bool returnValue;
                returnValue = new DirectoryInfo(directory).Exists;
                if (returnValue)
                    if (!returnValue)
                        MessageBox.Show("Directory does NOT EXIST");
                Console.WriteLine(returnValue);
                return returnValue;
            }
            catch (Exception) { }
            return false;
        }
    }
}
