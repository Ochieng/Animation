using System;
using System.Windows.Forms;
using System.Threading;
using Animation;

namespace Animation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ControlAnimation.HorizontalMove(label1, 300, 500, AnimationType.Resilience);
        }
    }
}
