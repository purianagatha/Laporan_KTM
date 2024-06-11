using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_FindMyKTM
{
    public static class ThemeColor
    {
        public static List<string> ColorList = new List<string>()
        {
            "#641220", "#6e1423", "#85182a", "#a11d33", "#a71e34", 
            "#b21e35", "#bd1f36", "#c71f37", "#da1e37", "#e01e37"};

        public static Color ChangeColorBrightness(Color color, double correctionFactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;

            // if correction factor is less than 0, darker color
            if(correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            // if correction factor is greater than 0, lighten color
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }
            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
        }
    }
}
