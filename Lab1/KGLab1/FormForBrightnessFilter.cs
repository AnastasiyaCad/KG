using System;
using System.Windows.Forms;

namespace KGLab1
{
    public partial class FormForBrightnessFilter : Form
    {
        //public int constBriht;
        public FormForBrightnessFilter()
        {
            InitializeComponent();
        }

        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = String.Format("Яркость: {0}", trackBar1.Value);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Program.constBriht = trackBar1.Value;
            this.Close();
        }
    }
}
