using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpha_Health.Model
{
    class FormatLogText
    {
        public static List<List<string>> formatting(List<List<string>> exceptionsLogText)
        {
            foreach (List<string> item in exceptionsLogText)
            {
                Console.WriteLine(item.Count());
            }

            List<string> formattedText = new List<string>();
            List<List<string>> Return = new List<List<string>>();
            char[] delimter = { '|' };
            Console.WriteLine();

            foreach (List<string> Listitem in exceptionsLogText)
            {
                Console.WriteLine(Listitem.Count());
                foreach (string item in Listitem)
                {
                    formattedText.Add(item.Split(delimter, 2)[1]);
                    Console.WriteLine(item);
                }
                Return.Add(formattedText);
                Console.WriteLine(Return[0].Count());
            }
            return Return;
        }
    }
}
