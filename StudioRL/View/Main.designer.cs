namespace StudioRL
{
    partial class Main
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
            this.PnlMinimizar = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.pnlExit = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.PnlHeader = new System.Windows.Forms.Panel();
            this.lblRelatorio = new System.Windows.Forms.Label();
            this.lblGerenciar = new System.Windows.Forms.Label();
            this.lblCadastro = new System.Windows.Forms.Label();
            this.lblConsulta = new System.Windows.Forms.Label();
            this.PnlTitle = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PnlMinimizar.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.PnlHeader.SuspendLayout();
            this.PnlTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlMinimizar
            // 
            this.PnlMinimizar.Controls.Add(this.btnMinimize);
            this.PnlMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.PnlMinimizar.Location = new System.Drawing.Point(905, 0);
            this.PnlMinimizar.Name = "PnlMinimizar";
            this.PnlMinimizar.Size = new System.Drawing.Size(84, 80);
            this.PnlMinimizar.TabIndex = 3;
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Black;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.Location = new System.Drawing.Point(0, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(84, 80);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.Text = "-";
            this.btnMinimize.UseVisualStyleBackColor = false;
            // 
            // pnlExit
            // 
            this.pnlExit.Controls.Add(this.btnExit);
            this.pnlExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlExit.Location = new System.Drawing.Point(989, 0);
            this.pnlExit.Name = "pnlExit";
            this.pnlExit.Size = new System.Drawing.Size(84, 80);
            this.pnlExit.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(0, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(84, 80);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
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
            this.PnlHeader.Size = new System.Drawing.Size(1073, 80);
            this.PnlHeader.TabIndex = 2;
            this.PnlHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PnlHeader_MouseMove);
            // 
            // lblRelatorio
            // 
            this.lblRelatorio.AutoSize = true;
            this.lblRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelatorio.ForeColor = System.Drawing.Color.White;
            this.lblRelatorio.Location = new System.Drawing.Point(509, 0);
            this.lblRelatorio.Name = "lblRelatorio";
            this.lblRelatorio.Padding = new System.Windows.Forms.Padding(15, 27, 15, 27);
            this.lblRelatorio.Size = new System.Drawing.Size(114, 78);
            this.lblRelatorio.TabIndex = 5;
            this.lblRelatorio.Text = "Relatorio";
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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1073, 556);
            this.Controls.Add(this.PnlHeader);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.PnlMinimizar.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.PnlHeader.ResumeLayout(false);
            this.PnlHeader.PerformLayout();
            this.PnlTitle.ResumeLayout(false);
            this.PnlTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PnlMinimizar;
        private System.Windows.Forms.Panel pnlExit;
        private System.Windows.Forms.Panel PnlHeader;
        private System.Windows.Forms.Label lblRelatorio;
        private System.Windows.Forms.Label lblGerenciar;
        private System.Windows.Forms.Label lblCadastro;
        private System.Windows.Forms.Label lblConsulta;
        private System.Windows.Forms.Panel PnlTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnExit;
    }
}