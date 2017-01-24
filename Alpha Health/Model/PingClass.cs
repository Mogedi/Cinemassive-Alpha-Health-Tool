using System;
using System.Net.NetworkInformation;


namespace Alpha_Health.Model
{
    class PingClass
    {
        public static bool pingVerification(string ip)
        {
            try
            {
                Ping pinger = new Ping();
                PingReply pingReply = pinger.Send(ip, 300);

                if (pingReply.Status == IPStatus.Success)
                {
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }

            return false;
        }
    }
}
