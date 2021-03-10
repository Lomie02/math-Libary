using System;
using System.Collections.Generic;
using System.Text;

namespace Math_Libary
{
    class Colour
    {
        //-------------------------------------------

        private uint colour = 0;

        //-------------------------------------------

        public Colour(byte red, byte green, byte blue, byte alpha)
        {
            colour = (uint)((red << 24) + (green << 16) + (blue << 8) + alpha);
        }

        //-------------------------------------------
        // Red
        //-------------------------------------------
        
        public void SetRed(byte red)
        {
            colour = colour | 0xff000000;
            colour = colour & (uint)(red << 24);
        }

        public byte GetRed()
        {
            return (byte)(colour >> 24);
        }

        //-------------------------------------------
        // Green 
        //-------------------------------------------

        public void SetGreen(byte green)
        {

            colour = colour & (uint)(green << 16);
        }

        public byte GetGreen()
        {
            return (byte)(colour >> 16);

        }

        //-------------------------------------------
        // Blue
        //-------------------------------------------

        public void SetBlue(byte Blue)
        {
            colour = colour & (uint)(Blue << 8);
        }

        public byte GetBlue()
        {
            return (byte)(colour >> 8);
        }
    }
}

