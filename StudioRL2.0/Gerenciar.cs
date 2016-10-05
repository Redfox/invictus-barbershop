using System;
using System.Drawing;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;
using StudioRL2._0.Class;

namespace StudioRL2._0
{
    public partial class Gerenciar : Form
    {
        private bool Historico = true;
        private bool clientes = false;

        public Gerenciar()
        {
            InitializeComponent();
        }

        private void Historico_Load(object sender, EventArgs e)
        {
            /*DataBase db = new DataBase();
            progressBar1.Maximum = db.autoComplete().Length;
            txtNome.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtNome.AutoCompleteSource = AutoCompleteSource.CustomSource;
            for (int i = 0; i < db.autoComplete().Length; i++)
            {
                txtNome.AutoCompleteCustomSource.Add(db.autoComplete()[i]);
                progressBar1.Value = i;
                if(i == (db.autoComplete().Length - 1))
                {
                    progressBar1.Value = progressBar1.Maximum;
                    progressBar1.Visible = false;
                }
                    
            }*/
            preencherGrid();
            lblHistorico.BackColor = ColorTranslator.FromHtml("#333333");
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

                if (Historico)
                {
                    cmd = new OdbcCommand("Select ID as 'ID do Corte', ID_Cliente, DataC as 'Data do corte',  Valor, ValorEmAberto, Status, Corte, Barba, Pezinho, Sombrancelha, SombrancelhaHenna as 'Sombrancelha de Henna', Relaxamento, Progressiva, PigmentacaoCorte as 'Pigmentacao Corte', PigmentacaoBarba as 'Pigmentacao Barba', Luzes, Gel, Lapis from historico order by DataC", conexao);
                }
                else if(clientes)
                {
                    cmd = new OdbcCommand("Select ID_Cliente as 'ID do Cliente', Nome, Apelido, Endereco, Tel_Fixo as 'Telefone Fixo', Tel_Cel as 'Celular', Operadora, Whatsapp, Sexo, Mensalista, Infantil, ValorPago as 'Valor Pago', ValoraPagar as 'Valor em Aberto' from clientes ORDER BY Nome ASC", conexao);
                }

                adapter = new OdbcDataAdapter(cmd);
                ds = new DataSet();
                adapter.Fill(ds, "clientes");

                metroGrid1.DataSource = ds;
                metroGrid1.DataMember = "clientes";


                metroGrid1.Columns[0].Visible = false;
                if (Historico)
                {
                    metroGrid1.Columns[1].Visible = false;
                }
                else
                {
                    metroGrid1.Columns[1].Visible = true;
                }
                

                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            metroGrid1.Focus();
            string corte = metroGrid1.CurrentRow.Cells[6].Value.ToString();
            string barba = metroGrid1.CurrentRow.Cells[7].Value.ToString();
            string gel = metroGrid1.CurrentRow.Cells[16].Value.ToString();
            string lapis = metroGrid1.CurrentRow.Cells[17].Value.ToString();
            string luzes = metroGrid1.CurrentRow.Cells[15].Value.ToString();
            string pezinho = metroGrid1.CurrentRow.Cells[8].Value.ToString();
            string pigbarba = metroGrid1.CurrentRow.Cells[14].Value.ToString();
            string pigCorte = metroGrid1.CurrentRow.Cells[13].Value.ToString();
            string progressiva = metroGrid1.CurrentRow.Cells[12].Value.ToString();
            string relaxamento = metroGrid1.CurrentRow.Cells[11].Value.ToString();
            string sombrancelha = metroGrid1.CurrentRow.Cells[9].Value.ToString();
            string sombancelhaHenna = metroGrid1.CurrentRow.Cells[10].Value.ToString();
            string status = metroGrid1.CurrentRow.Cells[5].Value.ToString();
            string valor = metroGrid1.CurrentRow.Cells[3].Value.ToString();
            string idHistorico = metroGrid1.CurrentRow.Cells[0].Value.ToString();
            string idCliente = metroGrid1.CurrentRow.Cells[1].Value.ToString();

            EditarHistorico edit = new EditarHistorico(corte, barba, gel, lapis, luzes, pezinho, pigbarba, pigCorte, progressiva, relaxamento, sombrancelha, sombancelhaHenna, status, valor, idHistorico, idCliente);
            edit.ShowDialog();
        }
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            preencherGrid();
        }
        private void lblHistorico_Click(object sender, EventArgs e)
        {
            Historico = true;
            clientes = false;
            lblCliente.BackColor = Color.Black;
            btnEditar.Enabled = true;
            preencherGrid();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            clientes = true;
            Historico = false;
            lblHistorico.BackColor = Color.Black;
            btnEditar.Enabled = false;
            preencherGrid();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja apagar dados selecionados?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                DataBase bd = new DataBase();
                if (Historico)
                {
                    bd.deleteHistorico(metroGrid1.CurrentRow.Cells[0].Value.ToString());
                    preencherGrid();
                }

                if (clientes)
                {
                    bd.deleteCliente(metroGrid1.CurrentRow.Cells[0].Value.ToString());
                    preencherGrid();
                }
            }
            else if (dialogResult == DialogResult.No){ }
            
        }

        private void lblHistorico_MouseLeave(object sender, EventArgs e)
        {
            if (Historico)
            {
                lblHistorico.BackColor = ColorTranslator.FromHtml("#333333");
            }
            else
            {
                lblHistorico.BackColor = Color.Black;
            }
            this.Cursor = Cursors.Arrow;
        }

        private void lblHistorico_MouseEnter(object sender, EventArgs e)
        {
            lblHistorico.BackColor = ColorTranslator.FromHtml("#333333");
            this.Cursor = Cursors.Hand;
        }

        private void lblCliente_MouseEnter(object sender, EventArgs e)
        {
            lblCliente.BackColor = ColorTranslator.FromHtml("#333333");
            this.Cursor = Cursors.Hand;
        }

        private void lblCliente_MouseLeave(object sender, EventArgs e)
        {
            if (clientes)
            {
                lblCliente.BackColor = ColorTranslator.FromHtml("#333333");
            }
            else
            {
                lblCliente.BackColor = Color.Black;
            }
            this.Cursor = Cursors.Arrow;
        }
    }
}
