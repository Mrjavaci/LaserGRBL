using System;
using System.Windows.Forms;

namespace LaserGRBL
{
    public partial class RxButtons : UserControl
    {
        private GrblCore Core;

        public RxButtons()
        {
            InitializeComponent();
        }

        public void setCore(GrblCore core)
        {
            Core = core;
        }

        private void ErmergButtonClicked(object sender, EventArgs e)
        {
            Core.FeedHold(false);

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {
        }


        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void ResumeButtonClick(object sender, EventArgs e)
        {
            Core.CycleStartResume(false);

        }

        private void ResetButtonClick(object sender, EventArgs e)
        {
            Core.GrblReset();

        }

        private void ZeroButtonClick(object sender, EventArgs e)
        {
            Core.SetNewZero();
        }

        private bool isPointer = false;

        private void PointerClick(object sender, EventArgs e)
        {
            if (isPointer)
            {
                Core.ExecuteCustombutton("M5 S0\r\nG0\r\n");
                this.isPointer = false;
            }
            else
            {
                Core.ExecuteCustombutton("M3 S[$30*3/100]\r\nG1 F1000\r\n");
                this.isPointer = true;

            }

        }

        private void CornerClick(object sender, EventArgs e)
        {
            Core.ExecuteCustombutton("G0 X[left] Y[bottom]");
        }

        private void CenterClick(object sender, EventArgs e)
        {
            Core.ExecuteCustombutton(
                "G0 X[left+width/2] Y[bottom+height/2]");
        }

        private void FrameClick(object sender, EventArgs e)
        {
            Core.ExecuteCustombutton(
                "G0 X[left] Y[bottom]\r\nM3 S[$30*3/100] F1000\r\nG1 Y[top] \r\nG1 X[right]\r\nG1 Y[bottom] \r\nG1 X[left]\r\nM5\r\nG0 X0 Y0");
        }
    }
}