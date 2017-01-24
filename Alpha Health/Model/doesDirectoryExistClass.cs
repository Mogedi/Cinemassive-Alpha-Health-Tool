using System;
using System.IO;
using System.Windows;

namespace Alpha_Health.Model
{
    class doesDirectoryExistClass
    {
        public static bool doesDirectoryExist(string directory)
        {
            try
            {
                bool returnValue;

                returnValue = new DirectoryInfo(directory).Exists;

                if (returnValue)
                    // MessageBox.Show("FileAccess.doesDirectoryExist: Directory Exist");

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
