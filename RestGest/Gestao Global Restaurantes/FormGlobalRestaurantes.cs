using System;
using System.Windows.Forms;

namespace RestGest
{
    public partial class FormGlobalRestaurantes : Form
    {
        public FormGlobalRestaurantes()
        {
            InitializeComponent();
        }


        private void btAbrirMenu_Click(object sender, EventArgs e)
        {
            new FormRegistarRestaurante().Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void btAlterarRestaurante_Click(object sender, EventArgs e)
        {
            new AlterarRestaurante().Show();
            this.Hide();
        }

        private void btnGerirCategoriasMenu_Click(object sender, EventArgs e)
        {
            new FormCategorias().Show();
            this.Close();

        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
            new FormPrincipal().Show();
        }

        private void FormGlobalRestaurantes_Load(object sender, EventArgs e)
        {

        }
    }
}
