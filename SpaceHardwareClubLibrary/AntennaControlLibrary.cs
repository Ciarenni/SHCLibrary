using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceHardwareClub
{
    public class AntennaControlLibrary
    {
        public string setAntenna(int azimuth, int elevation)
        {
            string a = azimuth.ToString(), e = elevation.ToString();
            if ((azimuth >= 0 && azimuth <= 360) && (elevation >= 0 && elevation <= 180))
            {
                while (a.Length < 3)
                    a = "0" + a;
                while (e.Length < 3)
                    e = "0" + e;
                return "W" + a + " " + e + "\r\n";
            }
            return "Invalid input";
        }

        public string getAntenna()
        {
            return "C2\r\n";
        }

        public string allStop()
        {
            return "S\r\n";
        }

        public string setSpeed(int speed)
        {
            if (speed >= 1 && speed <= 4)
                return "X" + speed + "\r\n";

            return "Invalid speed.";
        }
    }
}
