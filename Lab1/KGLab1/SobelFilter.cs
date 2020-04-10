using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;

namespace KGLab1
{
    class SobelFilter : MatrixFilter
    {
        public SobelFilter()
        {
            int sizeX = 3;
            int sizeY = 3;
            kernel = new float[sizeX, sizeY];
            kernel[0, 0] = - 1.0f;
            kernel[0, 1] = 0f;
            kernel[0, 2] = 1.0f;
            kernel[1, 0] = -2.0f;
            kernel[1, 1] = 0f;
            kernel[1, 2] = 2.0f;
            kernel[2, 0] = -1.0f;
            kernel[2, 1] = 0f;
            kernel[2, 2] = 1.0f;

        }

        public void swap()
        {
            float tmp;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    tmp = kernel[i, j];
                    kernel[i, j] = kernel[j, i];
                    kernel[j, i] = tmp;
                }
            }
        }
        public override Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            Bitmap Image1 = new Bitmap(sourceImage.Width, sourceImage.Height);
            for (int i = 0; i < sourceImage.Width; i++)
            {
                worker.ReportProgress((int)((float)i / Image1.Width * 100));
                if (worker.CancellationPending)
                    return null;

                for (int j = 0; j < sourceImage.Height; j++)
                {
                    Image1.SetPixel(i, j, calculateNewPixelColor(sourceImage, i, j));
                }
            }
            Bitmap Image2 = new Bitmap(sourceImage.Width, sourceImage.Height);
            swap();
            for (int i = 0; i < sourceImage.Width; i++)
            {
                worker.ReportProgress((int)((float)i / Image2.Width * 100));
                if (worker.CancellationPending)
                    return null;

                for (int j = 0; j < sourceImage.Height; j++)
                {
                    Image2.SetPixel(i, j, calculateNewPixelColor(sourceImage, i, j));
                }
            }
            Bitmap resuitImage = new Bitmap(sourceImage.Width, sourceImage.Height);
            for (int i = 0; i < sourceImage.Width; i++)
            {
                worker.ReportProgress((int)((float)i / resuitImage.Width * 100));
                if (worker.CancellationPending)
                    return null;

                for (int j = 0; j < sourceImage.Height; j++)
                {
                    Color Image1Color = Image1.GetPixel(i, j);
                    Color Image2Color = Image2.GetPixel(i, j);
                    double resultR = Math.Sqrt(Image1Color.R * Image1Color.R + Image2Color.R * Image2Color.R);
                    double resultG = Math.Sqrt(Image1Color.G * Image1Color.G + Image2Color.G * Image2Color.G);
                    double resultB = Math.Sqrt(Image1Color.B * Image1Color.B + Image2Color.B * Image2Color.B);

                    Color result = Color.FromArgb(Clamp((int)resultR, 0, 255), Clamp((int)resultG, 0, 255), Clamp((int)resultB, 0, 255));
                    resuitImage.SetPixel(i, j, result);
                }
            }
            return resuitImage;
        }
    }
}
