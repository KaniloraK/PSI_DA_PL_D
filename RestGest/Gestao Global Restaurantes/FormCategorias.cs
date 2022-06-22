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
    public partial class FormCategorias : Form

    {
        RestGestContainer container;

        public FormCategorias()
        {
            InitializeComponent();
            container = new RestGestContainer();
        }

        private void FormCategorias_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restGestDBDataSet.Categorias' table. You can move, or remove it, as needed.
            this.categoriasTableAdapter.Fill(this.restGestDBDataSet.Categorias);

          
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            new FormGlobalRestaurantes().Show();
            this.Close();
        }

        private void btnGuardar(object sender, EventArgs e)
        {
            container.SaveChanges();

            MessageBox.Show("Categorias aletradas com sucesso");
        }
    }
}
