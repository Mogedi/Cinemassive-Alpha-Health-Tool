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
            comboBoxDataClass data = new comboBoxDataClass();
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
            Console.WriteLine();
            Console.WriteLine("Can Ping Voyager: " + PingClass.pingVerification(hostname));
            Console.WriteLine(GetListLogDirectoryPathsClass.getListLogDirectoryPaths(hostname)[0]);
            Console.WriteLine("Local Directory Exist? : " + CreateLocalDirectoryClass.createLocalDirectory(hostname));
            Console.WriteLine();
        }



    }
}
