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
        public Relatorio()
        {
            InitializeComponent();
            setMaxProgressBar();
            setValurProgressBar();
        }
        DataBase bd = new DataBase();

        private void Relatorio_Load(object sender, EventArgs e)
        {
            MessageBox.Show(bd.returnCountHisotrico().ToString());
            progressCorte.Value = bd.returnCorte();
            progressCorte.Text = bd.returnCorte().ToString();
        }

        private void setMaxProgressBar()
        {
            progressBarba.Maximum = bd.returnCountHisotrico();
            progressCorte.Maximum = bd.returnCountHisotrico();
            progressPigBarba.Maximum = bd.returnCountHisotrico();
            progressPigCorte.Maximum = bd.returnCountHisotrico();
            progressLapis.Maximum = bd.returnCountHisotrico();
            progressGel.Maximum = bd.returnCountHisotrico();
            progressPezinho.Maximum = bd.returnCountHisotrico();
            progressSombrancelha.Maximum = bd.returnCountHisotrico();
            progressSombrancelhaHenna.Maximum = bd.returnCountHisotrico();
            progressLuzes.Maximum = bd.returnCountHisotrico();
            progressRelaxamento.Maximum = bd.returnCountHisotrico();
        }
        private void setValurProgressBar()
        {
            progressBarba.Value = bd.returnBarba();
            progressCorte.Value = bd.returnCorte();
            progressPigBarba.Value = bd.returnPigBarba();
            progressPigCorte.Value = bd.returnPigCorte();
            progressLapis.Value = bd.returnLapis();
            progressGel.Value = bd.returnGel();
            progressPezinho.Value = bd.returnPezinho();
            progressSombrancelha.Value = bd.returnSombrancelha();
            progressSombrancelhaHenna.Value = bd.returnSombrancelhaHenna();
            progressLuzes.Value = bd.returnLuzes();
            progressRelaxamento.Value = bd.returnRelaxamento();

            progressBarba.Text = bd.returnBarba().ToString();
            progressCorte.Text = bd.returnCorte().ToString();
            progressPigBarba.Text = bd.returnPigBarba().ToString();
            progressPigCorte.Text = bd.returnPigCorte().ToString();
            progressLapis.Text = bd.returnLapis().ToString();
            progressGel.Text = bd.returnGel().ToString() + " ";
            progressPezinho.Text = bd.returnPezinho().ToString();
            progressSombrancelha.Text = bd.returnSombrancelha().ToString();
            progressSombrancelhaHenna.Text = bd.returnSombrancelhaHenna().ToString();
            progressLuzes.Text = bd.returnLuzes().ToString();
            progressRelaxamento.Text = bd.returnRelaxamento().ToString();
        }
    }
}
