using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invictus.View
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_SizeChanged(object sender, EventArgs e)
        {
            panel5.Left = (this.ClientSize.Width - panel5.Width) / 2;
            panel5.Top = (this.ClientSize.Height - panel5.Height) / 2;
        }

        private void Home_Resize(object sender, EventArgs e)
        {
            panel5.Left = (this.ClientSize.Width - panel5.Width) / 2;
            panel5.Top = (this.ClientSize.Height - panel5.Height) / 2;
        }
    }
}
