using System;
using System.Windows.Forms;
using System.Data;
using System.Data.Odbc;

namespace StudioRL2._0.Class
{
    class DataBase
    {
        string ontem;

        private void setData()
        {
            string diaHoje = DateTime.Now.ToString("dd");
            int diaOntem = Convert.ToInt16(diaHoje) - 1;
            ontem = DateTime.Now.ToString("yyyy-MM-"+ diaOntem);
        }

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
                }
                else if(apagar == false)
                {
                    string SQL = "insert into Historico(ID_Cliente, DataC, Corte, Barba, Pezinho, Sombrancelha, SombrancelhaHenna, Relaxamento, Progressiva, PigmentacaoCorte, PigmentacaoBarba, Luzes, Gel, Lapis, Valor, ValorPago, Status, ValorEmAberto) value('" + ID_Cliente + "', '" + time.ToString("yyyy-MM-dd HH:mm:ss") + "','" + Corte + "', '" + Barba + "', '" + Pezinho + "', '" + Sombrancelha + "', '" + SombrancelhaHenna + "', '" + Relaxamento + "', '" + Progressiva + "', '" + PigmentacaoCorte + "', '" + PigmentacaoBarba + "', '" + Luzes + "', '" + Gel + "', '" + Lapis + "', '" + Valor + "', '"+ Valor + "', '" + Status + "', 0)";
                    cmd.CommandText = SQL;
                    cmd.ExecuteNonQuery();

                    SQL = "update clientes set ValorPago = ValorPago + '" + Valor + "' where ID_Cliente like '" + ID_Cliente + "'";
                    cmd.CommandText = SQL;
                    cmd.ExecuteNonQuery();
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

        public void atualizarHistorico(string corte, string barba, string pezinho, string sombrancelha, string sombrancelhaH, string relaxamento, string progressiva, string pigCorte, string pigBarba, string luzes, string gel, string lapis, string id)
        {
            try
            {
                OdbcConnection conexao = new Connection().Conexao();
                OdbcCommand cmd = new OdbcCommand("", conexao);
                conexao.Open();
                String SQl = "update historico set `Corte`= '"+ corte +"', `Barba`= '"+ barba + "', `Pezinho`= '"+ pezinho +"', `Sombrancelha`= '"+ sombrancelha +"', `SombrancelhaHenna`= '"+ sombrancelhaH + "', `Relaxamento`= '"+ relaxamento +"', `Progressiva`= '"+ progressiva +"', `PigmentacaoCorte`= '"+ pigCorte + "', `PigmentacaoBarba`= '"+ pigBarba +"', `Luzes`= '"+ luzes +"', `Gel`= '"+ gel +"', `Lapis`= '"+ lapis +"' WHERE  `ID`= '"+ id +"'";
                cmd.CommandText = SQl;
                cmd.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        public void atualizarValorHistorico(string valor, string idCliente, string idHistorico)
        {
            try
            {
                OdbcConnection conexao = new Connection().Conexao();
                OdbcCommand cmd = new OdbcCommand("", conexao);
                conexao.Open();

                String SQl = "select ValorEmAberto from historico WHERE  `ID`= '" + idHistorico + "'";
                cmd.CommandText = SQl;
                int ValorEmAberto = Convert.ToInt16(cmd.ExecuteScalar().ToString());

                SQl = "select valor from historico WHERE  `ID`= '" + idHistorico + "'";
                cmd.CommandText = SQl;
                int valorHistorico = Convert.ToInt16(cmd.ExecuteScalar().ToString());
                        
                if (Convert.ToInt16(valor) < ValorEmAberto)
                {
                    SQl = "update historico set ValorEmAberto = '" + valor + "' WHERE  `ID`= '" + idHistorico + "'";
                    cmd.CommandText = SQl;
                    cmd.ExecuteNonQuery();
                }

                if(ValorEmAberto == valorHistorico)
                {
                    SQl = "update historico set ValorEmAberto = '" + valor + "' WHERE  `ID`= '" + idHistorico + "'";
                    cmd.CommandText = SQl;
                    cmd.ExecuteNonQuery();
                }
                
                if(valorHistorico < Convert.ToInt16(valor))
                {
                    int valorDiferenca =  Convert.ToInt16(valor) - valorHistorico;
                    SQl = "update clientes set valoraPagar = valoraPagar + '" + valorDiferenca + "' WHERE  `ID_Cliente`= '" + idCliente + "'";
                    cmd.CommandText = SQl;
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    int valorDiferenca = valorHistorico - Convert.ToInt16(valor);
                    SQl = "update clientes set valoraPagar = valoraPagar - '" + valorDiferenca + "' WHERE  `ID_Cliente`= '" + idCliente + "'";
                    cmd.CommandText = SQl;
                    cmd.ExecuteNonQuery();
                }

                SQl = "update historico set valor = '" + valor + "' WHERE  `ID`= '" + idHistorico + "'";
                cmd.CommandText = SQl;
                cmd.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        public string[] autoComplete()
        {
            OdbcConnection conexao = new Connection().Conexao();
            OdbcCommand cmd1 = new OdbcCommand("", conexao);
            OdbcCommand cmd2 = new OdbcCommand("", conexao);
            conexao.Open();

            String SQL1 = "Select count(nome) From Clientes";
            String SQL2 = "Select (nome) From Clientes";
            cmd1.CommandText = SQL1;
            cmd2.CommandText = SQL2;
            string[] dados = new string[Convert.ToInt32(cmd1.ExecuteScalar())];

            OdbcDataReader rdr = cmd2.ExecuteReader();

            int i = 0;
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    dados[i] = rdr["nome"].ToString();
                    i++;
                }
            }
            conexao.Close();
            return dados;
        }

        public void deleteHistorico(string id)
        {
            try
            {
                OdbcConnection conexao = new Connection().Conexao();
                OdbcCommand cmd = new OdbcCommand("", conexao);
                conexao.Open();

                string SQl;
                SQl = "select ValorEmAberto from historico WHERE id = '" + id + "'";
                cmd.CommandText = SQl;
                string valor = cmd.ExecuteScalar().ToString();

                SQl = "select ID_Cliente from historico WHERE id = '" + id + "'";
                cmd.CommandText = SQl;
                string idCliente = cmd.ExecuteScalar().ToString();

                SQl = "select status from historico WHERE id = '" + id + "'";
                cmd.CommandText = SQl;
                string pago = cmd.ExecuteScalar().ToString();

                if(pago != "Pago")
                {
                    SQl = "update clientes set valorapagar =  valorapagar - " + valor + "  WHERE ID_Cliente = '" + idCliente + "'";
                    cmd.CommandText = SQl;
                    cmd.ExecuteNonQuery();
                }
                
                SQl = "DELETE FROM historico WHERE id = '"+ id +"'";
                cmd.CommandText = SQl;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Dados apagado com sucesso");
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        public void deleteCliente(string id)
        {
            try
            {
                OdbcConnection conexao = new Connection().Conexao();
                OdbcCommand cmd = new OdbcCommand("", conexao);
                conexao.Open();
                
                string SQl = "DELETE FROM clientes WHERE ID_Cliente = '" + id + "'";
                cmd.CommandText = SQl;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente apagado com sucesso");
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        public int returnCountHisotrico(string range)
        {
            int count = 0;
            try
            {
                OdbcConnection conexao = new Connection().Conexao();
                OdbcCommand cmd = new OdbcCommand("", conexao);
                conexao.Open();
                if (range == "Hoje")
                {
                    String SQl = "select count(*) from historico where DataC between '" + DateTime.Now.ToString("yyyy-MM-dd 00:00:00") + "' and '" + DateTime.Now.ToString("yyyy-MM-dd 23:59:59") + "'";
                    cmd.CommandText = SQl;
                    count = Convert.ToInt16(cmd.ExecuteScalar());
                }
                else if (range == "Ontem")
                {
                    String SQl = "select count(*) from historico where DataC between '" + ontem + " 00:00:00' and '" + ontem + " 23:59:59'";
                    cmd.CommandText = SQl;
                    count = Convert.ToInt16(cmd.ExecuteScalar());
                }
                else if (range == "todo")
                {
                    String SQl = "select count(*) from historico";
                    cmd.CommandText = SQl;
                    count = Convert.ToInt16(cmd.ExecuteScalar());
                }

                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            return count;
        }

        public int returnCorte(string range)
        {
            setData();
            int count = 0;
            try
            {
                OdbcConnection conexao = new Connection().Conexao();
                OdbcCommand cmd = new OdbcCommand("", conexao);
                conexao.Open();
                
                if (range == "Hoje")
                {
                    String SQl = "select count(corte) from historico where corte like 'S' and DataC between '" + DateTime.Now.ToString("yyyy-MM-dd 00:00:00") + "' and '" + DateTime.Now.ToString("yyyy-MM-dd 23:59:59") + "'";
                    cmd.CommandText = SQl;
                    count = Convert.ToInt16(cmd.ExecuteScalar());
                }
                else if (range == "Ontem")
                {
                    String SQl = "select count(corte) from historico where corte like 'S' and DataC between '" + ontem + " 00:00:00' and '" + ontem + " 23:59:59'";
                    cmd.CommandText = SQl;
                    count = Convert.ToInt16(cmd.ExecuteScalar());
                }
                else if (range == "todo")
                {
                    String SQl = "select count(corte) from historico where corte like 'S'";
                    cmd.CommandText = SQl;
                    count = Convert.ToInt16(cmd.ExecuteScalar());
                }
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            return count;
        }
        public int returnBarba(string range)
        {
            setData();
            int count = 0;
            try
            {
                OdbcConnection conexao = new Connection().Conexao();
                OdbcCommand cmd = new OdbcCommand("", conexao);
                conexao.Open();
                if (range == "Hoje")
                {
                    String SQl = "select count(barba) from historico where barba like 'S' and DataC between '" + DateTime.Now.ToString("yyyy-MM-dd 00:00:00") + "' and '" + DateTime.Now.ToString("yyyy-MM-dd 23:59:59") + "'";
                    cmd.CommandText = SQl;
                    count = Convert.ToInt16(cmd.ExecuteScalar());
                }
                else if (range == "Ontem")
                {
                    String SQl = "select count(barba) from historico where barba like 'S' and DataC between '" + ontem + " 00:00:00' and '" + ontem + " 23:59:59'";
                    cmd.CommandText = SQl;
                    count = Convert.ToInt16(cmd.ExecuteScalar());
                }
                else if (range == "todo")
                {
                    String SQl = "select count(barba) from historico where barba like 'S'";
                    cmd.CommandText = SQl;
                    count = Convert.ToInt16(cmd.ExecuteScalar());
                }
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            return count;
        }
        public int returnPezinho(string range)
        {
            setData();
            int count = 0;
            try
            {
                OdbcConnection conexao = new Connection().Conexao();
                OdbcCommand cmd = new OdbcCommand("", conexao);
                conexao.Open();
                if (range == "Hoje")
                {
                    String SQl = "select count(Pezinho) from historico where Pezinho like 'S' and DataC between '" + DateTime.Now.ToString("yyyy-MM-dd 00:00:00") + "' and '" + DateTime.Now.ToString("yyyy-MM-dd 23:59:59") + "'";
                    cmd.CommandText = SQl;
                    count = Convert.ToInt16(cmd.ExecuteScalar());
                }
                else if (range == "Ontem")
                {
                    String SQl = "select count(Pezinho) from historico where Pezinho like 'S' and DataC between '" + ontem + " 00:00:00' and '" + ontem + " 23:59:59'";
                    cmd.CommandText = SQl;
                    count = Convert.ToInt16(cmd.ExecuteScalar());
                }
                else if (range == "todo")
                {
                    String SQl = "select count(Pezinho) from historico where Pezinho like 'S'";
                    cmd.CommandText = SQl;
                    count = Convert.ToInt16(cmd.ExecuteScalar());
                }
                    
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            return count;
        }
        public int returnSombrancelha(string range)
        {
            setData();
            int count = 0;
            try
            {
                OdbcConnection conexao = new Connection().Conexao();
                OdbcCommand cmd = new OdbcCommand("", conexao);
                conexao.Open();
                if (range == "Hoje")
                {
                    String SQl = "select count(Sombrancelha) from historico where Sombrancelha like 'S'  and DataC between '" + DateTime.Now.ToString("yyyy-MM-dd 00:00:00") + "' and '" + DateTime.Now.ToString("yyyy-MM-dd 23:59:59") + "'";
                    cmd.CommandText = SQl;
                    count = Convert.ToInt16(cmd.ExecuteScalar());
                }
                else if (range == "Ontem")
                {
                    String SQl = "select count(Sombrancelha) from historico where Sombrancelha like 'S' and DataC between '" + ontem + " 00:00:00' and '" + ontem + " 23:59:59'";
                    cmd.CommandText = SQl;
                    count = Convert.ToInt16(cmd.ExecuteScalar());
                }
                else if (range == "todo")
                {
                    String SQl = "select count(Sombrancelha) from historico where Sombrancelha like 'S'";
                    cmd.CommandText = SQl;
                    count = Convert.ToInt16(cmd.ExecuteScalar());
                }
                    
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            return count;
        }
        public int returnSombrancelhaHenna(string range)
        {
            setData();
            int count = 0;
            try
            {
                OdbcConnection conexao = new Connection().Conexao();
                OdbcCommand cmd = new OdbcCommand("", conexao);
                conexao.Open();
                if (range == "Hoje")
                {
                    String SQl = "select count(SombrancelhaHenna) from historico where SombrancelhaHenna like 'S' and DataC between '" + DateTime.Now.ToString("yyyy-MM-dd 00:00:00") + "' and '" + DateTime.Now.ToString("yyyy-MM-dd 23:59:59") + "'";
                    cmd.CommandText = SQl;
                    count = Convert.ToInt16(cmd.ExecuteScalar());
                }
                else if (range == "Ontem")
                {
                    String SQl = "select count(SombrancelhaHenna) from historico where SombrancelhaHenna like 'S' and DataC between '" + ontem + " 00:00:00' and '" + ontem + " 23:59:59'";
                    cmd.CommandText = SQl;
                    count = Convert.ToInt16(cmd.ExecuteScalar());
                }
                else if (range == "todo")
                {
                    String SQl = "select count(SombrancelhaHenna) from historico where SombrancelhaHenna like 'S'";
                    cmd.CommandText = SQl;
                    count = Convert.ToInt16(cmd.ExecuteScalar());
                }
                    conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            return count;
        }
        public int returnRelaxamento(string range)
        {
            setData();
            int count = 0;
            try
            {
                OdbcConnection conexao = new Connection().Conexao();
                OdbcCommand cmd = new OdbcCommand("", conexao);
                conexao.Open();
                if (range == "Hoje")
                {
                    String SQl = "select count(Relaxamento) from historico where Relaxamento like 'S' and DataC between '" + DateTime.Now.ToString("yyyy-MM-dd 00:00:00") + "' and '" + DateTime.Now.ToString("yyyy-MM-dd 23:59:59") + "'";
                    cmd.CommandText = SQl;
                    count = Convert.ToInt16(cmd.ExecuteScalar());
                }
                else if (range == "Ontem")
                {
                    String SQl = "select count(Relaxamento) from historico where Relaxamento like 'S' and DataC between '" + ontem + " 00:00:00' and '" + ontem + " 23:59:59'";
                    cmd.CommandText = SQl;
                    count = Convert.ToInt16(cmd.ExecuteScalar());
                }
                else if (range == "todo")
                {
                    String SQl = "select count(Relaxamento) from historico where Relaxamento like 'S'";
                    cmd.CommandText = SQl;
                    count = Convert.ToInt16(cmd.ExecuteScalar());
                }
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            return count;
        }
        public int returnprogressiva(string range)
        {
            setData();
            int count = 0;
            try
            {
                OdbcConnection conexao = new Connection().Conexao();
                OdbcCommand cmd = new OdbcCommand("", conexao);
                conexao.Open();
                if (range == "Hoje")
                {
                    String SQl = "select count(Progressiva) from historico where Progressiva like 'S' and DataC between '" + DateTime.Now.ToString("yyyy-MM-dd 00:00:00") + "' and '" + DateTime.Now.ToString("yyyy-MM-dd 23:59:59") + "'";
                    cmd.CommandText = SQl;
                    count = Convert.ToInt16(cmd.ExecuteScalar());
                }
                else if (range == "Ontem")
                {
                    String SQl = "select count(Progressiva) from historico where Progressiva like 'S'and DataC between '" + ontem + " 00:00:00' and '" + ontem + " 23:59:59'";
                    cmd.CommandText = SQl;
                    count = Convert.ToInt16(cmd.ExecuteScalar());
                }
                else if (range == "todo")
                {
                    String SQl = "select count(Progressiva) from historico where Progressiva like 'S'";
                    cmd.CommandText = SQl;
                    count = Convert.ToInt16(cmd.ExecuteScalar());
                }
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            return count;
        }
        public int returnPigCorte(string range)
        {
            setData();
            int count = 0;
            try
            {
                OdbcConnection conexao = new Connection().Conexao();
                OdbcCommand cmd = new OdbcCommand("", conexao);
                conexao.Open();
                if (range == "Hoje")
                {
                    String SQl = "select count(PigmentacaoCorte) from historico where PigmentacaoCorte like 'S' and DataC between '" + DateTime.Now.ToString("yyyy-MM-dd 00:00:00") + "' and '" + DateTime.Now.ToString("yyyy-MM-dd 23:59:59") + "'";
                    cmd.CommandText = SQl;
                    count = Convert.ToInt16(cmd.ExecuteScalar());
                }
                else if (range == "Ontem")
                {
                    String SQl = "select count(PigmentacaoCorte) from historico where PigmentacaoCorte like 'S' and DataC between '" + ontem + " 00:00:00' and '" + ontem + " 23:59:59'";
                    cmd.CommandText = SQl;
                    count = Convert.ToInt16(cmd.ExecuteScalar());
                }
                else if (range == "todo")
                {
                    String SQl = "select count(PigmentacaoCorte) from historico where PigmentacaoCorte like 'S'";
                    cmd.CommandText = SQl;
                    count = Convert.ToInt16(cmd.ExecuteScalar());
                }
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            return count;
        }
        public int returnPigBarba(string range)
        {
            setData();
            int count = 0;
            try
            {
                OdbcConnection conexao = new Connection().Conexao();
                OdbcCommand cmd = new OdbcCommand("", conexao);
                conexao.Open();
                if (range == "Hoje")
                {
                    String SQl = "select count(PigmentacaoBarba) from historico where PigmentacaoBarba like 'S' and DataC between '" + DateTime.Now.ToString("yyyy-MM-dd 00:00:00") + "' and '" + DateTime.Now.ToString("yyyy-MM-dd 23:59:59") + "'";
                    cmd.CommandText = SQl;
                    count = Convert.ToInt16(cmd.ExecuteScalar());
                }
                else if (range == "Ontem")
                {
                    String SQl = "select count(PigmentacaoBarba) from historico where PigmentacaoBarba like 'S' and DataC between '" + ontem + " 00:00:00' and '" + ontem + " 23:59:59'";
                    cmd.CommandText = SQl;
                    count = Convert.ToInt16(cmd.ExecuteScalar());
                }
                else if (range == "todo")
                {
                    String SQl = "select count(PigmentacaoBarba) from historico where PigmentacaoBarba like 'S'";
                    cmd.CommandText = SQl;
                    count = Convert.ToInt16(cmd.ExecuteScalar());
                }
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            return count;
        }
        public int returnLuzes(string range)
        {
            setData();
            int count = 0;
            try
            {
                OdbcConnection conexao = new Connection().Conexao();
                OdbcCommand cmd = new OdbcCommand("", conexao);
                conexao.Open();
                if (range == "Hoje")
                {
                    String SQl = "select count(Luzes) from historico where Luzes like 'S' and DataC between '" + DateTime.Now.ToString("yyyy-MM-dd 00:00:00") + "' and '" + DateTime.Now.ToString("yyyy-MM-dd 23:59:59") + "'";
                    cmd.CommandText = SQl;
                    count = Convert.ToInt16(cmd.ExecuteScalar());
                }
                else if (range == "Ontem")
                {
                    String SQl = "select count(Luzes) from historico where Luzes like 'S' and DataC between '" + ontem + " 00:00:00' and '" + ontem + " 23:59:59'";
                    cmd.CommandText = SQl;
                    count = Convert.ToInt16(cmd.ExecuteScalar());
                }
                else if (range == "todo")
                {
                    String SQl = "select count(Luzes) from historico where Luzes like 'S'";
                    cmd.CommandText = SQl;
                    count = Convert.ToInt16(cmd.ExecuteScalar());
                }
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            return count;
        }
        public int returnGel(string range)
        {
            setData();
            int count = 0;
            try
            {
                OdbcConnection conexao = new Connection().Conexao();
                OdbcCommand cmd = new OdbcCommand("", conexao);
                conexao.Open();
                if (range == "Hoje")
                {
                    String SQl = "select count(Gel) from historico where Gel like 'S' and DataC between '" + DateTime.Now.ToString("yyyy-MM-dd 00:00:00") + "' and '" + DateTime.Now.ToString("yyyy-MM-dd 23:59:59") + "'";
                    cmd.CommandText = SQl;
                    count = Convert.ToInt16(cmd.ExecuteScalar());
                }
                else if (range == "Ontem")
                {
                    String SQl = "select count(Gel) from historico where Gel like 'S' and DataC between '" + ontem + " 00:00:00' and '" + ontem + " 23:59:59'";
                    cmd.CommandText = SQl;
                    count = Convert.ToInt16(cmd.ExecuteScalar());
                }
                else if (range == "todo")
                {
                    String SQl = "select count(Gel) from historico where Gel like 'S'";
                    cmd.CommandText = SQl;
                    count = Convert.ToInt16(cmd.ExecuteScalar());
                }
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            return count;
        }
        public int returnLapis(string range)
        {
            setData();
            int count = 0;
            try
            {
                OdbcConnection conexao = new Connection().Conexao();
                OdbcCommand cmd = new OdbcCommand("", conexao);
                conexao.Open();
                if (range == "Hoje")
                {
                    String SQl = "select count(Lapis) from historico where Lapis like 'S' and DataC between '" + DateTime.Now.ToString("yyyy-MM-dd 00:00:00") + "' and '" + DateTime.Now.ToString("yyyy-MM-dd 23:59:59") + "'";
                    cmd.CommandText = SQl;
                    count = Convert.ToInt16(cmd.ExecuteScalar());
                }
                else if (range == "Ontem")
                {
                    String SQl = "select count(Lapis) from historico where Lapis like 'S' and DataC between '" + ontem + " 00:00:00' and '" + ontem + " 23:59:59'";
                    cmd.CommandText = SQl;
                    count = Convert.ToInt16(cmd.ExecuteScalar());
                }
                else if (range == "todo")
                {
                    String SQl = "select count(Lapis) from historico where Lapis like 'S'";
                    cmd.CommandText = SQl;
                    count = Convert.ToInt16(cmd.ExecuteScalar());
                }
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            return count;
        }
        public int returnValorTotal(string range)
        {
            setData();
            int count = 0;
            try
            {
                OdbcConnection conexao = new Connection().Conexao();
                OdbcCommand cmd = new OdbcCommand("", conexao);
                conexao.Open();
                if (range == "Hoje")
                {
                    String SQl = "select sum(valor) from historico where DataC between '" + DateTime.Now.ToString("yyyy-MM-dd 00:00:00") + "' and '" + DateTime.Now.ToString("yyyy-MM-dd 23:59:59") + "'";
                    cmd.CommandText = SQl;
                    count = Convert.ToInt16(cmd.ExecuteScalar());
                }
                else if (range == "Ontem")
                {
                    String SQl = "select count(valor) from historico where valor like 'S' and DataC between '" + DateTime.Now.ToString("yyyy-MM-dd 00:00:00") + "' and '" + DateTime.Now.ToString("yyyy-MM-dd 23:59:59") + "'";
                    cmd.CommandText = SQl;
                    count = Convert.ToInt16(cmd.ExecuteScalar());
                }
                else if (range == "todo")
                {
                    String SQl = "select sum(valor) from historico";
                    cmd.CommandText = SQl;
                    count = Convert.ToInt16(cmd.ExecuteScalar());
                }
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            return count;
        }
        
    }
}
