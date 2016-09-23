using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudioRL2._0.Class
{
    class Cliente
    {
        private static string nome;
        private static string apelido;
        private static string endereco;
        private static string telFixo;
        private static string telCel;
        private static string operadora;
        private static string whatsapp;
        private static string sexo;
        private static string infantil;
        private static string mensalista;
        private static int valorpago;
        private static int valorapagar;

        public string getNome() {
            return nome;
        }
        public void setNome(string Nome)
        {
            nome = Nome;
        }

        public string getApelido()
        {
            return apelido;
        }
        public void setApelido(string Apelido)
        {
            apelido = Apelido;
        }

        public string getEndereco()
        {
            return endereco;
        }
        public void setEndereco(string Endereco)
        {
            endereco = Endereco;
        }

        public string getTelFixo()
        {
            return telFixo;
        }
        public void setTelFixo(string TelFixo)
        {
            telFixo = TelFixo;
        }

        public string getTelCel()
        {
            return telCel;
        }
        public void setTelCel(string TelCel)
        {
            telCel = TelCel;
        }

        public string getOperadora()
        {
            return operadora;
        }
        public void setOperadora(string Operadora)
        {
            operadora = Operadora;
        }

        public string getWhats()
        {
            return whatsapp;
        }
        public void setWhats(string whats)
        {
            whatsapp = whats;
        }

        public string getSexo()
        {
            return sexo;
        }
        public void setSexo(string Sexo)
        {
            sexo = Sexo;
        }

        public string getInfantil()
        {
            return infantil;
        }
        public void setInfantil(string Infantil)
        {
            infantil = Infantil;
        }

        public string getMensalista()
        {
            return mensalista;
        }
        public void setMensalista(string Mensalista)
        {
            mensalista = Mensalista;
        }

        public int getValorPago()
        {
            return valorpago;
        }
        public void setValorPago(int ValorPago)
        {
            valorpago = ValorPago;
        }

        public int getValoraPagar()
        {
            return valorapagar;
        }
        public void setValoraPagar(int ValoraPagar)
        {
            valorapagar = ValoraPagar;
        }
    }
}
