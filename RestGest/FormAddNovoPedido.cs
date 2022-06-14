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
    public partial class FormAddNovoPedido : Form
    {
        public FormAddNovoPedido()
        {
            InitializeComponent();
        }

        private void GoHome_Click(object sender, EventArgs e)
        {
            new FormPrincipal().Show();
            this.Close();
        }

        private void FormAddNovoPedido_Load(object sender, EventArgs e)
        {

        }
    }
}
