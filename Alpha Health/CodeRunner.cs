using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Alpha_Health.Model;

namespace Alpha_Health
{
    class CodeRunner
    {
        public void populateComboBox(ComboBox comboBox)
        {
            ComboBoxDataClass data = new ComboBoxDataClass();
            data.getComboBoxData();
            foreach (string item in data.getComboBoxData())
            {
                comboBox.Items.Add(item);
            }
        }

        public void populateExceptionInstances(LogInfoUserControl item)
        {
            item.addExceptionInstance();
        }

        public void populateWithLogInfo(Panel StackPanel, LogInfoUserControl item)
        {
            StackPanel.Children.Add(item);
            populateExceptionInstances(item);
        }

        public void pingAlpha(string hostname)
        {
            string localDirectory = SetGetLocalDirectoryClass.GetLocalDirectoryClass(hostname);
            string Directory = GetLogDirectoryPathsListClass.getListLogDirectoryPaths(hostname)[0];
            string LatestDirectory = GetLatestDirectoryClass.getLatestDirectory(Directory);
            string LatestFile = GetLastestFileInDirectoryClass.getLatestFileInEachDirectory(LatestDirectory);
            Console.WriteLine();
            Console.WriteLine("Can Ping Voyager: " + PingClass.pingVerification(hostname));
            Console.WriteLine(Directory);
            Console.WriteLine("Local Directory Exist? : " + SetGetLocalDirectoryClass.createLocalDirectory(hostname));
            Console.WriteLine(LatestDirectory);
            Console.WriteLine(LatestFile);
            Console.WriteLine("Was copying a success: " + CopyFileToDestinationClass.Copy(LatestFile, localDirectory));
        }



    }
}
