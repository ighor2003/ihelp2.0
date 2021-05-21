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
using ihelp.Forms;

namespace ihelp.Forms
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            FrmCliente frmcliente = new FrmCliente();
            frmcliente.TopLevel = false;
            panel2.Controls.Add(frmcliente);
            frmcliente.FormBorderStyle = FormBorderStyle.None;
            frmcliente.Show();
        }

        private void btnTrab_Click(object sender, EventArgs e)
        {
            FrmTrabalhador frmtrabalhador = new FrmTrabalhador();
            frmtrabalhador.TopLevel = false;
            panel2.Controls.Add(frmtrabalhador);
            frmtrabalhador.FormBorderStyle = FormBorderStyle.None;
            frmtrabalhador.Show();
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            FrmCategoria frmcategoria = new FrmCategoria();
            frmcategoria.TopLevel = false;
            panel2.Controls.Add(frmcategoria);
            frmcategoria.FormBorderStyle = FormBorderStyle.None;
            frmcategoria.Show();
        }

        private void btnServicos_Click(object sender, EventArgs e)
        {
            FrmServicos frmservicos= new FrmServicos();
            frmservicos.TopLevel = false;
            panel2.Controls.Add(frmservicos);
            frmservicos.FormBorderStyle = FormBorderStyle.None;
            frmservicos.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
