using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestGest
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btGestaoGlobal_Click(object sender, EventArgs e)
        {
            new FormGlobalRestaurantes().Show();
            this.Hide(); 
        }

        private void btGestaoIndividual_Click(object sender, EventArgs e)
        {
           new FormRestauranteIndividual().Show();
           this.Hide();
        }

        private void btGestaoClientes_Click(object sender, EventArgs e)
        {
            new FormClientes().Show();
            this.Hide();
        }

        private void btMenus_Click(object sender, EventArgs e)
        {
            new FormMenu().Show();
            this.Hide();
        }

        private void Pedidos_Click(object sender, EventArgs e)
        {
            new FormPedidos().Show();
            this.Hide();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            DialogResult sair = MessageBox.Show("Deseja sair?","Terminar Programa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sair == DialogResult.Yes)
            { this.Close();
            }
         
        }
    }
}
