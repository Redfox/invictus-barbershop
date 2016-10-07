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
    public partial class Relatorio : Form
    {
        DataBase bd = new DataBase();

        public Relatorio()
        {
            InitializeComponent();
        }

        private void Relatorio_Load(object sender, EventArgs e)
        {
            lblValor.Text = "R$ " + bd.returnValorTotal(cboRange.Text) + ",00";
            lblPago.Text = "R$ " + bd.returnValorPago(cboRange.Text) + ",00";
            lblRestante.Text = "R$ " + (bd.returnValorTotal(cboRange.Text) - bd.returnValorPago(cboRange.Text)) + ",00";
        }
        private void setMaxProgressBar()
        {
            progressBarba.Maximum = bd.returnCountHisotrico(cboRange.Text);
            progressCorte.Maximum = bd.returnCountHisotrico(cboRange.Text);
            progressPigBarba.Maximum = bd.returnCountHisotrico(cboRange.Text);
            progressPigCorte.Maximum = bd.returnCountHisotrico(cboRange.Text);
            progressLapis.Maximum = bd.returnCountHisotrico(cboRange.Text);
            progressGel.Maximum = bd.returnCountHisotrico(cboRange.Text);
            progressPezinho.Maximum = bd.returnCountHisotrico(cboRange.Text);
            progressSombrancelha.Maximum = bd.returnCountHisotrico(cboRange.Text);
            progressSombrancelhaHenna.Maximum = bd.returnCountHisotrico(cboRange.Text);
            progressLuzes.Maximum = bd.returnCountHisotrico(cboRange.Text);
            progressRelaxamento.Maximum = bd.returnCountHisotrico(cboRange.Text);

            lblQuantidade.Text = bd.returnCountHisotrico(cboRange.Text).ToString();
        }
        private void setValueProgressBar()
        {
            progressBarba.Value = bd.returnBarba(cboRange.Text);
            progressCorte.Value = bd.returnCorte(cboRange.Text);
            progressPigBarba.Value = bd.returnPigBarba(cboRange.Text);
            progressPigCorte.Value = bd.returnPigCorte(cboRange.Text);
            progressLapis.Value = bd.returnLapis(cboRange.Text);
            progressGel.Value = bd.returnGel(cboRange.Text);
            progressPezinho.Value = bd.returnPezinho(cboRange.Text);
            progressSombrancelha.Value = bd.returnSombrancelha(cboRange.Text);
            progressSombrancelhaHenna.Value = bd.returnSombrancelhaHenna(cboRange.Text);
            progressLuzes.Value = bd.returnLuzes(cboRange.Text);
            progressRelaxamento.Value = bd.returnRelaxamento(cboRange.Text);

            progressBarba.Text = bd.returnBarba(cboRange.Text).ToString();
            progressCorte.Text = bd.returnCorte(cboRange.Text).ToString();
            progressPigBarba.Text = bd.returnPigBarba(cboRange.Text).ToString();
            progressPigCorte.Text = bd.returnPigCorte(cboRange.Text).ToString();
            progressLapis.Text = bd.returnLapis(cboRange.Text).ToString();
            progressGel.Text = bd.returnGel(cboRange.Text).ToString();
            progressPezinho.Text = bd.returnPezinho(cboRange.Text).ToString();
            progressSombrancelha.Text = bd.returnSombrancelha(cboRange.Text).ToString();
            progressSombrancelhaHenna.Text = bd.returnSombrancelhaHenna(cboRange.Text).ToString();
            progressLuzes.Text = bd.returnLuzes(cboRange.Text).ToString();
            progressRelaxamento.Text = bd.returnRelaxamento(cboRange.Text).ToString();
        }
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(progressRelaxamento.Text + "\n" + progressRelaxamento.Value);
            
        }
        private void cboRange_SelectedIndexChanged(object sender, EventArgs e)
        {
            resetProgressBar();

            if (bd.returnCountHisotrico(cboRange.Text) == 0)
            {
                lblValor.Text = "R$ 00,00";
                lblPago.Text = "R$ 00,00";
                lblRestante.Text = "R$ 00,00";
                lblQuantidade.Text = "0";
                resetProgressBar();
            }
            else
            {
                setMaxProgressBar();
                setValueProgressBar();
                lblValor.Text = "R$ " + bd.returnValorTotal(cboRange.Text).ToString() + ",00";
                lblPago.Text = "R$ " + bd.returnValorPago(cboRange.Text) + ",00";
                lblRestante.Text = "R$ " + (bd.returnValorTotal(cboRange.Text) - bd.returnValorPago(cboRange.Text)) + ",00";
            }
            
        }
        private void resetProgressBar()
        {
            progressBarba.Value = 0;
            progressCorte.Value = 0;
            progressPigBarba.Value = 0;
            progressPigCorte.Value = 0;
            progressLapis.Value = 0;
            progressGel.Value = 0;
            progressPezinho.Value = 0;
            progressSombrancelha.Value = 0;
            progressSombrancelhaHenna.Value = 0;
            progressLuzes.Value = 0;
            progressRelaxamento.Value = 0;
        }
    }
}
