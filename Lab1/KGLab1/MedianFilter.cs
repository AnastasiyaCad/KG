using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGLab1
{
    class MedianFilter : MatrixFilter
    {
        protected override Color calculateNewPixelColor(Bitmap sourseImage, int x, int y)
        {

            int size = 5;
            int rad = size / 2;
            int s = size * size;
            Color[] sourceColor = new Color[s];

            int[] R = new int[s];
            int[] G = new int[s];
            int[] B = new int[s];

            int k = 0;

            for (int i = -rad; i <= rad; i++)
            {
                for (int j = -rad; j <= rad; j++)
                {
                    int idX = Clamp(x + i, 0, sourseImage.Width - 1);
                    int idY = Clamp(y + j, 0, sourseImage.Height - 1);

                    sourceColor[k++] = sourseImage.GetPixel(idX, idY);
                }
            }

            for (int i = 0; i < s; i++)
            {
                R[i] = sourceColor[i].R;
                G[i] = sourceColor[i].G;
                B[i] = sourceColor[i].B;
            }

            Array.Sort(R);
            Array.Sort(G);
            Array.Sort(B);

            return Color.FromArgb(R[s / 2], G[s / 2], B[s / 2]);
        }
    }
}
