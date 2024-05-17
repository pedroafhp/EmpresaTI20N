using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; //Importar o MySQL

namespace PessoaTI20N
{
    class DAO
    {
        public MySqlConnection conexao;
        public long[] cpf;
        public string[] nome;
        public string[] telefone;
        public string[] endereco;
        public int i;
        public int contador;

        public DAO()
        {
            conexao = new MySqlConnection("server=localhost;Database=empresaTI20N;Uid=root;password=");
            try
            {
                conexao.Open();//Abrir a Conexão
                MessageBox.Show("Conectado!");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Algo Deu Errado!\n\n" + ex);
            }
        }//Fim do Construtor

        public string Inserir(long CPF, string nome, string telefone, string endereco)
        {
            string inserir = $"Insert into pessoa(cpf, nome, telefone, endereco) values" + $"('{CPF}',{nome}','{telefone}'{endereco}')";

            MySqlCommand sql = new MySqlCommand(inserir, conexao);
            string resultado = sql.ExecuteNonQuery() + "Executado!";
            return resultado;
        }//Fim do Método

        public void PreencherVetor()
        {
            string query = "select * from pessoa";

            //Instanciar
            this.cpf = new long[100];
            this.nome = new string[100];
            this.telefone = new string[100];
            this.endereco = new string[100];

            //Fazer o Comando de Seleção do Banco
            MySqlCommand sql = new MySqlCommand(query, conexao);
            //Leitor do Banco
            MySqlDataReader leitura = sql.ExecuteReader();

            i = 0;
            contador = 0;
            while (leitura.Read())
            {
                cpf[i] = Convert.ToInt64(leitura["cpf"]);
                nome[i] = leitura["nome"] + "";
                telefone[i] = leitura["telefone"] + "";
                endereco[i] = leitura["endereco"] + "";
                i++;//Percorrer o Vetor
                contador++;//Contar Quantos Dados Tem
            }//Fim do While

            //Encerro a Comunicação Com o Software
            leitura.Close();
        }//Fim do Preencher

        //Criar o Método Para Retornar o Contador
        public int QuantidadeDados()
        {
            return contador;
        }//Fim da Quantidade de Dados

        public string Atualizar(long cpf, string nomeTabela, string campo, string dado)
        {
            string query = $"update {nomeTabela} set {campo} = '{dado}' where cpf = '{cpf}'";
            MySqlCommand sql = new MySqlCommand(query, conexao);
            string resultado = sql.ExecuteNonQuery() + "Atualizado!";
            return resultado;
        }//Fim do Método

        public string Excluir(long cpf, string nomeTabela)
        {
            string query = $"delete from {nomeTabela} where CPF = '{cpf}'";
            MySqlCommand sql = new MySqlCommand(query, conexao);
            string resultado = sql.ExecuteNonQuery() + "Excluido!";
            return resultado;
        }//Fim do Excluir

    }//Fim da Classe
}//Fim do Projeto
