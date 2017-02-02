using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpha_Health.Model
{
    class ReadFileClass
    {
        public static List<string> read(string filePath)
        {
            List<string> read = new List<string>();
            if (!File.Exists(filePath))
            {
                return read;
            }
            string line;
            char[] delimter = { '|' };
            StreamReader file = new StreamReader(filePath);
            while ((line = file.ReadLine()) != null)
            {
                if(line.Split(delimter, 2).Count() > 1)
                {
                    line = line.Split(delimter, 2)[1];
                }
                if (line.LastIndexOf('|') != -1)
                {
                    line = line.Substring(0, line.LastIndexOf('|'));
                }
                if(line.Length < 4)
                {
                    continue;
                }
                read.Add(line);
            }
            file.Close();
            return read;
            
        }
    }
}
