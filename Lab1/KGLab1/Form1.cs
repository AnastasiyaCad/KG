using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace KGLab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ListImage = new List<Bitmap>();
        }
        Bitmap image;
        private List<Bitmap> ListImage;
        private int I = -1; 

        private void ОткрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files|*.png;*.jpg;*.bmp|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                image = new Bitmap(dialog.FileName);
            }
            ListImage.Add(image);
            I++;
            pictureBox1.Image = image;
            pictureBox1.Refresh();

        }

        private void СохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null) //если в pictureBox есть изображение
            {
                SaveFileDialog dialog = new SaveFileDialog();
                //отображать ли предупреждение, если пользователь указывает имя уже существующего файла
                dialog.OverwritePrompt = true;
                //отображать ли предупреждение, если пользователь указывает несуществующий путь
                dialog.CheckPathExists = true;
                //список форматов файла, отображаемый в поле "Тип файла"
                dialog.Filter = "Image files|*.png;*.jpg;*.bmp|All files(*.*)|*.*";
                //отображается ли кнопка "Справка" в диалоговом окне
                dialog.ShowHelp = true;
                ImageFormat format = ImageFormat.Png;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string ext = System.IO.Path.GetExtension(dialog.FileName);
                    switch (ext)
                    {
                        case ".jpg":
                            format = ImageFormat.Jpeg;
                            break;
                        case ".bmp":
                            format = ImageFormat.Bmp;
                            break;
                    }
                    pictureBox1.Image.Save(dialog.FileName, format);
                }
            }
        }
        private void ОтменаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (I < 0)
            {
                pictureBox1.Image = ListImage[I - 1];
                pictureBox1.Refresh();
            }
        }
        private void ИнверсияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new InvertFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Bitmap newImage = ((Filters)e.Argument).processImage(image, backgroundWorker1);
            if (backgroundWorker1.CancellationPending != true)
                image = newImage;
        }

        private void BackgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                pictureBox1.Image = image;
                pictureBox1.Refresh();
            }
            progressBar1.Value = 0;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
        }

        private void РазмытиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new BlurFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ФильтрГауссаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new GaussianFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void GrayScaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new GrayScaleFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void СепияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new SepiaFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ЯркостьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormForBrightnessFilter newForm = new FormForBrightnessFilter();
            newForm.ShowDialog();              
                        

            Filters filter = new BrightnessFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void РезкостьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new Sharpness();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ТиснениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new GrayScaleFilter();
            Filters filter1 = new Impression();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ПереносToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormForTransfer newForm = new FormForTransfer();
            newForm.ShowDialog();
            Filters filter = new Transfer();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ПоворотToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormForTurn newForm = new FormForTurn();
            newForm.ShowDialog();
            Filters filter = new Turn();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void Волна1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new Wave1Filter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void Волна2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new Wave2Filter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ЭффектстеклаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new GlassFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ФильтрСобеляToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new SobelFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }


        private void СерыйМирToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new GrayWorld();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void РасширениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool[,] kernel = new bool[3, 3] { { false, true, false }, { true, true, true }, { false, true, false } };
            Filters filter = new MathematicalMorphology(kernel, true);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void СужениеToolStripMenuItem_Click(object sender, EventArgs e)
        {

            bool[,] kernel = new bool[3, 3] { { false, true, false }, { true, true, true }, { false, true, false } };
            Filters filter = new MathematicalMorphology(kernel, false);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ОткрытиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool[,] kernel = new bool[3, 3] { { false, true, false }, { true, true, true }, { false, true, false } };
            Filters filter = new Opening(kernel);
            backgroundWorker1.RunWorkerAsync(filter);

        }

        private void ЗакрытиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool[,] kernel = new bool[3, 3] { { false, true, false }, { true, true, true }, { false, true, false } };
            Filters filter = new Closing(kernel);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void МедианныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new MedianFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void TopHatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool[,] kernel = new bool[3, 3] { { false, true, false }, { true, true, true }, { false, true, false } };
            Filters filter = new TopHat(kernel);
            backgroundWorker1.RunWorkerAsync(filter);
        }
    }
}
