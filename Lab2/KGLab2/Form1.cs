using System;
using System.Windows.Forms;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace KGLab2
{
    public partial class Form1 : Form
    {
        Bin bin = new Bin();
        bool loaded = false;
        bool needReload = false;
        View view = new View();
        int currentLayer;
        int FrameCount;
        DateTime NextFPSUpdate = DateTime.Now.AddSeconds(1);
        int check;
        int min;
        int width;

        void displayFPS()
        {
            if (DateTime.Now >= NextFPSUpdate)
            {
                this.Text = String.Format("CT Visualizer (fps={0})", FrameCount);
                NextFPSUpdate = DateTime.Now.AddSeconds(1);
                FrameCount = 0;
            }
            FrameCount++;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Application.Idle += Application_Idle;
        }

        private void ОткрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                string str = dialog.FileName;
                bin.readBIN(str);
                view.SetupView(glControl1.Width, glControl1.Height);
                loaded = true;
                glControl1.Invalidate();
            }

        }

        private void GlControl1_Paint(object sender, PaintEventArgs e)
        {
            if (loaded)
            {
                if (check == 2)
                {
                    view.DrawQuads(currentLayer, min, width);
                    glControl1.SwapBuffers();
                }
                if (check == 3)
                {
                    view.DrawQuadStrip(currentLayer, min, width);
                    glControl1.SwapBuffers();
                }
                else
                {
                    if (needReload)
                    {
                        view.generateTextureImage(currentLayer, min, width);
                        view.Load2DTexture();
                        needReload = false;
                    }
                    //view.DrawQuads(currentLayer);
                    view.DrawTexture();
                    glControl1.SwapBuffers();
                }
       
            }
        }

        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            currentLayer = trackBar1.Value;
            needReload = true;
        }

        void Application_Idle(object sender, EventArgs e)
        {
            while (glControl1.IsIdle)
            {
                displayFPS();
                glControl1.Invalidate();
            }
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            check = 3;
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            check = 1;
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            check = 2;
        }

        private void TrackBar2_Scroll(object sender, EventArgs e) // min
        {
            min = trackBar2.Value;
            needReload = true;
        }

        private void TrackBar3_Scroll(object sender, EventArgs e) //высота
        {
            width = trackBar2.Value;
            needReload = true;
        }
    }
}
