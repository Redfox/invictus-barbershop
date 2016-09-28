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
        /*
        public void efetuarPagamento2(string valorPagamento, string valorAberto, string ID_Cliente, string valorRestante, int RowsCount, string sb, string valorpago)
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

                        String SQLPago = "update historico set status = 'pago' where ID_Cliente like '" + ID_Cliente + "' and ID in(" + sb + ")";
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
                        int ValorPagamento = Convert.ToInt16(valorPagamento);
                        int ValorTotal = Convert.ToInt16(valorAberto);

                        //deixa status em aberto
                        String SQLStatus = "update historico set Status = 'Em Processo' where ID_Cliente like '" + ID_Cliente + "' and ID in(" + sb + ")";
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

                    Int32 RowsCount2 = dataGridView1.RowCount - 1;

                    for (int i = 0; i < RowsCount2; i++)
                    {
                        Convert.ToString(sb.Append(", " + dataGridView1.Rows[i].Cells[0].Value));
                    }



                    sb.Remove(0, 2);
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
                        int valor = Convert.ToInt32(dataGridView1.Rows[0].Cells[14].Value);
                        //System.Text.StringBuilder id = new System.Text.StringBuilder();
                        int id = Convert.ToInt32(dataGridView1.Rows[0].Cells[0].Value);

                        //verificando possibilidades somente com o primeiro valor
                        if (valorPagamento == valor.ToString())
                        {

                            //so meche no primeiro
                            String SQLHistorico = "update Historico set ValorEmAberto = '0' where ID_Cliente like '" + ID_Cliente + "' and ID like '" + id + "'";
                            cmd.CommandText = SQLHistorico;
                            cmd.ExecuteNonQuery();

                            String SQLCliente = "update Clientes set ValorPago = ValorPago + '" + valorPagamento + "' where ID_Cliente like '" + ID_Cliente + "'";
                            cmd.CommandText = SQLCliente;
                            cmd.ExecuteNonQuery();

                            String SQLClienteApagar = "update Clientes set ValoraPagar = ValoraPagar - '" + valorPagamento + "' where ID_Cliente like '" + ID_Cliente + "'";
                            cmd.CommandText = SQLClienteApagar;
                            cmd.ExecuteNonQuery();

                            String SQLPago = "update historico set status = 'pago' where ID_Cliente like '" + ID_Cliente + "' and ID like '" + id + "'";
                            cmd.CommandText = SQLPago;
                            cmd.ExecuteNonQuery();

                            //String SQLValPago = "update historico set ValorPago = ValorPago + '" + valorPagamento + "' where ID_Cliente like '" + ID_Cliente + "' and ID in(" + sb + ")";
                            string SQLValPago = "UPDATE `cabeleireiro`.`historico` SET `ValorPago`= `ValorPago` + " + valorPagamento + " where ID_Cliente like '" + ID_Cliente + "' and ID  like '" + id + "'";
                            cmd.CommandText = SQLValPago;
                            cmd.ExecuteNonQuery();

                            String SQLPagamento = "update historico set DataP = '" + DateTime.Now.ToString("yyyy'-'MM'-'dd HH:mm:ss") + "' where ID_Cliente like '" + ID_Cliente + "' and ID like '" + id + "'";
                            cmd.CommandText = SQLPagamento;
                            cmd.ExecuteNonQuery();


                            MessageBox.Show("Pago com Sucesso!");

                        }
                        else if (Convert.ToInt32(valorPagamento) < valor)
                        {
                            //tambem meche so no primeiro

                            int valorrestante = valor - Convert.ToInt16(valorPagamento);


                            String SQLHistorico = "update Historico set ValorEmAberto = '" + valorrestante + "' where ID_Cliente like '" + ID_Cliente + "' and ID like '" + id + "'";
                            cmd.CommandText = SQLHistorico;
                            cmd.ExecuteNonQuery();

                            String SQLCliente = "update Clientes set ValorPago = ValorPago + '" + valorPagamento + "' where ID_Cliente like '" + ID_Cliente + "'";
                            cmd.CommandText = SQLCliente;
                            cmd.ExecuteNonQuery();

                            String SQLClienteApagar = "update Clientes set ValoraPagar = ValoraPagar - '" + valorPagamento + "' where ID_Cliente like '" + ID_Cliente + "'";
                            cmd.CommandText = SQLClienteApagar;
                            cmd.ExecuteNonQuery();

                            String SQLPago = "update historico set status = 'Em Processo' where ID_Cliente like '" + ID_Cliente + "' and ID like '" + id + "'";
                            cmd.CommandText = SQLPago;
                            cmd.ExecuteNonQuery();

                            //String SQLValPago = "update historico set ValorPago = ValorPago + '" + valorPagamento + "' where ID_Cliente like '" + ID_Cliente + "' and ID in(" + sb + ")";
                            string SQLValPago = "UPDATE `cabeleireiro`.`historico` SET `ValorPago`= `ValorPago` + " + valorPagamento + " where ID_Cliente like '" + ID_Cliente + "' and ID  like '" + id + "'";
                            cmd.CommandText = SQLValPago;
                            cmd.ExecuteNonQuery();


                            MessageBox.Show("Pago com Sucesso!");
                        }
                        else if (Convert.ToInt32(valorPagamento) > valor)
                        {
                            //valor do primeiro zera, tem que ve o que sobrou e abate do segundo ...  end

                            valorpagamento = Convert.ToInt16(valorPagamento);

                            RowsCount -= 1;

                            String SQLCliente = "update Clientes set ValorPago = ValorPago + '" + valorPagamento + "' where ID_Cliente like '" + ID_Cliente + "'";
                            cmd.CommandText = SQLCliente;
                            cmd.ExecuteNonQuery();

                            String SQLClienteApagar = "update Clientes set ValoraPagar = ValoraPagar - '" + valorPagamento + "' where ID_Cliente like '" + ID_Cliente + "'";
                            cmd.CommandText = SQLClienteApagar;
                            cmd.ExecuteNonQuery();



                            for (int i = 0; i <= RowsCount; i++)
                            {

                                int valorfor = Convert.ToInt32(dataGridView1.Rows[i].Cells[14].Value);
                                //int valortotal = Convert.ToInt32(dataGridView1.Rows[i].Cells[13].Value);
                                int idfor = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);

                                if (valorpagamento > valorfor)
                                {
                                    //se o valor do pagamento ainda e maior do que o valor da linha que esta GG
                                    String SQLHistorico = "update Historico set ValorEmAberto = '0' where ID_Cliente like '" + ID_Cliente + "' and ID like '" + idfor + "'";
                                    cmd.CommandText = SQLHistorico;
                                    cmd.ExecuteNonQuery();

                                    String SQLPago = "update historico set status = 'Pago' where ID_Cliente like '" + ID_Cliente + "' and ID like '" + idfor + "'";
                                    cmd.CommandText = SQLPago;
                                    cmd.ExecuteNonQuery();

                                    String SQLHistorico2 = "update Historico set ValorPago = '" + dataGridView1.Rows[i].Cells[13].Value + "'  where ID_Cliente like '" + ID_Cliente + "' and ID like '" + idfor + "'";
                                    cmd.CommandText = SQLHistorico2;
                                    cmd.ExecuteNonQuery();

                                    String SQLPagamento = "update historico set DataP = '" + DateTime.Now.ToString("yyyy'-'MM'-'dd HH:mm:ss") + "' where ID_Cliente like '" + .ID_Cliente + "' and ID like '" + idfor + "'";
                                    cmd.CommandText = SQLPagamento;
                                    cmd.ExecuteNonQuery();

                                }
                                else
                                {
                                    //se nao for maior entra aqui GG
                                    int valorR = Convert.ToInt16(dataGridView1.Rows[i].Cells[13].Value) - Convert.ToInt16(valorRestante);
                                    int UltimoValor = valorpagamento - valorfor;
                                    String SQLHistorico = "update Historico set ValorEmAberto = '" + valorRestante  + "' where ID_Cliente like '" + ID_Cliente + "' and ID like '" + idfor + "'";
                                    cmd.CommandText = SQLHistorico;
                                    cmd.ExecuteNonQuery();

                                    String SQLHistorico2 = "update Historico set ValorPago = ValorPago + '" + valorR + "' where ID_Cliente like '" + ID_Cliente + "' and ID like '" + idfor + "'";
                                    cmd.CommandText = SQLHistorico2;
                                    cmd.ExecuteNonQuery();

                                    String SQLPago = "update historico set status = 'Em Processo' where ID_Cliente like '" + ID_Cliente + "' and ID like '" + idfor + "'";
                                    cmd.CommandText = SQLPago;
                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Pago com Sucesso!");
                                }

                                valorpagamento -= valorfor;

                            }

                        }
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        */
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
                            
                            RowsCount -= 1;

                            String SQLCliente = "update Clientes set ValorPago = ValorPago + '" + valorPagamento + "' where ID_Cliente like '" + ID_Cliente + "'";
                            cmd.CommandText = SQLCliente;
                            cmd.ExecuteNonQuery();

                            String SQLClienteApagar = "update Clientes set ValoraPagar = ValoraPagar - '" + valorPagamento + "' where ID_Cliente like '" + ID_Cliente + "'";
                            cmd.CommandText = SQLClienteApagar;
                            cmd.ExecuteNonQuery();
                            
                            for (int i = 0; i <= RowsCount; i++)
                            {
                                
                            }
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
