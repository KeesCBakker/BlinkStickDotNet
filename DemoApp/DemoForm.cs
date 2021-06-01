using System;
using System.Windows.Forms;

namespace DemoApp
{
    public partial class BlinkStickDemo : Form
    {
        private ISimpleStickController _controller;
        public BlinkStickDemo()
        {
            InitializeComponent();
            _controller = new SimpleStickController();
        }

        private void btnBlinkGreen_Click(object sender, EventArgs e)
        {
            _controller.BlinkGreen();
        }

        private void btnSetRed_Click(object sender, EventArgs e)
        {
            _controller.SetRed();
        }

        private void btnTurnOff_Click(object sender, EventArgs e)
        {
            _controller.TurnOff();
        }

        private void btnSetWhite_Click(object sender, EventArgs e)
        {
            _controller.SetWhite();
        }
    }
}
