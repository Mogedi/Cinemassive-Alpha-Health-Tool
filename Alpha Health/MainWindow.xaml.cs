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
using Alpha_Health.Model;
using System.Timers;

namespace Alpha_Health
{
    public partial class MainWindow : Window
    {
        CodeRunner codeRunning = new CodeRunner();
        Timer myTimer;
        public MainWindow()
        {
            InitializeComponent();
            codeRunning.populateComboBox(comboBox);
        }

        private void viewButton_Click(object sender, RoutedEventArgs e)
        {
            StackPanel.Children.Clear();
            string hostname = comboBox.Text;
            codeRunning.setLocalDirectory(hostname);
            codeRunning.setDirectoryArray(hostname);
            List<string> directoryArray = codeRunning.getDirectoryArray();

            foreach (string directory in directoryArray)
            {
                LogInfoUserControl LogInfo = new LogInfoUserControl();

                LogInfo.createLogInfo(StackPanel, LogInfo, directory, codeRunning);
            }

        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            StackPanel.Children.Clear();
        }

        private void trackButton_Click(object sender, RoutedEventArgs e)
        {
            myTimer = new Timer
            {
                Interval = 2000,
                Enabled = true
            };
            myTimer.Elapsed += new ElapsedEventHandler(Repeat);
        }

        public void Repeat(object source, ElapsedEventArgs e)
        {
            string hostname = comboBox.Text;
            codeRunning.setLocalDirectory(hostname);
            codeRunning.setDirectoryArray(hostname);
            List<string> directoryArray = codeRunning.getDirectoryArray();

            foreach (string directory in directoryArray)
            {
                LogInfoUserControl LogInfo = new LogInfoUserControl();

                LogInfo.createLogInfo(StackPanel, LogInfo, directory, codeRunning);
            }
        }
    }
}
