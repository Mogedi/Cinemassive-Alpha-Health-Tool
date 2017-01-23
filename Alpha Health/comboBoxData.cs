using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpha_Health
{
    class comboBoxData
    {
        private List<string> comboBoxList;

        public comboBoxData()
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
