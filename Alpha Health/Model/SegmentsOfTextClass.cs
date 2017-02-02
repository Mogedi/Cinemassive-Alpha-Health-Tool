using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpha_Health.Model
{
    class SegmentsOfTextClass
    {
        public static List<List<string>> getSegmentsOfText(string beginningKeyword, string endKeyword, string filePath)
        {
            List<string> text = ReadFileClass.read(filePath);
            if (!File.Exists(filePath))
            {
                text = new List<string>();
            }
            List<List<string>> returnSegment = new List<List<string>>();
            while (text.Any())
            {
                if (text.ElementAt(0).Contains(beginningKeyword))
                {
                    List<string> segment = new List<string>();
                    while (!(text.ElementAt(0).Contains(endKeyword)))
                    {
                        segment.Add(text.ElementAt(0));
                        text.RemoveAt(0);
                    }
                    if (text.ElementAt(0).Contains(endKeyword))
                    {
                        segment.Add(text.ElementAt(0));
                    }
                    returnSegment.Add(segment);
                }
                text.RemoveAt(0);
            }
            return returnSegment;
        }
    }
}
