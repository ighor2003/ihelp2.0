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
    public partial class FrmCategoria : Form
    {
        public FrmCategoria()
        {
            InitializeComponent();
        }
        private void FrmCategoria_Load(object sender, EventArgs e)
        {

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            categoria categoria = new categoria();
            List<categoria> lista = categoria.Listar();
            foreach (var cat in lista)
            {
                listBox1.Items.Add(cat.Nome + '-' + cat.Ativo);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
