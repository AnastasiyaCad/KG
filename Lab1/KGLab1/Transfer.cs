using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace KGLab1 
{
    class Transfer : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int k, int l)
        {
            int x = k + Program.constX;
            int y = l + Program.constY;
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
