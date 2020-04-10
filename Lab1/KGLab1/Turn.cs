using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;

namespace KGLab1
{
    class Turn : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int k, int l)
        {
            return sourceImage.GetPixel(k, l);
        }
        public override Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            Bitmap transformImage = new Bitmap(sourceImage.Width, sourceImage.Height);
            int x0 = sourceImage.Width / 2;
            int y0 = sourceImage.Height / 2;
            double nu = Program.constNu;
            List<int> dx = new List<int>();
            List<int> dy = new List<int>();
            for (int i = 0; i < sourceImage.Width; i++)
            {
                for (int j = 0; j < sourceImage.Height; j++)
                {
                    int x = (int)((i - x0) * Math.Cos(nu) - (j - y0) * Math.Sin(nu) + x0);
                    int y = (int)((i - x0) * Math.Sin(nu) + (j - y0) * Math.Cos(nu) + y0);
                    dx.Add(x);
                    dy.Add(y);
                    transformImage.SetPixel(Clamp(x, 0, x0 * 2 - 1), Clamp(y, 0 , y0 * 2 - 1), calculateNewPixelColor(sourceImage, i, j));
                }
            }
            return transformImage;
        }
    }
}

