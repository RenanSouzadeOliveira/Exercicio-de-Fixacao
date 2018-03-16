using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
// Ativar biblioteca do banco
using System.Data.OleDb;

namespace Etec.ExerciciosFixacao
{
    public partial class Form1 : Form
    {

        // conexão
        static string strCn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Aluno_2\Desktop\Etec.ExerciciosFixacao\cadastro.accdb";

        OleDbConnection conexao = new OleDbConnection(strCn);
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //instrução sql responsável por adicionar dados ao banco (CRUD - Create) 
            string adiciona = "insert into Clientes values (" +
            txbId.Text + ",'" +
            txbNome.Text + "','" +
            txbEndereco.Text + "','" +
            txbRg.Text + "','" +
            txbCPF.Text + "','" +
            txbCidade.Text + "','" +
            txbEstado.Text + "','" +
            txbSalario.Text + "')"; 

            //criando um objeto de nome cmd tendo como modelo a classe OleDbCommand para //executar a instrução sql 
            OleDbCommand cmd = new OleDbCommand(adiciona, conexao);

            //tratamento de exceções: try - catch - finally (em caso de erro capturamos o //tipo do erro) 
            try
            {
                // Abrindo a conexão com o banco 
                conexao.Open();

                // Criando uma variável para adicionar e armazenar o resultado 
                int resultado;
                resultado = cmd.ExecuteNonQuery();

                // Verificando se o registro foi adicionado 
                // Caso o valor da variável resultado seja 1 
                // significa que o comando funcionou, neste caso limpar os campos e exibir uma //mensagem 
                if (resultado == 1)
                {
                    MessageBox.Show("Registro adicionado com sucesso");
                    txbId.Clear();
                    txbNome.Clear();
                    txbEndereco.Clear();
                    txbRg.Clear();
                    txbCPF.Clear();
                    txbCidade.Clear();
                    txbEstado.Clear();
                    txbSalario.Clear();
                    txbId.Focus();
                }

                // Encerrando o uso do cmd 
                cmd.Dispose();
            }

            //caso ocorra algum erro 
            catch (Exception ex)
            {

                //exiba qual é o erro 
                MessageBox.Show(ex.Message);
            }

            // de qualquer forma sempre fechar a conexão com o banco ("lembrar da porta da //geladeira rsrsrs") 
            finally
            {
                conexao.Close();
            } 

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            // instrução pesquisa
            string pesquisa = "select * from Clientes where Id = " + txbId.Text;

            // criando um objeto de nome cmd
            OleDbCommand cmd = new OleDbCommand(pesquisa, conexao);

            // Atravé da classe OleDbDataReader
            OleDbDataReader DR;

            // tratamento de excecões

            try
            {
                // Abrindo conexão
                conexao.Open();
                // Executando a instrução e armazenando o resultado no DR
                DR = cmd.ExecuteReader();
                // Se houver um registro corresponde ao Id
                if(DR.Read())
                {
                    // exibe  as informações nas caixar de texto
                    txbId.Text = DR.GetValue(0).ToString();
                    txbNome.Text = DR.GetValue(1).ToString();
                    txbEndereco.Text = DR.GetValue(2).ToString();
                    txbRg.Text = DR.GetValue(3).ToString();
                    txbCPF.Text = DR.GetValue(4).ToString();
                    txbCidade.Text = DR.GetValue(5).ToString();
                    txbEstado.Text = DR.GetValue(6).ToString();
                    txbSalario.Text = DR.GetValue(7).ToString();

                    double salario = Convert.ToDouble(txbSalario.Text);
                    double salario_liq;

                    salario_liq = salario - ((salario * 26) / 100);
                    salario_liq = salario_liq + 450;
                    

                    MessageBox.Show("Nome: " + txbNome.Text + "\n" + "Endereco: " +  txbEndereco.Text + "\n" + "Rg: " + txbRg.Text + "\n" + "CPF: " + txbCPF.Text + "\n" + "Cidade: " + txbCidade.Text + "\n" + "Estado: " + txbEstado.Text + "\n" + "Salario bruto:R$ " + salario + "\n" + "Salario liquido:R$ " + salario_liq);
                        
                }

                else
                {
                    MessageBox.Show("Registro não encontrado");
                    txbId.Clear();
                    txbNome.Clear();
                    txbEndereco.Clear();
                    txbRg.Clear();
                    txbCPF.Clear();
                    txbCidade.Clear();
                    txbEstado.Clear();
                    txbId.Focus();
                }
                // Encerrando o uso do reader
                DR.Close();
                // Encerrando o uso do cmd
                cmd.Dispose();
            }

            //caso ocorra algum erro 
            catch (Exception ex)
            {

                //exiba qual é o erro 
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            } 


        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            //instrução sql responsável por alterar um registro do banco (CRUD - Update) 
            string altera = "update Clientes set Nome= '" + txbNome.Text +
            "', Endereco= '" + txbEndereco.Text +
            "', RG= '" + txbRg.Text +
            "', CPF= '" + txbCPF.Text +
            "', Cidade= '" + txbCidade.Text +
            "', Estado= '" + txbEstado.Text +
            "', Salario= '" + txbSalario.Text +
            "' where Id= " + txbId.Text;

            //criando um objeto de nome cmd tendo como modelo a classe OleDbCommand para //executar a instrução sql 
            OleDbCommand cmd = new OleDbCommand(altera, conexao);

            //tratamento de exceções: try - catch - finally (em caso de erro capturamos o //tipo do erro) 
            try
            {
                // Abrindo a conexão com o banco 
                conexao.Open();

                // Criando uma variável para alterar e armazenar o resultado 
                int resultado;
                resultado = cmd.ExecuteNonQuery();
                // Verificando se o registro foi alterado 
                // Caso o valor da variável resultado seja 1 
                // significa que o comando funcionou, neste caso limpar os campos e exibir uma //mensagem 
                if (resultado == 1)
                {
                    txbId.Clear();
                    txbNome.Clear();
                    txbEndereco.Clear();
                    txbRg.Clear();
                    txbCPF.Clear();
                    txbCidade.Clear();
                    txbEstado.Clear();
                    txbSalario.Clear();
                    txbId.Focus();
                    MessageBox.Show("Registro alterado com sucesso");
                }

                // Encerrando o uso do cmd 
                cmd.Dispose();
            }

            //caso ocorra algum erro 
            catch (Exception ex)
            {

                //exiba qual é o erro 
                MessageBox.Show(ex.Message);
            }

            // De qualquer forma sempre fechar a conexão com o banco 
            finally
            {
                conexao.Close();
            } 

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //instrução sql responsável por remover um registro do banco (CRUD - Delete) 
            string remove = "delete from Clientes where Id= " + txbId.Text;

            //criando um objeto de nome cmd tendo como modelo a classe OleDbCommand para //executar a instrução sql 
            OleDbCommand cmd = new OleDbCommand(remove, conexao);

            //tratamento de exceções: try - catch - finally (em caso de erro capturamos o //tipo do erro) 
            try
            {

                // Abrindo a conexão com o banco 
                conexao.Open();

                // Criando uma variável para adicionar e armazenar o resultado 
                int resultado;
                if (MessageBox.Show("Tem certeza que deseja remover este registro ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    resultado = cmd.ExecuteNonQuery();
                    // Verificando se o registro foi apagado 
                    // Caso o valor da variável resultado seja 1 
                    // significa que o comando funcionou, neste caso limpar os campos e exibir uma //mensagem 
                    if (resultado == 1)
                    {
                        txbId.Clear();
                        txbNome.Clear();
                        txbEndereco.Clear();
                        txbRg.Clear();
                        txbCPF.Clear();
                        txbCidade.Clear();
                        txbEstado.Clear();
                        txbSalario.Clear();
                        txbId.Focus();
                        MessageBox.Show("Registro removido com sucesso");
                    }

                    // Encerrando o uso do cmd 
                    cmd.Dispose();
                }
            }

            //caso ocorra algum erro 
            catch (Exception ex)
            {

                //exiba qual é o erro 
                MessageBox.Show(ex.Message);
            }
            // de qualquer forma sempre fechar a conexão com o banco 
            finally
            {
                conexao.Close();
            } 
        }

        
       
        
    }
}
