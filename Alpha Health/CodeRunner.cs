using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Alpha_Health
{
    class CodeRunner
    {
        public void populateComboBox(ComboBox comboBox)
        {
            comboBoxData data = new comboBoxData();

            data.getComboBoxData();

            foreach (string item in data.getComboBoxData())
            {
                comboBox.Items.Add(item);
            }

        }
    }
}
