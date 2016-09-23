﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudioRL2._0
{
    
    public partial class Form1 : Form
    {
        private bool conActived = false;
        private bool cadActived = false;

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        Consulta consulta = new Consulta();
        Cadastro cadastro = new Cadastro();
        public Form1()
        {
            InitializeComponent();
            //Form Principal maximizado
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Height = Screen.PrimaryScreen.Bounds.Height - 40;

            this.Location = new Point();

            this.StartPosition = FormStartPosition.Manual;
        }
        private void lblConsulta_Click(object sender, EventArgs e)
        {
            conActived = true;
            cadActived = false;
            lblCadastro.BackColor = Color.Black;

            PnlContent.Controls.Clear();
            consulta.TopLevel = false;
            consulta.MaximizeBox = true;
            consulta.AutoSize = true;
            consulta.Size = PnlContent.Size;
            PnlContent.Controls.Add(consulta);
            consulta.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PnlContent.Controls.Clear();
        }
        
        //Movimentar o form Principal
        private void PnlHeaderLeft_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }
        private void PnlHeaderLeft_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }
        private void PnlHeaderLeft_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        private void PnlHeaderRight_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }
        private void PnlHeaderRight_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }
        private void PnlHeaderRight_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }//Movimentar o form Principal ~ END

        //Minimizar e fechar form / Mudar cor ao passar mouse em cima
        private void lblFechar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void lblFechar_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            pnlExit.BackColor = ColorTranslator.FromHtml("#333333");
        }
        private void lblFechar_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
            pnlExit.BackColor = Color.Black;
        }
        private void pnlExit_MouseClick(object sender, MouseEventArgs e)
        {
            Environment.Exit(0);
        }//Fechar ~ END
        private void PnlMinimizar_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void lblMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void PnlMinimizar_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            PnlMinimizar.BackColor = ColorTranslator.FromHtml("#333333");
        }
        private void PnlMinimizar_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
            PnlMinimizar.BackColor = Color.Black;
        }
        private void lblMinimizar_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            PnlMinimizar.BackColor = ColorTranslator.FromHtml("#333333");
        }//Minimizar e fechar form / Mudar cor ao passar mouse em cima ~ END

        //Move form para posicao 0
        private void PnlHeaderRight_DoubleClick(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
        }

        private void PnlHeaderLeft_DoubleClick(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
        }//Move form para posicao 0 ~ END

        //controle dos paineis do menu

            //Consulta
        private void pnlConsulta_Click(object sender, EventArgs e)
        {
            PnlContent.Controls.Clear();
            consulta.TopLevel = false;
            consulta.MaximizeBox = true;
            consulta.AutoSize = true;
            consulta.Size = PnlContent.Size;
            PnlContent.Controls.Add(consulta);
            consulta.Show();
        }
        
        private void lblConsulta_MouseEnter(object sender, EventArgs e)
        {
            lblConsulta.BackColor = ColorTranslator.FromHtml("#333333");
            this.Cursor = Cursors.Hand;
        }
        private void lblConsulta_MouseLeave(object sender, EventArgs e)
        {
            if (!conActived)
            {
                lblConsulta.BackColor = Color.Black;
            }
            
            this.Cursor = Cursors.Arrow;
        }
        //Consulta ~ END
        //cadastro
        private void lblCadastro_Click(object sender, EventArgs e)
        {
            cadActived = true;
            conActived = false;
            lblConsulta.BackColor = Color.Black;

            PnlContent.Controls.Clear();
            cadastro.TopLevel = false;
            cadastro.MaximizeBox = true;
            cadastro.AutoSize = true;
            cadastro.Size = PnlContent.Size;
            PnlContent.Controls.Add(cadastro);
            cadastro.Show();
        }
        private void lblCadastro_MouseEnter(object sender, EventArgs e)
        {
            lblCadastro.BackColor = ColorTranslator.FromHtml("#333333");
            this.Cursor = Cursors.Hand;
        }
        private void lblCadastro_MouseLeave(object sender, EventArgs e)
        {
            if (!(cadActived))
            {
                lblCadastro.BackColor = Color.Black;
            }            
            this.Cursor = Cursors.Arrow;
        }
        private void pnlCadastro_MouseClick(object sender, MouseEventArgs e)
        {
            PnlContent.Controls.Clear();
            cadastro.TopLevel = false;
            cadastro.MaximizeBox = true;
            cadastro.AutoSize = true;
            cadastro.Size = PnlContent.Size;
            PnlContent.Controls.Add(cadastro);
            cadastro.Show();
        }//cadastro ~ END
    }
}
