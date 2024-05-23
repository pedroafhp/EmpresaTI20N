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
    public partial class Cadastrar : Form
    {
        DAO bd;
        public Cadastrar()
        {
            InitializeComponent();
            bd = new DAO();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }//Fim do Botão Cancelar

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }//Fim do Campo CPF

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }//Fim do Campo Nome

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }//Fim do Campo Telefone

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }//Fim do Campo Endereço

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Coletar os Dados do Canco
                long cpf = Convert.ToInt64(textBox1.Text);
                string nome = textBox2.Text;
                string telefone = textBox3.Text;
                string endereco = textBox4.Text;

                //Cadastrar
                MessageBox.Show(bd.Inserir(cpf, nome, telefone, endereco));//Insere Dados no BD
                                                                           //Limpar a Tela
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu errado!\n\n" + ex);
            }
        }//Fim do Botão Cadastrar
    }//Fim da Classe 
}//Fim do Projeto
