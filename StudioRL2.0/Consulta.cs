using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudioRL2._0.Class;

namespace StudioRL2._0
{
    public partial class Consulta : Form
    {
        string[] data;
        DataBase bd = new DataBase();

        //strings de incersao no banco
        string corte = "N";
        string barba = "N";
        string gel = "N";
        string lapis = "N";
        string luzes = "N";
        string pezinho = "N";
        string pigbarba = "N";
        string pigCorte = "N";
        string progressiva = "N";
        string relaxamento = "N";
        string sombancelha = "N";
        string sombancelhaHenna = "N";
        string status = "Pago";
        bool pagar = false;

        public Consulta()
        {
            InitializeComponent();
            enable();
        }

        private void Consulta_Load(object sender, EventArgs e)
        {
            btnSair.Enabled = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (bd.countCliente(txtNome.Text) > 0)
            {
                data = bd.buscarCliente(txtNome.Text);
                txtApelido.Text = data[2];
                txtNomeCompleto.Text = data[1];
                txtEndereco.Text = data[3];
                mskTelCel.Text = data[5]; 
                mskTelFixo.Text = data[4];
                cboOperadora.Text = data[6];
                disable();
            }
            else
            {
                MessageBox.Show("sdads");
            }
        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            verificaDados();
            if (chkPagar.Checked)
                pagar = true;
            bd.cadastarConsulta(data[0], corte, barba, pezinho, sombancelha, sombancelhaHenna, relaxamento, progressiva, pigCorte, pigbarba, luzes, gel, lapis, txtValor.Text, status, txtValor.Text, pagar);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            enable();
            sair();
        }

        private void verificaDados()
        {
            if(chkCorte.Checked)
                corte = "S";
            if (chkBarba.Checked)
                barba = "S";
            if (chkGel.Checked)
                gel = "S";
            if (chkLapis.Checked)
                lapis = "S";
            if (chkLuzes.Checked)
                luzes = "S";
            if (chkPezinho.Checked)
                pezinho = "S";
            if (chkPigmentacaoBarba.Checked)
                pigbarba = "S";
            if (chkPigmentacaoCorte.Checked)
                pigCorte = "S";
            if (chkProgressiva.Checked)
                progressiva = "S";
            if (chkRelaxamento.Checked)
                relaxamento = "S";
            if (chkSombrancelha.Checked)
                sombancelha = "S";
            if (chkSombrancelhaHenna.Checked)
                sombancelhaHenna = "S";
            if (chkPagar.Checked)
                status = "Em aberto";
        }

        private void enable()
        {
            chkCorte.Enabled = false;
            chkBarba.Enabled = false;
            chkGel.Enabled = false;
            chkLapis.Enabled = false;
            chkLuzes.Enabled = false;
            chkPezinho.Enabled = false;
            chkPigmentacaoBarba.Enabled = false;
            chkPigmentacaoCorte.Enabled = false;
            chkProgressiva.Enabled = false;
            chkRelaxamento.Enabled = false;
            chkSombrancelha.Enabled = false;
            chkSombrancelhaHenna.Enabled = false;
            chkPagar.Enabled = false;
            chkFrequ.Enabled = false;

            txtValor.Enabled = false;
            txtApelido.Enabled = false;
            txtNomeCompleto.Enabled = false;
            txtEndereco.Enabled = false;
            mskTelCel.Enabled = false;
            mskTelFixo.Enabled = false;

            btnConcluir.Enabled = false;
            btnEditar.Enabled = false;
            btnBuscar.Enabled = true;
        }

        private void disable()
        {
            chkCorte.Enabled = true;
            chkBarba.Enabled = true;
            chkGel.Enabled = true;
            chkLapis.Enabled = true;
            chkLuzes.Enabled = true;
            chkPezinho.Enabled = true;
            chkPigmentacaoBarba.Enabled = true;
            chkPigmentacaoCorte.Enabled = true;
            chkProgressiva.Enabled = true;
            chkRelaxamento.Enabled = true;
            chkSombrancelha.Enabled = true;
            chkSombrancelhaHenna.Enabled = true;
            chkPagar.Enabled = true;
            chkFrequ.Enabled = true;

            txtValor.Enabled = true;
            txtApelido.Enabled = true;
            txtNomeCompleto.Enabled = true;
            txtEndereco.Enabled = true;
            mskTelCel.Enabled = true;
            mskTelFixo.Enabled = true;

            btnConcluir.Enabled = true;
            btnEditar.Enabled = true;
            btnSair.Enabled = true;
            btnBuscar.Enabled = false;
        }

        private void sair()
        {
            txtApelido.Clear();
            txtNomeCompleto.Clear();
            txtEndereco.Clear();
            mskTelCel.Clear();
            mskTelFixo.Clear();
            txtNome.Clear();
            cboOperadora.Text = "";
        }
        
    }
}
