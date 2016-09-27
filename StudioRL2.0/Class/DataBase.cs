using System;
using System.Windows.Forms;
using System.Data;
using System.Data.Odbc;

namespace StudioRL2._0.Class
{
    class DataBase
    {
        public void cadastrarCliente(string nome, string apelido, string endereco, string telFixo, string telCel, string operadora, string whatsapp, string sexo, string infantil, string mensalista)
        {
            try
            {
                OdbcConnection conexao = new Connection().Conexao();
                OdbcCommand cmd = new OdbcCommand("", conexao);
                conexao.Open();

                string SQL = "insert into Clientes(Nome, Apelido, Endereco, Tel_Fixo, Tel_Cel, Operadora, Whatsapp, Sexo, Infantil, Mensalista, ValorPago, ValoraPagar) values ('" + nome + "', '" + apelido + "', '" + endereco + "', '" + telFixo + "','" + telCel + "','" + operadora + "','" + whatsapp + "', '" + sexo + "', '" + infantil + "', '" + mensalista + "', '0', '0')";
                cmd.CommandText = SQL;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cadastrado com sucesso!");

                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }            
        }

        public int countCliente(string nome)
        {
            OdbcConnection conexao = new Connection().Conexao();
            OdbcCommand cmd = new OdbcCommand("", conexao);
            conexao.Open();

            string SQL = "select count(*) from Clientes where nome = '" + nome + "'";
            cmd.CommandText = SQL;
            int count = Convert.ToInt16(cmd.ExecuteScalar());
            
            conexao.Close();
            return count;
        }

        public string[] buscarCliente(string nome)
        {
            string[] data = new string[20];
            try
            {
                OdbcConnection conexao = new Connection().Conexao();
                OdbcCommand cmd = new OdbcCommand("", conexao);
                conexao.Open();
                string SQL;
                
                if(countCliente(nome) > 0)
                {
                    SQL = "select ID_Cliente from Clientes where nome = '" + nome + "'";
                    cmd.CommandText = SQL;
                    data[0] = cmd.ExecuteScalar().ToString();
                    
                    data[1] = nome;

                    SQL = "select apelido from Clientes where nome = '" + nome + "'";
                    cmd.CommandText = SQL;
                    data[2] = cmd.ExecuteScalar().ToString();

                    SQL = "select endereco from Clientes where nome = '" + nome + "'";
                    cmd.CommandText = SQL;
                    data[3] = cmd.ExecuteScalar().ToString();

                    SQL = "select Tel_Fixo from Clientes where nome = '" + nome + "'";
                    cmd.CommandText = SQL;
                    data[4] = cmd.ExecuteScalar().ToString();

                    SQL = "select Tel_Cel from Clientes where nome = '" + nome + "'";
                    cmd.CommandText = SQL;
                    data[5] = cmd.ExecuteScalar().ToString();

                    SQL = "select Operadora from Clientes where nome = '" + nome + "'";
                    cmd.CommandText = SQL;
                    data[6] = cmd.ExecuteScalar().ToString();

                    SQL = "select Whatsapp from Clientes where nome = '" + nome + "'";
                    cmd.CommandText = SQL;
                    data[7] = cmd.ExecuteScalar().ToString();

                    SQL = "select Sexo from Clientes where nome = '" + nome + "'";
                    cmd.CommandText = SQL;
                    data[8] = cmd.ExecuteScalar().ToString();

                    SQL = "select Infantil from Clientes where nome = '" + nome + "'";
                    cmd.CommandText = SQL;
                    data[9] = cmd.ExecuteScalar().ToString();

                    SQL = "select Mensalista from Clientes where nome = '" + nome + "'";
                    cmd.CommandText = SQL;
                    data[10] = cmd.ExecuteScalar().ToString();

                    SQL = "select ValoraPagar from Clientes where nome = '" + nome + "'";
                    cmd.CommandText = SQL;
                    data[11] = cmd.ExecuteScalar().ToString();

                    SQL = "select Obs from Clientes where nome = '" + nome + "'";
                    cmd.CommandText = SQL;
                    data[12] = cmd.ExecuteScalar().ToString();

                    SQL = "select Frequencia from Clientes where nome = '" + nome + "'";
                    cmd.CommandText = SQL;
                    data[13] = cmd.ExecuteScalar().ToString();

                    SQL = "select ValoraPagar from Clientes where nome = '" + nome + "'";
                    cmd.CommandText = SQL;
                    data[14] = cmd.ExecuteScalar().ToString();
                }
                
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            return data;
        }

        public void cadastarConsulta(string ID_Cliente, string Corte, string Barba, string Pezinho, string Sombrancelha, string SombrancelhaHenna, string Relaxamento, string Progressiva, string PigmentacaoCorte, string PigmentacaoBarba, string Luzes, string Gel, string Lapis, string Valor, string Status, string valorapagar, bool apagar)
        {
            DateTime time = DateTime.Now;
            try
            {
                OdbcConnection conexao = new Connection().Conexao();
                OdbcCommand cmd = new OdbcCommand("", conexao);
                conexao.Open();
                if (apagar == true)
                {
                    string SQL = "insert into Historico(ID_Cliente, DataC, Corte, Barba, Pezinho, Sombrancelha, SombrancelhaHenna, Relaxamento, Progressiva, PigmentacaoCorte, PigmentacaoBarba, Luzes, Gel, Lapis, Valor, ValorPago, Status, ValorEmAberto) value('" + ID_Cliente + "', '" + time.ToString("yyyy-MM-dd HH:mm:ss") + "','" + Corte + "', '" + Barba + "', '" + Pezinho + "', '" + Sombrancelha + "', '" + SombrancelhaHenna + "', '" + Relaxamento + "', '" + Progressiva + "', '" + PigmentacaoCorte + "', '" + PigmentacaoBarba + "', '" + Luzes + "', '" + Gel + "', '" + Lapis + "', '" + Valor + "', 0, '" + Status + "', '" + valorapagar + "')";
                    cmd.CommandText = SQL;
                    cmd.ExecuteNonQuery();

                    SQL = "update clientes set ValoraPagar = ValoraPagar + '" + Valor + "' where ID_Cliente like '" + ID_Cliente + "'";
                    cmd.CommandText = SQL;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("a pagar");
                }
                else if(apagar == false)
                {
                    string SQL = "insert into Historico(ID_Cliente, DataC, Corte, Barba, Pezinho, Sombrancelha, SombrancelhaHenna, Relaxamento, Progressiva, PigmentacaoCorte, PigmentacaoBarba, Luzes, Gel, Lapis, Valor, ValorPago, Status, ValorEmAberto) value('" + ID_Cliente + "', '" + time.ToString("yyyy-MM-dd HH:mm:ss") + "','" + Corte + "', '" + Barba + "', '" + Pezinho + "', '" + Sombrancelha + "', '" + SombrancelhaHenna + "', '" + Relaxamento + "', '" + Progressiva + "', '" + PigmentacaoCorte + "', '" + PigmentacaoBarba + "', '" + Luzes + "', '" + Gel + "', '" + Lapis + "', '" + Valor + "', '"+ Valor + "', '" + Status + "', 0)";
                    cmd.CommandText = SQL;
                    cmd.ExecuteNonQuery();

                    SQL = "update clientes set ValorPago = ValorPago + '" + Valor + "' where ID_Cliente like '" + ID_Cliente + "'";
                    cmd.CommandText = SQL;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("pago");
                }
                
                
                MessageBox.Show("Consulta salva com sucesso");
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        public void autalizarCliente(string nome, string apelido, string endereco, string telFixo, string telCel, string operadora, string whats, string infantil, string mensalista, string ID_Cliente)
        {
            try
            {
                OdbcConnection conexao = new Connection().Conexao();
                OdbcCommand cmd = new OdbcCommand("", conexao);
                conexao.Open();
                String SQl = "update clientes set Nome = '" + nome + "', Apelido = '" + apelido + "', Endereco = '" + endereco + "', Tel_Fixo = '" + telFixo + "', Tel_Cel = '" + telCel + "', Operadora = '" + operadora + "', Whatsapp = '" + whats + "', infantil = '" + infantil + "', Mensalista = '" + mensalista + "' where ID_Cliente like '" + ID_Cliente + "'";
                cmd.CommandText = SQl;
                cmd.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            
        }

        public void atualizarObs(string ID_Cliente, string obs)
        {
            try
            {
                OdbcConnection conexao = new Connection().Conexao();
                OdbcCommand cmd = new OdbcCommand("", conexao);
                conexao.Open();
                String SQl = "update clientes set Obs = '" + obs + "' where ID_Cliente like '" + ID_Cliente + "'";
                cmd.CommandText = SQl;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Observacao atualizada com sucesso");
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            
        }        
    }
}
