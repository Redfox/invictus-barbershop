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
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();

            //string d = webBrowser1.Document.InvokeScript("").ToString();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

        }

        private void Cadastro_Resize(object sender, EventArgs e)
        {
            
        }

        private void Cadastro_SizeChanged(object sender, EventArgs e)
        {
            pnlContent.Left = (this.ClientSize.Width - pnlContent.Width) / 2;
            pnlContent.Top = (this.ClientSize.Height - pnlContent.Height) / 2;
        }
    }
}
