using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Alpha_Health
{
    public partial class LogInfoUserControl : UserControl
    {
        public LogInfoUserControl()
        {
            InitializeComponent();
        }

        public void createLogInfo(Panel StackPanel, LogInfoUserControl LogInfo, string directory, CodeRunner codeRunning)
        {
            StackPanel.Children.Add(LogInfo);

            codeRunning.Main(directory, LogInfo);

            title.Text = codeRunning.getHostname() + ": " + codeRunning.getLogTitle();
            exceptionEntry.Text = codeRunning.getTotalExceptions().ToString();
            exceptionEntry.Foreground = Brushes.Red;
            dateEntry.Text = codeRunning.getDateOfLog();
            timeEntry.Text = codeRunning.getTimeOfLog();
            fileLocation.Text = codeRunning.getLocalDirecotry();

            List<List<string>> uniqueSegments = codeRunning.getUniqueSegments();
            List<int> frequencyOfExceptions = codeRunning.getFrequencyExceptions();

            int count = 0;
            foreach (int i in frequencyOfExceptions)
            {
                ExceptionInfoUserControl exceptionInfo = new ExceptionInfoUserControl();
                exceptionInfo.populateExceptionInstances((uniqueSegments[count][1].Split('|')[1]).Split(':')[1], i, exceptionText, uniqueSegments[count]);
                exceptionStackPanel.Children.Add(exceptionInfo);
                count++;

            }
        }
    }
}
