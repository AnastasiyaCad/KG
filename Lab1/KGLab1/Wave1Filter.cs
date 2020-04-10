using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace KGLab1
{
    class Wave1Filter : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int k, int l)
        {
            int x = (int)(k + 20 * Math.Sin(2 * Math.PI * l / 60));
            int y = l;
            if ((x < sourceImage.Width) && (x >= 0) && (y < sourceImage.Height) && (y >= 0))
            {
                Color sourceColor = sourceImage.GetPixel(x, y);
                Color resultColor = sourceColor;
                return resultColor;
            }
            else
            {
                Color resultColor = Color.FromArgb(0, 0, 0);
                return resultColor;
            }
        }
    }
}
