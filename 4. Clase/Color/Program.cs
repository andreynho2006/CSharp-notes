using System;

namespace Color
{
    class Color
    {
        public Color(byte red, byte green, byte blue)
        {

            this.red = red;
            this.green = green;
            this.blue = blue;
        }

        private byte red;
        private byte green;
        private byte blue;

        public static readonly Color Red;
        public static readonly Color Green;
        public static readonly Color Blue;

        // constructor static
        static Color()
        {
            Red = new Color(255, 0, 0);
            Green = new Color(0, 255, 0);
            Blue = new Color(0, 0, 255);
        }
    }

    class Demo
    {
        static void Main()
        {
            Color background = Color.Red;
        }
    }
}
