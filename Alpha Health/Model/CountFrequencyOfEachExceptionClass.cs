using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpha_Health.Model
{
    class CountFrequencyOfEachExceptionClass
    {
        public static List<int> countFrequencyOfEachException(List<List<string>> segments, List<List<string>> uniqueSegments)
        {
            List<int> exceptionFrequencyList = new List<int>(new int[uniqueSegments.Count]);
            foreach (List<string> item in segments)
            {
                foreach (List<string> item2 in uniqueSegments)
                {
                    if (item.SequenceEqual(item2))
                    {
                        exceptionFrequencyList[uniqueSegments.IndexOf(item2)] += 1;
                    }
                }
            }
            return exceptionFrequencyList;
        }
    }
}
