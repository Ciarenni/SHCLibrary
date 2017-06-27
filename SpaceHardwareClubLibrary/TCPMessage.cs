using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceHardwareClub
{
    public class TCPMessage : MarshalByRefObject, ITCPMessage
    {
        public static string satParams = string.Empty;

        public void sendMessage(string msg)
        {
            satParams = msg;
            
            //return "Data received!\n\n";
        }

        public string getParams()
        {
            return satParams;
        }

        public bool ping()
        {
            return true;
        }
    }
}
