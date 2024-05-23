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
    public partial class Atualizar : Form
    {
        DAO bd;
        public Atualizar()
        {
            InitializeComponent();
            bd = new DAO();
        }//Fim do Construtor

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }//Fim do CPF

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }//Fim do Campo

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }//Fim do Dado

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Coletar os Dados
                long cpf = Convert.ToInt64(textBox3.Text);
                string campo = textBox1.Text;
                string dado = textBox2.Text;

                //Atualizar os Dados
                MessageBox.Show(bd.Atualizar(cpf, "pessoa", campo, dado));

                //Limpar os Campos
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu errado!\n\n" + ex);
            }
        }//Fim do Atualizar

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }//Fim do Cancelar
    }//Fim da Classe
}//Fim do Projeto
