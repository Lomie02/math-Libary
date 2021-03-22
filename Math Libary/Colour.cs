using System;
using System.Collections.Generic;
using System.Text;

namespace MathClasses
{
   public class Colour
    {
        //-------------------------------------------

        public uint colour = 0;

        //-------------------------------------------
        public Colour()
        {

        }

        public Colour(byte red, byte green, byte blue, byte alpha)
        {
            colour = (uint)((red << 24) + (green << 16) + (blue << 8) + (alpha << 0));
        }

        //-------------------------------------------
        // Red
        //-------------------------------------------
        
        public void SetRed(byte red)
        {
            colour = colour & 0x00ffffff;
            colour = colour | (uint)(red << 24);
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

            colour = colour & 0xff00ffff;
            colour = colour | (uint)(green << 16);
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

            colour = colour & 0xffff00ff;
            colour = colour | (uint)(Blue << 8);
        }

        public byte GetBlue()
        {
            return (byte)(colour >> 8);
        }

        //-------------------------------------------
        // Alpha
        //-------------------------------------------

        public void SetAlpha(byte Alpha)
        {
            colour = colour & 0xffffff00;
            colour = colour | (uint)(Alpha << 0);
        }

        public byte GetAlpha()
        {
            return (byte)(colour >> 0);
        }
    }
}

