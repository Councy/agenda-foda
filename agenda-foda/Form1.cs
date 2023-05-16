using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lisinha_Matlugo
{
    public partial class Form1 : Form
    {
        private Contato[] listaDeContatos = new Contato[1];

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddContato_Click(object sender, EventArgs e)
        {

         
            // Criar nosso primeiro contato (um OBJETO da classe Contato).
            Contato objetoContato = new Contato(txtNome.Text, txtSobrenome.Text, txtTelefone.Text, txtEmail.Text);
            lstContatos.Items.Add(objetoContato.ToString());
        }

        private void Escrever(Contato contato) 
        {
            StreamWriter escrevedorDeArquivos = new StreamWriter("Contatos.txt");
            escrevedorDeArquivos.WriteLine(listaDeContatos.Length + 1);
            escrevedorDeArquivos.WriteLine(contato.PrimeiroNome);
            escrevedorDeArquivos.WriteLine(contato.Sobrenome);
            escrevedorDeArquivos.WriteLine(contato.Telefone);
            escrevedorDeArquivos.WriteLine(contato.Email);

            for (int i = 0; i < listaDeContatos.Length; i++) 
            {
                escrevedorDeArquivos.WriteLine(listaDeContatos.Length + 1);
                escrevedorDeArquivos.WriteLine(contato.PrimeiroNome);
                escrevedorDeArquivos.WriteLine(contato.Sobrenome);
                escrevedorDeArquivos.WriteLine(contato.Telefone);
                escrevedorDeArquivos.WriteLine(contato.Email);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
