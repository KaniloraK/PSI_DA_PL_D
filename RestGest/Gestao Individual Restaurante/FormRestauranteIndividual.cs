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
    public partial class FormRestauranteIndividual : Form
    {
        public FormRestauranteIndividual()
        {
            InitializeComponent();
        }

        private void btSairRestauranteIndividual_Click(object sender, EventArgs e)
        {
            this.Close();
            new FormPrincipal().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            new RegistarTrabalhadores().Show();
        }

        private void FormRestauranteIndividual_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restGestDBDataSet.ItemMenus' table. You can move, or remove it, as needed.
            this.itemMenusTableAdapter.Fill(this.restGestDBDataSet.ItemMenus);

        }
    }
}
