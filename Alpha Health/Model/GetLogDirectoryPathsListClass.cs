using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpha_Health.Model
{
    class GetLogDirectoryPathsListClass
    {
        public static List<string> getListLogDirectoryPaths(string hostname)
        {
            List<string> alphaDirectory = new List<string>();
            string[] paths = { "\\C\\Cinemassive\\SystemManager\\Logs\\CineNetSystemManagement\\",
                "\\C\\Cinemassive\\AlphaControlService\\Logs\\AlphaControlService\\",
                "\\C\\Cinemassive\\AuthenticationService\\Logs\\CineNetAuthenticationService\\",
                "\\C\\Cinemassive\\CineNetBootStrapper\\Logs\\CineNetBootstrapper\\",
                "\\C\\Cinemassive\\CineNetUI\\Logs\\CineNet\\",
                "\\C\\Cinemassive\\DeviceControl\\Logs\\CineNetDeviceControlService\\",
                "\\C\\Cinemassive\\NetworkManager\\Logs\\CineNetNetworkManager\\",
                "\\C\\Cinemassive\\RoomService\\Logs\\CineNetRoomService\\"};

            foreach (string item in paths)
            {
                alphaDirectory.Add("\\\\" + hostname + item);
            }

            return alphaDirectory;
        }
    }
}
