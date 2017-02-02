using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpha_Health.Model
{
    class GetUniqueElementsInListClass
    {
        public static List<List<string>> getUniqueList(List<List<string>> textList)
        {
            var uniqueTextList = textList.GroupBy(c => String.Join(",", c)).Select(c => c.First().ToList()).ToList();
            return uniqueTextList;
        }
    }
}
