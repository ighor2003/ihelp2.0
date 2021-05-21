using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ihelp.Classes;

namespace ihelp
{
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {

        }   

        private void txtNameCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmailCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenhaCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNivelCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNameCliente_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            {
                listBoxCliente.Items.Clear();
                Cliente cliente = new Cliente();
                List<Cliente> lista = cliente.Listar();
                foreach (var cli in lista)
                {
                    listBoxCliente.Items.Add('-' + cli.Nome + '-' + cli.Senha + '-' + cli.Email);
                }
            }
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            {
                if (txtId.Text == "")
                {
                    MessageBox.Show("Informe um ID valido para o Cliente ser Alterado!");
                }
                else
                {
                    Cliente cliente = new Cliente();
                    cliente.Nome = txtNameCliente.Text;
                    cliente.Senha = txtSenhaCliente.Text;
                    cliente.Email = txtEmailCliente.Text;

                    if (cliente.Alterar(int.Parse(txtId.Text)))
                    {
                        MessageBox.Show("Cliente alterado com Sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Ops... Algo deu Errado! :(");
                    }
                }
            }
        }

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            listBoxCliente.Items.Clear();
        }

        private void btnFechar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBoxCliente_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
