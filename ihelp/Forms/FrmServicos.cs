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

namespace ihelp.Forms
{
    public partial class FrmServicos : Form
    {
        public FrmServicos()
        {
            InitializeComponent();
        }            

        private void listBoxServicos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        

        private void txtStatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnListar_Click_1(object sender, EventArgs e)
        {
            {
                listBoxServicos.Items.Clear();
                Servicos servicos = new Servicos();
                List<Servicos> lista = servicos.Listar();
                foreach (var cat in lista)
                {
                    listBoxServicos.Items.Add(cat.Nome + '-' + cat.Descricao + '-' + cat.Valor + '-' + cat.Status + '-' + cat.Comentarios);
                }
            }
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            {
                if (txtStatus.Text == "")
                {
                    MessageBox.Show("Informe um ID valido para o Servico ser Alterado!");
                }
                else
                {
                    Servicos servicos = new Servicos();
                    servicos.Status = txtStatus.Text;

                    if (servicos.Alterar(int.Parse(txtStatus.Text)))
                    {
                        MessageBox.Show("Status alterado com Sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Ops... Algo deu Errado! :(");
                    }
                }
            }
        }

        private void btnLimparTrab_Click(object sender, EventArgs e)
        {
            listBoxServicos.Items.Clear();
        }

        private void btnFechar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
