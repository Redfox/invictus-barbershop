using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Invictus.View
{
    public partial class Main : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private Form activeForm = null;

        public Main()
        {
            InitializeComponent();
        }
        
        private void Main_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            Left = Top = 0;
            Width = Screen.PrimaryScreen.WorkingArea.Width;
            Height = Screen.PrimaryScreen.WorkingArea.Height;

            changeForm(new Home());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void PnlHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Width = 1073;
                Height = 556;
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PnlHeader_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Height = Screen.PrimaryScreen.Bounds.Height - 40;

            this.Left =  0;
            this.Top = 0;
            
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            
        }
        
        private void btnCadastro_Click(object sender, EventArgs e)
        {
            changeForm(new Cadastro());
        }


        private void changeForm(Form form)
        {
            activeForm = form;

            pnlMain.Controls.Clear();
            form.TopLevel = false;
            form.MaximizeBox = true;
            form.AutoSize = true;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Size = pnlMain.Size;
            pnlMain.Controls.Add(form);
            form.Show();
        }

        private void pnlMain_Resize(object sender, EventArgs e)
        {
            if(activeForm != null)
                activeForm.Size = pnlMain.Size;
        }
    }
}
