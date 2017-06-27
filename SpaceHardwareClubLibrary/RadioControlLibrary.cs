using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceHardwareClub
{
    public class RadioControlLibrary
    {
        public byte[] setFrequency(int freq)
        {
            //char[] frequencyChar = new char[10];
            string frequency = string.Empty;
            byte[] freqArray = new byte[11];
            //header bytes
            freqArray[0] = 0xFE;//Convert.ToByte("FE",16);
            freqArray[1] = 0xFE;//Convert.ToByte("FE", 16);
            freqArray[2] = 0x7C;//Convert.ToByte("7C", 16);
            freqArray[3] = 0xE0;// Convert.ToByte("E0", 16);
            //command number for setting frequency
            freqArray[4] = 0x05;//Convert.ToByte("05", 16);
            //end flag byte
            freqArray[10] = 0xFD;// Convert.ToByte("FD", 16);

            frequency = freq.ToString();

            while (frequency.Length < 10)
            {
                frequency = '0' + frequency;
            }

            freqArray[5] = Convert.ToByte(frequency[8].ToString() + frequency[9].ToString(), 16);
            freqArray[6] = Convert.ToByte(frequency[6].ToString() + frequency[7].ToString(), 16);
            freqArray[7] = Convert.ToByte(frequency[4].ToString() + frequency[5].ToString(), 16);
            freqArray[8] = Convert.ToByte(frequency[2].ToString() + frequency[3].ToString(), 16);
            freqArray[9] = Convert.ToByte(frequency[0].ToString() + frequency[1].ToString(), 16);

            return freqArray;
        }

        public byte[] engageDuplex()
        {
            byte[] duplexArray = new byte[7];
            //header bytes
            duplexArray[0] = 0xFE;
            duplexArray[1] = 0xFE;
            duplexArray[2] = 0x7C;
            duplexArray[3] = 0xE0;
            //command number for turning on duplex
            duplexArray[4] = 0x0F;
            duplexArray[5] = 0x12;
            //end flag byte
            duplexArray[6] = 0xFD;

            return duplexArray;
        }

        public byte[] setDuplexOffset()
        {
            byte[] offsetArray = new byte[12];
            //header bytes
            offsetArray[0] = 0xFE;
            offsetArray[1] = 0xFE;
            offsetArray[2] = 0x7C;
            offsetArray[3] = 0xE0;
            //command number for setting duplex offset
            offsetArray[4] = 0x1A;
            offsetArray[5] = 0x05;
            offsetArray[6] = 0x00;
            offsetArray[7] = 0x17;
            offsetArray[8] = 0x10;
            offsetArray[9] = 0x00;
            offsetArray[10] = 0x00;
            //end flag byte
            offsetArray[11] = 0xFD;

            return offsetArray;
        }
    }
}
