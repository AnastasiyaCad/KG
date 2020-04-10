using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace KGLab1
{
    class BrightnessFilter : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            
            int constBrigh = Program.constBriht;
            float resultR = 0;
            float resultG = 0;
            float resultB = 0;
            Color sourceColor = sourceImage.GetPixel(x, y);
            resultR = sourceColor.R + constBrigh;
            resultG = sourceColor.G + constBrigh;
            resultB = sourceColor.B + constBrigh;
            return Color.FromArgb(Clamp((int)resultR, 0, 255), Clamp((int)resultG, 0, 255), Clamp((int)resultB, 0, 255));
        }
    }
}
