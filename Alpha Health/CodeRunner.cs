using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Alpha_Health.Model;
using System.IO;

namespace Alpha_Health
{
    public class CodeRunner
    {
        string hostname;
        string localDirectory;
        List<string> directoryArray;
        string directory;
        string latestDirectory;
        string latestFile;
        bool boolCopyState;
        string localFileDestination;
        List<string> logTextInList;
        List<List<string>> segments;
        List<List<string>> uniqueSegments;
        List<int> frequencyOfExceptions;

        public void Main(string directoryVar, LogInfoUserControl item)
        {
            directory = directoryVar;
            latestDirectory = GetLatestDirectoryClass.getLatestDirectory(directory);
            latestFile = GetLastestFileInDirectoryClass.getLatestFileInEachDirectory(latestDirectory);
            boolCopyState = CopyFileToDestinationClass.Copy(latestFile, localDirectory);
            localFileDestination = CopyFileToDestinationClass.getLocalLogFileDestination(latestFile, localDirectory);
            logTextInList = ReadFileClass.read(localFileDestination);
            segments = SegmentsOfTextClass.getSegmentsOfText("|EXCEPTION=", "|END EXCEPTION=", localFileDestination);
            uniqueSegments = GetUniqueElementsInListClass.getUniqueList(segments);
            frequencyOfExceptions = CountFrequencyOfEachExceptionClass.countFrequencyOfEachException(segments, uniqueSegments);
        }

        public void populateComboBox(ComboBox comboBox)
        {
            ComboBoxDataClass data = new ComboBoxDataClass();
            data.getComboBoxData();
            foreach (string item in data.getComboBoxData())
            {
                comboBox.Items.Add(item);
            }
        }

        public void setLocalDirectory(string hostnames)
        {
            hostname = hostnames;
            localDirectory = SetGetLocalDirectoryClass.getLocalDirectoryClass(hostname);
        }

        public string getLocalDirecotry()
        {
            return localDirectory;
        }

        public void setDirectoryArray(string hostname)
        {
            directoryArray = GetLogDirectoryPathsListClass.getListLogDirectoryPaths(hostname);
        }

        public string getLogTitle()
        {
            string[] titleOfFile = directory.Split('\\');

            return titleOfFile[titleOfFile.Count() - 4];
        }

        public string getHostname()
        {
            return hostname;
        }

        public List<string> getDirectoryArray()
        {
            return directoryArray;
        }

        public List<int> getFrequencyExceptions()
        {
            return frequencyOfExceptions;
        }

        public List<List<string>> getUniqueSegments()
        {
            return uniqueSegments;
        }

        public List<List<string>> getFullText()
        {
            return uniqueSegments;
        }

        public int getTotalExceptions()
        {
            return segments.Count();
        }

        public string getDateOfLog()
        {
            DateTime creation = File.GetLastWriteTime(latestFile);
            return creation.ToString(" MM/dd/yyyy");
        }

        public string getTimeOfLog()
        {
            DateTime creation = File.GetLastWriteTime(latestFile);
            return creation.ToString("h:mm tt");
        }
    }
}
