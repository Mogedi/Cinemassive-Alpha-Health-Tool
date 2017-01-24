using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpha_Health
{
    class comboBoxDataClass
    {
        private List<string> comboBoxList;

        public comboBoxDataClass()
        {
            comboBoxList = new List<string>(new string[] {"Enterprise", "Galactica", "HeartOfGold", "JupiterII",
                "LobbyFX", "Normandy", "Nostromo", "Serenity", "Starfury", "Tigersclaw",
                "WhiteStar", "Voyager", "Awing",  "Bwing", "Xwing", "Ywing"});
        }

        public List<string> getComboBoxData()
        {
            return comboBoxList;
        }
    }
}
