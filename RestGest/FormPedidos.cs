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
    public partial class FormPedidos : Form
    {
        public FormPedidos()
        {
            InitializeComponent();
        }

        private void butNovoPedido_Click(object sender, EventArgs e)
        {
            new FormAddNovoPedido().Show();
            this.Close(); // fechar a janela porque no formulário temos btn para sair
        }

        private void FormPedidos_Load(object sender, EventArgs e)
        {

        }

        private void goHome_Click(object sender, EventArgs e)
        {
            new FormPrincipal().Show();
            this.Close();
        }
    }

    
}
