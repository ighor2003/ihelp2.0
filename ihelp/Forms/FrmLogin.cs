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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente(txtUsuario.Text, txtSenha.Text);
            if (cliente.EfetuarLogin(cliente))
            {
                this.Close();
                Program.usuarioLogado = cliente;
                //FrmHome frmhome = new FrmHome();
               // frmhome.ShowDialog();                
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorreto!");
                Application.Restart();
            }
            FrmCliente frmcliente = new FrmCliente();
            frmcliente.TopLevel = false;        
            frmcliente.FormBorderStyle = FormBorderStyle.None;
            frmcliente.Show();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
