using System;
using System.Windows.Forms;
using System.Data.Odbc;

namespace StudioRL2._0.Class
{
    class Pagamento
    {
        public int atualizarValorRestante(int valorAberto, int valorPago)
        {
            int valorRestante = 0;

            valorRestante = valorAberto - valorPago;

            return valorRestante;
        }
        public void efetuarPagamento(string ID_Cliente, string valorRestante, string valorPagamento, int RowsCount, string sb, int idCell, int valorCell)
        {
            try
            {
                OdbcConnection conexao = new Connection().Conexao();
                OdbcCommand cmd = new OdbcCommand("", conexao);
                conexao.Open();

                if (RowsCount == 1)
                {
                    int restante = Convert.ToInt16(valorRestante);

                    if (restante == 0)
                    {
                        String SQLHistorico = "update Historico set ValorEmAberto = '0' where ID_Cliente like '" + ID_Cliente + "' and ID in(" + sb + ")";
                        cmd.CommandText = SQLHistorico;
                        cmd.ExecuteNonQuery();

                        String SQLHistorico2 = "update Historico set ValorPago = ValorPago + '" + valorPagamento + "' where ID_Cliente like '" + ID_Cliente + "' and ID in(" + sb + ")";
                        cmd.CommandText = SQLHistorico2;
                        cmd.ExecuteNonQuery();

                        String SQLPago = "update historico set status = 'Pago' where ID_Cliente like '" + ID_Cliente + "' and ID in(" + sb + ")";
                        cmd.CommandText = SQLPago;
                        cmd.ExecuteNonQuery();

                        String SQLCliente = "update Clientes set ValorPago = ValorPago + '" + valorPagamento + "' where ID_Cliente like '" + ID_Cliente + "'";
                        cmd.CommandText = SQLCliente;
                        cmd.ExecuteNonQuery();

                        String SQLClienteApagar = "update Clientes set ValoraPagar = ValoraPagar - '" + valorPagamento + "' where ID_Cliente like '" + ID_Cliente + "'";
                        cmd.CommandText = SQLClienteApagar;
                        cmd.ExecuteNonQuery();

                        String SQLPagamento = "update historico set DataP = '" + DateTime.Now.ToString("yyyy'-'MM'-'dd HH:mm:ss") + "' where ID_Cliente like '" + ID_Cliente + "' and ID in(" + sb + ")";
                        cmd.CommandText = SQLPagamento;
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Pago com sucesso!");
                    }
                    else
                    {
                        //deixa status em aberto
                        String SQLStatus = "update historico set Status = 'Em Aberto' where ID_Cliente like '" + ID_Cliente + "' and ID in(" + sb + ")";
                        cmd.CommandText = SQLStatus;
                        cmd.ExecuteNonQuery();

                        //abaixar valor em aberto
                        String SQLValor = "update clientes set ValoraPagar = ValoraPagar - " + valorPagamento + "  where ID_Cliente like '" + ID_Cliente + "'";
                        cmd.CommandText = SQLValor;
                        cmd.ExecuteNonQuery();

                        //aumenta valor pago
                        String SQLValorPago = "update clientes set ValorPago = ValorPago + " + valorPagamento + " where ID_Cliente like '" + ID_Cliente + "'";
                        cmd.CommandText = SQLValorPago;
                        cmd.ExecuteNonQuery();

                        String SQLValPago = "update historico set ValorPago = ValorPago + '" + valorPagamento + "' where ID_Cliente like '" + ID_Cliente + "' and ID in(" + sb + ")";
                        cmd.CommandText = SQLValPago;
                        cmd.ExecuteNonQuery();

                        //altera o valor em aberto
                        String SQLValorAberto = "update historico set ValorEmAberto = ValorEmAberto - " + valorPagamento + " where ID_Cliente like '" + ID_Cliente + "' and ID in(" + sb + ")";
                        cmd.CommandText = SQLValorAberto;
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Pago com sucesso!");
                    }

                }
                else if (RowsCount > 1)
                {
                    int restante = Convert.ToInt16(valorRestante);

                    if (restante == 0)
                    {
                        String SQLCliente = "update Clientes set ValorPago = ValorPago + '" + valorPagamento + "' where ID_Cliente like '" + ID_Cliente + "'";
                        cmd.CommandText = SQLCliente;
                        cmd.ExecuteNonQuery();

                        String SQLClienteApagar = "update Clientes set ValoraPagar = ValoraPagar - '" + valorPagamento + "' where ID_Cliente like '" + ID_Cliente + "'";
                        cmd.CommandText = SQLClienteApagar;
                        cmd.ExecuteNonQuery();

                        String SQLPago = "update historico set status = 'pago' where ID_Cliente like '" + ID_Cliente + "' and ID in(" + sb + ")";
                        cmd.CommandText = SQLPago;
                        cmd.ExecuteNonQuery();

                        String SQLPagamento = "update historico set DataP = '" + DateTime.Now.ToString("yyyy'-'MM'-'dd HH:mm:ss") + "' where ID_Cliente like '" + ID_Cliente + "' and ID in(" + sb + ")";
                        cmd.CommandText = SQLPagamento;
                        cmd.ExecuteNonQuery();

                        String SQLHistorico = "update Historico set ValorEmAberto = '0' where ID_Cliente like '" + ID_Cliente + "' and ID in(" + sb + ")";
                        cmd.CommandText = SQLHistorico;
                        cmd.ExecuteNonQuery();

                        String SQLHistorico2 = "update Historico set ValorPago = Valor where ID_Cliente like '" + ID_Cliente + "' and ID in(" + sb + ")";
                        cmd.CommandText = SQLHistorico2;
                        cmd.ExecuteNonQuery();


                        MessageBox.Show("Pago com sucesso!");
                    }
                    else
                    {
                        //verificando possibilidades somente com o primeiro valor
                        if (valorPagamento == valorCell.ToString())
                        {
                            MessageBox.Show("valorPagamento == valorCell.ToString()");

                            //so meche no primeiro
                            String SQLHistorico = "update Historico set ValorEmAberto = '0' where ID_Cliente like '" + ID_Cliente + "' and ID like '" + idCell + "'";
                            cmd.CommandText = SQLHistorico;
                            cmd.ExecuteNonQuery();

                            String SQLCliente = "update Clientes set ValorPago = ValorPago + '" + valorPagamento + "' where ID_Cliente like '" + ID_Cliente + "'";
                            cmd.CommandText = SQLCliente;
                            cmd.ExecuteNonQuery();

                            String SQLClienteApagar = "update Clientes set ValoraPagar = ValoraPagar - '" + valorPagamento + "' where ID_Cliente like '" + ID_Cliente + "'";
                            cmd.CommandText = SQLClienteApagar;
                            cmd.ExecuteNonQuery();

                            String SQLPago = "update historico set status = 'pago' where ID_Cliente like '" + ID_Cliente + "' and ID like '" + idCell + "'";
                            cmd.CommandText = SQLPago;
                            cmd.ExecuteNonQuery();

                            //String SQLValPago = "update historico set ValorPago = ValorPago + '" + valorPagamento + "' where ID_Cliente like '" + ID_Cliente + "' and ID in(" + sb + ")";
                            string SQLValPago = "UPDATE `cabeleireiro`.`historico` SET `ValorPago`= `ValorPago` + " + valorPagamento + " where ID_Cliente like '" + ID_Cliente + "' and ID  like '" + idCell + "'";
                            cmd.CommandText = SQLValPago;
                            cmd.ExecuteNonQuery();

                            String SQLPagamento = "update historico set DataP = '" + DateTime.Now.ToString("yyyy'-'MM'-'dd HH:mm:ss") + "' where ID_Cliente like '" + ID_Cliente + "' and ID like '" + idCell + "'";
                            cmd.CommandText = SQLPagamento;
                            cmd.ExecuteNonQuery();


                            MessageBox.Show("Pago com Sucesso!");

                        }
                        else if (Convert.ToInt32(valorPagamento) < valorCell)
                        {//tambem meche so no primeiro
                            int valorrestante = valorCell - Convert.ToInt16(valorPagamento);


                            String SQLHistorico = "update Historico set ValorEmAberto = '" + valorrestante + "' where ID_Cliente like '" + ID_Cliente + "' and ID like '" + idCell + "'";
                            cmd.CommandText = SQLHistorico;
                            cmd.ExecuteNonQuery();

                            String SQLCliente = "update Clientes set ValorPago = ValorPago + '" + valorPagamento + "' where ID_Cliente like '" + ID_Cliente + "'";
                            cmd.CommandText = SQLCliente;
                            cmd.ExecuteNonQuery();

                            String SQLClienteApagar = "update Clientes set ValoraPagar = ValoraPagar - '" + valorPagamento + "' where ID_Cliente like '" + ID_Cliente + "'";
                            cmd.CommandText = SQLClienteApagar;
                            cmd.ExecuteNonQuery();

                            String SQLPago = "update historico set status = 'Em Processo' where ID_Cliente like '" + ID_Cliente + "' and ID like '" + idCell + "'";
                            cmd.CommandText = SQLPago;
                            cmd.ExecuteNonQuery();

                            //String SQLValPago = "update historico set ValorPago = ValorPago + '" + valorPagamento + "' where ID_Cliente like '" + ID_Cliente + "' and ID in(" + sb + ")";
                            string SQLValPago = "UPDATE `cabeleireiro`.`historico` SET `ValorPago`= `ValorPago` + " + valorPagamento + " where ID_Cliente like '" + ID_Cliente + "' and ID  like '" + idCell + "'";
                            cmd.CommandText = SQLValPago;
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Pago com Sucesso!");
                        }
                        else if (Convert.ToInt32(valorPagamento) > valorCell)
                        {
                            //valor do primeiro zera, tem que ve o que sobrou e abate do segundo ...  end

                            String SQLCliente = "update Clientes set ValorPago = ValorPago + '" + valorPagamento + "' where ID_Cliente like '" + ID_Cliente + "'";
                            cmd.CommandText = SQLCliente;
                            cmd.ExecuteNonQuery();

                            String SQLClienteApagar = "update Clientes set ValoraPagar = ValoraPagar - '" + valorPagamento + "' where ID_Cliente like '" + ID_Cliente + "'";
                            cmd.CommandText = SQLClienteApagar;
                            cmd.ExecuteNonQuery();
                            Consulta con = new Consulta();
                            con.doItTrue();
                        }
                    }
                }
                
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}
