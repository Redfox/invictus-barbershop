namespace Invictus.View
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
            this.pnlRelatorio = new System.Windows.Forms.Panel();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.pnlGerenciar = new System.Windows.Forms.Panel();
            this.btnGerenciar = new System.Windows.Forms.Button();
            this.pnlCadastro = new System.Windows.Forms.Panel();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.pnlConsulta = new System.Windows.Forms.Panel();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.PnlHome = new System.Windows.Forms.Panel();
            this.btnMain = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.PnlMinimizar.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.PnlHeader.SuspendLayout();
            this.pnlRelatorio.SuspendLayout();
            this.pnlGerenciar.SuspendLayout();
            this.pnlCadastro.SuspendLayout();
            this.pnlConsulta.SuspendLayout();
            this.PnlHome.SuspendLayout();
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
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
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
            this.PnlHeader.Controls.Add(this.pnlRelatorio);
            this.PnlHeader.Controls.Add(this.pnlGerenciar);
            this.PnlHeader.Controls.Add(this.pnlCadastro);
            this.PnlHeader.Controls.Add(this.pnlConsulta);
            this.PnlHeader.Controls.Add(this.PnlMinimizar);
            this.PnlHeader.Controls.Add(this.PnlHome);
            this.PnlHeader.Controls.Add(this.pnlExit);
            this.PnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlHeader.Location = new System.Drawing.Point(0, 0);
            this.PnlHeader.Name = "PnlHeader";
            this.PnlHeader.Size = new System.Drawing.Size(1073, 80);
            this.PnlHeader.TabIndex = 2;
            this.PnlHeader.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PnlHeader_MouseDoubleClick);
            this.PnlHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PnlHeader_MouseMove);
            // 
            // pnlRelatorio
            // 
            this.pnlRelatorio.BackColor = System.Drawing.Color.Transparent;
            this.pnlRelatorio.Controls.Add(this.btnRelatorio);
            this.pnlRelatorio.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlRelatorio.Location = new System.Drawing.Point(512, 0);
            this.pnlRelatorio.Name = "pnlRelatorio";
            this.pnlRelatorio.Size = new System.Drawing.Size(113, 80);
            this.pnlRelatorio.TabIndex = 6;
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.BackColor = System.Drawing.Color.Black;
            this.btnRelatorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRelatorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRelatorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRelatorio.FlatAppearance.BorderSize = 0;
            this.btnRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorio.Location = new System.Drawing.Point(0, 0);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(113, 80);
            this.btnRelatorio.TabIndex = 9;
            this.btnRelatorio.Text = "Relatorio";
            this.btnRelatorio.UseVisualStyleBackColor = false;
            // 
            // pnlGerenciar
            // 
            this.pnlGerenciar.BackColor = System.Drawing.Color.Transparent;
            this.pnlGerenciar.Controls.Add(this.btnGerenciar);
            this.pnlGerenciar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlGerenciar.Location = new System.Drawing.Point(399, 0);
            this.pnlGerenciar.Name = "pnlGerenciar";
            this.pnlGerenciar.Size = new System.Drawing.Size(113, 80);
            this.pnlGerenciar.TabIndex = 5;
            // 
            // btnGerenciar
            // 
            this.btnGerenciar.BackColor = System.Drawing.Color.Black;
            this.btnGerenciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGerenciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGerenciar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGerenciar.FlatAppearance.BorderSize = 0;
            this.btnGerenciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerenciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerenciar.Location = new System.Drawing.Point(0, 0);
            this.btnGerenciar.Name = "btnGerenciar";
            this.btnGerenciar.Size = new System.Drawing.Size(113, 80);
            this.btnGerenciar.TabIndex = 10;
            this.btnGerenciar.Text = "Gerenciar";
            this.btnGerenciar.UseVisualStyleBackColor = false;
            // 
            // pnlCadastro
            // 
            this.pnlCadastro.BackColor = System.Drawing.Color.Transparent;
            this.pnlCadastro.Controls.Add(this.btnCadastro);
            this.pnlCadastro.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlCadastro.Location = new System.Drawing.Point(286, 0);
            this.pnlCadastro.Name = "pnlCadastro";
            this.pnlCadastro.Size = new System.Drawing.Size(113, 80);
            this.pnlCadastro.TabIndex = 4;
            // 
            // btnCadastro
            // 
            this.btnCadastro.BackColor = System.Drawing.Color.Black;
            this.btnCadastro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCadastro.FlatAppearance.BorderSize = 0;
            this.btnCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastro.Location = new System.Drawing.Point(0, 0);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(113, 80);
            this.btnCadastro.TabIndex = 8;
            this.btnCadastro.Text = "Cadastro";
            this.btnCadastro.UseVisualStyleBackColor = false;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // pnlConsulta
            // 
            this.pnlConsulta.Controls.Add(this.btnConsulta);
            this.pnlConsulta.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlConsulta.Location = new System.Drawing.Point(173, 0);
            this.pnlConsulta.Name = "pnlConsulta";
            this.pnlConsulta.Size = new System.Drawing.Size(113, 80);
            this.pnlConsulta.TabIndex = 3;
            // 
            // btnConsulta
            // 
            this.btnConsulta.BackColor = System.Drawing.Color.Black;
            this.btnConsulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnConsulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConsulta.FlatAppearance.BorderSize = 0;
            this.btnConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulta.Location = new System.Drawing.Point(0, 0);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(113, 80);
            this.btnConsulta.TabIndex = 7;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.UseVisualStyleBackColor = false;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // PnlHome
            // 
            this.PnlHome.BackColor = System.Drawing.Color.Black;
            this.PnlHome.Controls.Add(this.btnMain);
            this.PnlHome.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlHome.Location = new System.Drawing.Point(0, 0);
            this.PnlHome.Name = "PnlHome";
            this.PnlHome.Size = new System.Drawing.Size(173, 80);
            this.PnlHome.TabIndex = 2;
            // 
            // btnMain
            // 
            this.btnMain.BackColor = System.Drawing.Color.Black;
            this.btnMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMain.FlatAppearance.BorderSize = 0;
            this.btnMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMain.Location = new System.Drawing.Point(0, 0);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(173, 80);
            this.btnMain.TabIndex = 6;
            this.btnMain.Text = "Invictus";
            this.btnMain.UseVisualStyleBackColor = false;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Transparent;
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.ForeColor = System.Drawing.Color.Black;
            this.pnlMain.Location = new System.Drawing.Point(0, 80);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1073, 476);
            this.pnlMain.TabIndex = 3;
            this.pnlMain.Resize += new System.EventHandler(this.pnlMain_Resize);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1073, 556);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.PnlHeader);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.PnlMinimizar.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.PnlHeader.ResumeLayout(false);
            this.pnlRelatorio.ResumeLayout(false);
            this.pnlGerenciar.ResumeLayout(false);
            this.pnlCadastro.ResumeLayout(false);
            this.pnlConsulta.ResumeLayout(false);
            this.PnlHome.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PnlMinimizar;
        private System.Windows.Forms.Panel pnlExit;
        private System.Windows.Forms.Panel PnlHeader;
        private System.Windows.Forms.Panel PnlHome;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Panel pnlConsulta;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Panel pnlCadastro;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Panel pnlGerenciar;
        private System.Windows.Forms.Panel pnlRelatorio;
        private System.Windows.Forms.Button btnGerenciar;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.Panel pnlMain;
    }
}