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
        public List<string> read(string filePath)
        {
            List<string> read = new List<string>();

            string line;

            StreamReader file = new StreamReader(filePath);

            while ((line = file.ReadLine()) != null)
            {
                read.Add(line);
            }

            file.Close();

            return read;
        }
    }
}
