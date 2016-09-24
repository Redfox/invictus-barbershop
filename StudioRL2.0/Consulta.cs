using System;
using System.Data;
using System.Data.Odbc;
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
        string whats = "N";
        string infantil = "N";
        string mensalista = "N";
        bool pagar = false;
        bool editando = false;
        bool editandoObs = false;

        public Consulta()
        {
            InitializeComponent();
            disable();
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
                txtObs.Text = data[12];

                if (data[7] == "S")
                {
                    chkWhats.Visible = true;
                    chkWhats.Checked = true;
                }
                if (data[9] == "S")
                {
                    chkInfantil.Visible = true;
                    chkInfantil.Checked = true;
                }
                if (data[10] == "S")
                {
                    chkMensalista.Visible = true;
                    chkMensalista.Checked = true;
                }

                preencherGrid();
                enable();
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            editar();
        }
        private void btnEditarObs_Click(object sender, EventArgs e)
        {
            if (!editandoObs)
            {
                editandoObs = true;
                txtObs.ReadOnly = false;
                btnEditarObs.Text = "Salvar";                
            }
            else if (editandoObs)
            {
                editandoObs = false;
                txtObs.ReadOnly = true;
                btnEditarObs.Text = "Editar";
                bd.atualizarObs(data[0], txtObs.Text);
            }
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

        private void disable()
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
            txtObs.ReadOnly = true;
            mskTelCel.Enabled = false;
            mskTelFixo.Enabled = false;

            btnConcluir.Enabled = false;
            btnEditar.Enabled = false;
            btnBuscar.Enabled = true;
        }

        private void enable()
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
            txtObs.ReadOnly = true;
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
            chkMensalista.Checked = false;
            chkMensalista.Visible = false;
            chkInfantil.Checked = false;
            chkInfantil.Visible = false;
            chkWhats.Checked = false;
            chkWhats.Visible = false;
            btnBuscar.Enabled = true;
            btnSair.Enabled = false;
        }
        
        private void editar()
        {
            if (!editando)
            {
                editando = true;
                btnEditar.Text = "Salvar";

                chkMensalista.Enabled = true;
                chkMensalista.Visible = true;
                chkWhats.Enabled = true;
                chkWhats.Visible = true;
                chkInfantil.Enabled = true;
                chkInfantil.Visible = true;

                txtNomeCompleto.ReadOnly = false;
                txtEndereco.ReadOnly = false;
                txtApelido.ReadOnly = false;
                mskTelCel.ReadOnly = false;
                mskTelFixo.ReadOnly = false;
                cboOperadora.Enabled = true;
            }
            else if(editando)
            {
                editando = false;
                btnEditar.Text = "Editar";

                chkMensalista.Enabled = false;
                chkInfantil.Enabled = false;
                chkWhats.Enabled = false;
                chkInfantil.Visible = true;
                chkMensalista.Visible = true;
                chkWhats.Visible = true;

                txtNomeCompleto.ReadOnly = true;
                txtEndereco.ReadOnly = true;
                txtApelido.ReadOnly = true;
                mskTelCel.ReadOnly = true;
                mskTelFixo.ReadOnly = true;
                cboOperadora.Enabled = false;
                
                if (!chkWhats.Checked)
                    chkWhats.Visible = false;
                if(!chkInfantil.Checked)
                    chkInfantil.Visible = false;
                if(!chkMensalista.Checked)
                    chkMensalista.Visible = false;

                if (chkWhats.Checked){whats = "S"; } else { whats = "N"; }
                if (chkInfantil.Checked){ infantil = "S"; } else { infantil = "N"; }
                if (chkMensalista.Checked){mensalista = "S";} else { mensalista = "N"; }
                    
                DialogResult confirm = MessageBox.Show("Deseja Atualizar o cadastro?", "Validação", MessageBoxButtons.YesNo);
                if (confirm.ToString().ToUpper() == "YES")
                {
                    bd.autalizarCliente(txtNomeCompleto.Text, txtApelido.Text, txtEndereco.Text, mskTelFixo.Text, mskTelCel.Text, cboOperadora.Text, whats, infantil, mensalista, data[0]);
                }
            }
        }

        private void preencherGrid()
        {
            try
            {
                OdbcConnection conexao = new Connection().Conexao();
                OdbcCommand cmd = new OdbcCommand("", conexao);
                OdbcDataAdapter adapter = new OdbcDataAdapter("", conexao);
                DataSet ds = new DataSet();
                conexao.Open();

                cmd = new OdbcCommand("Select ID as 'ID do Corte', DataC as 'Data do corte', Corte, Barba, Pezinho, Sombrancelha, SombrancelhaHenna as 'Sombrancelha de Henna', Relaxamento, Progressiva, PigmentacaoCorte as 'Pigmentacao Corte', PigmentacaoBarba as 'Pigmentacao Barba', Luzes, Gel, Lapis, Valor, ValorEmAberto, Status from historico where ID_Cliente like '" + data[0] + "' and Status like 'Em aberto' or Status like 'Em Processo'", conexao);

                adapter = new OdbcDataAdapter(cmd);
                ds = new DataSet();
                adapter.Fill(ds, "clientes");

                dataGridPagamento.DataMember = "clientes";

                dataGridPagamento.DataSource = ds;
                dataGridPagamento.DataMember = "clientes";

                dataGridPagamento.Columns[0].Visible = false;

                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }
    }
}
