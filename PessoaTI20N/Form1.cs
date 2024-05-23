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
    public partial class Form1 : Form
    {
        Cadastrar cad;
        Consultar con;
        Atualizar atu;
        Excluir exc;
        public Form1()
        {
            InitializeComponent();
            cad = new Cadastrar();
            atu = new Atualizar();
            exc = new Excluir();
        }//Construtor de Tela

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            cad.ShowDialog();
        }//Fim do Botão Cadastrar

        private void Consultar_Click(object sender, EventArgs e)
        {
            con = new Consultar();//Consultar ATUALIZADAS!
            con.ShowDialog();
        }//Fim do Consultar

        private void Atualizar_Click(object sender, EventArgs e)
        {
            atu.ShowDialog();
        }//Fim do Atualizar

        private void Excluir_Click(object sender, EventArgs e)
        {
            exc.ShowDialog();
        }//Fim do Excluir
    }//Fim da Classe
}//Fim do Projeto
