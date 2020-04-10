using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGLab1
{
    class TopHat : MathematicalMorphology
    {
        public TopHat(bool[,] _kernel)
         : base(_kernel)
        {

        }

        public override Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            Bitmap currImage = new Bitmap(sourceImage.Width, sourceImage.Height);
            Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);
            Bitmap resImage = new Bitmap(sourceImage.Width, sourceImage.Height);

            base.flag = true;

            for (int i = 0; i < sourceImage.Width; i++)
            {
                worker.ReportProgress((int)((float)i / resultImage.Width * 50));

                for (int j = 0; j < sourceImage.Height; j++)
                {
                    currImage.SetPixel(i, j, calculateNewPixelColor(sourceImage, i, j));
                }
            }

            base.flag = false;

            for (int i = 0; i < currImage.Width; i++)
            {
                worker.ReportProgress((int)(((float)i / resultImage.Width * 50) + 50));

                for (int j = 0; j < currImage.Height; j++)
                {
                    resultImage.SetPixel(i, j, calculateNewPixelColor(currImage, i, j));
                }
            }

            for (int i = 0; i < currImage.Width; i++)
            {
                worker.ReportProgress((int)(((float)i / resultImage.Width * 50) + 50));

                for (int j = 0; j < currImage.Height; j++)
                {
                    Color sourceColor = sourceImage.GetPixel(i, j);
                    Color sColor = resultImage.GetPixel(i, j);

                    int intensity = (int)(0.36 * sColor.R + 0.53 * sColor.G + 0.11 * sColor.B);

                    Color res = Color.FromArgb(
                    Clamp((int)-(sourceColor.R - intensity), 0, 255),
                    Clamp((int)-(sourceColor.G - intensity), 0, 255),
                    Clamp((int)-(sourceColor.B - intensity), 0, 255));
                    resImage.SetPixel(i, j, res);
                }
            }

            return resImage;
        }
    }
}
