using System;
using System.Collections.Generic;
using System.Text;

namespace ColorBall
{
    public class Color
    {
        private byte red;
        private byte green;
        private byte blue;
        private byte alpha;

        public Color(byte red, byte green, byte blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = 255;
        }

        //public byte GetRed()
        //{
        //    return red;
        //}
        //public void SetRed(byte red)
        //{
        //    this.red = red;
        //}
        public byte Red
        {
            get
            {
                return red;
            }
            set
            {
                red = value;
            }
        }
        //public byte GetGreen()
        //{
        //    return green;
        //}
        //public void SetGreen(byte green)
        //{
        //    this.green = green;
        //}
        public byte Green
        {
            get
            {
                return green;
            }
            set
            {
                green = value;
            }
        }
        //public byte GetBlue()
        //{
        //    return blue;
        //}
        //public void SetBlue(byte blue)
        //{
        //    this.blue = blue;
        //}
        public byte Blue
        {
            get
            {
                return blue;
            }
            set
            {
                blue = value;
            }
        }
        //public byte GetAlpha()
        //{
        //    return alpha;
        //}
        //public void SetAlpha(byte alpha)
        //{
        //    this.alpha = alpha;
        //}
        public byte Alpha{ set; private get; }

        public int getGreyScale()
        {
            return (byte)((red + green + blue) / 3);
        }
    }
}
