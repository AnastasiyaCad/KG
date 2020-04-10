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
    public partial class FormForTransfer : Form
    {
        public FormForTransfer()
        {
            InitializeComponent();
        }  

        private void Button1_Click_1(object sender, EventArgs e)
        {
            Program.constX = Int32.Parse(textBox1.Text);
            Program.constY = Int32.Parse(textBox2.Text);
            this.Close();
        }
    }
}
