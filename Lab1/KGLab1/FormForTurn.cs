using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KGLab1
{
    public partial class FormForTurn : Form
    {
        public FormForTurn()
        {
            InitializeComponent();
        }

        private void TrackBar1_Scroll_1(object sender, EventArgs e)
        {
            label4.Text = String.Format("Угол поворота: {0}", trackBar1.Value);
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            Program.constNu = (trackBar1.Value) * Math.PI / 180;
            this.Close();
        }
    }
}
