using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PessoaTI20N
{
    public partial class Consultar : Form
    {
        DAO bd;
        public Consultar()
        {
            InitializeComponent();
            bd = new DAO();

            ConfigurarGrid();//Estruturar o Grid
            NomesDados();//Dar os Nomes as Colunas
            bd.PreencherVetor();//Consulto o Banco de Dados
            AdicionarDados();//Inserir Linhas na Tela
        }//Fim do Construtor

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }//Fim do Data Grid

        public void NomesDados()
        {
            dataGridView1.Columns[0].Name = "CPF";
            dataGridView1.Columns[1].Name = "Nome";
            dataGridView1.Columns[2].Name = "Telefone";
            dataGridView1.Columns[3].Name = "Endereço";
        }//Fim do Método

        public void AdicionarDados()
        {
            for (int i = 0; i < bd.QuantidadeDados(); i++)
            {
                dataGridView1.Rows.Add(bd.cpf[i], bd.nome[i], bd.telefone[i], bd.endereco[i]);
            }
        }//Fim do Método

        public void ConfigurarGrid()
        {
            dataGridView1.AllowUserToAddRows = false;//Usuário Não Adiciona Linhas
            dataGridView1.AllowUserToDeleteRows = false;//Usuário Não Apaga Linhas
            dataGridView1.AllowUserToResizeColumns = false;//Usuário Não Adiciona Colunas
            dataGridView1.AllowUserToResizeRows = false;//Usuário Modificar Linhas
            dataGridView1.ColumnCount = 4;//Quantidade de Colunas
        }//Fim do Método
    }//Fim da Classe
}//Fim do Projeto
