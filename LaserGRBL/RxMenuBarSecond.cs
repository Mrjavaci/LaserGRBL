using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LaserGRBL.UserControls;

namespace LaserGRBL
{
    public partial class RxMenuBarSecond : UserControl
    {
        public RxMenuBarSecond()
        {
            InitializeComponent();
        }

        public TextProgressBar getBar()
        {
            return textProgressBar1;
        }

        public void setProgressBar(TextProgressBar myBar)
        {
            this.textProgressBar1 = myBar;

        }

        public String valueOfTime
        {
            set
            {
                label1.Text = value;
            }
        }


        private void rxProgressBar1_Click(object sender, EventArgs e)
        {


        }
    }
}
