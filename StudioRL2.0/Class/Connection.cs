using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace StudioRL2._0.Class
{
    class Connection
    {
        String Usuario { get; set; }

        String Senha { get; set; }

        String Server { get; set; }

        String Banco { get; set; }

        String Port { get; set; }


        public Connection(String Server, String Port, String BD, String User, String Pass)
        {
            this.Server = Server;
            this.Port = Port;
            this.Banco = BD;
            this.Usuario = User;
            this.Senha = Pass;
        }

        public Connection()
        {
            this.Server = "127.0.0.1";
            this.Port = "3307";
            this.Banco = "cabeleireiro";
            this.Usuario = "root";
            this.Senha = "usbw";
        }

        public OdbcConnection Conexao()
        {
            try
            {
                String StrConn = "Driver={MySQL ODBC 5.1 Driver};Server=" + Server +
                    ";Port=" + Port + ";Database=" + Banco +
                    ";User=" + Usuario + ";Password=" + Senha +
                    ";Option=3;";


                return new OdbcConnection(StrConn);
            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.Message);
                return null;
            }
        }
    }
}
