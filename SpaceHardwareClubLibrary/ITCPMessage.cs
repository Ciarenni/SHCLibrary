using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceHardwareClub
{
    public interface ITCPMessage
    {
        bool ping();
        void sendMessage(string msg);
        string getParams();
    }
}
