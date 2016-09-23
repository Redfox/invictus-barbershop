using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using StudioRL2._0.Class;

namespace StudioRL2._0
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //compo vazio ~to fix
            OdbcConnection conexao = new Connection().Conexao();
            DataBase db = new DataBase();

            string S = "M", M = "N", W = "N", I = "N";

            if (rdbFeminino.Checked)
            {
                S = "F";
            }
            if (chkMensalista.Checked)
            {
                M = "S";
            }
            if (chkWhats.Checked)
            {
                W = "S";
            }
            if (chkInfatil.Checked)
            {
                I = "S";
            }

            db.cadastrarCliente(txtNome.Text, txtApelido.Text, txtEndereco.Text, mskTelCel.Text, mskTelCel.Text, cboOperadora.Text, W, S, I, M);


        }
    }
}
