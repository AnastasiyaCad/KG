using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGLab1
{
    class Impression: MatrixFilter // теснение
    {
        public Impression()
        {
            int sizeX = 3;
            int sizeY = 3;
            kernel = new float[sizeX, sizeY];
            kernel[0, 1] = 1.0f;
            kernel[1, 0] = 1.0f;
            kernel[1, 2] = -1.0f;
            kernel[2, 1] = -1.0f;
            kernel[1, 1] = 0f;
            kernel[0, 0] = 0f;
            kernel[0, 2] = 0f;
            kernel[2, 0] = 0f;
            kernel[2, 2] = 0f;
        }
    }
}
