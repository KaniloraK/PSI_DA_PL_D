using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestGest.Gestao_Global_Restaurantes
{
    public partial class FormMetodoPagamento : Form
    {
        RestGestContainer container;
        public FormMetodoPagamento()
        {
            InitializeComponent();
            container = new RestGestContainer();
        }

        private void FormMetodoPagamento_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restGestDBDataSet.MetodoPagamentos' table. You can move, or remove it, as needed.
            this.metodoPagamentosTableAdapter.Fill(this.restGestDBDataSet.MetodoPagamentos);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            container.SaveChanges();

            MessageBox.Show("Categorias aletradas com sucesso");
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            new FormGlobalRestaurantes().Show();
            this.Close();
        }
    }
}
