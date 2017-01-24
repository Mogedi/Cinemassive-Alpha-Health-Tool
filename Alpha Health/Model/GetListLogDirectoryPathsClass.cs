using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpha_Health.Model
{
    class GetListLogDirectoryPathsClass
    {
        public static List<string> getListLogDirectoryPaths(string hostname)
        {
            List<string> alphaDirectory = new List<string>();
            string[] paths = { "\\Cinemassive\\SystemManager\\Logs\\CineNetSystemManagement\\",
                "\\Cinemassive\\AlphaControlService\\Logs\\AlphaControlService\\",
                "\\Cinemassive\\AuthenticationService\\Logs\\CineNetAuthenticationService",
                "\\Cinemassive\\CineNetBootStrapper\\Logs\\CineNetBootstrapper",
                "\\Cinemassive\\CineNetUI\\Logs\\CineNet",
                "\\Cinemassive\\DeviceControl\\Logs\\CineNetDeviceControlService",
                "\\Cinemassive\\NetworkManager\\Logs\\CineNetNetworkManager",
                "\\Cinemassive\\RoomService\\Logs\\CineNetRoomService"};

            foreach (string item in paths)
            {
                alphaDirectory.Add("\\\\" + hostname + item);
            }

            return alphaDirectory;
        }
    }
}
