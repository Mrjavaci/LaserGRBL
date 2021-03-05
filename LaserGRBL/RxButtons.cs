using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaserGRBL
{
    public partial class RxButtons : UserControl
    {
         GrblCore Core;
        public RxButtons()
        {
            InitializeComponent();
        }

        public void setCore(GrblCore core)
        {
            this.Core = core;
        }

        private void ErmergButtonClicked(object sender, EventArgs e)
        {
            Core.GrblReset();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ResumeButtonClick(object sender, EventArgs e)
        {

        }

        private void ResetButtonClick(object sender, EventArgs e)
        {

        }

        private void ZeroButtonClick(object sender, EventArgs e)
        {

        }

        private void PointerClick(object sender, EventArgs e)
        {

        }

        private void CornerClick(object sender, EventArgs e)
        {

        }

        private void CenterClick(object sender, EventArgs e)
        {

        }

        private void FrameClick(object sender, EventArgs e)
        {

        }
    }
}
