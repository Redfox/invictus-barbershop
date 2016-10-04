namespace StudioRL2._0
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblCadastro = new System.Windows.Forms.Label();
            this.lblConsulta = new System.Windows.Forms.Label();
            this.PnlTitle = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PnlHeader = new System.Windows.Forms.Panel();
            this.lblGerenciar = new System.Windows.Forms.Label();
            this.PnlMinimizar = new System.Windows.Forms.Panel();
            this.lblMinimizar = new System.Windows.Forms.Label();
            this.pnlExit = new System.Windows.Forms.Panel();
            this.lblFechar = new System.Windows.Forms.Label();
            this.PnlContent = new System.Windows.Forms.Panel();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.lblRelatorio = new System.Windows.Forms.Label();
            this.PnlTitle.SuspendLayout();
            this.PnlHeader.SuspendLayout();
            this.PnlMinimizar.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCadastro
            // 
            this.lblCadastro.AutoSize = true;
            this.lblCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastro.ForeColor = System.Drawing.Color.White;
            this.lblCadastro.Location = new System.Drawing.Point(282, 0);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Padding = new System.Windows.Forms.Padding(15, 27, 15, 27);
            this.lblCadastro.Size = new System.Drawing.Size(114, 78);
            this.lblCadastro.TabIndex = 3;
            this.lblCadastro.Text = "Cadastro";
            this.lblCadastro.Click += new System.EventHandler(this.lblCadastro_Click);
            this.lblCadastro.MouseEnter += new System.EventHandler(this.lblCadastro_MouseEnter);
            this.lblCadastro.MouseLeave += new System.EventHandler(this.lblCadastro_MouseLeave);
            // 
            // lblConsulta
            // 
            this.lblConsulta.AutoSize = true;
            this.lblConsulta.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsulta.ForeColor = System.Drawing.Color.White;
            this.lblConsulta.Location = new System.Drawing.Point(173, 0);
            this.lblConsulta.Name = "lblConsulta";
            this.lblConsulta.Padding = new System.Windows.Forms.Padding(15, 27, 15, 27);
            this.lblConsulta.Size = new System.Drawing.Size(113, 78);
            this.lblConsulta.TabIndex = 3;
            this.lblConsulta.Text = "Consulta";
            this.lblConsulta.Click += new System.EventHandler(this.lblConsulta_Click);
            this.lblConsulta.MouseEnter += new System.EventHandler(this.lblConsulta_MouseEnter);
            this.lblConsulta.MouseLeave += new System.EventHandler(this.lblConsulta_MouseLeave);
            // 
            // PnlTitle
            // 
            this.PnlTitle.BackColor = System.Drawing.Color.Black;
            this.PnlTitle.Controls.Add(this.panel2);
            this.PnlTitle.Controls.Add(this.label1);
            this.PnlTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlTitle.Location = new System.Drawing.Point(0, 0);
            this.PnlTitle.Name = "PnlTitle";
            this.PnlTitle.Size = new System.Drawing.Size(173, 80);
            this.PnlTitle.TabIndex = 2;
            this.PnlTitle.DoubleClick += new System.EventHandler(this.PnlHeaderLeft_DoubleClick);
            this.PnlTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlHeaderLeft_MouseDown);
            this.PnlTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PnlHeaderLeft_MouseMove);
            this.PnlTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PnlHeaderLeft_MouseUp);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(229, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(38, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "StudioRL";
            // 
            // PnlHeader
            // 
            this.PnlHeader.BackColor = System.Drawing.Color.Black;
            this.PnlHeader.Controls.Add(this.lblRelatorio);
            this.PnlHeader.Controls.Add(this.lblGerenciar);
            this.PnlHeader.Controls.Add(this.lblCadastro);
            this.PnlHeader.Controls.Add(this.lblConsulta);
            this.PnlHeader.Controls.Add(this.PnlMinimizar);
            this.PnlHeader.Controls.Add(this.PnlTitle);
            this.PnlHeader.Controls.Add(this.pnlExit);
            this.PnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlHeader.Location = new System.Drawing.Point(0, 0);
            this.PnlHeader.Name = "PnlHeader";
            this.PnlHeader.Size = new System.Drawing.Size(1364, 80);
            this.PnlHeader.TabIndex = 1;
            this.PnlHeader.DoubleClick += new System.EventHandler(this.PnlHeaderRight_DoubleClick);
            this.PnlHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlHeaderRight_MouseDown);
            this.PnlHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PnlHeaderRight_MouseMove);
            this.PnlHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PnlHeaderRight_MouseUp);
            // 
            // lblGerenciar
            // 
            this.lblGerenciar.AutoSize = true;
            this.lblGerenciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGerenciar.ForeColor = System.Drawing.Color.White;
            this.lblGerenciar.Location = new System.Drawing.Point(387, 0);
            this.lblGerenciar.Name = "lblGerenciar";
            this.lblGerenciar.Padding = new System.Windows.Forms.Padding(15, 27, 15, 27);
            this.lblGerenciar.Size = new System.Drawing.Size(123, 78);
            this.lblGerenciar.TabIndex = 4;
            this.lblGerenciar.Text = "Gerenciar";
            this.lblGerenciar.Click += new System.EventHandler(this.lblHistorico_Click);
            this.lblGerenciar.MouseEnter += new System.EventHandler(this.lblHistorico_MouseEnter);
            this.lblGerenciar.MouseLeave += new System.EventHandler(this.lblHistorico_MouseLeave);
            // 
            // PnlMinimizar
            // 
            this.PnlMinimizar.Controls.Add(this.lblMinimizar);
            this.PnlMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.PnlMinimizar.Location = new System.Drawing.Point(1196, 0);
            this.PnlMinimizar.Name = "PnlMinimizar";
            this.PnlMinimizar.Size = new System.Drawing.Size(84, 80);
            this.PnlMinimizar.TabIndex = 3;
            this.metroToolTip1.SetToolTip(this.PnlMinimizar, "Minimizar");
            this.PnlMinimizar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PnlMinimizar_MouseClick);
            this.PnlMinimizar.MouseEnter += new System.EventHandler(this.PnlMinimizar_MouseEnter);
            this.PnlMinimizar.MouseLeave += new System.EventHandler(this.PnlMinimizar_MouseLeave);
            // 
            // lblMinimizar
            // 
            this.lblMinimizar.AutoSize = true;
            this.lblMinimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimizar.ForeColor = System.Drawing.Color.White;
            this.lblMinimizar.Location = new System.Drawing.Point(32, 23);
            this.lblMinimizar.Name = "lblMinimizar";
            this.lblMinimizar.Size = new System.Drawing.Size(23, 31);
            this.lblMinimizar.TabIndex = 0;
            this.lblMinimizar.Text = "-";
            this.metroToolTip1.SetToolTip(this.lblMinimizar, "Minimizar");
            this.lblMinimizar.Click += new System.EventHandler(this.lblMinimizar_Click);
            this.lblMinimizar.MouseEnter += new System.EventHandler(this.lblMinimizar_MouseEnter);
            // 
            // pnlExit
            // 
            this.pnlExit.Controls.Add(this.lblFechar);
            this.pnlExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlExit.Location = new System.Drawing.Point(1280, 0);
            this.pnlExit.Name = "pnlExit";
            this.pnlExit.Size = new System.Drawing.Size(84, 80);
            this.pnlExit.TabIndex = 2;
            this.metroToolTip1.SetToolTip(this.pnlExit, "Fechar");
            this.pnlExit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlExit_MouseClick);
            this.pnlExit.MouseEnter += new System.EventHandler(this.lblFechar_MouseEnter);
            this.pnlExit.MouseLeave += new System.EventHandler(this.lblFechar_MouseLeave);
            // 
            // lblFechar
            // 
            this.lblFechar.AutoSize = true;
            this.lblFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechar.ForeColor = System.Drawing.Color.White;
            this.lblFechar.Location = new System.Drawing.Point(24, 23);
            this.lblFechar.Name = "lblFechar";
            this.lblFechar.Size = new System.Drawing.Size(32, 31);
            this.lblFechar.TabIndex = 0;
            this.lblFechar.Text = "X";
            this.metroToolTip1.SetToolTip(this.lblFechar, "Fechar");
            this.lblFechar.Click += new System.EventHandler(this.lblFechar_Click);
            this.lblFechar.MouseEnter += new System.EventHandler(this.lblFechar_MouseEnter);
            // 
            // PnlContent
            // 
            this.PnlContent.Location = new System.Drawing.Point(0, 80);
            this.PnlContent.Name = "PnlContent";
            this.PnlContent.Size = new System.Drawing.Size(1372, 671);
            this.PnlContent.TabIndex = 2;
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // lblRelatorio
            // 
            this.lblRelatorio.AutoSize = true;
            this.lblRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelatorio.ForeColor = System.Drawing.Color.White;
            this.lblRelatorio.Location = new System.Drawing.Point(513, 1);
            this.lblRelatorio.Name = "lblRelatorio";
            this.lblRelatorio.Padding = new System.Windows.Forms.Padding(15, 27, 15, 27);
            this.lblRelatorio.Size = new System.Drawing.Size(114, 78);
            this.lblRelatorio.TabIndex = 5;
            this.lblRelatorio.Text = "Relatorio";
            this.lblRelatorio.Click += new System.EventHandler(this.lblRelatorio_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1364, 772);
            this.Controls.Add(this.PnlContent);
            this.Controls.Add(this.PnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.PnlTitle.ResumeLayout(false);
            this.PnlTitle.PerformLayout();
            this.PnlHeader.ResumeLayout(false);
            this.PnlHeader.PerformLayout();
            this.PnlMinimizar.ResumeLayout(false);
            this.PnlMinimizar.PerformLayout();
            this.pnlExit.ResumeLayout(false);
            this.pnlExit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PnlHeader;
        private System.Windows.Forms.Panel PnlTitle;
        private System.Windows.Forms.Label lblFechar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlExit;
        private System.Windows.Forms.Panel PnlMinimizar;
        private System.Windows.Forms.Label lblMinimizar;
        private System.Windows.Forms.Label lblConsulta;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel PnlContent;
        private System.Windows.Forms.Label lblCadastro;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private System.Windows.Forms.Label lblGerenciar;
        private System.Windows.Forms.Label lblRelatorio;
    }
}

