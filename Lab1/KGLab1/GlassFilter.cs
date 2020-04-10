using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace KGLab1
{
    class GlassFilter : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int k, int l)
        {
            Random rnd = new Random();
            double rand = rnd.NextDouble();
            //int rand = rnd.Next(2);
            int x = (int)(k + (rand - 0.5) * 10);
            rand = rnd.NextDouble();
            //rand = rnd.Next(2);
            int y = (int)(l + (rand - 0.5) * 10);
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
