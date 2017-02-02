using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpha_Health.Model
{
    class FrequencyOfKeywordInListClass
    {
        public static int countKeyword(List<string> localLogFile, string keyword)
        {
            int count = 0;
            foreach (string item in localLogFile)
            {
                if (item.Contains(keyword))
                {
                    count++;
                }
            }
            return count;
        }

    }
}
