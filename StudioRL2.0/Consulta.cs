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
            txtValorPago.Text = "0";
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
                txtValorAberto.Text = data[14];

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
                MessageBox.Show("Cliente nao encontrado", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            disable();
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
        private void txtValorPago_KeyUp(object sender, KeyEventArgs e)
        {
            Pagamento pag = new Pagamento();
            if(txtValorPago.ReadOnly == false)
                txtValorRestante.Text = pag.atualizarValorRestante(Convert.ToInt16(txtValorAberto.Text), Convert.ToInt16(txtValorPago.Text)).ToString();
        }
        private void txtValorPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)))
            {
                e.Handled = true;
            }
            else
            {

            }
        }
        private void btnConcluirPagamento_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(txtValorRestante.Text) >= 0)
            {
                Pagamento pag = new Pagamento();
                pag.efetuarPagamento(data[0], txtValorRestante.Text, txtValorPago.Text, rowsCount(), sb(), idCell(), valorCell());
            }
            else
            {
                MessageBox.Show("Valor a pagar é maior que o valor em aberto", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBuscar_Click((object)sender, (EventArgs)e);
            }
        }

        private int valorCell()
        {
            int valor = Convert.ToInt32(metroGrid1.Rows[1].Cells[2].Value);
            return valor;
        }

        private int idCell()
        {
            int valor = Convert.ToInt32(metroGrid1.Rows[1].Cells[0].Value);
            return valor;
        }

        private int rowsCount()
        {
            Int32 RowsCount = metroGrid1.RowCount;
            return RowsCount;
        }

        private string sb()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            if (rowsCount() <= 1)
            {
                return Convert.ToString(sb.Append(metroGrid1.SelectedRows[0].Cells[0].Value)); ;
            }
            else
            {
                for (int i = 0; i < rowsCount(); i++)
                {
                    Convert.ToString(sb.Append(", " + metroGrid1.Rows[i].Cells[0].Value));
                }
                sb.Remove(0, 2);
                return sb.ToString();
            }
            
        }

        private string valorpago()
        {
            System.Text.StringBuilder valorpago = new System.Text.StringBuilder();
            return valorpago.Append(metroGrid1.SelectedRows[0].Cells[13].Value).ToString();
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

            metroGrid1.Enabled = false;

            txtValor.Enabled = false;
            txtApelido.Enabled = false;
            txtNomeCompleto.Enabled = false;
            txtEndereco.Enabled = false;
            txtObs.ReadOnly = true;
            txtValorPago.ReadOnly = true;
            mskTelCel.Enabled = false;
            mskTelFixo.Enabled = false;

            btnConcluir.Enabled = false;
            btnEditar.Enabled = false;
            btnBuscar.Enabled = true;
            btnConcluirPagamento.Enabled = false;
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

            metroGrid1.Enabled = true;

            txtValor.Enabled = true;
            txtApelido.Enabled = true;
            txtNomeCompleto.Enabled = true;
            txtEndereco.Enabled = true;
            txtObs.ReadOnly = true;
            txtValorPago.ReadOnly = false;
            mskTelCel.Enabled = true;
            mskTelFixo.Enabled = true;

            btnConcluir.Enabled = true;
            btnEditar.Enabled = true;
            btnSair.Enabled = true;
            btnBuscar.Enabled = false;
            btnConcluirPagamento.Enabled = true;
        }

        private void sair()
        {
            txtApelido.Clear();
            txtNomeCompleto.Clear();
            txtEndereco.Clear();
            mskTelCel.Clear();
            mskTelFixo.Clear();
            txtNome.Clear();
            txtValorPago.Text = "0";
            txtValorAberto.Clear();
            txtValorRestante.Clear();
            chkMensalista.Checked = false;
            chkMensalista.Visible = false;
            chkInfantil.Checked = false;
            chkInfantil.Visible = false;
            chkWhats.Checked = false;
            chkWhats.Visible = false;
            btnBuscar.Enabled = true;
            btnSair.Enabled = false;
            metroGrid1.Enabled = false;

            if (metroGrid1.DataSource != null)
            {
                metroGrid1.DataSource = null;
            }
            else
            {
                metroGrid1.Rows.Clear();

            }
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

                cmd = new OdbcCommand("Select ID as 'ID do Corte', DataC as 'Data do corte',  Valor, ValorEmAberto, Status, Corte, Barba, Pezinho, Sombrancelha, SombrancelhaHenna as 'Sombrancelha de Henna', Relaxamento, Progressiva, PigmentacaoCorte as 'Pigmentacao Corte', PigmentacaoBarba as 'Pigmentacao Barba', Luzes, Gel, Lapis from historico where ID_Cliente like '" + data[0] + "' and Status like 'Em aberto' or Status like 'Em Processo' order by DataC", conexao);

                adapter = new OdbcDataAdapter(cmd);
                ds = new DataSet();
                adapter.Fill(ds, "clientes");
                
                metroGrid1.DataSource = ds;
                metroGrid1.DataMember = "clientes";
                
                metroGrid1.Columns[0].Visible = false;

                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }
        
    }
}
