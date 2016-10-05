using System;
using System.Windows.Forms;
using StudioRL2._0.Class;

namespace StudioRL2._0
{
    public partial class EditarHistorico : Form
    {
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
        string sombrancelha = "N";
        string sombrancelhaHenna = "N";
        string status;
        string idHistorico;
        string idCliente;
        int valorInicial;

        public EditarHistorico(string Corte, string Barba, string Gel, string Lapis, string Luzes, string Pezinho, string Pigbarba, string Pigcorte, string Progressiva, string Relaxamento, string Sombrancelha, string SombrancelhaH, string Status, string valor, string IDHistorico, string IDCliente)
        {
            InitializeComponent();
            corte = Corte; barba = Barba; gel = Gel; lapis = Lapis; luzes = Luzes; pezinho = Pezinho; pigbarba = Pigbarba; pigCorte = Pigcorte; progressiva = Progressiva; relaxamento = Relaxamento; sombrancelha = Sombrancelha; sombrancelhaHenna = SombrancelhaH; status = Status; idHistorico = IDHistorico; idCliente = IDCliente;
            valorInicial = Convert.ToInt16(valor);
            txtValor.Text = valor;
            if (status == "Pago")
                chkPago.Checked = true;
        }
        
        private void EditarHistorico_Load(object sender, EventArgs e)
        {
            verificaVars();
            //arrumar o checkbox d apagar
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void lblConcluir_Click(object sender, EventArgs e)
        {
            DataBase bd = new DataBase();
            verificaDados();
            DialogResult dialogResult = MessageBox.Show("Deseja apagar dados selecionados?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                bd.atualizarHistorico(corte, barba, pezinho, sombrancelha, sombrancelhaHenna, relaxamento, progressiva, pigCorte, pigbarba, luzes, gel, lapis, idHistorico);
                if(valorInicial != Convert.ToInt16(txtValor.Text))
                {
                    bd.atualizarValorHistorico(txtValor.Text, idCliente, idHistorico);
                }
                MessageBox.Show("Dados do corte atualizado com sucesso");
                this.Dispose();
            }
                
        }

        private void verificaVars()
        {
            if (corte == "S")
                chkCorte.Checked = true;
            if (barba == "S")
                chkBarba.Checked = true;
            if (gel == "S")
                chkGel.Checked = true;
            if (lapis == "S")
                chkLapis.Checked = true;
            if (luzes == "S")
                chkLuzes.Checked = true;
            if (pezinho == "S")
                chkPezinho.Checked = true;
            if (pigbarba == "S")
                chkPigmentacaoBarba.Checked = true;
            if (pigCorte == "S")
                chkPigmentacaoCorte.Checked = true;
            if (progressiva == "S")
                chkProgressiva.Checked = true;
            if (sombrancelha == "S")
                chkSombrancelha.Checked = true;
            if (sombrancelhaHenna == "S")
                chkSombrancelhaHenna.Checked = true;
            /*
            string progressiva = "N";
            string relaxamento = "N";
            string sombrancelha = "N";
            string sombancelhaHenna = "N";
            string status = "Pago";*/
        }

        private void verificaDados()
        {
            if (chkCorte.Checked)
            {
                corte = "S";
            }
            else
            {
                corte = "N";
            }
                
            if (chkBarba.Checked)
            {
                barba = "S";
            }
            else
            {
                barba = "N";
            }
                
            if (chkGel.Checked)
            {
                gel = "S";
            }
            else
            {
                gel = "N";
            }
                
            if (chkLapis.Checked)
            {
                lapis = "S";
            }
            else
            {
                lapis = "N";
            }
                
            if (chkLuzes.Checked)
            {
                luzes = "S";
            }
            else
            {
                luzes = "N";
            }
                
            if (chkPezinho.Checked)
            {
                pezinho = "S";
            }
            else
            {
                pezinho = "N";
            }
                
            if (chkPigmentacaoBarba.Checked)
            {
                pigbarba = "S";
            }
            else
            {
                pigbarba = "N";
            }
                
            if (chkPigmentacaoCorte.Checked)
            {
                pigCorte = "S";
            }
            else
            {
                pigCorte = "N";
            }

            if (chkProgressiva.Checked)
            {
                progressiva = "S";
            }
            else
            {
                progressiva = "N";
            }
            
            if (chkRelaxamento.Checked)
            {
                relaxamento = "S";
            }
            else
            {
                relaxamento = "N";
            }

            if (chkSombrancelha.Checked)
            {
                sombrancelha = "S";
            }
            else
            {
                sombrancelha = "N";
            }
                
            if (chkSombrancelhaHenna.Checked)
            {
                sombrancelhaHenna = "S";
            }
            else
            {
                sombrancelhaHenna = "N";
            }
                
            if (chkPago.Checked)
                status = "Em aberto";
        }

        private void lblConcluir_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void lblConcluir_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }

        private void lblSair_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void lblSair_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }
    }
}
