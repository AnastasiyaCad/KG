using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;

namespace KGLab1
{
    class GrayWorld : Filters
    {
        private float avgR, avgG, avgB, avg;
        private void calculate(Bitmap sourceImage)
        {
            int sumR = 0, sumB = 0, sumG = 0;
            Color sourceColor;

            for (int i = 0; i < sourceImage.Width; i++)
            {
                for (int j = 0; j < sourceImage.Height; j++)
                {
                    sourceColor = sourceImage.GetPixel(i, j);
                    sumR += sourceColor.R;
                    sumG += sourceColor.G;
                    sumB += sourceColor.B;
                }
            }
            avgR = sumR / (sourceImage.Width * sourceImage.Height);
            avgG = sumG / (sourceImage.Width * sourceImage.Height);
            avgB = sumB / (sourceImage.Width * sourceImage.Height);
            avg = (avgR + avgG + avgB) / 3;
        }
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int k, int l)
        {
            Color sourceColor = sourceImage.GetPixel(k, l);
            Color resultColor = Color.FromArgb(Clamp((int)(sourceColor.R * avg / avgR), 0, 255), Clamp((int)(sourceColor.G * avg / avgG), 0, 255), Clamp((int)(sourceColor.B * avg / avgB), 0, 255));
            return resultColor;
        }
        public override Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            Bitmap resuitImage = new Bitmap(sourceImage.Width, sourceImage.Height);
            calculate(sourceImage);
            for (int i = 0; i < sourceImage.Width; i++)
            {
                worker.ReportProgress((int)((float)i / resuitImage.Width * 100));
                if (worker.CancellationPending)
                    return null;
                for (int j = 0; j < sourceImage.Height; j++)
                {
                    resuitImage.SetPixel(i, j, calculateNewPixelColor(sourceImage, i, j));
                }
            }
            return resuitImage;
        }
    }
}
